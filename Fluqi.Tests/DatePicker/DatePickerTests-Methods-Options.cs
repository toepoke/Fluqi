using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jDatePicker;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class DatePicker_Methods_Options_Tests
	{

		[TestMethod]
		public void Ensure_GetAltField_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetAltField();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"altField\")", html);
		}

		[TestMethod]
		public void Ensure_SetAltField_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetAltFieldJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"altField\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetAltField_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetAltField("#myAltField");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"altField\",\"#myAltField\")", html);
		}

		[TestMethod]
		public void Ensure_GetAltFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetAltFormat();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"altFormat\")", html);
		}

		[TestMethod]
		public void Ensure_SetAltFormat_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetAltFormatJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"altFormat\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetAltFormat_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetAltFormat("yy-mm-dd");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"altFormat\",\"yy-mm-dd\")", html);
		}

		[TestMethod]
		public void Ensure_GetAppendText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetAppendText();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"appendText\")", html);
		}

		[TestMethod]
		public void Ensure_SetAppendText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetAppendText("In UK Format");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"appendText\",\"In UK Format\")", html);
		}

		[TestMethod]
		public void Ensure_GetAutoSize_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetAutoSize();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"autoSize\")", html);
		}

		[TestMethod]
		public void Ensure_SetAutoSize_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetAutoSize(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"autoSize\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetButtonImage_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetButtonImage();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"buttonImage\")", html);
		}

		[TestMethod]
		public void Ensure_SetButtonImage_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetButtonImage("https://someurl.jpg");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"buttonImage\",\"https://someurl.jpg\")", html);
		}

		[TestMethod]
		public void Ensure_SetButtonImage_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetButtonImageJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"buttonImage\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_GetButtonImageOnly_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetButtonImageOnly();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"buttonImageOnly\")", html);
		}

		[TestMethod]
		public void Ensure_SetButtonImageOnly_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetButtonImageOnly(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"buttonImageOnly\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetButtonText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetButtonText();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"buttonText\")", html);
		}

		[TestMethod]
		public void Ensure_SetButtonText_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetButtonText("my button text");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"buttonText\",\"my button text\")", html);
		}

		[TestMethod]
		public void Ensure_SetButtonText_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetButtonTextJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"buttonText\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_GetCalculateWeek_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetCalculateWeek();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"calculateWeek\")", html);
		}

		[TestMethod]
		public void Ensure_SetCalculateWeek_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetCalculateWeek("myWeeklyCalcFunc");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"calculateWeek\",myWeeklyCalcFunc)", html);
		}

		[TestMethod]
		public void Ensure_GetChangeMonth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetChangeMonth();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"changeMonth\")", html);
		}

		[TestMethod]
		public void Ensure_SetChangeMonth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetChangeMonth(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"changeMonth\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetChangeYear_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetChangeYear();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"changeYear\")", html);
		}

		[TestMethod]
		public void Ensure_SetChangeYear_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetChangeYear(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"changeYear\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetCloseText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetCloseText();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"closeText\")", html);
		}

		[TestMethod]
		public void Ensure_SetCloseText_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetCloseText("close dlg");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"closeText\",\"close dlg\")", html);
		}

		[TestMethod]
		public void Ensure_SetCloseText_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetCloseTextJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"closeText\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_GetConstrainInput_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetConstrainInput();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"constrainInput\")", html);
		}

		[TestMethod]
		public void Ensure_SetConstrainInput_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetConstrainInput(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"constrainInput\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetCurrentText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetCurrentText();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"currentText\")", html);
		}

		[TestMethod]
		public void Ensure_SetCurrentText_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetCurrentText("now");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"currentText\",\"now\")", html);
		}

		[TestMethod]
		public void Ensure_SetCurrentText_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetCurrentTextJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"currentText\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_GetDateFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetDateFormat();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dateFormat\")", html);
		}

		[TestMethod]
		public void Ensure_SetDateFormat_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDateFormatJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dateFormat\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetDateFormat_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDateFormat("dd-mm-yy");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dateFormat\",\"dd-mm-yy\")", html);
		}

		[TestMethod]
		public void Ensure_GetDayNames_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetDayNames();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dayNames\")", html);
		}

		[TestMethod]
		public void Ensure_SetDayNames_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDayNames("mon", "tue", "wed", "thu", "fri", "sat", "sun");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dayNames\",[ 'mon', 'tue', 'wed', 'thu', 'fri', 'sat', 'sun' ])", html);
		}

		[TestMethod]
		public void Ensure_GetDayNamesMin_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetDayNamesMin();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dayNamesMin\")", html);
		}

		[TestMethod]
		public void Ensure_SetDayNamesMin_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDayNamesMin("mo", "tu", "wd", "th", "fr", "st", "sn");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dayNamesMin\",[ 'mo', 'tu', 'wd', 'th', 'fr', 'st', 'sn' ])", html);
		}

		[TestMethod]
		public void Ensure_GetDayNamesShort_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetDayNamesShort();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dayNamesShort\")", html);
		}

		[TestMethod]
		public void Ensure_SetDayNamesShort_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDayNamesShort("mo", "tu", "wd", "th", "fr", "st", "sn");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"dayNamesShort\",[ 'mo', 'tu', 'wd', 'th', 'fr', 'st', 'sn' ])", html);
		}

		[TestMethod]
		public void Ensure_GetDefaultDate_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetDefaultDate();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"defaultDate\")", html);
		}

		[TestMethod]
		public void Ensure_SetDefaultDate_By_Actual_Date_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDefaultDate(new DateTime(2000, 1, 1));

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"defaultDate\",$.datepicker.parseDate( \"yy-mm-dd\", \"2000-01-01\" ))", html);
		}

		[TestMethod]
		public void Ensure_SetDefaultDate_By_Relative_Positive_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDefaultDate(7);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"defaultDate\",7)", html);
		}

		[TestMethod]
		public void Ensure_SetDefaultDate_By_Relative_Negative_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDefaultDate(-7);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"defaultDate\",-7)", html);
		}

		[TestMethod]
		public void Ensure_SetDefaultDate_By_Relative_String_Number_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDefaultDate("+1m +7d");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"defaultDate\",\"+1m +7d\")", html);
		}

		[TestMethod]
		public void Ensure_SetDefaultDate_By_Relative_String_Number_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDefaultDateJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"defaultDate\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_GetDuration_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetDuration();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"duration\")", html);
		}

		[TestMethod]
		public void Ensure_SetDuration_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDuration(Core.Speed.eSpeed.Fast);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"duration\",\"fast\")", html);
		}

		[TestMethod]
		public void Ensure_SetDuration_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDuration("fast");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"duration\",\"fast\")", html);
		}

		[TestMethod]
		public void Ensure_SetDuration_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetDuration(99);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"duration\",99)", html);
		}

		[TestMethod]
		public void Ensure_GetFirstDay_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetFirstDay();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"firstDay\")", html);
		}

		[TestMethod]
		public void Ensure_SetFirstDay_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetFirstDay(3);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"firstDay\",3)", html);
		}

		[TestMethod]
		public void Ensure_GetGotoCurrent_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetGotoCurrent();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"gotoCurrent\")", html);
		}

		[TestMethod]
		public void Ensure_SetGotoCurrent_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetGotoCurrent(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"gotoCurrent\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetHideIfNoPrevNext_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetHideIfNoPrevNext();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"hideIfNoPrevNext\")", html);
		}

		[TestMethod]
		public void Ensure_SetHideIfNoPrevNext_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetHideIfNoPrevNext(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"hideIfNoPrevNext\",false)", html);
		}

		[TestMethod]
		public void Ensure_GetIsRTL_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetIsRTL();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"isRTL\")", html);
		}

		[TestMethod]
		public void Ensure_SetIsRTL_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetIsRTL(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"isRTL\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetMaxDate_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetMaxDate();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"maxDate\")", html);
		}

		[TestMethod]
		public void Ensure_SetMaxDate_By_Actual_Date_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMaxDate(new DateTime(2000, 1, 1));

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"maxDate\",$.datepicker.parseDate( \"yy-mm-dd\", \"2000-01-01\" ))", html);
		}

		[TestMethod]
		public void Ensure_SetMaxDate_By_Relative_Positive_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMaxDate(4);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"maxDate\",4)", html);
		}

		[TestMethod]
		public void Ensure_SetMaxDate_By_Relative_Negative_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMaxDate(-4);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"maxDate\",-4)", html);
		}

		[TestMethod]
		public void Ensure_SetMaxDate_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMaxDate("+1m +1w");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"maxDate\",\"+1m +1w\")", html);
		}

		[TestMethod]
		public void Ensure_GetMinDate_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetMinDate();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"minDate\")", html);
		}

		[TestMethod]
		public void Ensure_SetMinDate_By_Actual_Date_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMinDate(new DateTime(2000, 1, 1));

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"minDate\",$.datepicker.parseDate( \"yy-mm-dd\", \"2000-01-01\" ))", html);
		}

		[TestMethod]
		public void Ensure_SetMinDate_By_Relative_Positive_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMinDate(4);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"minDate\",4)", html);
		}

		[TestMethod]
		public void Ensure_SetMinDate_By_Relative_Negative_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMinDate(-4);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"minDate\",-4)", html);
		}

		[TestMethod]
		public void Ensure_SetMinDate_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMinDateJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"minDate\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetMinDate_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMinDate("+1m +1w");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"minDate\",\"+1m +1w\")", html);
		}

		[TestMethod]
		public void Ensure_GetMonthNames_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetMonthNames();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"monthNames\")", html);
		}

		[TestMethod]
		public void Ensure_SetMonthNames_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMonthNames("jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"monthNames\",[ 'jan', 'feb', 'mar', 'apr', 'may', 'jun', 'jul', 'aug', 'sep', 'oct', 'nov', 'dec' ])", html);
		}

		[TestMethod]
		public void Ensure_GetMonthNamesShort_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetMonthNamesShort();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"monthNamesShort\")", html);
		}

		[TestMethod]
		public void Ensure_SetMonthNamesShort_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetMonthNamesShort("ja", "fe", "ma", "ap", "ma", "ju", "ju", "au", "se", "oc", "no", "de");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"monthNamesShort\",[ 'ja', 'fe', 'ma', 'ap', 'ma', 'ju', 'ju', 'au', 'se', 'oc', 'no', 'de' ])", html);
		}

		[TestMethod]
		public void Ensure_GetIsNavigationAsDateFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetNavigationAsDateFormat();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"navigationAsDateFormat\")", html);
		}

		[TestMethod]
		public void Ensure_SetNavigationAsDateFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetNavigationAsDateFormat(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"navigationAsDateFormat\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetNextText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetNextText();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"nextText\")", html);
		}

		[TestMethod]
		public void Ensure_SetNextText_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetNextTextJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"nextText\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetNextText_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetNextText("NEXT");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"nextText\",\"NEXT\")", html);
		}

		[TestMethod]
		public void Ensure_GetNumberOfMonths_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetNumberOfMonths();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"numberOfMonths\")", html);
		}

		[TestMethod]
		public void Ensure_SetNumberOfMonths_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetNumberOfMonths(3);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"numberOfMonths\",3)", html);
		}

		[TestMethod]
		public void Ensure_SetNumberOfMonths_By_Rows_And_Cols_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetNumberOfMonths(1, 2);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"numberOfMonths\",[ 1, 2 ])", html);
		}

		[TestMethod]
		public void Ensure_GetPrevText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetPrevText();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"prevText\")", html);
		}

		[TestMethod]
		public void Ensure_SetPrevText_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetPrevTextJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"prevText\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetPrevText_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetPrevText("PREV");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"prevText\",\"PREV\")", html);
		}

		[TestMethod]
		public void Ensure_GetSelectOtherMonths_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetSelectOtherMonths();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"selectOtherMonths\")", html);
		}

		[TestMethod]
		public void Ensure_SetSelectOtherMonths_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetSelectOtherMonths(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"selectOtherMonths\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetShortyearCutoff_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShortYearCutoff();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"shortYearCutoff\")", html);
		}

		[TestMethod]
		public void Ensure_SetShortYearCutoff_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShortYearCutoff(3);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"shortYearCutoff\",3)", html);
		}

		[TestMethod]
		public void Ensure_SetShortYearCutoff_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShortYearCutoffJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"shortYearCutoff\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetShortYearCutoff_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShortYearCutoff("-10");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"shortYearCutoff\",\"-10\")", html);
		}

		[TestMethod]
		public void Ensure_GetShowAnim_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShowAnim();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showAnim\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowAnim_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowAnim(Core.Animation.eAnimation.Blind);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showAnim\",\"blind\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowAnim_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowAnim("blind");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showAnim\",\"blind\")", html);
		}

		[TestMethod]
		public void Ensure_GetShowButtonPanel_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShowButtonPanel();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showButtonPanel\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowButtonPanel_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowButtonPanel(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showButtonPanel\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetShowCurrentAtPos_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShowCurrentAtPos();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showCurrentAtPos\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowCurrentAtPos_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowCurrentAtPos(2);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showCurrentAtPos\",2)", html);
		}

		[TestMethod]
		public void Ensure_GetShowMonthAfterYear_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShowMonthAfterYear();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showMonthAfterYear\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowMonthAfterYear_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowMonthAfterYear(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showMonthAfterYear\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetShowOn_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShowOn();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showOn\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowOnFocus_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowOnFocus();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showOn\",\"focus\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowOnButton_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowOnButton();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showOn\",\"button\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowOnFocusOrButton_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowOnFocusOrButton();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showOn\",\"both\")", html);
		}

		[TestMethod]
		public void Ensure_GetShowOptions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShowOptions();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showOptions\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowOptions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowOptions("{direction: 'up'}");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showOptions\",{direction: 'up'})", html);
		}

		[TestMethod]
		public void Ensure_GetShowOtherMonths_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShowOtherMonths();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showOtherMonths\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowOtherMonths_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowOtherMonths(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showOtherMonths\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetShowWeek_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetShowWeek();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showWeek\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowWeek_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetShowWeek(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"showWeek\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetStepMonths_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetStepMonths();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"stepMonths\")", html);
		}

		[TestMethod]
		public void Ensure_SetStepMonths_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetStepMonths(2);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"stepMonths\",2)", html);
		}

		[TestMethod]
		public void Ensure_GetWeekHeader_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetWeekHeader();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"weekHeader\")", html);
		}

		[TestMethod]
		public void Ensure_SetWeekHeader_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetWeekHeaderJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"weekHeader\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetWeekHeader_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetWeekHeader("WEEK");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"weekHeader\",\"WEEK\")", html);
		}

		[TestMethod]
		public void Ensure_GetYearRange_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetYearRange();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"yearRange\")", html);
		}

		[TestMethod]
		public void Ensure_SetYearRange_By_Combined_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetYearRange("-99:+99");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"yearRange\",\"-99:+99\")", html);
		}

		[TestMethod]
		public void Ensure_SetYearRange_By_Lower_And_Upper_Boundaries_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetYearRange("-99", "+99");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"yearRange\",\"-99:+99\")", html);
		}

		[TestMethod]
		public void Ensure_GetYearSuffix_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.GetYearSuffix();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"yearSuffix\")", html);
		}

		[TestMethod]
		public void Ensure_SetYearSuffix_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDatePickerObject(resp);

		  ctl.Methods.SetYearSuffix("YEAR");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"option\",\"yearSuffix\",\"YEAR\")", html);
		}

	} // DatePicker_Methods_Options_Tests

} // ns
