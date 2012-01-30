using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Fluqi.Widget.jDatePicker;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;
using Fluqi.Helpers;
using System.IO;

namespace Fluqi.Models
{
	/// <summary>
	/// Takes all the Initial Settings defined on the view and configures the control accordingly.
	/// Also displays the JavaScript and C# required to make the jQuery UI control do what we want
	/// For instance on the DatePicker screen we can change the "ShowAnim" setting to "Explode"
	/// this class takes what the model tells us and would then configure the DatePicker (or whatever
	/// control we're looking at).
	/// </summary>
	/// <remarks>
	/// Note all the files in this project are for demo purposes and certainly aren't "best practice" by
	/// any stretch of the imagination.
	/// </remarks>
	public class DatePickerModel: BaseModel {

		public DatePickerModel() : base() {
			this.Reset();
		}
		
		public bool         Disabled                  { get; set; }
		public string       AltField                  { get; set; }
		public string       AltFormat                 { get; set; }
		public string       AppendText                { get; set; }
		public bool         AutoSize                  { get; set; }
		public string       ButtonImage               { get; set; }
		public bool         ButtonImageOnly           { get; set; }
		public string       ButtonText                { get; set; }
		public string       CalculateWeek             { get; set; }
		public bool         ChangeMonth               { get; set; }
		public bool         ChangeYear                { get; set; }
		public string       CloseText                 { get; set; }
		public bool         ConstrainInput            { get; set; }
		public string       CurrentText               { get; set; }
		public string       DateFormat                { get; set; }
		public bool         FakeDayNamesChange        { get; set; }
		public bool         FakeMonthNamesChange      { get; set; }
		public string       DefaultDate               { get; set; }
		public string       Duration	                { get; set; }
		public int          FirstDay                  { get; set; }
		public bool         GotoCurrent               { get; set; }
		public bool         HideIfNoPrevNext          { get; set; }
		public bool         IsRTL                     { get; set; }
		public string       MaxDate                   { get; set; }
		public string       MinDate                   { get; set; }
		public bool         NavigationAsDateFormat    { get; set; }
		public string       NextText                  { get; set; }
		public int          NumberOfMonths            { get; set; }
		public string       PrevText                  { get; set; }
		public bool         SelectOtherMonths         { get; set; }
		public string       ShortYearCutoff           { get; set; }
		public string       ShowAnim                  { get; set; }
		public bool         ShowButtonPanel           { get; set; }
		public int          ShowCurrentAtPos          { get; set; }
		public bool         ShowMonthAfterYear        { get; set; }
		public string       ShowOn                    { get; set; }
		public bool         ShowOtherMonths           { get; set; }
		public bool         ShowWeek                  { get; set; }
		public int          StepMonths                { get; set; }
		public string       WeekHeader                { get; set; }
		public string       YearRange                 { get; set; }
		public string       YearSuffix                { get; set; }
		public bool         ShowInline                { get; set; }

		public List<string> DayNames                  { get; set; }
		public List<string> DayNamesMin               { get; set; }
		public List<string> DayNamesShort	            { get; set; }
		public List<string> MonthNames                { get; set; }
		public List<string> MonthNamesShort           { get; set; }
	
