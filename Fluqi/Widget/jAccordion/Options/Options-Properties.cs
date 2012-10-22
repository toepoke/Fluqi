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
		/// Tag used for the outer accordion HTML element (i.e. the parent element of all panels).
		/// By default this is DIV
		/// </summary>
		protected internal string ContainerTag { get; set; }

		/// <summary>
		/// Tag used for the accordion panel header (by default this is an H3).
		/// </summary>
		protected internal string HeadingTag { get; set; }

		/// <summary>
		/// Tag used for the accordion panel content element (by default this is a DIV)
		/// </summary>
		/// <remarks>
		/// Note that this is not detailed in the jQuery UI library, this is a property for Fluqi to
		/// aid overriding the HTML mark-up of the content element of the panel.
		/// </remarks>
		protected internal string ContentTag { get; set; }

		/// <summary>
		/// Flags whether the "disabled" flag is on or off (default is "false").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-disabled for details</remarks>
		protected internal bool Disabled { get; set; }


		/// <summary>
		/// Stores the animation to be used when opening/closing panels (default is "slide")
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-animated for details</remarks>
		protected internal string Animate { get; set; }

		/// <summary>
		/// Flags whether the highest content pane is used as a reference for all other
		/// panes (provides more consistent animations).
		/// (default is "true")
		/// </summary>
		protected internal bool AutoHeight { get; set; }

		/// <summary>
		/// If set, clears height and overflow styles after finishing animations. This enables 
		/// accordion to work with dynamic content. Won't work together with autoHeight (default is "false").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-clearStyle for details</remarks>
		protected internal bool ClearStyle { get; set; }

		/// <summary>
		/// Stores whether the panels are initialised with the collapsible option on or off (default is "false").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-collapsible for more details</remarks>
		protected internal bool Collapsible { get; set; }
		
		/// <summary>
		/// Stores the event [override] to be used when opening/closing panels (default is "click").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-event for details</remarks>
		protected internal string Event { get; set; }
	
		/// <summary>
		/// If set, the accordion completely fills the height of the parent element. Overrides autoheight (default is "false").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-fillSpace for more details</remarks>
		protected internal bool FillSpace { get; set; }
		
		/// <summary>
		/// Icons to use for non-selected accordion headers icon class.  This equates to the 'header' 
		/// class.
		/// We recommend using the icons native to the jQuery UI CSS Framework manipulated 
		/// by jQuery UI ThemeRoller
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-icons for more details</remarks>
		protected internal string HeaderIconClass { get; set; }
			
		/// <summary>
		/// Icons to use for selected accordion header icon class.  This equates to the 'headerSelected' 
		/// class.
		/// We recommend using the icons native to the jQuery UI CSS Framework manipulated 
		/// by jQuery UI ThemeRoller
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-icons for more details</remarks>
		protected internal string HeaderSelectedIconClass { get; set; }

		/// <summary>
		/// If set, looks for the anchor that matches location.href and activates it. 
		/// Great for href-based state-saving. Use navigationFilter to implement your own 
		/// matcher (default is "false").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-navigation for more details</remarks>
		protected internal bool Navigation { get; set; }

		/// <summary>
		/// Overwrite the default location.href-matching with your own matcher.
		/// (see also "Navigation" above) (default is "")..
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-navigationFilter for more details</remarks>
		protected internal string NavigationFilter { get; set; }
		
	} // Options

} // ns Fluqi.jTab
