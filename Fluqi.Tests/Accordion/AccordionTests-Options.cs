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
	public partial class Accordion_Options_Tests
	{
		[TestMethod]
		public void Ensure_Multiple_Options_Are_Added_To_Script_Definition_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetCollapsible(true)
					.SetDisabled(true)
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({disabled: true,collapsible: true});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}


		[TestMethod]
		public void Ensure_Collapsible_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetCollapsible(true)
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({collapsible: true});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Disabled_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetDisabled(true)
				;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({disabled: true});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Animate_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetAnimate("bounceslide")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({animate: \"bounceslide\"});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_AutoHeight_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetAutoHeight(false)
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({autoHeight: false});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_ClearStyle_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetClearStyle(true)
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({clearStyle: true});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Event_Option_By_String_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetEvent("mouseover")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({event: 'mouseover'});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Event_Option_By_Enum_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetEvent(BrowserEvent.eBrowserEvent.MouseOver)
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({event: 'mouseover'});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_FillSpace_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetFillSpace(true)
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({fillSpace: true});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Icons_Default_String_Option_Is_Not_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetIcons("ui-icon-triangle-1-e", "ui-icon-triangle-1-s")
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
		public void Ensure_Icons_String_By_String_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetIcons("ui-icon-circle-plus", "ui-icon-circle-minus")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({icons: { 'header': 'ui-icon-circle-plus', 'activeHeader': 'ui-icon-circle-minus' }});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Icons_String_By_Enum_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetIcons(Icons.eIconClass.circle_plus, Icons.eIconClass.circle_minus)
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({icons: { 'header': 'ui-icon-circle-plus', 'activeHeader': 'ui-icon-circle-minus' }});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Icons_With_Non_JQueryUI_Icon_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetIcons("my-primary-icon", "my-secondary-icon")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({icons: { 'header': 'my-primary-icon', 'activeHeader': 'my-secondary-icon' }});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Icons_Enum_Default_Option_Is_Not_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetIcons( Icons.eIconClass.triangle_1_e, Icons.eIconClass.triangle_1_s )
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
		public void Ensure_Icons_Enum_Option_Is_Not_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetIcons( Icons.eIconClass.plusthick, Icons.eIconClass.minusthick )
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({icons: { 'header': 'ui-icon-plusthick', 'activeHeader': 'ui-icon-minusthick' }});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Navigation_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetNavigation(true)
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({navigation: true});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_NavigationFilter_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  // only testing raw output
		  accordion
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetNavigationFilter("function(bob){alert(bob);}")
			;

			TestHelper.ForceRender(accordion);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myAccordion\").accordion({navigationFilter: function(bob){alert(bob);}});" + 
					"});" + 
				"</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // jAccordion_Tests

} // ns
