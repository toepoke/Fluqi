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
	public partial class Accordion_Methods_Tests
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.Destroy();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.Enable();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.Widget();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_Activate_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.Activate(2);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"activate\",2)", html);
		}

		[TestMethod]
		public void Ensure_Select_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.Select(2);

		  // Act
			string html = resp.Output.ToString();

		  // Assert - Note the "Select" method is the same as the "Activate" method and is merely
			//          present in the API as it's arguably more discoverable than "Activate".
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"activate\",2)", html);
		}

		[TestMethod]
		public void Ensure_CollapseAll_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.CollapseAll();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"activate\",false)", html);
		}

		[TestMethod]
		public void Ensure_Resize_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.Resize();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"resize\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var accordion = TestHelper.SetupSimpleAccordionObject(resp);

		  accordion.Methods.Disable();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myAccordion\").accordion(\"disable\")", html);
		}
		
	} // jAccordion_Tests

} // ns
