using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jTab
{

	public partial class Options: Core.Options
	{
		/// <summary>
		/// Flags whether the "disabled" flag is on or off (default is "false").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-disabled for details</remarks>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// An array containing the position of the tabs (zero-based index) that should be disabled on initialization.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-disabled for details</remarks>
		protected internal List<int> DisabledArray { get; set; }

		/// <summary>
		/// Whether or not to cache remote tabs content, e.g. load only once or with every click. 
		/// Cached content is being lazy loaded, e.g once and only once for the first click. 
		/// Note that to prevent the actual Ajax requests from being cached by the browser you need to provide an extra 
		/// cache: false flag to ajaxOptions
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-cache for details</remarks>
		protected internal bool Cache { get; set; }

		/// <summary>
		/// Additional Ajax options to consider when loading tab content (see $.ajax).
		/// </summary>
		/// <remarks>Note this is passed "as is" to the jQuery UI Tabs.ajaxOptions setting.</remarks>
		protected internal string AjaxOptions { get; set; }

		/// <summary>
		/// Stores whether the tabs are initialised with the collapsible option on or off (default is "false").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-collapsible for more details</remarks>
		protected internal bool Collapsible { get; set; }

		/// <summary>
		/// Stores the event [override] to be used when opening/closing tabs (default is "click").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-event for details</remarks>
		protected internal string Evt { get; set; }

		/// <summary>
		/// Stores the animation to be used when opening/closing tabs (default is "").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-fx for details</remarks>
		protected internal string Fx { get; set; }

		/// <summary>
		/// If the remote tab, its anchor element that is, has no title attribute to generate an 
		/// id from, an id/fragment identifier is created from this prefix and a unique id returned 
		/// by $.data(el), for example "ui-tabs-54".
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-idPrefix for details</remarks>
		protected internal string IdPrefix { get; set; }

		/// <summary>
		/// HTML template from which a new tab panel is created in case of adding a tab with the 
		/// add method or when creating a panel for a remote tab on the fly.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-panelTemplate for details</remarks>
		protected internal string PanelTemplate { get; set; }

		/// <summary>
		/// The HTML content of this string is shown in a tab title while remote content is loading. 
		/// Pass in empty string to deactivate that behavior. An span element must be present in 
		/// the A tag of the title, for the spinner content to be visible.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-spinner for details</remarks>
		protected internal string Spinner { get; set; }

		/// <summary>
		/// HTML template from which a new tab is created and added. The placeholders 
		/// #{href} and #{label} are replaced with the url and tab label that are passed as 
		/// arguments to the add method.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#option-tabTemplate for details</remarks>
		protected internal string TabTemplate { get; set; }

	} // Options

} // ns Fluqi.jTab
