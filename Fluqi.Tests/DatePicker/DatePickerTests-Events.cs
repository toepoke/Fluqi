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
	public partial class DatePicker_Events_Tests
	{

		[TestMethod]
		public void Ensure_DatePicker_With_Multiple_EventHandlers_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
			;
			ac.Events
				.SetCreateEvent("addToLog('Create event called');")
				.SetOnCloseEvent("addToLog('OnClose event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');},onClose: function(dateText, inst) {addToLog('OnClose event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
			;
			ac.Events
				.SetCreateEvent("addToLog('Create event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_With_BeforeShow_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac
				.Rendering
				.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetBeforeShowEvent("addToLog('BeforeShow event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "beforeShow: function(input, inst) {addToLog('BeforeShow event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_With_BeforeShowDay_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
			;
			ac.Events
				.SetBeforeShowDayEvent("addToLog('BeforeShowDay event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "beforeShowDay: function(date) {addToLog('BeforeShowDay event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_With_OnChangeMonthYear_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetOnChangeMonthYearEvent("addToLog('OnChangeMonthYear event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "onChangeMonthYear: function(year, month, inst) {addToLog('OnChangeMonthYear event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_With_OnClose_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac
				.Rendering
				.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetOnCloseEvent("addToLog('OnClose event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "onClose: function(dateText, inst) {addToLog('OnClose event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void DatePicker_With_OnSelect_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetOnSelectEvent("addToLog('OnSelect event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "onSelect: function(dateText, inst) {addToLog('OnSelect event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // DatePicker_Tests

} // ns
