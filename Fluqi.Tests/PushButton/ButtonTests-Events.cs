using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jPushButton;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Button_Events_Tests
	{

		[TestMethod]
		public void Button_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
					.ShowCSS()
			;
			btn.Events
				.SetCreateEvent("addToLog('Create event called');")
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Button_With_Click_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
					.ShowCSS()
			;
			btn.Events
				.SetClickEvent("addToLog('Click event called');")
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert - Note as a pseudo event, the "click" is rendered a little bit differently
			string expected = "$(\"#btn\").click(function() {addToLog('Click event called');}";

		  Assert.IsTrue(html.Contains(expected));
		}

	} // jButton_Tests

} // ns
