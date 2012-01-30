using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Microsoft.VisualBasic;

namespace Fluqi.Widget.jDatePicker
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI DatePicker.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables (true) or enables (false) the control. Can be set when initialising 
		/// (first creating) the control.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-disabled for details</remarks>
		public Options SetDisabled(bool disabled) {
			this.Disabled = disabled;
			return this;
		}

		/// <summary>
		/// The jQuery selector for another field that is to be updated with the selected date from 
		/// the datepicker. Use the altFormat setting to change the format of the date within this 
		/// field. Leave as blank for no alternate field.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-altfield for details</remarks>
		public Options SetAltField(string altField) {
			this.AltField = altField;
			return this;
		}

		/// <summary>
		/// The dateFormat to be used for the altField option. This allows one date format to 
		/// be shown to the user for selection purposes, while a different format is actually 
		/// sent behind the scenes. For a full list of the possible formats see the formatDate function
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-altformat for more details</remarks>
		public Options SetAltFormat(string altFormat) {
			this.AltFormat = altFormat;
			return this;
		}
			
		/// <summary>
		/// The dateFormat to be used for the altField option. This allows one date format to 
		/// be shown to the user for selection purposes, while a different format is actually 
		/// sent behind the scenes. For a full list of the possible formats see the formatDate function
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-appendtext for more details</remarks>
		public Options SetAppendText(string appendText) {
			this.AppendText = appendText;
			return this;
		}

		/// <summary>
		/// Set to true to automatically resize the input field to accommodate dates in the 
		/// current dateFormat.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-autosize for details</remarks>
		public Options SetAutoSize(bool autoSize) {
			this.AutoSize = autoSize;
			return this;
		}

		/// <summary>
		/// The URL for the popup button image. If set, buttonText becomes the alt value and is not directly displayed.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-buttonimage for details</remarks>
		public Options SetButtonImage(string buttonImage) {
			this.ButtonImage = buttonImage;
			return this;
		}

		/// <summary>
		/// Set to true to place an image after the field to use as the trigger without it appearing on a button.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-buttonimageonly for details</remarks>
		public Options SetButtonImageOnly(bool buttonImageOnly) {
			this.ButtonImageOnly = buttonImageOnly;
			return this;
		}

		/// <summary>
		/// The text to display on the trigger button. Use in conjunction with showOn equal to 'button' or 'both'.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-buttontext for details</remarks>
		public Options SetButtonText(string buttonText) {
			this.ButtonText = buttonText;
			return this;
		}

		/// <summary>
		/// A function to calculate the week of the year for a given date. The default implementation uses the ISO 8601 
		/// definition: weeks start on a Monday; the first week of the year contains the first Thursday of the year.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-calculateweek for details</remarks>
		public Options SetCalculateWeek(string calculateWeek) {
			this.CalculateWeek = calculateWeek;
			return this;
		}

		/// <summary>
		/// Allows you to change the month by selecting from a drop-down list. You can enable this feature by setting the 
		/// attribute to true.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-changemonth for details</remarks>
		public Options SetChangeMonth(bool changeMonth) {
			this.ChangeMonth = changeMonth;
			return this;
		}

		/// <summary>
		/// Allows you to change the year by selecting from a drop-down list. You can enable this feature by setting 
		/// the attribute to true. Use the yearRange option to control which years are made available for selection.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-changeyear for details</remarks>
		public Options SetChangeYear(bool changeYear) {
			this.ChangeYear = changeYear;
			return this;
		}

		/// <summary>
		/// The text to display for the close link. This attribute is one of the regionalisation attributes. Use the 
		/// showButtonPanel to display this button.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-closetext for details</remarks>
		public Options SetCloseText(string closeText) {
			this.CloseText = closeText;
			return this;
		}

		/// <summary>
		/// When true entry in the input field is constrained to those characters allowed by the current dateFormat.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-constrainInput for details</remarks>
		public Options SetConstrainInput(bool constrainInput) {
			this.ConstrainInput = constrainInput;
			return this;
		}

		/// <summary>
		/// The text to display for the current day link. This attribute is one of the regionalisation attributes. Use 
		/// the showButtonPanel to display this button.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-currentText for details</remarks>
		public Options SetCurrentText(string currentText) {
			this.CurrentText = currentText;
			return this;
		}

		/// <summary>
		/// The format for parsed and displayed dates. This attribute is one of the regionalisation attributes. For a full 
		/// list of the possible formats see the formatDate function.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-dateFormat for details</remarks>
		public Options SetDateFormat(string dateFormat) {
			this.DateFormat = dateFormat;
			return this;
		}

		/// <summary>
		/// The list of long day names, starting from Sunday, for use as requested via the dateFormat setting. 
		/// They also appear as popup hints when hovering over the corresponding column headings. This attribute is 
		/// one of the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-dayNames for details</remarks>
		public Options SetDayNames(List<string> dayNames) {
			this.DayNamesList = dayNames;
			return this;
		}

		/// <summary>
		/// The list of long day names, starting from Sunday, for use as requested via the dateFormat setting. 
		/// They also appear as popup hints when hovering over the corresponding column headings. This attribute is 
		/// one of the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-dayNames for details</remarks>
		public Options SetDayNames(string dayNames) {
			this.DayNames = dayNames;
			return this;
		}

		/// <summary>
		/// The list of minimised day names, starting from Sunday, for use as column headers within the datepicker. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-dayNamesMin for details</remarks>
		public Options SetDayNamesMin(List<string> dayNamesMin) {
			this.DayNamesMinList = dayNamesMin;
			return this;
		}

		/// <summary>
		/// The list of minimised day names, starting from Sunday, for use as column headers within the datepicker. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-dayNamesMin for details</remarks>
		public Options SetDayNamesMin(string dayNamesMin) {
			this.DayNamesMin = dayNamesMin;
			return this;
		}

		/// <summary>
		/// The list of abbreviated day names, starting from Sunday, for use as requested via the dateFormat setting. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-dayNamesShort for details</remarks>
		public Options SetDayNamesShort(List<string> dayNamesShort) {
			this.DayNamesShortList = dayNamesShort;
			return this;
		}

		/// <summary>
		/// The list of abbreviated day names, starting from Sunday, for use as requested via the dateFormat setting. 
		/// This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-dayNamesShort for details</remarks>
		public Options SetDayNamesShort(string dayNamesShort) {
			this.DayNamesShort = dayNamesShort;
			return this;
		}

		/// <summary>
		/// Set the date to highlight on first opening if the field is blank. Specify either an actual date via a 
		/// Date object or as a string in the current dateFormat, or a number of days from today (e.g. +7) or a string 
		/// of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-defaultDate for details</remarks>
		public Options SetDefaultDate(string defaultDate) {
			this.DefaultDateString = defaultDate;
			return this;
		}

		/// <summary>
		/// Set the date to highlight on first opening if the field is blank. Specify either an actual date via a 
		/// Date object or as a string in the current dateFormat, or a number of days from today (e.g. +7) or a string 
		/// of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-defaultDate for details</remarks>
		public Options SetDefaultDate(int relativeDays) {
			// note we don't attempt to convert this, we merely pass on what we've been told onto the DatePicker
			this.DefaultDateString = relativeDays.ToString();
			return this;
		}

		/// <summary>
		/// Set the date to highlight on first opening if the field is blank, using an actual date object.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-defaultDate for details</remarks>
		public Options SetDefaultDate(DateTime newDate) {
			this.DefaultDate = newDate;
			return this;
		}

		/// <summary>
		/// Control the speed at which the datepicker appears using 
		/// one of the three predefined speeds ("slow", "normal", "fast").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-duration for details</remarks>
		public Options SetDuration(string duration) {
			this.Duration = duration;
			return this;
		}


		/// <summary>
		/// Control the speed at which the datepicker appears using 
		/// one of the three predefined speeds ("slow", "normal", "fast").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-duration for details</remarks>
		public Options SetDuration(Core.Speed.eSpeed speed) {
			string speedStr = Core.Speed.SpeedToString(speed);
			this.Duration = speedStr;
			return this;
		}


		/// <summary>
		/// Control the speed at which the datepicker appears, it may be a time in milliseconds or a string representing 
		/// one of the three predefined speeds ("slow", "normal", "fast").
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-duration for details</remarks>
		public Options SetDuration(int durationInMilliseconds) {
			// note we just store the string, we'll pick up if it's a numeric value when we're rendering the script
			// conversion
			this.Duration = durationInMilliseconds.ToString();
			return this;
		}

		/// <summary>
		/// Set the first day of the week: Sunday is 0, Monday is 1, ... This attribute is one of the 
		/// regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-firstDay for details</remarks>
		public Options SetFirstDay(int firstDay) {
			this.FirstDay = firstDay;
			return this;
		}

		/// <summary>
		/// When true the current day link moves to the currently selected date instead of today.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-gotoCurrent for details</remarks>
		public Options SetGotoCurrent(bool gotoCurrent) {
			this.GotoCurrent = gotoCurrent;
			return this;
		}

		/// <summary>
		/// Normally the previous and next links are disabled when not applicable (see minDate/maxDate). You 
		/// can hide them altogether by setting this attribute to true.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-hideIfNoPrevNext for details</remarks>
		public Options SetHideIfNoPrevNext(bool hideIfNoPrevNext) {
			this.HideIfNoPrevNext = hideIfNoPrevNext;
			return this;
		}

		/// <summary>
		/// True if the current language is drawn from right to left. This attribute is one of the 
		/// regionalisation attributes
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-isRTL for details</remarks>
		public Options SetIsRTL(bool isRTL) {
			this.IsRTL = isRTL;
			return this;
		}

		/// <summary>
		/// Set a minimum selectable date via a Date object.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-minDate  for details</remarks>
		public Options SetMinDate(DateTime minDate) {
			this.MinDate = minDate;
			return this;
		}

		/// <summary>
		/// Set a minimum selectable date via a string in the current dateFormat, 
		/// or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 
		/// 'm' for months, 'w' for weeks, 'd' for days, e.g. '-1y -1m'), or null for no limit.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-minDate  for details</remarks>
		public Options SetMinDate(string minDate) {
			this.MinDateString = minDate;
			return this;
		}

		/// <summary>
		/// Set a minimum selectable date via a string in the current dateFormat, 
		/// or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 
		/// 'm' for months, 'w' for weeks, 'd' for days, e.g. '-1y -1m'), or null for no limit.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-minDate  for details</remarks>
		public Options SetMinDate(int relativeDays) {
			// note we just store the string, we'll pick up if it's a numeric value when we're rendering the script
			// conversion
			this.MinDateString = relativeDays.ToString();
			return this;
		}

		/// <summary>
		/// Set a maximum selectable date via a Date object.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-maxDate for details</remarks>
		public Options SetMaxDate(DateTime maxDate) {
			this.MaxDate = maxDate;
			return this;
		}

		/// <summary>
		/// Set a maximum selectable date via a string in the current dateFormat, 
		/// or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 
		/// 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +1w'), or null for no limit.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-maxDate for details</remarks>
		public Options SetMaxDate(string maxDate) {
			this.MaxDateString = maxDate;
			return this;
		}

		/// <summary>
		/// Set a maximum selectable date via a string in the current dateFormat, 
		/// or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 
		/// 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +1w'), or null for no limit.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-maxDate for details</remarks>
		public Options SetMaxDate(int relativeDays) {
			// note we just store the string, we'll pick up if it's a numeric value when we're rendering the script
			// conversion
			this.MaxDateString = relativeDays.ToString();
			return this;
		}

		/// <summary>
		/// The list of full month names, for use as requested via the dateFormat setting. This attribute is one of 
		/// the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-monthNames for details</remarks>
		public Options SetMonthNames(List<string> monthNames) {
			this.MonthNamesList = monthNames;
			return this;
		}

		/// <summary>
		/// The list of full month names, for use as requested via the dateFormat setting. This attribute is one of 
		/// the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-monthNames for details</remarks>
		public Options SetMonthNames(string monthNames) {
			this.MonthNames = monthNames;
			return this;
		}

		/// <summary>
		/// The list of abbreviated month names, as used in the month header on each datepicker and as requested via 
		/// the dateFormat setting. This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-monthNamesShort for details</remarks>
		public Options SetMonthNamesShort(List<string> monthNamesShort) {
			this.MonthNamesShortList = monthNamesShort;
			return this;
		}

		/// <summary>
		/// The list of abbreviated month names, as used in the month header on each datepicker and as requested via 
		/// the dateFormat setting. This attribute is one of the regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-monthNamesShort for details</remarks>
		public Options SetMonthNamesShort(string monthNamesShort) {
			this.MonthNamesShort = monthNamesShort;
			return this;
		}

		/// <summary>
		/// When true the formatDate function is applied to the prevText, nextText, and currentText values before 
		/// display, allowing them to display the target month names for example.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-navigationAsDateFormat  for details</remarks>
		public Options SetNavigationAsDateFormat(bool navigationAsDateFormat) {
			this.NavigationAsDateFormat = navigationAsDateFormat;
			return this;
		}

		/// <summary>
		/// The text to display for the next month link. This attribute is one of the regionalisation attributes. 
		/// With the standard ThemeRoller styling, this value is replaced by an icon.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-nextText for details</remarks>
		public Options SetNextText(string nextText) {
			this.NextText = nextText;
			return this;
		}

		/// <summary>
		/// Set how many months to show at once. The value can be a straight integer, or can be a two-element array 
		/// to define the number of rows and columns to display.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-numberOfMonths for details</remarks>
		public Options SetNumberOfMonths(int numberOfMonths) {
			this.NumberOfMonths = numberOfMonths.ToString();
			return this;
		}


		/// <summary>
		/// Set how many months to show at once. The value can be a straight integer, or can be a two-element array 
		/// to define the number of rows and columns to display.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-numberOfMonths for details</remarks>
		public Options SetNumberOfMonths(int rows, int columns) {
			// bit more difficult this version, have to pick up that it isn't Numeric and therefore it's an array when we render out
			this.NumberOfMonths = string.Format("[{0}, {1}]", rows, columns);
			return this;
		}

		/// <summary>
		/// The text to display for the previous month link. This attribute is one of the regionalisation attributes. 
		/// With the standard ThemeRoller styling, this value is replaced by an icon.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-prevText  for details</remarks>
		public Options SetPrevText(string prevText) {
			this.PrevText = prevText;
			return this;
		}

		/// <summary>
		/// When true days in other months shown before or after the current month are selectable. 
		/// This only applies if showOtherMonths is also true.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-selectOtherMonths for details</remarks>
		public Options SetSelectOtherMonths(bool selectOtherMonths) {
			this.SelectOtherMonths = selectOtherMonths;
			return this;
		}

		/// <summary>
		/// Set the cutoff year for determining the century for a date (used in conjunction with dateFormat 'y'). 
		/// If a numeric value (0-99) is provided then this value is used directly. If a string value is provided 
		/// then it is converted to a number and added to the current year. Once the cutoff year is calculated, 
		/// any dates entered with a year value less than or equal to it are considered to be in the current century, 
		/// while those greater than it are deemed to be in the previous century.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-shortYearCutOff for details</remarks>
		public Options SetShortYearCutoff(string shortYearCutoff) {
			this.ShortYearCutoff = shortYearCutoff;
			return this;
		}

		/// <summary>
		/// Set the cutoff year for determining the century for a date (used in conjunction with dateFormat 'y'). 
		/// If a numeric value (0-99) is provided then this value is used directly. If a string value is provided 
		/// then it is converted to a number and added to the current year. Once the cutoff year is calculated, 
		/// any dates entered with a year value less than or equal to it are considered to be in the current century, 
		/// while those greater than it are deemed to be in the previous century.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-shortYearCutOff for details</remarks>
		public Options SetShortYearCutoff(int shortYearCutOff) {
			this.ShortYearCutoff = shortYearCutOff.ToString();
			return this;
		}

		/// <summary>
		/// Set the name of the animation used to show/hide the datepicker. Use 'show' (the default), 
		/// 'slideDown', 'fadeIn', any of the show/hide jQuery UI effects, or '' for no animation.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-showAnim for details</remarks>
		public Options SetShowAnim(string showAnim) {
			this.ShowAnim = showAnim;
			return this;
		}

		/// <summary>
		/// Set the name of the animation used to show/hide the datepicker. Use 'show' (the default), 
		/// 'slideDown', 'fadeIn', any of the show/hide jQuery UI effects, or '' for no animation.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-showAnim for details</remarks>
		public Options SetShowAnim(Core.Animation.eAnimation showAnimation) {
			string animation = Core.Animation.AnimationToString(showAnimation);
			return this.SetShowAnim(animation);
		}

		/// <summary>
		/// If using one of the jQuery UI effects for showAnim, you can provide additional 
		/// settings for that animation via this option.
		/// <param name="showOptions">
		/// showOptions is expected to be a JSON type object, including
		/// the curly braces.</param>
		/// </summary>
		/// <remarks>
		/// See http://jqueryui.com/demos/datepicker/#option-showOptions for details
		/// Due to the numerous permutations that can be applied, only string support is provided
		/// which will be passed to the DatePicker "as is".
		/// </remarks>
		public Options SetShowOptions(string showOptions) {
			// Note we're just being stupid here, Options object can be pretty much
			// whatever the caller wants, so just let it pass-through .. they'll have to add their
			// own brackets
			this.ShowOptions = showOptions;

			return this;
		}

		/// <summary>
		/// Whether to show the button panel
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-showButtonPanel for details</remarks>
		public Options SetShowButtonPanel(bool showButtonPanel) {
			this.ShowButtonPanel = showButtonPanel;
			return this;
		}

		/// <summary>
		/// Specify where in a multi-month display the current month shows, starting from 0 at the top/left
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-showCurrentAtPos for details</remarks>
		public Options SetShowCurrentAtPos(int showCurrentAtPos) {
			this.ShowCurrentAtPos = showCurrentAtPos;
			return this;
		}

		/// <summary>
		/// Whether to show the month after the year in the header. This attribute is one of the regionalisation 
		/// attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-showMonthAfterYear for details</remarks>
		public Options SetShowMonthAfterYear(bool showMonthAfterYear) {
			this.ShowMonthAfterYear = showMonthAfterYear;
			return this;
		}

		/// <summary>
		/// Have the datepicker appear automatically when the field receives focus ('focus'), appear only when 
		/// a button is clicked ('button'), or appear when either event takes place ('both').
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-showOn for details</remarks>
		public Options SetShowOn(string showOn) {
			this.ShowOn = showOn;
			return this;
		}

		/// <summary>
		/// Display dates in other months (non-selectable) at the start or end of the current month. 
		/// To make these days selectable use selectOtherMonths.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-showOtherMonths for details</remarks>
		public Options SetShowOtherMonths(bool showOtherMonths) {
			this.ShowOtherMonths = showOtherMonths;
			return this;
		}

		/// <summary>
		/// When true a column is added to show the week of the year. The calculateWeek option determines how 
		/// the week of the year is calculated. You may also want to change the firstDay option.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-showWeek for details</remarks>
		public Options SetShowWeek(bool showWeek) {
			this.ShowWeek = showWeek;
			return this;
		}

		/// <summary>
		/// Set how many months to move when clicking the Previous/Next links
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-stepMonths for details</remarks>
		public Options SetStepMonths(int stepMonths) {
			this.StepMonths = stepMonths;
			return this;
		}

		/// <summary>
		/// The text to display for the week of the year column heading. This attribute is one of the regionalisation 
		/// attributes. Use showWeek to display this column.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-weekHeader for details</remarks>
		public Options SetWeekHeader(string weekHeader) {
			this.WeekHeader = weekHeader;
			return this;
		}

		/// <summary>
		/// Control the range of years displayed in the year drop-down: either relative to today's year (-nn:+nn), 
		/// relative to the currently selected year (c-nn:c+nn), absolute (nnnn:nnnn), or combinations of these 
		/// formats (nnnn:-nn). Note that this option only affects what appears in the drop-down, to restrict which 
		/// dates may be selected use the minDate and/or maxDate options.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-yearRange for details</remarks>
		public Options SetYearRange(string yearRange) {
			this.YearRange = yearRange;
			return this;
		}

		/// <summary>
		/// Additional text to display after the year in the month headers. This attribute is one of the 
		/// regionalisation attributes.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/datepicker/#option-yearSuffix for details</remarks>
		public Options SetYearSuffix(string yearSuffix) {
			this.YearSuffix = yearSuffix;
			return this;
		}

		/// <summary>
		/// Shows the calendar inline on the page (attaches the datePicker to a DIV rather than an INPUT)
		/// </summary>
		/// <param name="showInline">
		/// If true datePicker is shown inline (inside a DIV)
		/// If false datePicker is shown against an INPUT
		/// </param>
		public Options SetShowInline(bool showInline) {
			this.ShowInline = showInline;
			return this;
		}

	} // Options

} // ns Fluqi.jAutoComplete
