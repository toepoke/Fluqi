using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jTab;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Tab_Events_Tests
	{

		[TestMethod]
		public void Ensure_Tab_With_Multiple_EventHandlers_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
				.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetCreateEvent("addToLog('Create event called');")
				.SetDisableEvent("addToLog('Disable event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');},disable: function(event, ui) {addToLog('Disable event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
					.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetCreateEvent("addToLog('Create event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Select_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
				.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetSelectEvent("addToLog('Select event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "select: function(event, ui) {addToLog('Select event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Load_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
					.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetLoadEvent("addToLog('Load event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "load: function(event, ui) {addToLog('Load event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Show_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
				.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetShowEvent("addToLog('Show event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "show: function(event, ui) {addToLog('Show event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Add_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
				.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetAddEvent("addToLog('Add event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "add: function(event, ui) {addToLog('Add event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Remove_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
					.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetRemoveEvent("addToLog('Remove event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "remove: function(event, ui) {addToLog('Remove event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Enable_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs	
				.Options
					.SetEvent("mouseover")
					.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetEnableEvent("addToLog('Enable event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "enable: function(event, ui) {addToLog('Enable event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // jTab_Tests

} // ns
