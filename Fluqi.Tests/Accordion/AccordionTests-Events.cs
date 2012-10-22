using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jAccordion;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Core;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Accordion_Events_Tests
	{

		[TestMethod]
		public void Ensure_Accordion_With_Multiple_EventHandlers_Are_Added_To_Script_Definition_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Events
					.SetCreateEvent("addToLog('Create event called');")
					.SetActivateEvent("addToLog('Activate event called');")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');},activate: function(event, ui) {addToLog('Activate event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Accordion_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Events
					.SetCreateEvent("addToLog('Create event called');")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Accordion_With_Activate_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Events
					.SetActivateEvent("addToLog('Activate event called');")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "activate: function(event, ui) {addToLog('Activate event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Accordion_With_BeforeActivate_EventHandler_Wired_Up_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Events
					.SetBeforeActivateEvent("addToLog('BeforeActivate event called');")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "beforeActivate: function(event, ui) {addToLog('BeforeActivate event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // jAccordion_Tests

} // ns
