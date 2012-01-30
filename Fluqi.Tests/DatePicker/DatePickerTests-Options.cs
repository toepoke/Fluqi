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
	public partial class DatePicker_Options_Tests
	{

		[TestMethod]
		public void Ensure_Multiple_Options_Are_Added_To_Script_Definition_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetAltField("#my-element")
					.SetDisabled(true)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({disabled: true,altField: \"#my-element\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_AltField_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetAltField("#my-element")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({altField: \"#my-element\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_AltFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac.Options
		    .SetAltFormat("DD, d MM, yy")
					.Finish()
				.Rendering
					.Compress()
		    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({altFormat: \"DD, d MM, yy\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_AppendText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
		    .SetAppendText("(dd-mm-yyyy)")
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({appendText: \"(dd-mm-yyyy)\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_AutoSize_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetAutoSize(true)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({autoSize: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ButtonImage_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetButtonImage("http://example.com/my-date-picker-image.png")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({buttonImage: \"http://example.com/my-date-picker-image.png\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ButtonImageOnly_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetButtonImageOnly(true)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({buttonImageOnly: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ButtonText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetButtonText("click here")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({buttonText: \"click here\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ButtonText_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetButtonText(Options.DEFAULT_BUTTON_TEXT)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_CalculateWeek_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetCalculateWeek("function myWeekCalc() { return 1; }")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({calculateWeek: function myWeekCalc() { return 1; }})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_CalculateWeek_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetCalculateWeek(Options.DEFAULT_CALCULATE_WEEK)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ChangeMonth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetChangeMonth(true)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({changeMonth: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ChangeYear_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetChangeYear(true)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({changeYear: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_CloseText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetCloseText("OK")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({closeText: \"OK\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_CloseText_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetCloseText(Options.DEFAULT_CLOSE_TEXT)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ConstrainInput_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetConstrainInput(false)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({constrainInput: false})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_CurrentText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetCurrentText("Now")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({currentText: \"Now\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_CurrentText_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetCurrentText(Options.DEFAULT_CURRENT_TEXT)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DateFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDateFormat("dd-mm-yyyy")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({dateFormat: \"dd-mm-yyyy\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DateFormat_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDateFormat(Options.DEFAULT_DATE_FORMAT)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DayNames_As_A_List_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			List<string> newNames = new List<string>() {
				"SUNDAY",
				"MONDAY",
				"TUESDAY",
				"WEDNESDAY",
				"THURSDAY",
				"FRIDAY",
				"SATURDAY"
			};

		  // only testing raw output
		  ac
				.Options
					.SetDayNames(newNames)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({dayNames: [ 'SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY' ]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DayNames_As_A_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			string newNames = "[ 'SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY' ]";

		  // only testing raw output
		  ac
				.Options
					.SetDayNames(newNames)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({dayNames: [ 'SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY' ]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DayNamesMin_As_A_List_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			List<string> newNames = new List<string>() {
				"SU",
				"MO",
				"TU",
				"WE",
				"TH",
				"FR",
				"SA"
			};

		  // only testing raw output
		  ac
				.Options
					.SetDayNames(newNames)
					.Finish()
				.Rendering
					.Compress()
		    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({dayNames: [ 'SU', 'MO', 'TU', 'WE', 'TH', 'FR', 'SA' ]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DayNamesMin_As_A_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			string newNames = "[ 'SU', 'MO', 'TU', 'WE', 'TH', 'FR', 'SA' ]";

		  // only testing raw output
		  ac
				.Options
					.SetDayNames(newNames)
					.Finish()
				.Rendering
					.Compress()
		    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({dayNames: [ 'SU', 'MO', 'TU', 'WE', 'TH', 'FR', 'SA' ]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DayNamesShort_As_A_List_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			List<string> newNames = new List<string>() {
				"SUN",
				"MON",
				"TUE",
				"WED",
				"THU",
				"FRI",
				"SAT"
			};

		  // only testing raw output
		  ac
				.Options
					.SetDayNames(newNames)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({dayNames: [ 'SUN', 'MON', 'TUE', 'WED', 'THU', 'FRI', 'SAT' ]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DayNamesShort_As_A_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			string newNames = "[ 'SUN', 'MON', 'TUE', 'WED', 'THU', 'FRI', 'SAT' ]";

		  // only testing raw output
		  ac
				.Options
					.SetDayNames(newNames)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({dayNames: [ 'SUN', 'MON', 'TUE', 'WED', 'THU', 'FRI', 'SAT' ]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DefaultDate_With_Date_Object_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDefaultDate(new DateTime(2000, 01, 01))
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({defaultDate: $.datepicker.parseDate( \"yy-mm-dd\", \"2000-01-01\" )})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DefaultDate_With_Date_In_String_And_Slash_Format_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDefaultDate("01/01/2000")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({defaultDate: \"01/01/2000\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DefaultDate_With_Date_In_String_And_Dash_Format_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
			    .SetDefaultDate("01-01-2000")
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({defaultDate: \"01-01-2000\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DefaultDate_With_Numeric_Negative_Offset_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDefaultDate(-3)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({defaultDate: -3})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DefaultDate_With_Numeric_Positive_Offset_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDefaultDate(+3)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({defaultDate: 3})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DefaultDate_With_Numeric_No_Sign_Offset_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDefaultDate(3)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({defaultDate: 3})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_DefaultDate_With_Relative_TimeSpan_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
				  .SetDefaultDate("+1y +1m")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({defaultDate: \"+1y +1m\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_Duration_With_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDuration("fast")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({duration: \"fast\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_Duration_With_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDuration(Core.Speed.eSpeed.Fast)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({duration: \"fast\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_Duration_With_String_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDuration(Options.DEFAULT_DURATION)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_Duration_With_Integer_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetDuration(2000)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({duration: 2000})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_FirstDay_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetFirstDay(1)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({firstDay: 1})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_FirstDay_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetFirstDay(Options.DEFAULT_FIRST_DAY)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_GotoCurrent_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetGotoCurrent(true)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({gotoCurrent: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_HideIfNoPrevNext_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetHideIfNoPrevNext(true)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({hideIfNoPrevNext: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_IsRTL_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetIsRTL(true)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({isRTL: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MinDate_With_DateTime_Object_Date_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetMinDate(new DateTime(2000, 01, 01))
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({minDate: $.datepicker.parseDate( \"yy-mm-dd\", \"2000-01-01\" )})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MinDate_With_Absolute_JavaScript_Date_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetMinDate("01/01/2000")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({minDate: \"01/01/2000\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MinDate_With_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetMinDate(7)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({minDate: 7})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MinDate_With_TimeSpan_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetMinDate("-1y -1m")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({minDate: \"-1y -1m\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MaxDate_With_DateTime_Object_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetMaxDate(new DateTime(2000, 01, 01))
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({maxDate: $.datepicker.parseDate( \"yy-mm-dd\", \"2000-01-01\" )})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MaxDate_With_Absolute_JavaScript_Date_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetMaxDate("01/01/2000")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({maxDate: \"01/01/2000\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MaxDate_With_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetMaxDate(7)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({maxDate: 7})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MaxDate_With_TimeSpan_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetMaxDate("+1y +1m")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({maxDate: \"+1y +1m\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MonthNames_As_A_List_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			List<string> newNames = new List<string>() {
				"JANUARY",
				"FEBRUARY",
				"MARCH",
				"APRIL",
				"MAY",
				"JUNE",
				"JULY",
				"AUGUST",
				"SEPTEMBER",
				"OCTOBER",
				"NOVEMBER",
				"DECEMBER"
			};

		  // only testing raw output
		  ac
				.Options
			    .SetMonthNames(newNames)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({monthNames: [ 'JANUARY', 'FEBRUARY', 'MARCH', 'APRIL', 'MAY', 'JUNE', 'JULY', 'AUGUST', 'SEPTEMBER', 'OCTOBER', 'NOVEMBER', 'DECEMBER' ]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_MonthNames_As_A_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			string newNames = "[ 'JANUARY', 'FEBRUARY', 'MARCH', 'APRIL', 'MAY', 'JUNE', 'JULY', 'AUGUST', 'SEPTEMBER', 'OCTOBER', 'NOVEMBER', 'DECEMBER' ]";

		  // only testing raw output
		  ac
				.Options
			    .SetMonthNames(newNames)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({monthNames: [ 'JANUARY', 'FEBRUARY', 'MARCH', 'APRIL', 'MAY', 'JUNE', 'JULY', 'AUGUST', 'SEPTEMBER', 'OCTOBER', 'NOVEMBER', 'DECEMBER' ]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		public void DatePicker_Option_MonthNamesShort_As_A_List_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			List<string> newNames = new List<string>() {
				"JAN",
				"FEB",
				"MAR",
				"APR",
				"MAY",
				"JUN",
				"JUL",
				"AUG",
				"SEP",
				"OCT",
				"NOV",
				"DEC"
			};

		  // only testing raw output
		  ac
				.Options
					.SetMonthNamesShort(newNames)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({monthNamesShort: ['JAN','FEB','MAR','APR','MAY','JUN','JUL','AUG','SEP','OCT','NOV','DEC']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}
		
		public void DatePicker_Option_MonthNamesShort_As_A_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);
			string newNames = "['JAN','FEB','MAR','APR','MAY','JUN','JUL','AUG','SEP','OCT','NOV','DEC']";

		  // only testing raw output
		  ac
				.Options
					.SetMonthNamesShort(newNames)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({monthNamesShort: ['JAN','FEB','MAR','APR','MAY','JUN','JUL','AUG','SEP','OCT','NOV','DEC']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}
		
		[TestMethod]
		public void DatePicker_Option_NavigationAsDateFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetNavigationAsDateFormat(true)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({navigationAsDateFormat: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_NextText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
			    .SetNextText("N E X T")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({nextText: \"N E X T\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_NextText_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetNextText(Options.DEFAULT_NEXT_TEXT)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_NumberOfMonths_When_Integer_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetNumberOfMonths(2)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({numberOfMonths: 2})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_NumberOfMonths_When_Integer_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetNumberOfMonths(Options.DEFAULT_NUMBER_OF_MONTHS)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_NumberOfMonths_When_Rows_And_Cols_Specified_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetNumberOfMonths(2, 3)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({numberOfMonths: [2, 3]})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_PrevText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetPrevText("P R E V")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({prevText: \"P R E V\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_PrevText_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetPrevText(Options.DEFAULT_PREV_TEXT)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_SelectOtherMonths_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetSelectOtherMonths(true)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({selectOtherMonths: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShortYearCutOff_By_Absolute_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
			    .SetShortYearCutoff(7)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({shortYearCutoff: 7})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShortYearCutOff_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShortYearCutoff(Options.DEFAULT_SHORT_YEAR_CUTOFF)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShortYearCutOff_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShortYearCutoff("+11")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({shortYearCutoff: \"+11\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowAnim_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowAnim("fadeIn")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showAnim: \"fadeIn\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowAnim_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowAnim(Core.Animation.eAnimation.Explode)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showAnim: \"explode\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}


		[TestMethod]
		public void DatePicker_Option_ShowAnim_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
			    .SetShowAnim(Options.DEFAULT_SHOW_ANIM)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowButtonPanel_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowButtonPanel(true)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showButtonPanel: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowCurrentAtPos_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowCurrentAtPos(3)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showCurrentAtPos: 3})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowCurrentAtPos_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowCurrentAtPos(Options.DEFAULT_SHOW_CURRENT_AT_POS)
					.Finish()
				.Rendering
					.Compress()
		    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowMonthByYear_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowMonthAfterYear(true)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showMonthAfterYear: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowOn_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowOn("both")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showOn: \"both\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowOn_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowOn(Options.DEFAULT_SHOW_ON)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowOptions_With_Default_Value_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowOptions("{}")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowOptions_By_JSON_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowOptions("{ direction: \"up\" }")
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showOptions: { direction: \"up\" }})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowOtherMonths_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowOtherMonths(true)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showOtherMonths: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_ShowWeek_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetShowWeek(true)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({showWeek: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_StepMonths_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
			    .SetStepMonths(3)
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({stepMonths: 3})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_StepMonths_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetStepMonths(Options.DEFAULT_STEP_MONTHS)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_WeekHeader_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetWeekHeader("Week")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({weekHeader: \"Week\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_WeekHeader_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetWeekHeader(Options.DEFAULT_WEEK_HEADER)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_YearRange_By_Relative_Number_Of_Days_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetYearRange("2000:2010")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({yearRange: \"2000:2010\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_YearRange_Default_Is_Not_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetYearRange(Options.DEFAULT_YEAR_RANGE)
					.Finish()
				.Rendering
					.Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_Option_YearSuffix_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

		  // only testing raw output
		  ac
				.Options
					.SetYearSuffix("CE")
					.Finish()
				.Rendering
			    .Compress()
			    .ShowCSS()
		  ;

		  // Act - Force output we'd see on the web page
		  ac.Render();
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker({yearSuffix: \"CE\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // DatePicker_Tests

} // ns