		public void ConfigureDatePicker(DatePicker dt) {

			// make the input a bit wider than our default style
			dt.WithCss("wide");

			dt.Options
				.SetDisabled(this.Disabled)
				.SetAltField(this.AltField)
				.SetAltFormat(this.AltFormat)
				.SetAppendText(this.AppendText)
				.SetAutoSize(this.AutoSize)
				.SetButtonImage(this.ButtonImage)
				.SetButtonImageOnly(this.ButtonImageOnly)
				.SetButtonText(this.ButtonText)
				.SetCalculateWeek(this.CalculateWeek)
				.SetChangeMonth(this.ChangeMonth)
				.SetChangeYear(this.ChangeYear)
				.SetCloseText(this.CloseText)
				.SetConstrainInput(this.ConstrainInput)
				.SetCurrentText(this.CurrentText)
				.SetDateFormat(this.DateFormat)
				.SetDefaultDate(this.DefaultDate)
				.SetDuration(this.Duration)
				.SetFirstDay(this.FirstDay)
				.SetGotoCurrent(this.GotoCurrent)
				.SetHideIfNoPrevNext(this.HideIfNoPrevNext)
				.SetIsRTL(this.IsRTL)
				.SetMaxDate(this.MaxDate)
				.SetMinDate(this.MinDate)
				.SetNavigationAsDateFormat(this.NavigationAsDateFormat)
				.SetNextText(this.NextText)
				.SetNumberOfMonths(this.NumberOfMonths)
				.SetPrevText(this.PrevText)
				.SetSelectOtherMonths(this.SelectOtherMonths)
				.SetShortYearCutoff(this.ShortYearCutoff)
				.SetShowAnim(this.ShowAnim)
				.SetShowButtonPanel(this.ShowButtonPanel)
				.SetShowMonthAfterYear(this.ShowMonthAfterYear)
				.SetShowOn(this.ShowOn)
				.SetShowOtherMonths(this.ShowOtherMonths)
				.SetShowWeek(this.ShowWeek)
				.SetStepMonths(this.StepMonths)
				.SetWeekHeader(this.WeekHeader)
				.SetYearRange(this.YearRange)
				.SetYearSuffix(this.YearSuffix)
				.SetShowInline(this.ShowInline)
			.Finish();
				
			if (this.FakeDayNamesChange) {
				dt.Options
					.SetDayNames(this.DayNames)
					.SetDayNamesMin(this.DayNamesMin)
					.SetDayNamesShort(this.DayNamesShort)
				.Finish();
			}
			if (this.FakeMonthNamesChange) {
				dt.Options
					.SetMonthNames(this.MonthNames)
					.SetMonthNamesShort(this.MonthNamesShort)
				.Finish();
			}

			if (this.showEvents) {
				dt.Events
					.SetCreateEvent("return createEvent(event, ui);")
					.SetBeforeShowEvent("return beforeShowEvent(input, inst);")
					.SetBeforeShowDayEvent("return beforeShowDayEvent(date);")
					.SetOnChangeMonthYearEvent("return onChangeMonthYear(year, month, inst);")
					.SetOnCloseEvent("return onClose(dateText, inst);")
					.SetOnSelectEvent("return onSelect(dateText, inst);")
					.Finish()
				;
			}
			if (!this.prettyRender)
				dt.Rendering.Compress();
			if (this.renderCSS)
				dt.Rendering.ShowCSS();
		}

		public string JavaScriptCode(DatePicker dt) {
			return dt.GetStartUpScript();
		}

		public string CSharpCode(DatePicker dt) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsFormatLineIf("Html.CreateDatePicker(\"{0}\")", dt.ID);

			string optionsCode = OptionsCSharpCode();
			string showEventsCode = ShowEventsCSharpCode();
			string renderCode = base.RenderCSharpCode();
			bool showOptions = (optionsCode.Length > 0 || showEventsCode.Length > 0 || renderCode.Length > 0);

			if (showOptions) {
				sb.IncIndent();

				if (optionsCode.Length > 0) {
					sb.AppendTabsLineIf(".Options");
					sb.IncIndent();
					sb.Append(optionsCode);			
					sb.DecIndent();
					sb.AppendTabsLineIf(".Finish()");
				}	
				if (showEventsCode.Length > 0) {
					sb.AppendTabsLineIf(".Events");
					sb.IncIndent();
					sb.Append(showEventsCode);
					sb.DecIndent();
					sb.AppendTabsLineIf(".Finish()");
				}

				if (renderCode.Length > 0)
					sb.Append(renderCode);
				sb.DecIndent();
			}
			sb.AppendTabsLineIf(".Render();");
			sb.AppendTabsLineIf("%>");

			return sb.ToString();
		}

