using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jAutoComplete;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class AutoComplete_Events_Tests
	{
		
		[TestMethod]
		public void Ensure_AutoComplete_With_Multiple_EventHandlers_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.Finish()
				.Rendering
					.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetCreateEvent("addToLog('Create event called');")
				.SetCloseEvent("addToLog('Close event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

			// Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');},close: function(event, ui) {addToLog('Close event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac.Rendering
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
		public void AutoComplete_With_Search_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.Finish()
				.Rendering
					.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetSearchEvent("addToLog('Search event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "search: function(event, ui) {addToLog('Search event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_With_Open_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetOpenEvent("addToLog('Open event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "open: function(event, ui) {addToLog('Open event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_With_Focus_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;
			ac.Events
				.SetFocusEvent("addToLog('Focus event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "focus: function(event, ui) {addToLog('Focus event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_With_Select_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetSelectEvent("addToLog('Select event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "select: function(event, ui) {addToLog('Select event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_With_Close_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
				.ShowCSS()
			;
			ac.Events
				.SetCloseEvent("addToLog('Close event called');")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "close: function(event, ui) {addToLog('Close event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_With_Change_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.Finish()
				.Events
					.SetChangeEvent("addToLog('Change event called');")
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "change: function(event, ui) {addToLog('Change event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // jAutoComplete_Tests

} // ns
