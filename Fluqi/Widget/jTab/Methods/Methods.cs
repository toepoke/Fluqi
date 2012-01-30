using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jTab {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tabs">Tabs object to call</param>
		public Methods(Tabs tabs) : base(tabs)
		{
		}		

		/// <summary>
		/// Remove the tabs functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-destroy for details.</remarks>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	


		/// <summary>
		/// Disable the tabs.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-disable for details.</remarks>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	


		/// <summary>
		/// Disable a tab. The selected tab cannot be disabled. To disable more than one tab at once use:
		/// $('#example').tabs("option","disabled", [1, 2, 3]);
		/// The second argument is the zero-based index of the tab to be disabled.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-disable for details.</remarks>
		public void Disable(params int[] indexes) {
			if (indexes.Count() == 1)
				this.RenderMethodCall("disable", indexes[0] );
			else 
				this.RenderMethodCall("disable", indexes.JsArray() );
		}	


		/// <summary>
		/// Enable the tabs.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-enable for details.</remarks>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	


		/// <summary>
		/// Enable a disabled tab. The second argument is the zero-based index of the tab to be enabled.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-enable for details.</remarks>
		public void Enable(int index) {
			this.RenderMethodCall("enable", index);
		}	


		/// <summary>
		/// Returns the .ui-tabs element.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-widget for details.</remarks>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	


		/// <summary>
		/// Add a new tab. 
		/// <param name="url">
		/// The second argument is either a URL consisting of a fragment identifier only to create an in-page tab or a 
		/// full url (relative or absolute, no cross-domain support) to turn the new tab into an Ajax (remote) tab.
		/// </param>
		/// <param name="label">
		/// Text to appear in the title of the tab.
		/// </param>
		/// <param name="insertAt">
		/// The third is the zero-based position where to insert the new tab.
		/// </param>
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-add for details.</remarks>
		public void Add(string url, string label, int insertAt) {
			this.RenderMethodCall("add", url.InDoubleQuotes(), label.InDoubleQuotes(), insertAt );
		}	


		/// <summary>
		/// Add a new tab and the end of the set of tab panes. 
		/// <param name="url">
		/// The second argument is either a URL consisting of a fragment identifier only to create an in-page tab or a 
		/// full url (relative or absolute, no cross-domain support) to turn the new tab into an Ajax (remote) tab.
		/// </param>
		/// <param name="label">
		/// Text to appear in the title of the tab.
		/// </param>
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-add for details.</remarks>
		public void Add(string url, string label) {
			this.RenderMethodCall("add", url.InDoubleQuotes(), label.InDoubleQuotes() );
		}	


		/// <summary>
		/// Remove a tab. 
		/// </summary>
		/// <param name="index">
		/// Zero-based index of the tab to be removed.
		/// </param>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-remove for details.</remarks>
		public void Remove(int index) {
			this.RenderMethodCall("remove", index );
		}	


		/// <summary>
		/// Select a tab, as if it were clicked. The second argument is the zero-based index of the 
		/// tab to be selected or the id selector of the panel the tab is associated with 
		/// (the tab's href fragment identifier, e.g. hash, points to the panel's id)
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-select for details.</remarks>
		public void Select(int index) {
			this.RenderMethodCall("select", index);
		}	


		/// <summary>
		/// Select a tab, as if it were clicked. The second argument is id selector of the panel the 
		/// tab is associated with (the tab's href fragment identifier, e.g. hash, points to the panel's id)
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-select for details.</remarks>
		public void SelectJS(string idOrHash) {
			this.RenderMethodCall("select", idOrHash);
		}	

		/// <summary>
		/// Select a tab, as if it were clicked. The second argument is id selector of the panel the 
		/// tab is associated with (the tab's href fragment identifier, e.g. hash, points to the panel's id)
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-select for details.</remarks>
		/// <param name="idOrHash">What tab to select</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void Select(string idOrHash, bool inDoubleQuotes) {
			this.RenderMethodCall("select", idOrHash.InQuotes(inDoubleQuotes));
		}	

		/// <summary>
		/// Select a tab, as if it were clicked. The second argument is id selector of the panel the 
		/// tab is associated with (the tab's href fragment identifier, e.g. hash, points to the panel's id)
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-select for details.</remarks>
		public void Select(string idOrHash) {
			this.Select(idOrHash, true/*doubleQuotes*/);
		}	

		/// <summary>
		/// Reload the content of an Ajax tab programmatically. This method always loads the tab content 
		/// from the remote location, even if cache is set to true. Note the remote location is the href
		/// in the header of the tab.
		/// <param name="index">
		/// Zero-based index of the tab to be reloaded.
		/// </param>
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-load for details.</remarks>
		public void Load(int index) {
			this.RenderMethodCall("load", index);
		}	


		/// <summary>
		/// Change the url from which an Ajax (remote) tab will be loaded. The specified URL will be 
		/// used for subsequent loads. 
		/// Note that you can not only change the URL for an existing remote tab with this method, 
		/// but also turn an in-page tab into a remote tab. 
		/// The second argument is the zero-based index of the tab of which its URL is to be updated. 
		/// The third is a URL the content of the tab is loaded from.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-url for details.</remarks>
		public void Url(int index, string url) {
			this.RenderMethodCall("url", index, url.InDoubleQuotes());
		}

		
		/// <summary>
		/// Retrieve the number of tabs of the first matched tab pane.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-length for details.</remarks>
		public void Length() {
			this.RenderMethodCall("length");
		}	
		

		/// <summary>
		/// Terminate all running tab ajax requests and animations.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-abort for details.</remarks>
		public void Abort() {
			this.RenderMethodCall("abort");
		}	


		/// <summary>
		/// Set up an automatic rotation through tabs of a tab pane. 
		/// The second argument is an amount of time in milliseconds until the next tab in the cycle gets activated. 
		///		Use 0 or null to stop the rotation. 
		///	The third controls whether or not to continue the rotation after a tab has been selected by a 
		///	user. Default: false.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-rotate for details.</remarks>
		public void StartRotation(int ms, bool cont) {
			this.RenderMethodCall("rotate", ms, cont.JsBool());
		}	


		/// <summary>
		/// Set up an automatic rotation through tabs of a tab pane, with a delay of 1 second between
		/// transitions.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-rotate for details.</remarks>
		public void StartRotation() {
			this.RenderMethodCall("rotate", 1000/*1 second*/);
		}	


		/// <summary>
		/// Stops the rotation effect
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/tabs/#method-rotate for details.</remarks>
		public void StopRotation() {
			this.StartRotation( 0/*zero stops rotation*/, false/*continue*/);
		}	

		
		/// <summary>
		/// Returns [in JavaScript] the current "cache" setting.
		/// </summary>
		public void GetCache() {
			this.RenderGetOptionCall("cache");
		}

		/// <summary>
		/// Whether or not to cache remote tabs content, e.g. load only once or with every click. 
		/// Cached content is being lazy loaded, e.g once and only once for the first click. 
		/// Note that to prevent the actual Ajax requests from being cached by the browser you need to 
		/// provide an extra cache: false flag to ajaxOptions.
		/// </summary>
		/// <param name="newValue">New cache setting</param>
		public void SetCache(bool newValue) {
			this.RenderSetOptionCall("cache", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "collapsible" setting.
		/// </summary>
		public void GetCollapsible() {
			this.RenderGetOptionCall("collapsible");
		}

		/// <summary>
		/// Set to true to allow an already selected tab to become unselected again upon reselection.
		/// </summary>
		/// <param name="newValue">New collapsible setting</param>
		public void SetCollapsible(bool newValue) {
			this.RenderSetOptionCall("collapsible", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "event" setting.
		/// </summary>
		public void GetCookie() {
			this.RenderGetOptionCall("cookie");
		}

		/// <summary>
		/// Specifies when the cookie should expire
		/// </summary>
		/// <param name="expiryInDays">Number of days in which the expiry page</param>
		public void SetCookieExpiry(int expiryInDays) {
			this.RenderSetOptionCall("cookie", "{{ expires: {0} }}", expiryInDays.ToString());
		}

		/// <summary>
		/// Specifies the path the cookie is valid within.  So "/" means the whole site, "/demos" 
		/// means it's only applicable in the "demos" subfolder.
		/// </summary>
		/// <param name="path">Path of the cookie</param>
		public void SetCookiePath(string path) {
			this.RenderSetOptionCall("cookie", "{{ path: '{0}' }}", path);
		}

		/// <summary>
		/// Specifies the domain the cookie should be saved to.  So you could have a subdomain
		/// so the cookie is only saved there.
		/// </summary>
		/// <param name="domain">Domain of the cookie</param>
		public void SetCookieDomain(string domain) {
			this.RenderSetOptionCall("cookie", "{{ domain: '{0}' }}", domain);
		}

		/// <summary>
		/// If true, the secure attribute of the cookie will be set and the cookie transmission will
		/// require a secure protocol (like HTTPS).
		/// </summary>
		/// <param name="secure">
		/// true for a secure cookie
		/// false for non-secure cookie
		/// </param>
		public void SetCookieSecure(bool secure) {
			this.RenderSetOptionCall("cookie", "{{ secure: {0} }}", secure.JsBool() );
		}

		/// <summary>
		/// Returns [in JavaScript] the current "event" setting.
		/// </summary>
		public void GetEvent() {
			this.RenderGetOptionCall("event");
		}

		/// <summary>
		/// The type of event to be used for selecting a tab.
		/// </summary>
		/// <param name="newValue">New event setting</param>
		public void SetEvent(Core.BrowserEvent.eBrowserEvent newValue) {
			this.RenderSetOptionCall("event", Core.BrowserEvent.BrowserEventToString(newValue).InDoubleQuotes());
		}

		/// <summary>
		/// The type of event to be used for selecting a tab.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New event setting</param>
		public void SetEventJS(string newValue) {
			this.RenderSetOptionCall("event", newValue);
		}

		/// <summary>
		/// The type of event to be used for selecting a tab.
		/// </summary>
		/// <param name="newValue">New event setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetEvent(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("event", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The type of event to be used for selecting a tab.
		/// </summary>
		/// <param name="newValue">New event setting</param>
		public void SetEvent(string newValue) {
			this.SetEvent(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "effect" setting.
		/// </summary>
		public void GetEffect() {
			this.RenderGetOptionCall("fx");
		}

		/// <summary>
		/// Enable animations for hiding and showing tab panels. The duration option can be 
		/// a string representing one of the three predefined speeds ("slow", "normal", "fast") 
		/// or the duration in milliseconds to run an animation (default is "normal").
		/// </summary>
		/// <param name="newValue">New effect setting</param>
		public void SetEffect(int newValue) {
			this.RenderSetOptionCall("fx", newValue.ToString());
		}

		/// <summary>
		/// Enable animations for hiding and showing tab panels. The duration option can be 
		/// a string representing one of the three predefined speeds ("slow", "normal", "fast") 
		/// or the duration in milliseconds to run an animation (default is "normal").
		/// </summary>
		/// <param name="newValue">New effect setting</param>
		public void SetEffect(Core.Speed.eSpeed newValue) {
			string speedStr = Core.Speed.SpeedToString(newValue);
			this.RenderSetOptionCall("fx", speedStr.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "idPrefix" setting.
		/// </summary>
		public void GetIdPrefix() {
			this.RenderGetOptionCall("idPrefix");
		}

		/// <summary>
		/// If the remote tab, its anchor element that is, has no title attribute to generate an id 
		/// from, an id/fragment identifier is created from this prefix and a unique id returned 
		/// by $.data(el), for example "ui-tabs-54".
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New idPrefix setting</param>
		public void SetIdPrefixJS(string newValue) {
			this.RenderSetOptionCall("idPrefix", newValue);
		}

		/// <summary>
		/// If the remote tab, its anchor element that is, has no title attribute to generate an id 
		/// from, an id/fragment identifier is created from this prefix and a unique id returned 
		/// by $.data(el), for example "ui-tabs-54".
		/// </summary>
		/// <param name="newValue">New idPrefix setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetIdPrefix(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("idPrefix", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// If the remote tab, its anchor element that is, has no title attribute to generate an id 
		/// from, an id/fragment identifier is created from this prefix and a unique id returned 
		/// by $.data(el), for example "ui-tabs-54".
		/// </summary>
		/// <param name="newValue">New idPrefix setting</param>
		public void SetIdPrefix(string newValue) {
			this.SetIdPrefix(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "panelTemplate" setting.
		/// </summary>
		public void GetPanelTemplate() {
			this.RenderGetOptionCall("panelTemplate");
		}

		/// <summary>
		/// HTML template from which a new tab panel is created in case of adding a tab 
		/// with the add method or when creating a panel for a remote tab on the fly.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New panelTemplate setting</param>
		public void SetPanelTemplateJS(string newValue) {
			this.RenderSetOptionCall("panelTemplate", newValue);
		}

		/// <summary>
		/// HTML template from which a new tab panel is created in case of adding a tab 
		/// with the add method or when creating a panel for a remote tab on the fly.
		/// </summary>
		/// <param name="newValue">New panelTemplate setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetPanelTemplate(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("panelTemplate", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// HTML template from which a new tab panel is created in case of adding a tab 
		/// with the add method or when creating a panel for a remote tab on the fly.
		/// </summary>
		/// <param name="newValue">New panelTemplate setting</param>
		public void SetPanelTemplate(string newValue) {
			this.SetPanelTemplate(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "spinner" setting.
		/// </summary>
		public void GetSpinner() {
			this.RenderGetOptionCall("spinner");
		}

		/// <summary>
		/// The HTML content of this string is shown in a tab title while remote content is loading. 
		/// Pass in empty string to deactivate that behavior. An span element must be present in the 
		/// A tag of the title, for the spinner content to be visible.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New spinner setting</param>
		public void SetSpinnerJS(string newValue) {
			this.RenderSetOptionCall("spinner", newValue);
		}

		/// <summary>
		/// The HTML content of this string is shown in a tab title while remote content is loading. 
		/// Pass in empty string to deactivate that behavior. An span element must be present in the 
		/// A tag of the title, for the spinner content to be visible.
		/// </summary>
		/// <param name="newValue">New spinner setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetSpinner(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("spinner", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The HTML content of this string is shown in a tab title while remote content is loading. 
		/// Pass in empty string to deactivate that behavior. An span element must be present in the 
		/// A tag of the title, for the spinner content to be visible.
		/// </summary>
		/// <param name="newValue">New spinner setting</param>
		public void SetSpinner(string newValue) {
			this.SetSpinner(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the selected setting.
		/// To set all tabs to unselected pass -1 as value.
		/// </summary>
		public void GetSelected() {
			this.RenderGetOptionCall("selected");
		}

		/// <summary>
		/// Zero-based index of the tab to be selected on initialization. 
		/// To set all tabs to unselected pass -1 as value.
		/// </summary>
		/// <param name="newValue">New selected value</param>
		public void SetSelected(int newValue) {
			this.RenderSetOptionCall("selected", newValue.ToString()); 
		}

		/// <summary>
		/// Returns [in JavaScript] the current "tabTemplate" setting.
		/// </summary>
		public void GetTabTemplate() {
			this.RenderGetOptionCall("tabTemplate");
		}

		/// <summary>
		/// HTML template from which a new tab is created and added. The placeholders #{href} 
		/// and #{label} are replaced with the url and tab label that are passed as arguments 
		/// to the add method.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New tabTemplate setting</param>
		public void SetTabTemplateJS(string newValue) {
			this.RenderSetOptionCall("tabTemplate", newValue);
		}

		/// <summary>
		/// HTML template from which a new tab is created and added. The placeholders #{href} 
		/// and #{label} are replaced with the url and tab label that are passed as arguments 
		/// to the add method.
		/// </summary>
		/// <param name="newValue">New tabTemplate setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetTabTemplate(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("tabTemplate", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// HTML template from which a new tab is created and added. The placeholders #{href} 
		/// and #{label} are replaced with the url and tab label that are passed as arguments 
		/// to the add method.
		/// </summary>
		/// <param name="newValue">New tabTemplate setting</param>
		public void SetTabTemplate(string newValue) {
			this.SetTabTemplate(newValue, true/*doubleQuotes*/);
		}
	}

}
