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
		/// Specifies how the panels should expand (default is "auto")
		/// </summary>
		protected internal string HeightStyle { get; set; }

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
		/// Icons to use for non-selected accordion headers icon class.  This equates to the 'header' 
		/// class.
		/// We recommend using the icons native to the jQuery UI CSS Framework manipulated 
		/// by jQuery UI ThemeRoller
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-icons for more details</remarks>
		protected internal string HeaderIconClass { get; set; }
			
		/// <summary>
		/// Icons to use for selected accordion header icon class.  This equates to the 'activeHeader' 
		/// class.
		/// We recommend using the icons native to the jQuery UI CSS Framework manipulated 
		/// by jQuery UI ThemeRoller
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#option-icons for more details</remarks>
		protected internal string activeHeaderIconClass { get; set; }

	} // Options

} // ns Fluqi.jTab