		protected string OptionsCSharpCode() {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			if (this.Disabled)
				sb.AppendTabsLineIf(".SetDisabled(true)");
			if (!string.IsNullOrEmpty(this.AltField))
				sb.AppendTabsFormatLineIf(".SetAltField(\"{0}\")", this.AltField);
			if (!string.IsNullOrEmpty(this.AltFormat))
				sb.AppendTabsFormatLineIf(".SetAltFormat(\"{0}\")", this.AltFormat);
			if (!string.IsNullOrEmpty(this.AppendText))
				sb.AppendTabsFormatLineIf(".SetAppendText(\"{0}\")", this.AppendText);
			if (this.AutoSize)
				sb.AppendTabsLineIf(".SetAutoSize(true)");
			if (!string.IsNullOrEmpty(this.ButtonImage))
				sb.AppendTabsFormatLineIf(".SetButtonImage(\"{0}\")", this.ButtonImage);
			if (this.ButtonImageOnly)
				sb.AppendTabsLineIf(".SetButtonImageOnly(true)");
			if (!Utils.IsNullEmptyOrDefault(this.ButtonText, Options.DEFAULT_BUTTON_TEXT))
				sb.AppendTabsFormatLineIf(".SetButtonText(\"{0}\")", this.ButtonText);
			if (!Utils.IsNullEmptyOrDefault(this.CalculateWeek, Options.DEFAULT_CALCULATE_WEEK) )
				sb.AppendTabsFormatLineIf(".SetCalculateWeek(\"{0}\")", this.CalculateWeek);
			if (this.ChangeMonth)
				sb.AppendTabsLineIf(".SetChangeMonth(true)");
			if (this.ChangeYear)
				sb.AppendTabsLineIf(".SetChangeYear(true)");
			if (!Utils.IsNullEmptyOrDefault(this.CloseText, Options.DEFAULT_CLOSE_TEXT))
				sb.AppendTabsFormatLineIf(".SetCloseText(\"{0}\")", this.CloseText);
			if (!this.ConstrainInput)
				sb.AppendTabsLineIf(".SetConstraintInput(false)");
			if (!Utils.IsNullEmptyOrDefault(this.CurrentText, Options.DEFAULT_CURRENT_TEXT))
				sb.AppendTabsFormatLineIf(".SetCurrentText(\"{0}\")", this.CurrentText);
			if (!Utils.IsNullEmptyOrDefault(this.DateFormat, Options.DEFAULT_DATE_FORMAT))
				sb.AppendTabsFormatLineIf(".SetDateFormat({0})", Utils.AddQuotesToJQueryDate(this.DateFormat));
			if (!Utils.IsNullEmptyOrDefault(this.Duration, Options.DEFAULT_DURATION))
				sb.AppendTabsFormatLineIf(".SetDuration(\"{0}\")", this.Duration);
			if (this.FirstDay != Options.DEFAULT_FIRST_DAY)
				sb.AppendTabsFormatLineIf(".SetFirstDay({0})", this.FirstDay);
			if (this.GotoCurrent)
				sb.AppendTabsLineIf(".SetGotoCurrent(true)");
			if (this.HideIfNoPrevNext)
				sb.AppendTabsLineIf(".SetHideIfNoPrevNext(true)");
			if (this.IsRTL)
				sb.AppendTabsLineIf(".SetIsRTL(true)");
			if (!string.IsNullOrEmpty(this.MinDate))
				sb.AppendTabsFormatLineIf(".SetMinDate({0})", Utils.AddQuotesToJQueryDate(this.MinDate));
			if (!string.IsNullOrEmpty(this.MaxDate))
				sb.AppendTabsFormatLineIf(".SetMaxDate({0})", Utils.AddQuotesToJQueryDate(this.MaxDate));

			if (this.NavigationAsDateFormat)
				sb.AppendTabsLineIf(".SetNavigationAsDateFormat(true)");
			if (!Utils.IsNullEmptyOrDefault(this.NextText, Options.DEFAULT_NEXT_TEXT))
				sb.AppendTabsFormatLineIf(".SetNextText(\"{0}\")", this.NextText);
			if (!Utils.IsNullEmptyOrDefault(this.PrevText, Options.DEFAULT_PREV_TEXT))
				sb.AppendTabsFormatLineIf(".SetPrevText(\"{0}\")", this.PrevText);
			if (this.NumberOfMonths != Options.DEFAULT_NUMBER_OF_MONTHS) {
				sb.AppendTabsFormatLineIf(".SetNumberOfMonths({0})", this.NumberOfMonths);
			}
			if (this.SelectOtherMonths)
				sb.AppendTabsLineIf(".SetSelectOtherMonths(true)");
			if (!Utils.IsNullEmptyOrDefault(this.ShortYearCutoff, Options.DEFAULT_SHORT_YEAR_CUTOFF))
				sb.AppendTabsFormatLineIf(".SetShortYearCutoff(\"{0}\")", this.ShortYearCutoff);
			if (!Utils.IsNullEmptyOrDefault(this.ShowAnim, Options.DEFAULT_SHOW_ANIM))
				sb.AppendTabsFormatLineIf(".SetShowAnim(\"{0}\")", this.ShowAnim);
			if (this.ShowButtonPanel)
				sb.AppendTabsLineIf(".SetShowButtonPanel(true)");
			if (this.ShowCurrentAtPos != Options.DEFAULT_SHOW_CURRENT_AT_POS)
				sb.AppendTabsFormatLineIf(".SetShowCurrentAtPos({0})", this.ShowCurrentAtPos);
			if (this.ShowMonthAfterYear)
				sb.AppendTabsFormatLine(".SetShowMonthAfterYear(true)");
			if (!Utils.IsNullEmptyOrDefault(this.ShowOn, Options.DEFAULT_SHOW_ON))
				sb.AppendTabsFormatLineIf(".SetShowOn(\"{0}\")", this.ShowOn);
			if (this.ShowOtherMonths)
				sb.AppendTabsFormatLineIf(".SetShowOtherMonths({0})", this.ShowOtherMonths);
			if (this.ShowWeek)
				sb.AppendTabsLineIf(".SetShowWeek(true)");
			if (this.StepMonths != Options.DEFAULT_STEP_MONTHS)
				sb.AppendTabsFormatLineIf(".SetStepMonths({0})", this.StepMonths);
			if (!Utils.IsNullEmptyOrDefault(this.WeekHeader, Options.DEFAULT_WEEK_HEADER))
				sb.AppendTabsFormatLineIf(".SetWeekHeader(\"{0}\")", this.WeekHeader);
			if (!Utils.IsNullEmptyOrDefault(this.YearRange, Options.DEFAULT_YEAR_RANGE))
				sb.AppendTabsFormatLineIf(".SetYearRange(\"{0}\")", this.YearRange);
			if (!string.IsNullOrEmpty(this.YearSuffix))
				sb.AppendTabsFormatLineIf(".SetYearSuffix(\"{0}\")", this.YearSuffix);

			if (this.FakeDayNamesChange) {
				if (!Utils.IsNullEmptyOrDefault(this.DayNames, Options.DEFAULT_DAY_NAMES))
					sb.AppendTabsFormatLineIf(".SetDayNames(\"{0}\")", this.DayNames.JsArray());
				if (!Utils.IsNullEmptyOrDefault(this.DayNamesMin, Options.DEFAULT_DAY_NAMES_MIN))
					sb.AppendTabsFormatLineIf(".SetDayNamesMin(\"{0}\")", this.DayNamesMin.JsArray());
				if (!Utils.IsNullEmptyOrDefault(this.DayNamesShort, Options.DEFAULT_DAY_NAMES_SHORT))
					sb.AppendTabsFormatLineIf(".SetDayNamesShort(\"{0}\")", this.DayNamesShort.JsArray());
			}
			if (this.FakeMonthNamesChange) {
				if (!Utils.IsNullEmptyOrDefault(this.MonthNames, Options.DEFAULT_MONTH_NAMES))
					sb.AppendTabsFormatLineIf(".SetMonthNames(\"{0}\")", this.MonthNames.JsArray());
				if (!Utils.IsNullEmptyOrDefault(this.MonthNamesShort, Options.DEFAULT_MONTH_NAMES_SHORT))
					sb.AppendTabsFormatLineIf(".SetMonthNamesShort(\"{0}\")", this.MonthNamesShort.JsArray());
			}
			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);
			
