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

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Menu_Events_Tests 
	{

		[TestMethod]
		public void Menu_With_Blur_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering.Compress();

		  menu.Events
		    .SetBlurEvent("addToLog('Blur event called');")
		  ;

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "blur: function(event, ui) {addToLog('Blur event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering.Compress();

		  menu.Events
		    .SetCreateEvent("addToLog('Create event called');")
		  ;

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}
		
		[TestMethod]
		public void Menu_With_Focus_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering.Compress();

		  menu.Events
		    .SetFocusEvent("addToLog('Focus event called');")
		  ;

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "focus: function(event, ui) {addToLog('Focus event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_With_Select_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering.Compress();

		  menu.Events
		    .SetSelectEvent("addToLog('Select event called');")
		  ;

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "select: function(event, ui) {addToLog('Select event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}
		
	}

} // ns
