using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jDatePicker {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Returns [in JavaScript] the current "altField" setting.
		/// </summary>
		public void GetAltField() {
			this.RenderGetOptionCall("altField");
		}

		/// <summary>
		/// The jQuery selector for another field that is to be updated with the selected date 
		/// from the datepicker. Use the altFormat setting to change the format of the date 
		/// within this field. Leave as blank for no alternate field.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New altField setting</param>
		public void SetAltFieldJS(string newValue) {
			this.RenderSetOptionCall("altField", newValue);
		}

		/// <summary>
		/// The jQuery selector for another field that is to be updated with the selected date 
		/// from the datepicker. Use the altFormat setting to change the format of the date 
		/// within this field. Leave as blank for no alternate field.
		/// </summary>
		/// <param name="newValue">New altField setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetAltField(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("altField", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The jQuery selector for another field that is to be updated with the selected date 
		/// from the datepicker. Use the altFormat setting to change the format of the date 
		/// within this field. Leave as blank for no alternate field.
		/// </summary>
		/// <param name="newValue">New altField setting</param>
		public void SetAltField(string newValue) {
			this.SetAltField(newValue, true/*doubleQuotes*/);
		}
	
		/// <summary>
		/// Returns [in JavaScript] the current "altFormat" setting.
		/// </summary>
		public void GetAltFormat() {
			this.RenderGetOptionCall("altFormat");
		}

		/// <summary>
		/// The dateFormat to be used for the altField option. This allows one date format to 
		/// be shown to the user for selection purposes, while a different format is actually 
		/// sent behind the scenes. For a full list of the possible formats see the formatDate 
		/// function.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New altFormat setting</param>
		public void SetAltFormatJS(string newValue) {
			this.RenderSetOptionCall("altFormat", newValue);
		}

		/// <summary>
		/// The dateFormat to be used for the altField option. This allows one date format to 
		/// be shown to the user for selection purposes, while a different format is actually 
		/// sent behind the scenes. For a full list of the possible formats see the formatDate 
		/// function
		/// </summary>
		/// <param name="newValue">New altFormat setting</param>
		public void SetAltFormat(string newValue) {
			this.SetAltFormat(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// The dateFormat to be used for the altField option. This allows one date format to 
		/// be shown to the user for selection purposes, while a different format is actually 
		/// sent behind the scenes. For a full list of the possible formats see the formatDate 
		/// function
		/// </summary>
		/// <param name="newValue">New altFormat setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetAltFormat(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("altFormat", newValue.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "appendText" setting.
		/// </summary>
		public void GetAppendText() {
			this.RenderGetOptionCall("appendText");
		}

		/// <summary>
		/// The text to display after each date field, e.g. to show the required format.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New appendText setting</param>
		public void SetAppendTextJS(string newValue) {
			this.RenderSetOptionCall("appendText", newValue);
		}

		/// <summary>
		/// The text to display after each date field, e.g. to show the required format.
		/// </summary>
		/// <param name="newValue">New appendText setting</param>
		public void SetAppendText(string newValue) {
			this.SetAppendText(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// The text to display after each date field, e.g. to show the required format.
		/// </summary>
		/// <param name="newValue">New appendText setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetAppendText(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("appendText", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "autoSize" setting.
		/// </summary>
		public void GetAutoSize() {
			this.RenderGetOptionCall("autoSize");
		}

		/// <summary>
		/// Set to true to automatically resize the input field to accommodate 
		/// dates in the current dateFormat.
		/// </summary>
		/// <param name="newValue">New autoSize setting</param>
		public void SetAutoSize(bool newValue) {
			this.RenderSetOptionCall("autoSize", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "buttonImage" setting.
		/// </summary>
		public void GetButtonImage() {
			this.RenderGetOptionCall("buttonImage");
		}

		/// <summary>
		/// The URL for the popup button image. If set, buttonText becomes 
		/// the alt value and is not directly displayed.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New buttonImage setting</param>
		public void SetButtonImageJS(string newValue) {
			this.RenderSetOptionCall("buttonImage", newValue);
		}

		/// <summary>
		/// The URL for the popup button image. If set, buttonText becomes 
		/// the alt value and is not directly displayed.
		/// </summary>
		/// <param name="newValue">New buttonImage setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetButtonImage(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("buttonImage", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The URL for the popup button image. If set, buttonText becomes 
		/// the alt value and is not directly displayed.
		/// </summary>
		/// <param name="newValue">New buttonImage setting</param>
		public void SetButtonImage(string newValue) {
			this.SetButtonImage(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "buttonImageOnly" setting.
		/// </summary>
		public void GetButtonImageOnly() {
			this.RenderGetOptionCall("buttonImageOnly");
		}

		/// <summary>
		/// Set to true to place an image after the field to use as the trigger 
		/// without it appearing on a button.
		/// </summary>
		/// <param name="newValue">New buttonImageOnly setting</param>
		public void SetButtonImageOnly(bool newValue) {
			this.RenderSetOptionCall("buttonImageOnly", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "buttonText" setting.
		/// </summary>
		public void GetButtonText() {
			this.RenderGetOptionCall("buttonText");
		}

		/// <summary>
		/// The text to display on the trigger button. Use in conjunction 
		/// with showOn equal to 'button' or 'both'.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New buttonText setting</param>
		public void SetButtonTextJS(string newValue) {
			this.RenderSetOptionCall("buttonText", newValue);
		}

		/// <summary>
		/// The text to display on the trigger button. Use in conjunction 
		/// with showOn equal to 'button' or 'both'.
		/// </summary>
		/// <param name="newValue">New buttonText setting</param>
		public void SetButtonText(string newValue) {
			this.SetButtonText(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// The text to display on the trigger button. Use in conjunction 
		/// with showOn equal to 'button' or 'both'.
		/// </summary>
		/// <param name="newValue">New buttonText setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetButtonText(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("buttonText", newValue.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "calculateWeek" setting.
		/// </summary>
		public void GetCalculateWeek() {
			this.RenderGetOptionCall("calculateWeek");
		}

		/// <summary>
		/// A function to calculate the week of the year for a given date. 
		/// The default implementation uses the ISO 8601 definition: 
		/// weeks start on a Monday; the first week of the year contains the 
		/// first Thursday of the year.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New calculateWeek setting</param>
		public void SetCalculateWeekJS(string newValue) {
			this.RenderSetOptionCall("calculateWeek", newValue);
		}

		/// <summary>
		/// A function to calculate the week of the year for a given date. 
		/// The default implementation uses the ISO 8601 definition: 
		/// weeks start on a Monday; the first week of the year contains the 
		/// first Thursday of the year.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New calculateWeek setting</param>
		public void SetCalculateWeek(string newValue) {
			// It's not appropriate to have a quoted version of the CalculateWeek, so this
			// entry point is merely to be consistent from a method signature perspective.
			this.SetCalculateWeekJS(newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "changeMonth" setting.
		/// </summary>
		public void GetChangeMonth() {
			this.RenderGetOptionCall("changeMonth");
		}

		/// <summary>
		/// Allows you to change the month by selecting from a drop-down list. 
		/// You can enable this feature by setting the attribute to true.
		/// </summary>
		/// <param name="newValue">New changeMonth setting</param>
		public void SetChangeMonth(bool newValue) {
			this.RenderSetOptionCall("changeMonth", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "changeYear" setting.
		/// </summary>
		public void GetChangeYear() {
			this.RenderGetOptionCall("changeYear");
		}

		/// <summary>
		/// Allows you to change the year by selecting from a drop-down list. 
		/// You can enable this feature by setting the attribute to true. 
		/// Use the yearRange option to control which years are made available 
		/// for selection.
		/// </summary>
		/// <param name="newValue">New changeYear setting</param>
		public void SetChangeYear(bool newValue) {
			this.RenderSetOptionCall("changeYear", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "closeText" setting.
		/// </summary>
		public void GetCloseText() {
			this.RenderGetOptionCall("closeText");
		}

		/// <summary>
		/// The text to display for the close link. This attribute is one of 
		/// the regionalisation attributes. Use the showButtonPanel to display 
		/// this button.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New closeText setting</param>
		public void SetCloseTextJS(string newValue) {
			this.RenderSetOptionCall("closeText", newValue);
		}

		/// <summary>
		/// The text to display for the close link. This attribute is one of 
		/// the regionalisation attributes. Use the showButtonPanel to display 
		/// this button.
		/// </summary>
		/// <param name="newValue">New closeText setting</param>
		public void SetCloseText(string newValue) {
			this.SetCloseText(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// The text to display for the close link. This attribute is one of 
		/// the regionalisation attributes. Use the showButtonPanel to display 
		/// this button.
		/// </summary>
		/// <param name="newValue">New closeText setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetCloseText(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("closeText", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "constraintInput" setting.
		/// </summary>
		public void GetConstrainInput() {
			this.RenderGetOptionCall("constrainInput");
		}

		/// <summary>
		/// When true entry in the input field is constrained to those characters 
		/// allowed by the current dateFormat.
		/// </summary>
		/// <param name="newValue">New constraintInput setting</param>
		public void SetConstrainInput(bool newValue) {
			this.RenderSetOptionCall("constrainInput", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "currentText" setting.
		/// </summary>
		public void GetCurrentText() {
			this.RenderGetOptionCall("currentText");
		}

		/// <summary>
		/// The text to display for the current day link. This attribute is 
		/// one of the regionalisation attributes. Use the showButtonPanel to 
		/// display this button.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New currentText setting</param>
		public void SetCurrentTextJS(string newValue) {
			this.RenderSetOptionCall("currentText", newValue);
		}

		/// <summary>
		/// The text to display for the current day link. This attribute is 
		/// one of the regionalisation attributes. Use the showButtonPanel to 
		/// display this button.
		/// </summary>
		/// <param name="newValue">New currentText setting</param>
		public void SetCurrentText(string newValue) {
			this.SetCurrentText(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// The text to display for the current day link. This attribute is 
		/// one of the regionalisation attributes. Use the showButtonPanel to 
		/// display this button.
		/// </summary>
		/// <param name="newValue">New currentText setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetCurrentText(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("currentText", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "dateFormat" setting.
		/// </summary>
		public void GetDateFormat() {
			this.RenderGetOptionCall("dateFormat");
		}

		/// <summary>
		/// The format for parsed and displayed dates. This attribute is one of the 
		/// regionalisation attributes. For a full list of the possible formats 
		/// see the formatDate function.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New dateFormat setting</param>
		public void SetDateFormatJS(string newValue) {
			this.RenderSetOptionCall("dateFormat", newValue);
		}

		/// <summary>
		/// The format for parsed and displayed dates. This attribute is one of the 
		/// regionalisation attributes. For a full list of the possible formats 
		/// see the formatDate function.
		/// </summary>
		/// <param name="newValue">New dateFormat setting</param>
		public void SetDateFormat(string newValue) {
			this.SetDateFormat(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// The format for parsed and displayed dates. This attribute is one of the 
		/// regionalisation attributes. For a full list of the possible formats 
		/// see the formatDate function.
		/// </summary>
		/// <param name="newValue">New dateFormat setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetDateFormat(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("dateFormat", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "dayNames" setting.
		/// </summary>
		public void GetDayNames() {
			this.RenderGetOptionCall("dayNames");
		}

		/// <summary>
		/// The list of long day names, starting from Sunday, for use as requested 
		/// via the dateFormat setting. They also appear as popup hints when hovering over 
		/// the corresponding column headings. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New dayNames setting</param>
		public void SetDayNames(params string[] newValues) {
			this.SetDayNames(new List<string>(newValues));
		}

		/// <summary>
		/// The list of long day names, starting from Sunday, for use as requested 
		/// via the dateFormat setting. They also appear as popup hints when hovering over 
		/// the corresponding column headings. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New dayNames setting</param>
		public void SetDayNames(List<string> newValues) {
			this.RenderSetOptionCall("dayNames", newValues.JsArray(false/*singleQuotes*/));
		}
		
		/// <summary>
		/// Returns [in JavaScript] the current "dayNamesMin" setting.
		/// </summary>
		public void GetDayNamesMin() {
			this.RenderGetOptionCall("dayNamesMin");
		}

		/// <summary>
		/// The list of minimised day names, starting from Sunday, 
		/// for use as column headers within the datepicker. This 
		/// attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New dayNamesMin setting</param>
		public void SetDayNamesMin(params string[] newValues) {
			this.SetDayNamesMin(new List<string>(newValues));
		}

		/// <summary>
		/// The list of minimised day names, starting from Sunday, 
		/// for use as column headers within the datepicker. This 
		/// attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New dayNamesMin setting</param>
		public void SetDayNamesMin(List<string> newValues) {
			this.RenderSetOptionCall("dayNamesMin", newValues.JsArray(false/*singleQuotes*/));
		}

		/// <summary>
		/// Returns [in JavaScript] the current "dayNamesShort" setting.
		/// </summary>
		public void GetDayNamesShort() {
			this.RenderGetOptionCall("dayNamesShort");
		}

		/// <summary>
		/// The list of abbreviated day names, starting from Sunday, 
		/// for use as requested via the dateFormat setting. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New dayNamesShort setting</param>
		public void SetDayNamesShort(params string[] newValues) {
			this.SetDayNamesShort(new List<string>(newValues));
		}

		/// <summary>
		/// The list of abbreviated day names, starting from Sunday, 
		/// for use as requested via the dateFormat setting. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New dayNamesShort setting</param>
		public void SetDayNamesShort(List<string> newValues) {
			this.RenderSetOptionCall("dayNamesShort", newValues.JsArray(false/*singleQuotes*/));
		}

	
		/// <summary>
		/// Returns [in JavaScript] the current "defaultDate" setting.
		/// </summary>
		public void GetDefaultDate() {
			this.RenderGetOptionCall("defaultDate");
		}

		/// <summary>
		/// Set the date to highlight on first opening if the field is blank. 
		/// Specify either an actual date via a Date object or as a string in 
		/// the current dateFormat, or a number of days from today (e.g. +7) 
		/// or a string of values and periods ('y' for years, 'm' for months, 
		/// 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New defaultDate setting</param>
		public void SetDefaultDateJS(string newValue) {
			this.RenderSetOptionCall("defaultDate", newValue );
		}

		/// <summary>
		/// Set the date to highlight on first opening if the field is blank. 
		/// Specify either an actual date via a Date object or as a string in 
		/// the current dateFormat, or a number of days from today (e.g. +7) 
		/// or a string of values and periods ('y' for years, 'm' for months, 
		/// 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
		/// </summary>
		/// <param name="newValue">New defaultDate setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetDefaultDate(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("defaultDate", newValue, inDoubleQuotes );
		}

		/// <summary>
		/// Set the date to highlight on first opening if the field is blank. 
		/// Specify either an actual date via a Date object or as a string in 
		/// the current dateFormat, or a number of days from today (e.g. +7) 
		/// or a string of values and periods ('y' for years, 'm' for months, 
		/// 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
		/// </summary>
		/// <param name="newValue">New defaultDate setting</param>
		public void SetDefaultDate(string newValue) {
			this.SetDefaultDate(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Set the date to highlight on first opening if the field is blank. 
		/// Specify either an actual date via a Date object or as a string in 
		/// the current dateFormat, or a number of days from today (e.g. +7) 
		/// or a string of values and periods ('y' for years, 'm' for months, 
		/// 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
		/// </summary>
		/// <param name="newValue">New defaultDate setting</param>
		public void SetDefaultDate(int newValue) {
			this.RenderSetOptionCall("defaultDate", newValue.ToString() );
		}

		/// <summary>
		/// Set the date to highlight on first opening if the field is blank. 
		/// Specify either an actual date via a Date object or as a string in 
		/// the current dateFormat, or a number of days from today (e.g. +7) 
		/// or a string of values and periods ('y' for years, 'm' for months, 
		/// 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
		/// </summary>
		/// <param name="newValue">New defaultDate setting</param>
		public void SetDefaultDate(DateTime newValue) {
			this.RenderSetOptionCall("defaultDate", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "duration" setting.
		/// </summary>
		public void GetDuration() {
			this.RenderGetOptionCall("duration");
		}

		/// <summary>
		/// Control the speed at which the datepicker appears, 
		/// Duration in milliseconds
		/// </summary>
		/// <param name="newValue">Duration in milliseconds</param>
		public void SetDuration(int newValue) {
			this.RenderSetOptionCall("duration", newValue.ToString() );
		}

		/// <summary>
		/// Control the speed at which the datepicker appears, using one of the inbuilt
		/// constants of "slow", "normal" or "fast"
		/// </summary>
		/// <param name="newValue">Duration in milliseconds</param>
		public void SetDuration(string newValue) {
			this.RenderSetOptionCall("duration", newValue.InDoubleQuotes() );
		}

		/// <summary>
		/// Control the speed at which the datepicker appears, 
		/// </summary>
		/// <param name="speed">One of the three predefined speeds ("slow", "normal", "fast").</param>
		public void SetDuration(Core.Speed.eSpeed speed) {
			string speedStr = Core.Speed.SpeedToString(speed);
			this.RenderSetOptionCall("duration", speedStr.InDoubleQuotes() );
		}

		/// <summary>
		/// Returns [in JavaScript] the current "firstDay" setting.
		/// </summary>
		public void GetFirstDay() {
			this.RenderGetOptionCall("firstDay");
		}

		/// <summary>
		/// Set the first day of the week: Sunday is 0, Monday is 1, ... 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValue">New firstDay setting</param>
		public void SetFirstDay(int newValue) {
			this.RenderSetOptionCall("firstDay", newValue.ToString() );
		}
		
		/// <summary>
		/// Returns [in JavaScript] the current "gotoCurrent" setting.
		/// </summary>
		public void GetGotoCurrent() {
			this.RenderGetOptionCall("gotoCurrent");
		}

		/// <summary>
		/// When true the current day link moves to the currently 
		/// selected date instead of today.
		/// </summary>
		/// <param name="newValue">New gotoCurrent setting</param>
		public void SetGotoCurrent(bool newValue) {
			this.RenderSetOptionCall("gotoCurrent", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "hideIfNoPrevNext" setting.
		/// </summary>
		public void GetHideIfNoPrevNext() {
			this.RenderGetOptionCall("hideIfNoPrevNext");
		}

		/// <summary>
		/// Normally the previous and next links are disabled when not applicable 
		/// (see minDate/maxDate). You can hide them altogether by setting this 
		/// attribute to true.
		/// </summary>
		/// <param name="newValue">New hideIfNoPrevNext setting</param>
		public void SetHideIfNoPrevNext(bool newValue) {
			this.RenderSetOptionCall("hideIfNoPrevNext", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "isRTL" setting.
		/// </summary>
		public void GetIsRTL() {
			this.RenderGetOptionCall("isRTL");
		}

		/// <summary>
		/// True if the current language is drawn from right to left. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValue">New isRTL setting</param>
		public void SetIsRTL(bool newValue) {
			this.RenderSetOptionCall("isRTL", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "maxDate" setting.
		/// </summary>
		public void GetMaxDate() {
			this.RenderGetOptionCall("maxDate");
		}

		/// <summary>
		/// Set a maximum selectable date as a string of values and periods 
		/// ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, 
		/// e.g. '+1m +1w'), or null for no limit.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New maxDate setting</param>
		public void SetMaxDateJS(string newValue) {
			this.RenderSetOptionCall("maxDate", newValue);
		}

		/// <summary>
		/// Set a maximum selectable date as a string of values and periods 
		/// ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, 
		/// e.g. '+1m +1w'), or null for no limit.
		/// </summary>
		/// <param name="newValue">New maxDate setting</param>
		public void SetMaxDate(string newValue) {
			if (this.AddQuotesToDate(newValue))
				newValue = newValue.InDoubleQuotes();
			this.RenderSetOptionCall("maxDate", newValue);
		}

		/// <summary>
		/// Set a maximum selectable date as a number of days from 
		/// today (e.g. +7)
		/// </summary>
		/// <param name="newValue">New maxDate setting</param>
		public void SetMaxDate(int newValue) {
			this.RenderSetOptionCall("maxDate", newValue.ToString());
		}

		/// <summary>
		/// Set a maximum selectable date via a Date object.
		/// </summary>
		/// <param name="newValue">New maxDate setting</param>
		public void SetMaxDate(DateTime newValue) {
			this.RenderSetOptionCall("maxDate", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "minDate" setting.
		/// </summary>
		public void GetMinDate() {
			this.RenderGetOptionCall("minDate");
		}

		/// <summary>
		/// Set a minimum selectable date via a string of values 
		/// and periods ('y' for years, 'm' for months, 'w' for weeks, 
		/// 'd' for days, e.g. '-1y -1m'), or null for no limit.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New minDate setting</param>
		public void SetMinDateJS(string newValue) {
			this.RenderSetOptionCall("minDate", newValue);
		}

		/// <summary>
		/// Set a minimum selectable date via a string of values 
		/// and periods ('y' for years, 'm' for months, 'w' for weeks, 
		/// 'd' for days, e.g. '-1y -1m'), or null for no limit.
		/// </summary>
		/// <param name="newValue">New minDate setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetMinDate(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("minDate", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Set a minimum selectable date via a string of values 
		/// and periods ('y' for years, 'm' for months, 'w' for weeks, 
		/// 'd' for days, e.g. '-1y -1m'), or null for no limit.
		/// </summary>
		/// <param name="newValue">New minDate setting</param>
		public void SetMinDate(string newValue) {
			if (this.AddQuotesToDate(newValue))
				newValue = newValue.InDoubleQuotes();
			this.RenderSetOptionCall("minDate", newValue);
		}

		/// <summary>
		/// Set a minimum selectable date via a Date object.
		/// </summary>
		/// <param name="newValue">New minDate setting</param>
		public void SetMinDate(DateTime newValue) {
			this.RenderSetOptionCall("minDate", newValue);
		}

		/// <summary>
		/// Set a minimum selectable date via number of days from today 
		/// (e.g. +7).
		/// </summary>
		/// <param name="newValue">New minDate setting</param>
		public void SetMinDate(int newValue) {
			this.RenderSetOptionCall("minDate", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "monthNames" setting.
		/// </summary>
		public void GetMonthNames() {
			this.RenderGetOptionCall("monthNames");
		}

		/// <summary>
		/// The list of full month names, for use as requested via the dateFormat setting.
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New monthNames setting</param>
		public void SetMonthNames(List<string> newValues) {
			this.RenderSetOptionCall("monthNames", newValues.JsArray(false/*singleQuotes*/));
		}

		/// <summary>
		/// The list of full month names, for use as requested via the dateFormat setting.
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New monthNames setting</param>
		public void SetMonthNames(params string[] newValues) {
			this.SetMonthNames(new List<string>(newValues));
		}

		/// <summary>
		/// Returns [in JavaScript] the current "monthNamesShort" setting.
		/// </summary>
		public void GetMonthNamesShort() {
			this.RenderGetOptionCall("monthNamesShort");
		}

		/// <summary>
		/// The list of abbreviated month names, as used in the month header on 
		/// each datepicker and as requested via the dateFormat setting. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New monthNamesShort setting</param>
		public void SetMonthNamesShort(params string[] newValues) {
			this.SetMonthNamesShort(new List<string>(newValues));
		}

		/// <summary>
		/// The list of abbreviated month names, as used in the month header on 
		/// each datepicker and as requested via the dateFormat setting. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValues">New monthNamesShort setting</param>
		public void SetMonthNamesShort(List<string> newValues) {
			this.RenderSetOptionCall("monthNamesShort", newValues.JsArray(false/*singleQuotes*/));
		}

		/// <summary>
		/// Returns [in JavaScript] the current "navigationAsDateFormat" setting.
		/// </summary>
		public void GetNavigationAsDateFormat() {
			this.RenderGetOptionCall("navigationAsDateFormat");
		}

		/// <summary>
		/// When true the formatDate function is applied to the prevText, nextText, 
		/// and currentText values before display, allowing them to display the 
		/// target month names for example
		/// </summary>
		/// <param name="newValue">New navigationAsDateFormat setting</param>
		public void SetNavigationAsDateFormat(bool newValue) {
			this.RenderSetOptionCall("navigationAsDateFormat", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "nextText" setting.
		/// </summary>
		public void GetNextText() {
			this.RenderGetOptionCall("nextText");
		}

		/// <summary>
		/// The text to display for the next month link. This attribute is one of the 
		/// regionalisation attributes. With the standard ThemeRoller styling, 
		/// this value is replaced by an icon.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New nextText setting</param>
		public void SetNextTextJS(string newValue) {
			this.RenderSetOptionCall("nextText", newValue);
		}

		/// <summary>
		/// The text to display for the next month link. This attribute is one of the 
		/// regionalisation attributes. With the standard ThemeRoller styling, 
		/// this value is replaced by an icon.
		/// </summary>
		/// <param name="newValue">New nextText setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetNextText(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("nextText", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The text to display for the next month link. This attribute is one of the 
		/// regionalisation attributes. With the standard ThemeRoller styling, 
		/// this value is replaced by an icon.
		/// </summary>
		/// <param name="newValue">New nextText setting</param>
		public void SetNextText(string newValue) {
			this.SetNextText(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "numberOfMonths" setting.
		/// </summary>
		public void GetNumberOfMonths() {
			this.RenderGetOptionCall("numberOfMonths");
		}

		/// <summary>
		/// Set how many months to show at once. 
		/// or can be a two-element array to define the number of rows and columns to display
		/// </summary>
		/// <param name="newValue">New numberOfMonths setting</param>
		public void SetNumberOfMonths(int newValue) {
			this.RenderSetOptionCall("numberOfMonths", newValue.ToString());
		}

		/// <summary>
		/// Set how many months to show at once. 
		/// </summary>
		/// <param name="numRows">Number of rows</param>
		/// <param name="numCols">Number of columns</param>
		public void SetNumberOfMonths(int numRows, int numCols) {
			List<int> values = new List<int>() { numRows, numCols };
			this.RenderSetOptionCall("numberOfMonths", values.JsArray());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "prevText" setting.
		/// </summary>
		public void GetPrevText() {
			this.RenderGetOptionCall("prevText");
		}

		/// <summary>
		/// The text to display for the previous month link. This attribute 
		/// is one of the regionalisation attributes. With the standard 
		/// ThemeRoller styling, this value is replaced by an icon.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New prevText setting</param>
		public void SetPrevTextJS(string newValue) {
			this.RenderSetOptionCall("prevText", newValue);
		}

		/// <summary>
		/// The text to display for the previous month link. This attribute 
		/// is one of the regionalisation attributes. With the standard 
		/// ThemeRoller styling, this value is replaced by an icon.
		/// </summary>
		/// <param name="newValue">New prevText setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetPrevText(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("prevText", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The text to display for the previous month link. This attribute 
		/// is one of the regionalisation attributes. With the standard 
		/// ThemeRoller styling, this value is replaced by an icon.
		/// </summary>
		/// <param name="newValue">New prevText setting</param>
		public void SetPrevText(string newValue) {
			this.SetPrevText(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "selectOtherMonths" setting.
		/// </summary>
		public void GetSelectOtherMonths() {
			this.RenderGetOptionCall("selectOtherMonths");
		}

		/// <summary>
		/// When true days in other months shown before or after the current month 
		/// are selectable. This only applies if showOtherMonths is also true
		/// </summary>
		/// <param name="newValue">New selectOtherMonths setting</param>
		public void SetSelectOtherMonths(bool newValue) {
			this.RenderSetOptionCall("selectOtherMonths", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "shortYearCutoff" setting.
		/// </summary>
		public void GetShortYearCutoff() {
			this.RenderGetOptionCall("shortYearCutoff");
		}

		/// <summary>
		/// Set the cutoff year for determining the century for a date (used in 
		/// conjunction with dateFormat 'y'). If a numeric value (0-99) is provided then 
		/// this value is used directly. 
		/// If a string value is provided then it is converted to a number and 
		/// added to the current year. Once the cutoff year is calculated, any dates 
		/// entered with a year value less than or equal to it are considered to be in 
		/// the current century, while those greater than it are deemed to be in the previous century.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New shortYearCutoff setting</param>
		public void SetShortYearCutoffJS(string newValue) {
			this.RenderSetOptionCall("shortYearCutoff", newValue);
		}

		/// <summary>
		/// Set the cutoff year for determining the century for a date (used in 
		/// conjunction with dateFormat 'y'). If a numeric value (0-99) is provided then 
		/// this value is used directly. 
		/// If a string value is provided then it is converted to a number and 
		/// added to the current year. Once the cutoff year is calculated, any dates 
		/// entered with a year value less than or equal to it are considered to be in 
		/// the current century, while those greater than it are deemed to be in the previous century.
		/// </summary>
		/// <param name="newValue">New shortYearCutoff setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetShortYearCutoff(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("shortYearCutoff", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Set the cutoff year for determining the century for a date (used in 
		/// conjunction with dateFormat 'y'). If a numeric value (0-99) is provided then 
		/// this value is used directly. 
		/// If a string value is provided then it is converted to a number and 
		/// added to the current year. Once the cutoff year is calculated, any dates 
		/// entered with a year value less than or equal to it are considered to be in 
		/// the current century, while those greater than it are deemed to be in the previous century.
		/// </summary>
		/// <param name="newValue">New shortYearCutoff setting</param>
		public void SetShortYearCutoff(string newValue) {
			this.SetShortYearCutoff(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Set the cutoff year for determining the century for a date (used in 
		/// conjunction with dateFormat 'y'). If a numeric value (0-99) is provided then 
		/// this value is used directly. 
		/// If a string value is provided then it is converted to a number and 
		/// added to the current year. Once the cutoff year is calculated, any dates 
		/// entered with a year value less than or equal to it are considered to be in 
		/// the current century, while those greater than it are deemed to be in the previous century.
		/// </summary>
		/// <param name="newValue">New shortYearCutoff setting</param>
		public void SetShortYearCutoff(int newValue) {
			this.RenderSetOptionCall("shortYearCutoff", newValue.ToString() );
		}

		/// <summary>
		/// Returns [in JavaScript] the current "showAnim" setting.
		/// </summary>
		public void GetShowAnim() {
			this.RenderGetOptionCall("showAnim");
		}

		/// <summary>
		/// Set the name of the animation used to show/hide the datepicker. Use 'show' 
		/// (the default), 'slideDown', 'fadeIn', any of the show/hide jQuery UI effects, 
		/// or '' for no animation
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New showAnim setting</param>
		public void SetShowAnimJS(string newValue) {
			this.RenderSetOptionCall("showAnim", newValue);
		}

		/// <summary>
		/// Set the name of the animation used to show/hide the datepicker. Use 'show' 
		/// (the default), 'slideDown', 'fadeIn', any of the show/hide jQuery UI effects, 
		/// or '' for no animation
		/// </summary>
		/// <param name="newValue">New showAnim setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetShowAnim(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("showAnim", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Set the name of the animation used to show/hide the datepicker. Use 'show' 
		/// (the default), 'slideDown', 'fadeIn', any of the show/hide jQuery UI effects, 
		/// or '' for no animation
		/// </summary>
		/// <param name="newValue">New showAnim setting</param>
		public void SetShowAnim(string newValue) {
			this.SetShowAnim(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Set the name of the animation used to show/hide the datepicker. Use 'show' 
		/// (the default), 'slideDown', 'fadeIn', any of the show/hide jQuery UI effects, 
		/// or '' for no animation
		/// </summary>
		/// <param name="animation">New showAnim setting</param>
		public void SetShowAnim(Core.Animation.eAnimation animation) {
			this.SetShowAnim(Core.Animation.AnimationToString(animation));
		}

		/// <summary>
		/// Returns [in JavaScript] the current "showButtonPanel" setting.
		/// </summary>
		public void GetShowButtonPanel() {
			this.RenderGetOptionCall("showButtonPanel");
		}

		/// <summary>
		/// Whether to show the button panel.
		/// </summary>
		/// <param name="newValue">New showButtonPanel setting</param>
		public void SetShowButtonPanel(bool newValue) {
			this.RenderSetOptionCall("showButtonPanel", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "showCurrentAtPos" setting.
		/// </summary>
		public void GetShowCurrentAtPos() {
			this.RenderGetOptionCall("showCurrentAtPos");
		}

		/// <summary>
		/// Specify where in a multi-month display the current month shows, 
		/// starting from 0 at the top/left
		/// </summary>
		/// <param name="newValue">New showCurrentAtPos setting</param>
		public void SetShowCurrentAtPos(int newValue) {
			this.RenderSetOptionCall("showCurrentAtPos", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "showMonthAfterYear" setting.
		/// </summary>
		public void GetShowMonthAfterYear() {
			this.RenderGetOptionCall("showMonthAfterYear");
		}

		/// <summary>
		/// Whether to show the month after the year in the header. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValue">New showMonthAfterYear setting</param>
		public void SetShowMonthAfterYear(bool newValue) {
			this.RenderSetOptionCall("showMonthAfterYear", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "showOn" setting.
		/// </summary>
		public void GetShowOn() {
			this.RenderGetOptionCall("showOn");
		}

		/// <summary>
		/// Have the datepicker appear automatically when the field receives focus 
		/// </summary>
		public void SetShowOnFocus() {
			this.RenderSetOptionCall("showOn", "focus".InDoubleQuotes());
		}

		/// <summary>
		/// Have the datepicker appear automatically when a button is 
		/// clicked.
		/// </summary>
		public void SetShowOnButton() {
			this.RenderSetOptionCall("showOn", "button".InDoubleQuotes());
		}

		/// <summary>
		/// Have the datepicker appear automatically when the field 
		/// receives focus or when a button is clicked ('button').
		/// </summary>
		public void SetShowOnFocusOrButton() {
			this.RenderSetOptionCall("showOn", "both".InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "showOtherMonths" setting.
		/// </summary>
		public void GetShowOtherMonths() {
			this.RenderGetOptionCall("showOtherMonths");
		}

		/// <summary>
		/// Display dates in other months (non-selectable) at the start or 
		/// end of the current month. To make these days selectable use selectOtherMonths.
		/// </summary>
		/// <param name="newValue">New showOtherMonths setting</param>
		public void SetShowOtherMonths(bool newValue) {
			this.RenderSetOptionCall("showOtherMonths", newValue);
		}

		/// <summary>
		/// If using one of the jQuery UI effects for showAnim, you can provide additional settings 
		/// for that animation via this option.
		/// </summary>
		public void GetShowOptions() {
			this.RenderGetOptionCall("showOptions");
		}

		/// <summary>
		/// If using one of the jQuery UI effects for showAnim, you can provide additional settings 
		/// for that animation via this option.
		/// </summary>
		/// <param name="newValue">New showOptions setting</param>
		public void SetShowOptions(string newValue) {
			this.RenderSetOptionCall("showOptions", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "showWeek" setting.
		/// </summary>
		public void GetShowWeek() {
			this.RenderGetOptionCall("showWeek");
		}

		/// <summary>
		/// When true a column is added to show the week of the year. The calculateWeek option 
		/// determines how the week of the year is calculated. 
		/// You may also want to change the firstDay option.
		/// </summary>
		/// <param name="newValue">New showWeek setting</param>
		public void SetShowWeek(bool newValue) {
			this.RenderSetOptionCall("showWeek", newValue);
		}
		
		/// <summary>
		/// Returns [in JavaScript] the current "stepMonths" setting.
		/// </summary>
		public void GetStepMonths() {
			this.RenderGetOptionCall("stepMonths");
		}

		/// <summary>
		/// Set how many months to move when clicking the Previous/Next links
		/// </summary>
		/// <param name="newValue">New stepMonths setting</param>
		public void SetStepMonths(int newValue) {
			this.RenderSetOptionCall("stepMonths", newValue.ToString());
		}


		/// <summary>
		/// Returns [in JavaScript] the current "weekHeader" setting.
		/// </summary>
		public void GetWeekHeader() {
			this.RenderGetOptionCall("weekHeader");
		}

		/// <summary>
		/// The text to display for the week of the year column heading. 
		/// This attribute is one of the regionalisation attributes. Use showWeek to display this column.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New weekHeader setting</param>
		public void SetWeekHeaderJS(string newValue) {
			this.RenderSetOptionCall("weekHeader", newValue);
		}

		/// <summary>
		/// The text to display for the week of the year column heading. 
		/// This attribute is one of the regionalisation attributes. Use showWeek to display this column.
		/// </summary>
		/// <param name="newValue">New weekHeader setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetWeekHeader(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("weekHeader", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The text to display for the week of the year column heading. 
		/// This attribute is one of the regionalisation attributes. Use showWeek to display this column.
		/// </summary>
		/// <param name="newValue">New weekHeader setting</param>
		public void SetWeekHeader(string newValue) {
			this.SetWeekHeader(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "yearRange" setting.
		/// </summary>
		public void GetYearRange() {
			this.RenderGetOptionCall("yearRange");
		}

		/// <summary>
		/// Control the range of years displayed in the year drop-down: 
		/// Either :
		/// Relative to today's year (-nn:+nn), 
		/// Relative to the currently selected year (c-nn:c+nn), 
		/// Absolute (nnnn:nnnn), 
		/// Or combinations of these formats (nnnn:-nn). 
		/// Note that this option only affects what appears in the drop-down, to restrict which 
		/// dates may be selected use the minDate and/or maxDate options.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New yearRange setting</param>
		public void SetYearRangeJS(string newValue) {
			this.RenderSetOptionCall("yearRange", newValue);
		}

		/// <summary>
		/// Control the range of years displayed in the year drop-down: 
		/// Either :
		/// Relative to today's year (-nn:+nn), 
		/// Relative to the currently selected year (c-nn:c+nn), 
		/// Absolute (nnnn:nnnn), 
		/// Or combinations of these formats (nnnn:-nn). 
		/// Note that this option only affects what appears in the drop-down, to restrict which 
		/// dates may be selected use the minDate and/or maxDate options.
		/// </summary>
		/// <param name="newValue">New yearRange setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetYearRange(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("yearRange", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Control the range of years displayed in the year drop-down: 
		/// Either :
		/// Relative to today's year (-nn:+nn), 
		/// Relative to the currently selected year (c-nn:c+nn), 
		/// Absolute (nnnn:nnnn), 
		/// Or combinations of these formats (nnnn:-nn). 
		/// Note that this option only affects what appears in the drop-down, to restrict which 
		/// dates may be selected use the minDate and/or maxDate options.
		/// </summary>
		/// <param name="newValue">New yearRange setting</param>
		public void SetYearRange(string newValue) {
			this.SetYearRange(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Control the range of years displayed in the year drop-down: 
		/// Either :
		/// Relative to today's year (-nn:+nn), 
		/// Relative to the currently selected year (c-nn:c+nn), 
		/// Absolute (nnnn:nnnn), 
		/// Or combinations of these formats (nnnn:-nn). 
		/// Note that this option only affects what appears in the drop-down, to restrict which 
		/// dates may be selected use the minDate and/or maxDate options.
		/// </summary>
		/// <param name="lowerRange">Lower range for year dropdown</param>
		/// <param name="upperRange">Upper range for year dropdown</param>
		public void SetYearRange(string lowerRange, string upperRange) {
			string newValue = string.Format("{0}:{1}", lowerRange, upperRange);
			this.RenderSetOptionCall("yearRange", newValue.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "yearSuffix" setting.
		/// </summary>
		public void GetYearSuffix() {
			this.RenderGetOptionCall("yearSuffix");
		}

		/// <summary>
		/// Additional text to display after the year in the month headers. 
		/// This attribute is one of the regionalisation attributes.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New yearSuffix setting</param>
		public void SetYearSuffixJS(string newValue) {
			this.RenderSetOptionCall("yearSuffix", newValue);
		}

		/// <summary>
		/// Additional text to display after the year in the month headers. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValue">New yearSuffix setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetYearSuffix(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("yearSuffix", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Additional text to display after the year in the month headers. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <param name="newValue">New yearSuffix setting</param>
		public void SetYearSuffix(string newValue) {
			this.SetYearSuffix(newValue, true/*doubleQuotes*/);
		}

	}

}
