using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jSlider;
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

		//[TestMethod]
		//public void Slider_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		//{
		//  // Arrange
		//  // Arrange
		//  var resp = new MockWriter();
		//  Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

		//  // only testing raw output
		//  sldr.Rendering.Compress();

		//  sldr.Events
		//    .SetCreateEvent("addToLog('Create event called');")
		//  ;

		//  TestHelper.ForceRender(sldr);

		//  // Act - Force output we'd see on the web page
		//  string html = resp.Output.ToString();

		//  // Assert
		//  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		//  Assert.IsTrue(html.Contains(expected));
		//}

		//[TestMethod]
		//public void Slider_With_Start_EventHandler_Wired_Up_Renders_Correctly()
		//{
		//  // Arrange
		//  // Arrange
		//  var resp = new MockWriter();
		//  Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

		//  // only testing raw output
		//  sldr.Rendering.Compress();

		//  sldr.Events
		//    .SetStartEvent("addToLog('Start event called');")
		//  ;

		//  TestHelper.ForceRender(sldr);

		//  // Act - Force output we'd see on the web page
		//  string html = resp.Output.ToString();

		//  // Assert
		//  string expected = "start: function(event, ui) {addToLog('Start event called');}";
		//  Assert.IsTrue(html.Contains(expected));
		//}

		//[TestMethod]
		//public void Slider_With_Slide_EventHandler_Wired_Up_Renders_Correctly()
		//{
		//  // Arrange
		//  // Arrange
		//  var resp = new MockWriter();
		//  Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

		//  // only testing raw output
		//  sldr.Rendering.Compress();

		//  sldr.Events
		//    .SetSlideEvent("addToLog('Slide event called');")
		//  ;

		//  TestHelper.ForceRender(sldr);

		//  // Act - Force output we'd see on the web page
		//  string html = resp.Output.ToString();

		//  // Assert
		//  string expected = "slide: function(event, ui) {addToLog('Slide event called');}";
		//  Assert.IsTrue(html.Contains(expected));
		//}

		//[TestMethod]
		//public void Slider_With_Change_EventHandler_Wired_Up_Renders_Correctly()
		//{
		//  // Arrange
		//  // Arrange
		//  var resp = new MockWriter();
		//  Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

		//  // only testing raw output
		//  sldr.Rendering.Compress();

		//  sldr.Events
		//    .SetChangeEvent("addToLog('Change event called');")
		//  ;

		//  TestHelper.ForceRender(sldr);

		//  // Act - Force output we'd see on the web page
		//  string html = resp.Output.ToString();

		//  // Assert
		//  string expected = "change: function(event, ui) {addToLog('Change event called');}";
		//  Assert.IsTrue(html.Contains(expected));
		//}

		//[TestMethod]
		//public void Slider_With_Stop_EventHandler_Wired_Up_Renders_Correctly()
		//{
		//  // Arrange
		//  // Arrange
		//  var resp = new MockWriter();
		//  Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

		//  // only testing raw output
		//  sldr.Rendering.Compress();

		//  sldr.Events
		//    .SetStopEvent("addToLog('Stop event called');")
		//  ;

		//  TestHelper.ForceRender(sldr);

		//  // Act - Force output we'd see on the web page
		//  string html = resp.Output.ToString();

		//  // Assert
		//  string expected = "stop: function(event, ui) {addToLog('Stop event called');}";
		//  Assert.IsTrue(html.Contains(expected));
		//}

	}

} // ns
