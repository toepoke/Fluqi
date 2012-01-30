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
#pragma warning disable 1591
		public const string DEFAULT_BUTTON_TEXT = "...";
		public const string DEFAULT_CALCULATE_WEEK = "$.datepicker.iso8601Week";
		public const string DEFAULT_CLOSE_TEXT = "Done";
		public const string DEFAULT_CURRENT_TEXT = "Today";
		public const string DEFAULT_DATE_FORMAT = "mm/dd/yy";
		public const string DEFAULT_DURATION = "normal";
		public const int    DEFAULT_FIRST_DAY = 0;
		public const int    DEFAULT_NUMBER_OF_MONTHS = 1;
		public const string DEFAULT_NEXT_TEXT = "Next";
		public const string DEFAULT_PREV_TEXT = "Prev";
		public const string DEFAULT_SHORT_YEAR_CUTOFF = "+10";
		public const string DEFAULT_SHOW_ANIM = "show";
		public const int    DEFAULT_SHOW_CURRENT_AT_POS = 0;
		public const string DEFAULT_SHOW_ON = "focus";
		public const string DEFAULT_SHOW_OPTIONS = "{}";
		public const int    DEFAULT_STEP_MONTHS = 1;
		public const string DEFAULT_WEEK_HEADER = "Wk";
		public const string DEFAULT_YEAR_RANGE = "c-10:c+10";
