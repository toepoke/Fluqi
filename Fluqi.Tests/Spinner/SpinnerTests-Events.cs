using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jSpinner;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Spinner_Events_Tests 
	{

		[TestMethod]
		public void Spinner_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spin = TestHelper.SetupSimpleSpinnerObject(resp);

		  // only testing raw output
		  spin.Rendering.Compress();

		  spin.Events
		    .SetCreateEvent("addToLog('Create event called');")
		  ;

		  TestHelper.ForceRender(spin);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Spinner_With_Spin_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spin = TestHelper.SetupSimpleSpinnerObject(resp);

		  // only testing raw output
		  spin.Rendering.Compress();

		  spin.Events
		    .SetSpinEvent("addToLog('Spin event called');")
		  ;

		  TestHelper.ForceRender(spin);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "spin: function(event, ui) {addToLog('Spin event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Spinner_With_Start_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spin = TestHelper.SetupSimpleSpinnerObject(resp);

		  // only testing raw output
		  spin.Rendering.Compress();

		  spin.Events
		    .SetStartEvent("addToLog('Start event called');")
		  ;

		  TestHelper.ForceRender(spin);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "start: function(event, ui) {addToLog('Start event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Spinner_With_Stop_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spin = TestHelper.SetupSimpleSpinnerObject(resp);

		  // only testing raw output
		  spin.Rendering.Compress();

		  spin.Events
		    .SetStopEvent("addToLog('Stop event called');")
		  ;

		  TestHelper.ForceRender(spin);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "stop: function(event, ui) {addToLog('Stop event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

	}

} // ns
