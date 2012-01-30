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
	public partial class Accordion_Core_Tests
	{

		[TestMethod]
		public void Accordion_Without_CSS_On_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

			// only testing raw output
			accordion
				.Rendering
					.Compress()
			;
			
			TestHelper.ForceRender(accordion);

			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"myAccordion\""));

			// 3 content panels
			Assert.AreEqual(3, Utils.NumberOfMatches(html, "<h3><a href=\"#\"") );
			Assert.AreEqual(3, Utils.NumberOfMatches(html, "</h3><div>") );

			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<a href=\"#\">Pane #1</a>") );
			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<a href=\"#\">Pane #2</a>") );
			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<a href=\"#\">Pane #3</a>") );
		}


		[TestMethod]
		public void Accordion_With_Full_CSS_Delivers_Correct_CSS_Classes()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.ShowCSS()
			;
			
			TestHelper.ForceRender(accordion);

			// Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("id=\"myAccordion\""));

		  Assert.AreEqual(1, Utils.NumberOfMatches(html, "<div id=\"myAccordion\" class=\"ui-accordion ui-widget ui-helper-reset ui-accordion-icons\">") );

			// Test the Active panel
		  Assert.AreEqual(1, Utils.NumberOfMatches(html, "<h3 class=\"ui-accordion-header ui-helper-reset ui-state-default ui-state-active ui-corner-top\">") );
		  Assert.AreEqual(1, Utils.NumberOfMatches(html, "<div class=\"ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom ui-accordion-content-active\">") );

			// Test the InActive panel(s)
		  Assert.AreEqual(2, Utils.NumberOfMatches(html, "<h3 class=\"ui-accordion-header ui-helper-reset ui-state-default ui-corner-all\">") );
		  Assert.AreEqual(2, Utils.NumberOfMatches(html, "<div class=\"ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom\">") );
		}


		[TestMethod]
		public void Accordion_With_Custom_Attribute_CSS_Delivers_Correct_CSS_Classes()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
				.Finish()
				.WithAttribute("font-size", "xx-large")
			;
			
			TestHelper.ForceRender(accordion);

			// Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("<div id=\"myAccordion\" font-size=\"xx-large\">"));
		}

		[TestMethod]
		public void Accordion_With_Custom_CSS_But_No_jQuery_Framework_CSS_Delivers_Correct_Classes()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
				.Finish()
				.WithCss("bob")
			;
			
			TestHelper.ForceRender(accordion);

			// Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("<div id=\"myAccordion\" class=\"bob\">"));
		}

		[TestMethod]
		public void Accordion_Header_With_Custom_Attribute_CSS_Delivers_Correct_CSS_Classes()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
				.Finish()
				.Panels.ToList()[0].WithAttribute("font-size", "xx-large")
			;
			
			TestHelper.ForceRender(accordion);

			// Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("<h3 font-size=\"xx-large\""));
		}

		[TestMethod]
		public void Auto_Script_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
			;

			TestHelper.ForceRender(accordion);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion();" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Script_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.SetAutoScript(false)
				.Finish()
			;

			TestHelper.ForceRender(accordion);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
			string expected = 
				"<div id=\"myAccordion\">\r\n" +
				"	<h3>\r\n" +
				"		<a href=\"#\">Pane #1</a>\r\n" +
				"	</h3>\r\n" +
				"	<div>\r\n" +
				"\r\n" +
				"	</div>\r\n\r\n" +
				"	<h3>\r\n" +
				"		<a href=\"#\">Pane #2</a>\r\n" +
				"	</h3>\r\n" +
				"	<div>\r\n" +
				"\r\n" +
				"	</div>\r\n\r\n" +
				"	<h3>\r\n" +
				"		<a href=\"#\">Pane #3</a>\r\n" +
				"	</h3>\r\n" +
				"	<div>\r\n" +
				"\r\n" +
				"	</div>\r\n" +
				"\r\n" +
				"</div>\r\n";
				
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			TestHelper.ForceRender(accordion);
			accordion.RenderStartUpScript();
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion();" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_Auto_Script_Is_Off()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			TestHelper.ForceRender(accordion);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion();" + 
					"});" + 
				"</script>";
		  Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			accordion.RenderStartUpScript();
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"$(\"#myAccordion\").accordion();";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

			// only testing raw output and no script init
			accordion
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			TestHelper.ForceRender(accordion);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"myAccordion\""));
			Assert.IsFalse(html.Contains("$(document).ready("));
		}

		[TestMethod]
		public void Changing_Active_Panel_Changes_The_Panel_Ordering_Accordingly_And_Only_Leaves_One_Panel_Selected()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
			;

			// Change the active panel around before rendering
			accordion.Panels.ToList()[2].IsActive = true;
			accordion.Panels.ToList()[1].IsActive = true;

			TestHelper.ForceRender(accordion);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({active: 1});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));

			// Pane #2 (index 1) should be the active one
			Assert.AreEqual("Pane #2", accordion.Panels.GetActivePanel().Title);
		}


		[TestMethod]
		public void Panel_Marked_As_Active_Has_Correct_Styling_And_JavaScript()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion				
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Set 3rd panel as active
			accordion.Panels.ToList()[2].IsActive = true;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
			// Check styling is correct
			Assert.IsTrue(html.Contains("<h3 class=\"ui-accordion-header ui-helper-reset ui-state-default ui-state-active ui-corner-top\">"));

			// Check scripting is correct
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({active: 2});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // jAccordion_Tests

} // ns
