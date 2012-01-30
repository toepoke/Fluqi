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
	public partial class Slider_Methods_Tests 
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			sldr.Methods.Destroy();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			sldr.Methods.Disable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			sldr.Methods.Enable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			sldr.Methods.Widget();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_GetValue_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			sldr.Methods.GetValue();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"value\")", html);
		}

		[TestMethod]
		public void Ensure_SetValue_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			sldr.Methods.SetValue(44);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"value\",44)", html);
		}

		[TestMethod]
		public void Ensure_GetValue_Multiple_Slides_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			sldr.Methods.GetValue(2);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"values\",2)", html);
		}

		[TestMethod]
		public void Ensure_SetValue_Multiple_Slider_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			sldr.Methods.SetValue(2, 99);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#mySlider\").slider(\"values\",2,99)", html);
		}
		
	} // jSlider_Tests

} // ns
