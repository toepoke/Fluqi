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
		/// <remarks>
		/// Note this just an interface to the header.hyperlink object (normally you won't want to use
		/// the hyperlink as you just want a panel with an anchor (#) link within it).
		/// </remarks>
		public string Title { 
			get { return Header.Hyperlink.Title; }
			set { Header.Hyperlink.Title = value; }
		}

		/// <summary>
		/// If set, clicking on the accordion panel header will open this URL
		/// By default this is a link to a # anchor
		/// </summary>
		/// <remarks>
		/// Note this just an interface to the header.hyperlink object (normally you won't want to use
		/// the hyperlink as you just want a panel with an anchor (#) link within it).
		/// </remarks>
		public string URL { 
			get { return Header.Hyperlink.URL; }
			set { Header.Hyperlink.URL = value; }
		}

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
		protected internal Accordion OnAccordion { get; set; }

		/// <summary>
		/// Reference to the header of the panel.
		/// </summary>
		public Header Header { get; set; }

		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">HttpResponse object to render the accordion onto</param>
		/// <param name="owner">Accordions object the panel belongs to</param>
		/// <param name="title">Title to appear in the accordion panel</param>
		/// <param name="isActive">Flags whether this panel is the active one</param>
		public Panel(TextWriter writer, Accordion owner, string title, bool isActive) {
			this.OnAccordion = owner;
			this.Header = new Header(this);
			this._Writer = writer;
			this.Title = title;
			this.IsActive = isActive;
		}

		/// <summary>
		/// Returns the fluent interface back to the Panels collection
		/// </summary>
		public Panels Finish() {
			// Why didn't we add a Panels reference?!?!?  Duh!
			return this.OnAccordion.Panels;
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

			sb.Append(this.Header.GetTagHtml());
			this.RenderBody(sb);

			return sb.ToString();
		}


		/// <summary>
		/// Renders the body of the accordion panel.
		/// </summary>
		/// <param name="sb">StringBuilder to render the object to</param>
		internal void RenderBody(jStringBuilder sb) {
			bool renderCss = this.OnAccordion.Rendering.RenderCSS;

			// Opening pane container div
			sb.AppendTabsFormatIf("<{0}", this.OnAccordion.Options.ContentTag);

			base.RenderAttributes(sb);
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

			Accordion ac = this.OnAccordion;
			bool prettyRender = ac.Rendering.PrettyRender;
			int tabDepth = ac.Rendering.TabDepth + 1;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			// Close pane container div
			sb.AppendLineIf();
			sb.AppendTabsFormatLineIf("</{0}>", ac.Options.ContentTag);
			
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
