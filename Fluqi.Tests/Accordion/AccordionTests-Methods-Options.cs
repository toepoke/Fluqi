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
	public partial class Accordion_Method_Options_Tests
	{

		[TestMethod]
		public void Ensure_GetAnimation_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetAnimation();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"animated\")", html);
		}

		[TestMethod]
		public void Ensure_SetAnimation_WithoutQuotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetAnimationJS("some_javascript");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"animated\",some_javascript)", html);
		}

		[TestMethod]
		public void Ensure_SetAnimation_WithQuotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetAnimation("myNewAnimation", true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"animated\",\"myNewAnimation\")", html);
		}

		[TestMethod]
		public void Ensure_DisableAnimation_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.DisableAnimation();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"animated\",false)", html);
		}
		
		[TestMethod]
		public void Ensure_GetAutoHeight_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetAutoHeight();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"autoHeight\")", html);
		}

		[TestMethod]
		public void Ensure_SetAutoHeight_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetAutoHeight(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"autoHeight\",false)", html);
		}

		[TestMethod]
		public void Ensure_GetClearStyle_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetClearStyle();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"clearStyle\")", html);
		}

		[TestMethod]
		public void Ensure_SetClearStyle_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetClearStyle(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"clearStyle\",false)", html);
		}

		[TestMethod]
		public void Ensure_GetCollapsible_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetCollapsible();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"collapsible\")", html);
		}

		[TestMethod]
		public void Ensure_SetCollapsible_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetCollapsible(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"collapsible\",false)", html);
		}

		[TestMethod]
		public void Ensure_GetEvent_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetEvent();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"event\")", html);
		}

		[TestMethod]
		public void Ensure_SetEvent_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetEventJS("click");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"event\",click)", html);
		}

		[TestMethod]
		public void Ensure_SetEvent_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetEvent("click");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"event\",\"click\")", html);
		}

		[TestMethod]
		public void Ensure_GetFillSpace_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetFillSpace();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"fillSpace\")", html);
		}

		[TestMethod]
		public void Ensure_SetFillSpace_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetFillSpace(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"fillSpace\",false)", html);
		}

		[TestMethod]
		public void Ensure_GetHeader_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetHeader();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"header\")", html);
		}

		[TestMethod]
		public void Ensure_SetHeader_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetHeader("> li > :file-child", true/*doubleQuotes*/);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"header\",\"> li > :file-child\")", html);
		}

		[TestMethod]
		public void Ensure_SetHeader_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetHeaderJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"header\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_GetIcons_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetIcons();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"icons\")", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetIcons("ui-icon-triangle-1-e", "ui-icon-triangle-1-s");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"icons\",{ 'header': 'ui-icon-triangle-1-e', 'headerSelected': 'ui-icon-triangle-1-s' })", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetIcons(Icons.eIconClass.triangle_1_e, Icons.eIconClass.triangle_1_s);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"icons\",{ 'header': 'ui-icon-triangle-1-e', 'headerSelected': 'ui-icon-triangle-1-s' })", html);
		}

		[TestMethod]
		public void Ensure_GetNavigation_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetNavigation();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"navigation\")", html);
		}

		[TestMethod]
		public void Ensure_SetNavigation_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetNavigation(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"navigation\",false)", html);
		}

		[TestMethod]
		public void Ensure_GetNavigationFilter_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.GetNavigationFilter();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"navigationFilter\")", html);
		}

		[TestMethod]
		public void Ensure_SetNavigationFilter_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.SetNavigationFilter("function() { return blah; }");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"option\",\"navigationFilter\",function() { return blah; })", html);
		}

	} // jAccordion_Tests

} // ns
