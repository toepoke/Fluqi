using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jDatePicker {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dp">DatePicker object to call</param>
		public Methods(DatePicker dp) 
			: base(dp)
		{
		}		


		/// <summary>
		/// Remove the datepicker functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	


		/// <summary>
		/// Disable the datepicker.
		/// </summary>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	


		/// <summary>
		/// Enable the datepicker.
		/// </summary>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	


		/// <summary>
		/// Returns the .ui-datepicker element.
		/// </summary>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	


		/// <summary>
		/// Open a datepicker in a "dialog" box.
		/// </summary>
		/// <param name="date">Initial date for the date picker as Date.</param>
		public void Dialog(DateTime date) {
			this.Dialog(date, "", null, null, null);
		}


		/// <summary>
		/// Open a datepicker in a "dialog" box.
		/// </summary>
		/// <param name="date">Initial date for the date picker as a string in the current date format.</param>
		public void Dialog(string date) {
			this.Dialog(date.InSingleQuotes(), "", null, null, null);
		}


		/// <summary>
		/// Open a datepicker in a "dialog" box.
		/// </summary>
		/// <param name="date">Initial date for the date picker as Date.</param>
		/// <param name="onSelect">
		/// A callback function when a date is selected. 
		/// The function receives the date text and date picker instance as parameters.
		/// </param>
		public void Dialog(DateTime date, string onSelect) {
			this.Dialog(date, onSelect, null, null, null);
		}


		/// <summary>
		/// Open a datepicker in a "dialog" box.
		/// </summary>
		/// <param name="date">Initial date for the date picker as a string in the current date format.</param>
		/// <param name="onSelect">
		/// A callback function when a date is selected. 
		/// The function receives the date text and date picker instance as parameters.
		/// </param>
		public void Dialog(string date, string onSelect) {
			this.Dialog(date.InSingleQuotes(), onSelect, null, null, null);
		}


		/// <summary>
		/// Open a datepicker in a "dialog" box.
		/// </summary>
		/// <param name="date">Initial date for the date picker as Date.</param>
		/// <param name="onSelect">
		/// A callback function when a date is selected. 
		/// The function receives the date text and date picker instance as parameters.
		/// </param>
		/// <param name="settings">The new settings for the date picker.</param>
		public void Dialog(DateTime date, string onSelect, Options settings) {
			this.Dialog(date, onSelect, null, null, settings);
		}


		/// <summary>
		/// Open a datepicker in a "dialog" box.
		/// </summary>
		/// <param name="date">Initial date for the date picker as a string in the current date format.</param>
		/// <param name="onSelect">
		/// A callback function when a date is selected. 
		/// The function receives the date text and date picker instance as parameters.
		/// </param>
		/// <param name="settings">The new settings for the date picker.</param>
		public void Dialog(string date, string onSelect, Options settings) {
			this.Dialog(date.InSingleQuotes(), onSelect, null, null, settings);
		}


		/// <summary>
		/// Open a datepicker in a "dialog" box.
		/// </summary>
		/// <param name="date">Initial date for the date picker as Date.</param>
		/// <param name="onSelect">A callback function when a date is selected. The function receives the date text and date picker instance as parameters.</param>
		/// <param name="leftPosition">The position of the left of the dialog</param>
		/// <param name="topPosition">The position of the top/left of the dialog</param>
		/// <param name="settings">The new settings for the date picker.</param>
		public void Dialog(DateTime date, string onSelect, int? leftPosition, int? topPosition, Options settings) {
			this.DialogBuilder(date.JsDate(), onSelect, leftPosition, topPosition, settings);			
		}


		/// <summary>
		/// Open a datepicker in a "dialog" box.
		/// </summary>
		/// <param name="date">Initial date for the date picker as a string in the current date format.</param>
		/// <param name="onSelect">
		/// A callback function when a date is selected. 
		/// The function receives the date text and date picker instance as parameters.
		/// </param>
		/// <param name="leftPosition">The position of the left of the dialog</param>
		/// <param name="topPosition">The position of the top/left of the dialog</param>
		/// <param name="settings">The new settings for the date picker.</param>
		public void Dialog(string date, string onSelect, int? leftPosition, int? topPosition, Options settings) {
			this.DialogBuilder(date.InSingleQuotes(), onSelect, leftPosition, topPosition, settings);
		}


		/// <summary>
		/// Determines if the datepicker is disabled
		/// </summary>
		public void IsDisabled() {
			this.RenderMethodCall("isDisabled");
		}	


		/// <summary>
		/// Close a previously opened date picker.
		/// </summary>
		public void Hide() {
			this.RenderMethodCall("hide");
		}	


		/// <summary>
		/// Call up a previously attached date picker.
		/// </summary>
		public void Show() {
			this.RenderMethodCall("show");
		}

		
		/// <summary>
		/// Redraw a date picker, after having made some external modifications.
		/// </summary>
		public void Refresh() {
			this.RenderMethodCall("refresh");
		}	
		

		/// <summary>
		/// Returns the current date for the datepicker or null if no date has been selected.
		/// </summary>
		public void GetDate() {
			this.RenderMethodCall("getDate");
		}	


		/// <summary>
		/// Sets the current date for the datepicker. The new date is a .NET Date object 
		/// which is converted the JavaScript equivalent (using the jQuery parseDate helper function). 
		/// </summary>
		public void SetDate(DateTime dt) {
			this.RenderMethodCall("setDate", dt.JsDate());
		}	


		/// <summary>
		/// As there are so many overrides for the In-Dialog option, the building of the option is
		/// abstracted out
		/// </summary>
		/// <param name="date">Initial date for the date picker as Date (if it's a string it should already have quotes in place).</param>
		/// <param name="onSelect">
		/// A callback function when a date is selected. The function receives the date text 
		/// and date picker instance as parameters.
		/// </param>
		/// <param name="leftPosition">The position of the left of the dialog</param>
		/// <param name="topPosition">The position of the top/left of the dialog</param>
		/// <param name="settings">The new settings for the date picker.</param>
		private void DialogBuilder(string date, string onSelect, int? leftPosition, int? topPosition, Options settings) {
			string position = null;
			if (leftPosition.HasValue && topPosition.HasValue) {
				List<int> posList = new List<int>() { leftPosition.Value, topPosition.Value };
				position = posList.JsArray();
			}
			if (!string.IsNullOrEmpty(onSelect)) {
				onSelect = "function(dateStr, dateInst) { " + onSelect + " }";
			} else {
				onSelect = null;
			}

			this.RenderMethodCall("dialog", date, onSelect, settings, position);
		}

	}

}
