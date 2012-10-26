using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jAutoComplete {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Returns [in JavaScript] the current "appendTo" setting.
		/// </summary>
		public void GetAppendTo() {
			this.RenderGetOptionCall("appendTo");
		}

		/// <summary>
		/// Which element the menu should be appended to.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New appendTo value</param>
		public void SetAppendToJS(string newValue) {
			this.RenderSetOptionCall("appendTo", newValue);
		}
	
		/// <summary>
		/// Which element the menu should be appended to.
		/// </summary>
		/// <param name="newValue">New appendTo value</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetAppendTo(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("appendTo", newValue, inDoubleQuotes);
		}
	
		/// <summary>
		/// Which element the menu should be appended to.
		/// </summary>
		/// <param name="newValue">New appendTo value</param>
		public void SetAppendTo(string newValue) {
			this.SetAppendTo(newValue, true/*doubleQuotes*/);
		}
	
		/// <summary>
		/// Returns [in JavaScript] the current "autoFocus" setting.
		/// </summary>
		public void GetAutoFocus() {
			this.RenderGetOptionCall("autoFocus");
		}

		/// <summary>
		/// If set to true the first item will be automatically focused.
		/// </summary>
		/// <param name="newValue">New autoFocus setting</param>
		public void SetAutoFocus(bool newValue) {
			this.RenderSetOptionCall("autoFocus", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "delay" setting.
		/// </summary>
		public void GetDelay() {
			this.RenderGetOptionCall("delay");
		}

		/// <summary>
		/// The delay in milliseconds the Autocomplete waits after a keystroke to activate 
		/// itself. A zero-delay makes sense for local data (more responsive), but can produce 
		/// a lot of load for remote data, while being less responsive.
		/// </summary>
		/// <param name="newValue">New delay setting</param>
		public void SetDelay(int newValue) {
			this.RenderSetOptionCall("delay", newValue.ToString());
		}
		
			/// <summary>
			/// Returns [in JavaScript] the current "minLength" setting.
			/// </summary>
		public void GetMinLength() {
			this.RenderGetOptionCall("minLength");
		}

		/// <summary>
		/// The minimum number of characters a user has to type before the Autocomplete 
		/// activates. Zero is useful for local data with just a few items. Should be increased when 
		/// there are a lot of items, where a single character would match a few thousand items.
		/// </summary>
		/// <param name="newValue">New minLength setting</param>
		public void SetMinLength(int newValue) {
			this.RenderSetOptionCall("minLength", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "position" setting.
		/// </summary>
		public void GetPosition() {
			this.RenderGetOptionCall("position");
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPositionJS(string position) {
			this.RenderSetOptionCall("position", position);
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// </summary>
		/// <param name="position">New position setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetPosition(string position, bool inDoubleQuotes) {
			this.RenderSetOptionCall("position", position, inDoubleQuotes);
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPosition(string position) {
			this.SetPosition(position, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPosition(Core.Position.ePosition position) {
			this.RenderSetOptionCall("position", Core.Position.PositionToString(position).InDoubleQuotes() );
		}
		
		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// An array containing x,y position string values (e.g. ['right','top'] for top right corner)
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(string pos1, string pos2) {
			List<string> positions = new List<string>() { pos1, pos2 };
			this.RenderSetOptionCall("position", positions.JsArray(false/*singleQuotes*/));
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// An array containing x,y position string values (e.g. ['right','top'] for top right corner)
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			this.SetPosition( Core.Position.PositionToString(pos1), Core.Position.PositionToString(pos2) );
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// An array containing an x,y coordinate pair in pixel offset from left, top corner of viewport (e.g. [350,100]) 
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(int pos1, int pos2) {
			List<int> positions = new List<int>() { pos1, pos2 };
			this.RenderSetOptionCall("position", positions.JsArray());
		}

		/// <summary>
		/// Defines the data to use, must be specified. See Overview section for more details, 
		/// and look at the various demos.
		/// </summary>
		/// <param name="sourceItems">Array of items to become the source</param>
		public void SetSource(List<string> sourceItems) {
			this.SetSource(sourceItems, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Defines the data to use, must be specified. See Overview section for more details, 
		/// and look at the various demos.
		/// </summary>
		/// <param name="sourceItems">Array of items to become the source</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetSource(List<string> sourceItems, bool inDoubleQuotes) {
			this.RenderSetOptionCall("source", sourceItems.JsArray(inDoubleQuotes) );
		}

		/// <summary>
		/// Defines the data to use, must be specified. See Overview section for more details, 
		/// and look at the various demos.
		/// </summary>
		/// <param name="items">Items to become the source</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetSource(bool inDoubleQuotes, params string[] items) {
			this.SetSource(new List<string>(items), inDoubleQuotes);
		}

		/// <summary>
		/// Defines the data to use, must be specified. See Overview section for more details, 
		/// and look at the various demos.
		/// </summary>
		/// <param name="items">Array of items to become the source</param>
		public void SetSource(params string[] items) {
			this.SetSource(true/*doubleQuotes*/, items);
		}

		/// <summary>
		/// Defines the data to use, must be specified. See Overview section for more details, 
		/// and look at the various demos.
		/// </summary>
		/// <param name="url">url to deliver the source items for</param>
		public void SetSource(string url) {
			this.SetSource(url, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Defines the data to use, must be specified. See Overview section for more details, 
		/// and look at the various demos.
		/// </summary>
		/// <param name="url">url to deliver the source items for</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetSource(string url, bool inDoubleQuotes) {
			this.RenderSetOptionCall("source", url.InQuotes(inDoubleQuotes) );
		}

	}

}
