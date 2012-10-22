using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Accordion.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	///   header
	/// </remarks>
	public partial class Options: Core.Options
	{

		/// <summary>
		/// Sets the "disabled" flag 
		/// </summary>
		/// <param name="disabled">
		/// True: sets disabled on
		/// False: sets disabled off
		/// </param>
		/// <returns>Options object for chainability</returns>
		public Options SetDisabled(bool disabled) {
		  this.Disabled = disabled;
		  return this;
		}


		/// <summary>
		/// Sets the panel transition effect.  As this can have multiple arguments the
		/// parameter is specified as JSON, so for example: 
		///		myAccordion.Options.SetEffect("{ opacity: 'toggle' }")
		/// </summary>
		/// <param name="animated">Animation definition</param>
		/// <returns>Options object for chainability</returns>
		public Options SetAnimate(string animated) {
			this.Animate = animated ?? "";
			return this;
		}


		/// <summary>
		/// Sets the panel transition effect.  
		/// </summary>
		/// <param name="effect">Animation definition</param>
		/// <returns>Options object for chainability</returns>
		public Options SetAnimate(Core.Ease.eEase effect) {
			string easeString = Core.Ease.EaseToString(effect);
			return this.SetAnimate(easeString);
		}


		/// <summary>
		/// Sets whether the selected panel is collapsible or not.
		/// </summary>
		/// <param name="collapsible">Flags whether collapsible is on or off</param>
		/// <returns>Options object for chainability</returns>
		public Options SetCollapsible(bool collapsible) {
			this.Collapsible = collapsible;
			return this;
		}
	

		/// <summary>
		/// Sets the event that opens a panel, e.g. "mouseover"
		/// </summary>
		/// <param name="evt">Event to use to open a tab</param>
		/// <returns>Options object for chainability</returns>
		public Options SetEvent(string evt) {
			this.Event = evt ?? "";

			return this;
		}


		/// <summary>
		/// Sets the event that opens a panel, e.g. "mouseover"
		/// </summary>
		/// <param name="browserEvent">Event to kick off changing of panes</param>
		/// <returns>Options object for chainability</returns>
		public Options SetEvent(Core.BrowserEvent.eBrowserEvent browserEvent) {
			string evtName = Core.BrowserEvent.BrowserEventToString(browserEvent);
			return this.SetEvent(evtName);
		}


		/// <summary>
		/// Controls the height of the accordion and each panel.  Possible values are "auto", "fill" and "content".
		/// </summary>
		/// <param name="style">Style to use</param>
		/// <returns>Options object for chainability</returns>
		public Options SetHeightStyle(Core.HeightStyle.eHeightStyle style) {
			this.HeightStyle = Core.HeightStyle.HeightStyleToString(style);
			return this;
		}


		/// <summary>
		/// Controls the height of the accordion and each panel.  Possible values are "auto", "fill" and "content".
		/// </summary>
		/// <param name="style">Style to use</param>
		/// <returns>Options object for chainability</returns>
		public Options SetHeightStyle(string style) {
			this.HeightStyle = style;
			return this;
		}


		/// <summary>
		/// Sets the container tag (outer accordion HTML element) that contains all panels.
		/// By default this is DIV.
		/// </summary>
		/// <param name="containerTag">Container tag to use, e.g. DL, DIV, etc</param>
		/// <returns>Options object for chainability</returns>
		public Options SetContainerTag(string containerTag) {
			this.ContainerTag = containerTag;
			return this;
		}


		/// <summary>
		/// Sets the tag to use for the heading of all panels, by default this is H3.
		/// </summary>
		/// <param name="headingTag">Heading tag to use, e.g. H2</param>
		/// <returns>Options object for chainability</returns>
		public Options SetHeadingTag(string headingTag) {
			this.HeadingTag = headingTag;
			return this;
		}


		/// <summary>
		/// Sets the tag to use for the content of all panels, by default this is DIV.
		/// </summary>
		/// <param name="contentTag">Content tag to use, e.g. P or DT</param>
		/// <returns>Options object for chainability</returns>
		public Options SetContentTag(string contentTag) {
			this.ContentTag = contentTag;
			return this;
		}
		

		/// <summary>
		/// Icons to use for headers. Icons may be specified for 'header' and 'activeHeader', 
		/// and we recommend using the icons native to the jQuery UI CSS Framework manipulated 
		/// by jQuery UI ThemeRoller
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-icons for more details</remarks>
		public Options SetIcons(string headerIconClass, string activeHeaderIconClass) {
			this.HeaderIconClass = headerIconClass ?? "";
			this.activeHeaderIconClass = activeHeaderIconClass ?? "";
			return this;
		}


		/// <summary>
		/// Icons to use for headers. Icons may be specified for 'header' and 'activeHeader', 
		/// and we recommend using the icons native to the jQuery UI CSS Framework manipulated 
		/// by jQuery UI ThemeRoller
		/// </summary>
		/// <remarks>
		/// Overload for specifying icons through an enumeration (so you get the itellisense when finding them).
		/// </remarks>
		public Options SetIcons(Core.Icons.eIconClass headerIconClass, Core.Icons.eIconClass activeHeaderIconClass) {
			this.HeaderIconClass = Core.Icons.ByEnum(headerIconClass);
			this.activeHeaderIconClass = Core.Icons.ByEnum(activeHeaderIconClass);
			return this;
		}


		/// <summary>
		/// Turns panel header icons off
		/// </summary>
		public Options SetIconsOff() {
			// just set both to empty strings to signify they are off ... the rendering phase will deal with this
			this.HeaderIconClass = "";
			this.activeHeaderIconClass = "";
			return this;
		}

	} // Options

} // ns Fluqi.jTab
