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
	public partial class Slider_Methods_Options_Tests 
	{

		[TestMethod]
		public void Ensure_GetAnimate_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.GetAnimate();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"animate\")", html);
		}

		[TestMethod]
		public void Ensure_SetAnimate_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetAnimate(Core.Speed.eSpeed.Fast);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"animate\",\"fast\")", html);
		}

		[TestMethod]
		public void Ensure_SetAnimate_By_Integer_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetAnimate(1456);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"animate\",1456)", html);
		}

		[TestMethod]
		public void Ensure_SetAnimate_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetAnimate("fast");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"animate\",\"fast\")", html);
		}

		[TestMethod]
		public void Ensure_GetMax_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.GetMax();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"max\")", html);
		}

		[TestMethod]
		public void Ensure_SetMax_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetMax(200);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"max\",200)", html);
		}

		[TestMethod]
		public void Ensure_GetMin_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.GetMin();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"min\")", html);
		}

		[TestMethod]
		public void Ensure_SetMin_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetMin(123);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"min\",123)", html);
		}

		[TestMethod]
		public void Ensure_GetOrientation_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.GetOrientation();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"orientation\")", html);
		}

		[TestMethod]
		public void Ensure_SetOrientation_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetOrientation(Core.Orientation.eOrientation.Vertical);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"orientation\",\"vertical\")", html);
		}

		[TestMethod]
		public void Ensure_SetOrientation_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetOrientationJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"orientation\",some_javascript_variable)", html);
		}	

		[TestMethod]
		public void Ensure_SetOrientation_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetOrientation("vertical");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"orientation\",\"vertical\")", html);
		}	

		[TestMethod]
		public void Ensure_GetRange_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.GetRange();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"range\")", html);
		}

		[TestMethod]
		public void Ensure_SetRange_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetRange(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"range\",true)", html);
		}

		[TestMethod]
		public void Ensure_SetRangeToMin_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetRangeToMin();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"range\",\"min\")", html);
		}

		[TestMethod]
		public void Ensure_SetRangeToMax_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetRangeToMax();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"range\",\"max\")", html);
		}

		[TestMethod]
		public void Ensure_GetStep_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.GetStep();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"step\")", html);
		}

		[TestMethod]
		public void Ensure_SetStep_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSliderObject(resp);

		  ctl.Methods.SetStep(3);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"option\",\"step\",3)", html);
		}

	} // Slider_Methods_Options_Tests

} // ns

