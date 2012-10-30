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
	public partial class Spinner_Methods_Tests 
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.Destroy();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.Disable();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.Enable();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.Widget();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_PageDown_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.PageDown(99);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"pageDown\",99)", html);
		}

		[TestMethod]
		public void Ensure_PageUp_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.PageUp(98);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"pageUp\",98)", html);
		}

		[TestMethod]
		public void Ensure_StepDown_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.StepDown(101);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"stepDown\",101)", html);
		}

		[TestMethod]
		public void Ensure_StepUp_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.StepUp(102);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"stepUp\",102)", html);
		}

		[TestMethod]
		public void Ensure_GetValue_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.GetValue();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"value\")", html);
		}

		[TestMethod]
		public void Ensure_SetValue_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

		  spinner.Methods.SetValue(44);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"value\",44)", html);
		}
		
	}

} // ns