#pragma warning restore 1591

		/// <summary>
		/// Default names of the days of the week used by jQuery UI date picker.
		/// </summary>
		public static readonly List<string> DEFAULT_DAY_NAMES = new List<string>() {
			"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
		};

		/// <summary>
		/// Default names of the days of the week (min version, which is the first two characters) used by jQuery UI date picker.
		/// </summary>
		public static readonly List<string> DEFAULT_DAY_NAMES_MIN = new List<string>() {
			"Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"
		};

		/// <summary>
		/// Default names of the days of the week (short version, which is the first three characters) used by jQuery UI date picker.
		/// </summary>
		public static readonly List<string> DEFAULT_DAY_NAMES_SHORT = new List<string>() {
			"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"
		};

		/// <summary>
		/// Default names of the months of the year used by jQuery UI date picker.
		/// </summary>
		public static readonly List<string> DEFAULT_MONTH_NAMES = new List<string>() {
			"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
		};

		/// <summary>
		/// Default names of the months of the year (short version, which is the first three characters) used by jQuery UI date picker.
		/// </summary>
		public static readonly List<string> DEFAULT_MONTH_NAMES_SHORT = new List<string>() {
			"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
		};


		/// <summary>
		/// Holds a reference to the <see cref="DatePicker"/> object these options are for
		/// </summary>
		public DatePicker DatePicker { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="DatePicker"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="DatePicker"/> object to return chaining to the Tabs collection</returns>
		public DatePicker Finish() {
			return this.DatePicker;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(GetDatePickerScriptOption(false/*asChild*/));
		}


		/// <summary>
		/// Gets a script option defining the DatePicker options.
		/// </summary>
		/// <returns>Script option for the DatePicker object</returns>
		protected internal Core.ScriptOption GetDatePickerScriptOption() {
			return GetDatePickerScriptOption(true/*asChild*/);
		}


		/// <summary>
		/// Gets a script option defining the DatePicker options.
		/// </summary>
		/// <param name="asChild">Flags that this option should be added a child</param>
		/// <returns>Script option for the DatePicker object</returns>
		protected internal Core.ScriptOption GetDatePickerScriptOption(bool asChild) {
			Core.ScriptOption parentOpts = new Core.ScriptOption() {
				Key = "datePicker",
				IsChild = asChild
			};
			Core.ScriptOptions childOpts = parentOpts.ChildOptions;

			childOpts.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			childOpts.Add(!this.IsNullOrEmpty(this.AltField), "altField", this.AltField.InDoubleQuotes());
			childOpts.Add(!this.IsNullOrEmpty(this.AltFormat), "altFormat", this.AltFormat.InDoubleQuotes());
			childOpts.Add(!this.IsNullOrEmpty(this.AppendText), "appendText", this.AppendText.InDoubleQuotes());
			childOpts.Add(this.AutoSize, "autoSize", this.AutoSize.JsBool());
			childOpts.Add(!this.IsNullOrEmpty(this.ButtonImage), "buttonImage", this.ButtonImage.InDoubleQuotes());
			childOpts.Add(this.ButtonImageOnly, "buttonImageOnly", this.ButtonImageOnly.JsBool());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.ButtonText, DEFAULT_BUTTON_TEXT), "buttonText", this.ButtonText.InDoubleQuotes());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.CalculateWeek, DEFAULT_CALCULATE_WEEK), "calculateWeek", this.CalculateWeek);
			childOpts.Add(this.ChangeMonth, "changeMonth", this.ChangeMonth.JsBool());
			childOpts.Add(this.ChangeYear, "changeYear", this.ChangeYear.JsBool());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.CloseText, DEFAULT_CLOSE_TEXT), "closeText", this.CloseText.InDoubleQuotes());
			childOpts.Add(!this.ConstrainInput, "constrainInput", this.ConstrainInput.JsBool());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.CurrentText, DEFAULT_CURRENT_TEXT), "currentText", this.CurrentText.InDoubleQuotes());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.DateFormat, DEFAULT_DATE_FORMAT), "dateFormat", this.DateFormat.InDoubleQuotes());
			if (!this.IsNullOrEmpty(this.DayNames))
				childOpts.Add("dayNames", this.DayNames);
			else
				childOpts.Add(!this.IsNullEmptyOrDefault(this.DayNamesList, DEFAULT_DAY_NAMES), "dayNames", this.DayNamesList.JsArray(false/*singleQuotes*/));
			if (!this.IsNullOrEmpty(this.DayNamesMin))
				childOpts.Add("dayNamesMin", this.DayNamesMin);
			else
				childOpts.Add(!this.IsNullEmptyOrDefault(this.DayNamesMinList, DEFAULT_DAY_NAMES_MIN), "dayNamesMin", this.DayNamesMinList.JsArray(false/*singleQuotes*/));
			if (!this.IsNullOrEmpty(this.DayNamesShort))
				childOpts.Add("dayNamesShort", this.DayNamesShort);
			else
				childOpts.Add(!this.IsNullEmptyOrDefault(this.DayNamesShortList, DEFAULT_DAY_NAMES_SHORT), "dayNamesShort", this.DayNamesShortList.JsArray(false/*singleQuotes*/));
			
			if (this.DefaultDate.HasValue)
				childOpts.AddDate("defaultDate", this.DefaultDate);
			else
				childOpts.AddDate("defaultDate", this.DefaultDateString);

			if (IsNumeric(this.Duration))
				childOpts.Add(!this.IsNullEmptyOrDefault(this.Duration, DEFAULT_DURATION), "duration", this.Duration);
			else 
				childOpts.Add(!this.IsNullEmptyOrDefault(this.Duration, DEFAULT_DURATION), "duration", this.Duration.InDoubleQuotes());
			childOpts.Add(this.FirstDay != DEFAULT_FIRST_DAY, "firstDay", this.FirstDay.ToString());
			childOpts.Add(this.GotoCurrent, "gotoCurrent", this.GotoCurrent.JsBool());
			childOpts.Add(this.HideIfNoPrevNext, "hideIfNoPrevNext", this.HideIfNoPrevNext.JsBool());
			childOpts.Add(this.IsRTL, "isRTL", this.IsRTL.JsBool());
			if (this.MinDate.HasValue)
				childOpts.AddDate("minDate", this.MinDate);
			else 
				childOpts.AddDate("minDate", this.MinDateString);
			if (this.MaxDate.HasValue)
				childOpts.AddDate("maxDate", this.MaxDate);
			else 
				childOpts.AddDate("maxDate", this.MaxDateString);
			if (!this.IsNullOrEmpty(this.MonthNames))
				childOpts.Add("monthNames", this.MonthNames);
			else 
				childOpts.Add(!this.IsNullEmptyOrDefault(this.MonthNamesList, DEFAULT_MONTH_NAMES), "monthNames", this.MonthNamesList.JsArray(false/*singleQuotes*/));
			if (!this.IsNullOrEmpty(this.MonthNamesShort))
				childOpts.Add("monthNamesShort", this.MonthNamesShort);
			else 
				childOpts.Add(!this.IsNullEmptyOrDefault(this.MonthNamesShortList, DEFAULT_MONTH_NAMES_SHORT), "monthNamesShort", this.MonthNamesShortList.JsArray(false/*singleQuotes*/));
			childOpts.Add(this.NavigationAsDateFormat, "navigationAsDateFormat", this.NavigationAsDateFormat.JsBool());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.NextText, DEFAULT_NEXT_TEXT), "nextText", this.NextText.InDoubleQuotes());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.PrevText, DEFAULT_PREV_TEXT), "prevText", this.PrevText.InDoubleQuotes());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.NumberOfMonths, DEFAULT_NUMBER_OF_MONTHS.ToString()), "numberOfMonths", this.NumberOfMonths.ToString());
			childOpts.Add(this.SelectOtherMonths, "selectOtherMonths", this.SelectOtherMonths.JsBool());
			if (IsRelativeDateSpec(this.ShortYearCutoff))
				childOpts.Add(!this.IsNullEmptyOrDefault(this.ShortYearCutoff, DEFAULT_SHORT_YEAR_CUTOFF), "shortYearCutoff", this.ShortYearCutoff.InDoubleQuotes());
			else 
				childOpts.Add(!this.IsNullEmptyOrDefault(this.ShortYearCutoff, DEFAULT_SHORT_YEAR_CUTOFF), "shortYearCutoff", this.ShortYearCutoff);
			childOpts.Add(!this.IsNullEmptyOrDefault(this.ShowAnim, DEFAULT_SHOW_ANIM), "showAnim", this.ShowAnim.InDoubleQuotes());
			childOpts.Add(this.ShowButtonPanel, "showButtonPanel", this.ShowButtonPanel.JsBool());
			childOpts.Add(this.ShowCurrentAtPos != DEFAULT_SHOW_CURRENT_AT_POS, "showCurrentAtPos", this.ShowCurrentAtPos.ToString());
			childOpts.Add(this.ShowMonthAfterYear, "showMonthAfterYear", this.ShowMonthAfterYear.JsBool());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.ShowOn, DEFAULT_SHOW_ON), "showOn", this.ShowOn.InDoubleQuotes());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.ShowOptions, DEFAULT_SHOW_OPTIONS), "showOptions", this.ShowOptions);
			childOpts.Add(this.ShowOtherMonths, "showOtherMonths", this.ShowOtherMonths.JsBool());
			childOpts.Add(this.ShowWeek, "showWeek", this.ShowWeek.JsBool());
			childOpts.Add(this.StepMonths != DEFAULT_STEP_MONTHS, "stepMonths", this.StepMonths.ToString());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.WeekHeader, DEFAULT_WEEK_HEADER), "weekHeader", this.WeekHeader.InDoubleQuotes());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.YearRange, DEFAULT_YEAR_RANGE), "yearRange", this.YearRange.InDoubleQuotes());
			childOpts.Add(!this.IsNullOrEmpty(this.YearSuffix), "yearSuffix", this.YearSuffix.InDoubleQuotes());

			// Any of the above actually going to render?
			parentOpts.Condition = childOpts.Where(x=>x.Condition).Any();
			return parentOpts;
		}


		/// <summary>
		/// Initialises the day-names the DatePicker is set-up with initially
		/// </summary>
		protected void InitialiseDayNames() {
			string dayName = "";
			this.DayNamesList = new List<string>(); 
			this.DayNamesMinList = new List<string>();
			this.DayNamesShortList = new List<string>();

			for (int d=1; d <= 7; d++) {
				dayName = DateAndTime.WeekdayName(d, false, FirstDayOfWeek.Sunday);
				
				this.DayNamesList.Add(dayName);
				this.DayNamesMinList.Add(dayName.Substring(0, 2));
				this.DayNamesShortList.Add(dayName.Substring(0, 3));
			}

		}


		/// <summary>
		/// Initialises the month-names the DatePicker is set-up with initially
		/// </summary>
		protected void InitialiseMonthNames() {
			string monthName = "";
			this.MonthNamesList = new List<string>();
			this.MonthNamesShortList = new List<string>();

			for (int m=1; m <= 12; m++) {
				monthName = DateAndTime.MonthName(m, false);
				
				this.MonthNamesList.Add(monthName);
				this.MonthNamesShortList.Add(monthName.Substring(0, 3));
			}
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Disabled = false;
			this.AltField = "";
			this.AltFormat = "";
			this.AppendText = "";
			this.AutoSize = false;
			this.ButtonImage = "";
			this.ButtonImageOnly = false;
			this.ButtonText = DEFAULT_BUTTON_TEXT;
			this.CalculateWeek = DEFAULT_CALCULATE_WEEK;
			this.ChangeMonth = false;
			this.ChangeYear = false;
			this.CloseText = DEFAULT_CLOSE_TEXT;
			this.ConstrainInput = true;
			this.CurrentText = DEFAULT_CURRENT_TEXT;
			this.DateFormat = DEFAULT_DATE_FORMAT;
			this.DefaultDateString = "";
			this.DefaultDate = null;
			this.Duration = DEFAULT_DURATION;
			this.FirstDay = DEFAULT_FIRST_DAY;
			this.GotoCurrent = false;
			this.HideIfNoPrevNext = false;
			this.IsRTL = false;
			this.MinDateString = "";
			this.MaxDateString = "";
			this.NextText = DEFAULT_NEXT_TEXT;
			this.NumberOfMonths = DEFAULT_NUMBER_OF_MONTHS.ToString();
			this.PrevText = DEFAULT_PREV_TEXT;
			this.SelectOtherMonths = false;
			this.ShortYearCutoff = DEFAULT_SHORT_YEAR_CUTOFF;
			this.ShowAnim = DEFAULT_SHOW_ANIM;
			this.ShowButtonPanel = false;
			this.ShowCurrentAtPos = DEFAULT_SHOW_CURRENT_AT_POS;
			this.ShowMonthAfterYear = false;
			this.ShowOn = DEFAULT_SHOW_ON;
			this.ShowOptions = DEFAULT_SHOW_OPTIONS;
			this.ShowOtherMonths = false;
			this.ShowWeek = false;
			this.StepMonths = DEFAULT_STEP_MONTHS;
			this.WeekHeader = DEFAULT_WEEK_HEADER;
			this.YearRange = DEFAULT_YEAR_RANGE;
			this.YearSuffix = "";
			this.DayNamesList = DEFAULT_DAY_NAMES;
			this.DayNamesMinList = DEFAULT_DAY_NAMES_MIN;
			this.DayNamesShortList = DEFAULT_DAY_NAMES_SHORT;
			this.MonthNamesList = DEFAULT_MONTH_NAMES;
			this.MonthNamesShortList = DEFAULT_MONTH_NAMES_SHORT;
		}

	} // Options

} // ns Fluqi.jDatePicker
