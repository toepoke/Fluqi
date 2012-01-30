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
		/// Sets the "disabled" flag (http://jqueryui.com/demos/tabs/#option-disabled).
		/// </summary>
		/// <param name="disabled">
		/// True: sets disabled on
		/// False: sets disabled off
		/// </param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>Why you'd want to use this I have no idea!</remarks>
		public Options SetDisabled(bool disabled) {
			this.Disabled = disabled;
			return this;
		}


		/// <summary>
		/// An array containing the position of the tabs (zero-based index) that 
		/// should be disabled on initialization.
		/// </summary>
		/// <returns>Options object for chainability</returns>
		public Options SetDisabled(List<int> disabled) {
			this.DisabledArray = disabled;
			return this;
		}


		/// <summary>
		/// An array containing the position of the tabs (zero-based index) that 
		/// should be disabled on initialization.
		/// </summary>
		/// <returns>Options object for chainability</returns>
		public Options SetDisabled(params int[] disabledTabs) {
			this.DisabledArray = (from i in disabledTabs select i).ToList<int>();
			return this;
		}


		/// <summary>
		/// Whether or not to cache remote tabs content, e.g. load only once or with every click. 
		/// Cached content is being lazy loaded, e.g once and only once for the first click. 
		/// Note that to prevent the actual Ajax requests from being cached by the browser you need to provide an extra 
		/// cache: false flag to ajaxOptions
		/// </summary>
		/// <returns>Options object for chainability</returns>
		public Options SetCache(bool cache) {
			this.Cache = cache;
			return this;
		}


		/// <summary>
		/// Additional Ajax options to consider when loading tab content (see $.ajax).
		/// </summary>
		/// <remarks>Note this is passed "as is" to the jQuery UI Tabs.ajaxOptions setting.</remarks>
		public Options SetAjaxOptions(string ajaxOptions) {
			this.AjaxOptions = ajaxOptions;
			return this;
		}


		/// <summary>
		/// Sets whether the selected tab is collapsible or not.
		/// </summary>
		/// <param name="collapsible">Flags whether collapsible is on or off</param>
		/// <returns>Options object for chainability</returns>
		public Options SetCollapsible(bool collapsible) {
			this.Collapsible = collapsible;
			return this;
		}


		/// <summary>
		/// Sets the event that opens a tab, e.g. "mouseover"
		/// </summary>
		/// <param name="evt">Event to use to open a tab</param>
		/// <returns>Options object for chainability</returns>
		public Options SetEvent(string evt) {
			this.Evt = evt ?? "";

			// we'll be adding our own quotes when we render
			this.Evt = this.Evt.Trim(new char[] { '\"', '\'' });

			return this;
		}


		/// <summary>
		/// Sets the event that opens a tab, e.g. "mouseover"
		/// </summary>
		/// <param name="browserEvent">Event to use to open a tab</param>
		/// <returns>Options object for chainability</returns>
		public Options SetEvent(Core.BrowserEvent.eBrowserEvent browserEvent) {
			return this.SetEvent( Core.BrowserEvent.BrowserEventToString(browserEvent) );
		}


		/// <summary>
		/// Sets the tab transition effect.  As this can have multiple arguments the
		/// parameter is specified as JSON, so for example: 
		///		myTabs.Options.SetEffect("{ opacity: 'toggle' }")
		/// See http://stackoverflow.com/questions/1350666/jquery-ui-tabs-available-fx-options for 
		/// more details
		/// </summary>
		/// <param name="effect">Animation definition</param>
		/// <returns>Options object for chainability</returns>
		public Options SetEffect(string effect) {
			this.Fx = effect ?? "";
			return this;
		}


		/// <summary>
		/// If the remote tab, its anchor element that is, has no title attribute to generate an 
		/// id from, an id/fragment identifier is created from this prefix and a unique id returned 
		/// by $.data(el), for example "ui-tabs-54".
		/// </summary>
		/// <returns>Options object for chainability</returns>
		public Options SetIdPrefix(string idPrefix) {
			this.IdPrefix = idPrefix ?? "";
			return this;
		}


		/// <summary>
		/// HTML template from which a new tab panel is created in case of adding a tab with the 
		/// add method or when creating a panel for a remote tab on the fly.
		/// </summary>
		/// <returns>Options object for chainability</returns>
		public Options SetPanelTemplate(string panelTemplate) {
			this.PanelTemplate = panelTemplate ?? "";
			return this;
		}


		/// <summary>
		/// The HTML content of this string is shown in a tab title while remote content is loading. 
		/// Pass in empty string to deactivate that behavior. An span element must be present in 
		/// the A tag of the title, for the spinner content to be visible.
		/// </summary>
		/// <returns>Options object for chainability</returns>
		public Options SetSpinner(string spinner) {
			this.Spinner = spinner ?? "";
			return this;
		}		

		
		/// <summary>
		/// HTML template from which a new tab is created and added. The placeholders 
		/// #{href} and #{label} are replaced with the url and tab label that are passed as 
		/// arguments to the add method.
		/// </summary>
		/// <returns>Options object for chainability</returns>
		public Options SetTabTemplate(string tabTemplate) {
			this.TabTemplate = tabTemplate;
			return this;
		}

	} // Options

} // ns Fluqi.jTab
