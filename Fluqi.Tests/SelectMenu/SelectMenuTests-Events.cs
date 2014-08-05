using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jMenu;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;
using Fluqi.Widget.jSelectMenu;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class SelectMenu_Events_Tests 
	{

		[TestMethod]
		public void Change_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu m = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  m.Rendering.Compress();
		  m.Events
		    .SetChangeEvent("addToLog('Change event called');")
		  ;

		  TestHelper.ForceRender(m);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "change: function(event, ui) {addToLog('Change event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Close_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu m = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  m.Rendering.Compress();

		  m.Events
		    .SetCloseEvent("addToLog('Close event called');")
		  ;

		  TestHelper.ForceRender(m);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "close: function(event, ui) {addToLog('Close event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Create_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu m = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  m.Rendering.Compress();

		  m.Events
		    .SetCreateEvent("addToLog('Create event called');")
		  ;

		  TestHelper.ForceRender(m);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}
		
		[TestMethod]
		public void Focus_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu m = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  m.Rendering.Compress();

		  m.Events
		    .SetFocusEvent("addToLog('Focus event called');")
		  ;

		  TestHelper.ForceRender(m);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "focus: function(event, ui) {addToLog('Focus event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Select_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu m = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  m.Rendering.Compress();

		  m.Events
		    .SetSelectEvent("addToLog('Select event called');")
		  ;

		  TestHelper.ForceRender(m);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "select: function(event, ui) {addToLog('Select event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}
		
		[TestMethod]
		public void Open_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu m = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  m.Rendering.Compress();

		  m.Events
		    .SetOpenEvent("addToLog('Open event called');")
		  ;

		  TestHelper.ForceRender(m);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "open: function(event, ui) {addToLog('Open event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}
		
	}

} // ns