			sb.AppendTabsLineIf(".SetCreateEvent(\"return createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetBeforeShowEvent(\"return beforeShowEvent(input, inst);\")");
			sb.AppendTabsLineIf(".SetBeforeShowDayEvent(\"return beforeShowDayEvent(date);\")");
			sb.AppendTabsLineIf(".SetOnChangeMonthYearEvent(\"return onChangeMonthYear(year, month, inst);\")");
			sb.AppendTabsLineIf(".SetOnCloseEvent(\"return onClose(dateText, inst);\")");
			sb.AppendTabsLineIf(".SetOnSelectEvent(\"return onSelect(dateText, inst);\")");
	
			return sb.ToString();
		}
	
		public void Reset() {
			this.Disabled = false;
			this.AltField = "";
			this.AltFormat = "";
			this.AppendText = "";
			this.AutoSize = false;
			this.ButtonImage = "/Content/calendar_week.png";
			this.ButtonImageOnly = false;
			this.ButtonText = Options.DEFAULT_BUTTON_TEXT;
			this.CalculateWeek = Options.DEFAULT_CALCULATE_WEEK;
			this.ChangeMonth = false;
			this.ChangeYear = false;
			this.CloseText = Options.DEFAULT_CLOSE_TEXT;
			this.ConstrainInput = true;
			this.CurrentText = Options.DEFAULT_CURRENT_TEXT;
			this.DateFormat = Options.DEFAULT_DATE_FORMAT;
			this.DefaultDate = "";
			this.Duration = Options.DEFAULT_DURATION;
			this.FirstDay = Options.DEFAULT_FIRST_DAY;
			this.GotoCurrent = false;
			this.HideIfNoPrevNext = false;
			this.IsRTL = false;
			this.MinDate = "";
			this.MaxDate = "";
			this.NextText = Options.DEFAULT_NEXT_TEXT;
			this.NumberOfMonths = Options.DEFAULT_NUMBER_OF_MONTHS;
			this.PrevText = Options.DEFAULT_PREV_TEXT;
			this.SelectOtherMonths = false;
			this.ShortYearCutoff = Options.DEFAULT_SHORT_YEAR_CUTOFF;
			this.ShowAnim = Options.DEFAULT_SHOW_ANIM;
			this.ShowButtonPanel = false;
			this.ShowCurrentAtPos = Options.DEFAULT_SHOW_CURRENT_AT_POS;
			this.ShowMonthAfterYear = false;
			this.ShowOn = Options.DEFAULT_SHOW_ON;
			this.ShowOtherMonths = false;
			this.ShowWeek = false;
			this.StepMonths = Options.DEFAULT_STEP_MONTHS;
			this.WeekHeader = Options.DEFAULT_WEEK_HEADER;
			this.YearRange = Options.DEFAULT_YEAR_RANGE;
			this.YearSuffix = "";
			this.FakeDayNamesChange = false;
			this.FakeMonthNamesChange = false;
			this.ShowInline = false;			

			this.DayNames = new List<string>(Options.DEFAULT_DAY_NAMES);
			this.DayNamesShort = new List<string>(Options.DEFAULT_DAY_NAMES_SHORT);
			this.DayNamesMin = new List<string>(Options.DEFAULT_DAY_NAMES_MIN);

			this.MonthNames = new List<string>(Options.DEFAULT_MONTH_NAMES);
			this.MonthNamesShort = new List<string>(Options.DEFAULT_MONTH_NAMES_SHORT);
		}

	}	

}

