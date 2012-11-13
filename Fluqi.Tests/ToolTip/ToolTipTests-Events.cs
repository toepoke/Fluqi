using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jToolTip;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class ToolTip_Events_Tests 
	{

		[TestMethod]
		public void ToolTip_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tip = TestHelper.SetupSimpleToolTipObject(resp);

		  // only testing raw output
		  tip.Rendering.Compress();

		  tip.Events
		    .SetCreateEvent("addToLog('Create event called');")
		  ;

		  TestHelper.ForceRender(tip);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_With_Open_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tip = TestHelper.SetupSimpleToolTipObject(resp);

		  // only testing raw output
		  tip.Rendering.Compress();

		  tip.Events
		    .SetOpenEvent("addToLog('Open event called');")
		  ;

		  TestHelper.ForceRender(tip);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "open: function(event, ui) {addToLog('Open event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_With_Close_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tip = TestHelper.SetupSimpleToolTipObject(resp);

		  // only testing raw output
		  tip.Rendering.Compress();

		  tip.Events
		    .SetCloseEvent("addToLog('Close event called');")
		  ;

		  TestHelper.ForceRender(tip);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "close: function(event, ui) {addToLog('Close event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

	}

} // ns
