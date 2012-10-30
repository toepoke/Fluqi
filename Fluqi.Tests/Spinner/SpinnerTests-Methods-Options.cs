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
	public partial class Spinner_Methods_Options_Tests 
	{

		[TestMethod]
		public void Ensure_GetCulture_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetCulture();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"culture\")", html);
		}

		[TestMethod]
		public void Ensure_SetCulture_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetCulture("en");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"culture\",\"en\")", html);
		}

		[TestMethod]
		public void Ensure_GetDisabled_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetDisabled();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"disabled\")", html);
		}

		[TestMethod]
		public void Ensure_SetDisabled_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetDisabled(true);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"disabled\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetIcons_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetIcons();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"icons\")", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetIcons(Core.Icons.eIconClass.alert, Core.Icons.eIconClass.info);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"icons\",{ down:\"ui-icon-alert\", up:\"ui-icon-info\" })", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetIcons("down", "up");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"icons\",{ down:\"down\", up:\"up\" })", html);
		}

		[TestMethod]
		public void Ensure_GetIncremental_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetIncremental();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"incremental\")", html);
		}

		[TestMethod]
		public void Ensure_SetIncremental_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetIncremental(true);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"incremental\",true)", html);
		}

		[TestMethod]
		public void Ensure_SetIncremental_By_Function_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetIncremental("function bob() { }");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"incremental\",function bob() { })", html);
		}

		[TestMethod]
		public void Ensure_GetMin_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetMin();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"min\")", html);
		}

		[TestMethod]
		public void Ensure_SetMin_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetMin(98);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"min\",98)", html);
		}

		[TestMethod]
		public void Ensure_SetMin_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetMin("en");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"min\",\"en\")", html);
		}

		[TestMethod]
		public void Ensure_GetMax_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetMax();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"max\")", html);
		}

		[TestMethod]
		public void Ensure_SetMax_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetMax(102);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"max\",102)", html);
		}

		[TestMethod]
		public void Ensure_SetMax_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetMax("abcxyz");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"max\",\"abcxyz\")", html);
		}

		[TestMethod]
		public void Ensure_GetNumberFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetNumberFormat();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"numberFormat\")", html);
		}

		[TestMethod]
		public void Ensure_SetNumberFormat_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetNumberFormat("C");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"numberFormat\",\"C\")", html);
		}

		[TestMethod]
		public void Ensure_GetPage_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetPage();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"page\")", html);
		}

		[TestMethod]
		public void Ensure_SetPage_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetPage(101);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"page\",101)", html);
		}

		[TestMethod]
		public void Ensure_GetStep_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.GetStep();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"step\")", html);
		}

		[TestMethod]
		public void Ensure_SetStep_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetStep(102);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"step\",102)", html);
		}

		[TestMethod]
		public void Ensure_SetStep_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSpinnerObject(resp);

		  ctl.Methods.SetStep("abc102");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySpinner\").spinner(\"option\",\"step\",\"abc102\")", html);
		}

	}

} // ns

