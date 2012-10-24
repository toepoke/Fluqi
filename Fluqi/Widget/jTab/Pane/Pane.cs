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
using System.IO;

namespace Fluqi.Widget.jTab
{

	/// <summary>
	/// Holds the definition of a given Tab in a collection of <see cref="Tabs"/>.
	/// </summary>
	public partial class Pane: Core.ControlBase, IDisposable
	{
		private bool _Disposed;
		private readonly TextWriter _Writer = null;
		internal bool _IsActive = false;

		/// <summary>
		/// Specifies the ID for the DIV that holds the tab content (for static tabs), or the URL where
		/// the content is loaded from (for dynamic tabs).
		/// </summary>
		/// <remarks>
		/// This ID holds the relationship between the URL in the tab header and it's content pane.
		/// </remarks>
		public string IDOrLocation { get; set; }

		/// <summary>
		/// Specifies the Title that should appear in the tab.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Flags whether this tab should be active when the page is first loaded.
		/// </summary>
		/// <remarks>
		/// Note we manage unselecting a tab if a different tab is active, hence the 
		/// private "_IsActive" flag above.
		/// </remarks>
		public bool IsActive { 
			get {
				return this._IsActive;
			}
			set {
				if (value && this.Panes.HasActiveTab()) {
					this.Panes.ResetSelectedTabs();
				}

				this._IsActive = value;
			}
		}

		/// <summary>
		/// Index of the Tab in the list of Tabs added thus far.
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// Flags whether this Pane is to be rendered or not.
		/// </summary>
		/// <remarks>
		/// Note this is very different to show/hide as you would in jQuery.  This is really a server-side thing.
		/// If you mark a Pane as !Visible the Pane is not rendered at all to the page.  So you will actually have
		/// less panes on the rendered page.
		/// This is so you can programmatically remove a Pane from a set of Tabs.  You still define the rendering 
		/// area, however it won't be rendered if Visible=False.
		/// </remarks>
		public bool Visible { get; set; }


		/// <summary>
		/// Flags whether this tab Pane is visble or not.
		/// </summary>
		/// <param name="isVisble">Flags whether this tab Pane is visble or not.</param>
		/// <returns>Pane (for chainability)</returns>
		public Pane SetVisibility(bool isVisble) {
			this.Visible = isVisble;
			return this;
		}


		/// <summary>
		/// Sets the title to appear in the tab Pane header.
		/// </summary>
		/// <param name="title">Title of the tab</param>
		/// <returns>Pane (for chainability)</returns>
		public Pane SetTitle(string title) {
			this.Title = title;
			return this;
		}

		/// <summary>
		/// Returns the fluent interface back to the Panes collection (i.e. the Parent object to the tab Pane).
		/// </summary>
		public Panes Finish() {
			return this.Panes;
		}

		/// <summary>
		/// Holds a reference to the set of tab Panels this pane is being rendered on.
		/// </summary>
		protected Panes Panes { get; set; }

		/// <summary>
		/// Constructor for a new tab.  Typically a new tab is added via the method, 
		/// hence the constructor is internal.
		/// </summary>
		/// <param name="writer">Response we're writing the Tab JavaScript definition to</param>
		/// <param name="owner">Set of panes this pane is part of</param>
		/// <param name="idOrLocation">
		/// For static tabs this is the ID of the tab content pane (must be unique on the page).
		/// For dynamic tabs this is the URL where the content is loaded from.
		/// </param>
		/// <param name="title">Title of the tab heading (same as <see cref="Title"/> property)</param>
		/// <param name="isActive">Flags whether this tab should be the active one on page load (same as <see cref="IsActive"/> property)</param>
		internal Pane(TextWriter writer, Panes owner, string idOrLocation, string title, bool isActive)  {
			this.Panes = owner;
			this._Writer = writer;
			this.IDOrLocation = idOrLocation;
			this.Title = title;
			this.IsActive = isActive;
			this.Index = 0;
			this.Visible = true;
		}


		/// <summary>
		/// Writes out the content pane of the Tab to the response
		/// </summary>
		internal Pane Render() {
			if (!this.Visible)
				// literally nothing to see here!
				return this;

			int tabDepth = this.Panes.Tabs.Rendering.TabDepth;
			bool prettyRender = this.Panes.Tabs.Rendering.PrettyRender;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			this.RenderBody(sb);

			_Writer.Write(sb.ToString());
			return this;
		}


		/// <summary>
		/// Writes out the opening part of a jQuery UI tab (the LI)
		/// </summary>
		internal void RenderHeader(jStringBuilder sb) {
			if (!this.Visible)
				// literally nothing to see here!
				return;

			string selected = "";
			bool prettyRender = this.Panes.Tabs.Rendering.PrettyRender;
			bool renderCss = this.Panes.Tabs.Rendering.RenderCSS;

			if (renderCss) {
				if (this.IsActive)
					selected = " ui-tabs-active ui-state-active";

				sb.AppendTabsFormatLineIf("<li class=\"ui-state-default ui-corner-top{0}\">", selected);
			} else {
				sb.AppendTabsFormatLineIf("<li>");
			}

			sb.IncIndent();

			if (this.Panes.Tabs._AsDynamic) {
				sb.AppendTabsFormatLineIf("<a href=\"{0}\"><span>{1}</span></a>", this.IDOrLocation, HttpUtility.HtmlEncode(this.Title) );
			} else { 
				sb.AppendTabsFormatLineIf("<a href=\"#{0}\" title=\"{1}\">{1}</a>", 
					HttpUtility.HtmlEncode(this.IDOrLocation), HttpUtility.HtmlEncode(this.Title)
				);
			}
			sb.DecIndent();
			
			sb.AppendTabsLineIf("</li>");
		
		} // RenderHeader

		
		/// <summary>
		/// Writes out the opening part of the content part of the jQuery UI tab (the DIV just after the LI header)
		/// that belongs to this particular tab.  So basically this marries up the LI and the content for the LI.
		/// </summary>
		/// <param name="sb"></param>
		private void RenderBody(jStringBuilder sb) {
			bool renderCss = this.Panes.Tabs.Rendering.RenderCSS;
			bool prettyRender = this.Panes.Tabs.Rendering.PrettyRender;
			
			this.WithID(this.IDOrLocation);
			if (renderCss)
				this.WithCss("ui-tabs-panel ui-widget-content ui-corner-bottom");

			sb.IncIndent();
			sb.AppendTabsIf("<div");
			base.RenderAttributes(sb);
			sb.AppendLineIf(">");
			sb.DecIndent();
		}


		/// <summary>
		/// Writes out the closing tag for the content DIV of the tab
		/// </summary>
		/// <param name="disposing"></param>
		protected virtual void Dispose(bool disposing) {
			if (!this._Disposed)
			{
				this._Disposed = true;
				bool prettyRender = this.Panes.Tabs.Rendering.PrettyRender;
				int tabDepth = this.Panes.Tabs.Rendering.TabDepth + 1;
				jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

				if (this.Visible) { 
					// Close pane
					sb.AppendLineIf();
					sb.AppendTabsLineIf("</div>");
				
					_Writer.Write(sb.ToString());
				}
			}
		}

#pragma warning disable 1591
		[SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
		public void Dispose() {
			Dispose(true /* disposing */);
			GC.SuppressFinalize(this);
		}
#pragma warning restore 1591

	} // Tab

} // ns Fluqi.jTab

