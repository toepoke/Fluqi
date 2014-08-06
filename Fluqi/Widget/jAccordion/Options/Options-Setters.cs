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
		/// Disables the accordion if set to true 
		/// </summary>
		/// <param name="disabled">Disables the accordion if set to true</param>
		/// <returns>Options object for chainability</returns>
		public Options SetDisabled(bool disabled) {
		  this.Disabled = disabled;
		  return this;
		}


		/// <summary>
		/// If and how to animate changing panels.
		/// </summary>
		/// <param name="animated">Name of easing to use with default duration.</param>
		/// <returns>Options object for chainability</returns>
		public Options SetAnimate(string animated) {
			this.Animate = animated ?? "";
			return this;
		}


		/// <summary>
		/// If and how to animate changing panels.
		/// </summary>
		/// <param name="effect">Name of easing to use with default duration.</param>
		public Options SetAnimate(Core.Ease.eEase effect) {
			string easeString = Core.Ease.EaseToString(effect);
			return this.SetAnimate(easeString);
		}


		/// <summary>
		/// Whether all the sections can be closed at once. Allows collapsing the active section.
		/// </summary>
		/// <param name="collapsible">Flags whether collapsible is on or off</param>
		/// <returns>Options object for chainability</returns>
		public Options SetCollapsible(bool collapsible) {
			this.Collapsible = collapsible;
			return this;
		}
	

		/// <summary>
		/// The event that accordion headers will react to in order to activate the associated panel. 
		/// Multiple events can be specificed, separated by a space
		/// </summary>
		/// <param name="evt">Event to use to open a tab</param>
		/// <returns>Options object for chainability</returns>
		public Options SetEvent(string evt) {
			this.Event = evt ?? "";

			return this;
		}


		/// <summary>
		/// The event that accordion headers will react to in order to activate the associated panel. 
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
		/// Icons to use for headers, matching an icon defined by the jQuery UI CSS Framework. 
		/// </summary>
		public Options SetIcons(string headerIconClass, string activeHeaderIconClass) {
			this.HeaderIconClass = headerIconClass ?? "";
			this.activeHeaderIconClass = activeHeaderIconClass ?? "";
			return this;
		}


		/// <summary>
		/// Icons to use for headers, matching an icon defined by the jQuery UI CSS Framework. 
		/// </summary>
		/// <remarks>
		/// Overload for specifying icons through an enumeration (so you get the itellisense when finding them).
		/// See http://api.jqueryui.com/accordion/#option-icons for details
		/// </remarks>
		public Options SetIcons(Core.Icons.eIconClass headerIconClass, Core.Icons.eIconClass activeHeaderIconClass) {
			this.HeaderIconClass = Core.Icons.ByEnum(headerIconClass);
			this.activeHeaderIconClass = Core.Icons.ByEnum(activeHeaderIconClass);
			return this;
		}


		/// <summary>
		/// Icons to use for headers, matching an icon defined by the jQuery UI CSS Framework. 
		/// </summary>
		public Options SetIconsOff() {
			// just set both to empty strings to signify they are off ... the rendering phase will deal with this
			this.HeaderIconClass = "";
			this.activeHeaderIconClass = "";
			return this;
		}

	} // Options

} // ns Fluqi.jTab
