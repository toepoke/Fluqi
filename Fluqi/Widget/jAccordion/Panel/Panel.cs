using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension.Helpers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;
using Fluqi.Core.Interfaces;
using System.IO;

namespace Fluqi.Widget.jAccordion
{
	/// <summary>
	/// Responsible for modelling and rendering a single pane in the Accordion control.
	/// </summary>
	public partial class Panel: Core.ControlBase, IDisposable
	{
		private bool _Disposed;
		private readonly TextWriter _Writer = null;
		internal bool _IsActive = false;

		/// <summary>
		/// Specifies the Title that should appear in the tab.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Flags whether this tab should be selected when the page is first loaded.
		/// </summary>
		/// <remarks>
		/// If more than 1 tab is marked as selected, the first one wins.
		/// By default the first tab is selected.
		/// </remarks>
		public bool IsActive { 
			get {
				return this._IsActive;
			}
			set {
				if (value && this.OnAccordion.Panels.HasActivePane()) {
					this.OnAccordion.Panels.ResetActivePanes();
				}

				this._IsActive = value;
			}
		}

		/// <summary>
		/// Holds a reference to the set of Tabs this tab is being rendered on.
		/// </summary>
		protected Accordion OnAccordion { get; set; }

		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">HttpResponse object to render the accordion onto</param>
		/// <param name="owner">Accordions object the panel belongs to</param>
		/// <param name="title">Title to appear in the accordion panel</param>
		/// <param name="isActive">Flags whether this panel is the active one</param>
		public Panel(TextWriter writer, Accordion owner, string title, bool isActive) {
			this.OnAccordion = owner;
			this._Writer = writer;
			this.Title = title;
			this.IsActive = isActive;
		}


		/// <summary>
		/// Adds the panel HTML to the response stream.
		/// </summary>
		internal void Render() {
			string tagHtml = this.GetTagHtml();

			_Writer.Write(tagHtml);
		}


		/// <summary>
		/// Renders the accordion panel and returns the HTML
		/// </summary>
		/// <returns>Rendered HTML for the accordion panel</returns>
		internal string GetTagHtml() {
			bool prettyRender = this.OnAccordion.Rendering.PrettyRender;
			int tabDepth = this.OnAccordion.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth + 1);

			this.RenderHeader(sb);
			this.RenderBody(sb);

			return sb.ToString();
		}


		/// <summary>
		/// Renders the header of the accordion panel.
		/// </summary>
		/// <param name="sb">StringBuilder to render the object to</param>
		internal void RenderHeader(jStringBuilder sb) {
			bool prettyRender = this.OnAccordion.Rendering.PrettyRender;
			bool renderCss = this.OnAccordion.Rendering.RenderCSS;
			int tabDepth = this.OnAccordion.Rendering.TabDepth;
			string headingTag = this.OnAccordion.Options.HeadingTag;

			// H3 tag (or whatever if it's been overriden in the options)
			sb.AppendLineIf();
			sb.AppendTabsFormatIf("<{0}", headingTag);
			if (renderCss) {
				base.WithCss("ui-accordion-header ui-helper-reset ui-state-default");

				if (this.IsActive)
					base.WithCss("ui-state-active ui-corner-top");
				else 
					base.WithCss("ui-corner-all");
			}
			base.RenderAttributes(sb);
			sb.Append(">");	
			sb.AppendLineIf();

			// Note we don't render the header or selected header class
			// as jQuery adds these in.  If we add them we'll end up with the
			// same attribute declared twice in the DOM and it will look weird
			// (and be wrong)
		
			// Hyperlink for the title (same for active and non-active)
			sb.IncIndent();
			sb.AppendTabsFormatLineIf("<a href=\"#\">{0}</a>", this.Title);
			sb.DecIndent();

			// Closing heading (H3)
			sb.AppendTabsFormatLineIf("</{0}>", headingTag);

		} // RenderHeader


		/// <summary>
		/// Renders the body of the accordion panel.
		/// </summary>
		/// <param name="sb">StringBuilder to render the object to</param>
		internal void RenderBody(jStringBuilder sb) {
			bool renderCss = this.OnAccordion.Rendering.RenderCSS;

			// Opening pane container div
			sb.AppendTabsIf("<div");

			if (renderCss) {
				sb.Append(" class=\"ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom");

				if (this.IsActive)
					sb.Append(" ui-accordion-content-active");

				sb.Append("\"");
			}
			sb.Append(">");
			sb.AppendLineIf();
		}


		/// <summary>
		/// Writes out the closing tag for the content DIV of the tab
		/// </summary>
		/// <param name="disposing"></param>
		protected virtual void Dispose(bool disposing) {
			if (this._Disposed)
				return;

			this._Disposed = true;

			bool prettyRender = this.OnAccordion.Rendering.PrettyRender;
			int tabDepth = this.OnAccordion.Rendering.TabDepth + 1;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			// Close pane container div
			sb.AppendLineIf();
			sb.AppendTabsLineIf("</div>");
			
			_Writer.Write(sb.ToString());

		} // Dispose


#pragma warning disable 1591
		[SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
		public void Dispose() {
			Dispose(true /* disposing */);
			GC.SuppressFinalize(this);
		}
#pragma warning restore 1591

	}
}
