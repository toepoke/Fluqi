using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jProgressBar;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class ProgressBar_Events_Tests
	{

		[TestMethod]
		public void Slider_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering.Compress();

			pb.Events
				.SetCreateEvent("addToLog('Create event called');")
			;

			TestHelper.ForceRender(pb);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Slider_With_Change_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering.Compress();

			pb.Events
				.SetChangeEvent("addToLog('Change event called');")
			;

			TestHelper.ForceRender(pb);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "change: function(event, ui) {addToLog('Change event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Slider_With_Complete_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering.Compress();

			pb.Events
				.SetCompleteEvent("addToLog('Complete event called');")
			;

			TestHelper.ForceRender(pb);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "complete: function(event, ui) {addToLog('Complete event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // jSlider_Tests

} // ns
