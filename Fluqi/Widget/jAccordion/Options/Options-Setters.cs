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
		public Options SetAnimated(string animated) {
			this.Animated = animated ?? "";
			return this;
		}


		/// <summary>
		/// Sets the panel transition effect.  
		/// </summary>
		/// <param name="effect">Animation definition</param>
		/// <returns>Options object for chainability</returns>
		public Options SetAnimated(Core.Animation.eAnimation effect) {
			string animationString = Core.Animation.AnimationToString(effect);
			return this.SetAnimated(animationString);
		}


		/// Flags whether the highest content pane is used as a reference for all other
		/// panes (provides more consistent animations).
		/// <param name="autoHeight">New setting</param>
		/// <returns>Options object for chainability</returns>
		public Options SetAutoHeight(bool autoHeight) {
			this.AutoHeight = autoHeight;
			return this;
		}


		/// <summary>
		/// If set, clears height and overflow styles after finishing animations. This enables 
		/// accordion to work with dynamic content. Won't work together with autoHeight.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-clearStyle for details</remarks>
		public Options SetClearStyle(bool clearStyle) {
			this.ClearStyle = clearStyle;
			return this;
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
		/// If set, the accordion completely fills the height of the parent element. Overrides autoheight.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-fillSpace for more details</remarks>
		/// <returns>Options object for chainability</returns>
		public Options SetFillSpace(bool fillSpace) {
			this.FillSpace = fillSpace;
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
		/// Icons to use for headers. Icons may be specified for 'header' and 'headerSelected', 
		/// and we recommend using the icons native to the jQuery UI CSS Framework manipulated 
		/// by jQuery UI ThemeRoller
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-icons for more details</remarks>
		public Options SetIcons(string headerIconClass, string headerSelectedIconClass) {
			this.HeaderIconClass = headerIconClass ?? "";
			this.HeaderSelectedIconClass = headerSelectedIconClass ?? "";
			return this;
		}


		/// <summary>
		/// Icons to use for headers. Icons may be specified for 'header' and 'headerSelected', 
		/// and we recommend using the icons native to the jQuery UI CSS Framework manipulated 
		/// by jQuery UI ThemeRoller
		/// </summary>
		/// <remarks>
		/// Overload for specifying icons through an enumeration (so you get the itellisense when finding them).
		/// </remarks>
		public Options SetIcons(Core.Icons.eIconClass headerIconClass, Core.Icons.eIconClass headerSelectedIconClass) {
			this.HeaderIconClass = Core.Icons.ByEnum(headerIconClass);
			this.HeaderSelectedIconClass = Core.Icons.ByEnum(headerSelectedIconClass);
			return this;
		}


		/// <summary>
		/// If set, looks for the anchor that matches location.href and activates it. 
		/// Great for href-based state-saving. Use navigationFilter to implement your own 
		/// matcher.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-navigation for more details</remarks>
		public Options SetNavigation(bool navigation) {
			this.Navigation = navigation;
			return this;
		}


		/// <summary>
		/// Overwrite the default location.href-matching with your own matcher.
		/// (see also "Navigation" above).
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-navigationFilter for more details</remarks>
		public Options SetNavigationFilter(string navigationFilter) {
			this.NavigationFilter = navigationFilter ?? "";
			return this;
		}

	} // Options

} // ns Fluqi.jTab
