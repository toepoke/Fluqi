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
	public partial class Slider_Options_Tests 
	{

		[TestMethod]
		public void Ensure_Multiple_Options_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetAnimate(true)
					.SetDisabled(true)
					.Finish()
				.Rendering
					.Compress();
			;
	
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({disabled: true,animate: true})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Disabled_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetDisabled(true)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({disabled: true})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Animate_Option_With_Bool_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetAnimate(true)
				.Finish()
				.Rendering
					.Compress();
	
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({animate: true})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Animate_Option_With_Integer_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetAnimate(1500)
				.Finish()
				.Rendering
					.Compress();
	
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({animate: 1500})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Animate_Option_With_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetAnimate("slow")
					.Finish()
				.Rendering
					.Compress();
	
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({animate: \"slow\"})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

	[TestMethod]
		public void Ensure_Animate_Option_With_Enum_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetAnimate(Core.Speed.eSpeed.Slow)
					.Finish()
				.Rendering
					.Compress();
	
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({animate: \"slow\"})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Min_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetMin(3)
				.Finish()
				.Rendering
					.Compress();
	
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({min: 3})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Max_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetMax(2)
					.Finish()
				.Rendering
					.Compress();
	
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({max: 2})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Min_Default_Option_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetMin(Options.DEFAULT_MIN)
				.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Max_Default_Option_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetMax(Options.DEFAULT_MAX)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Orientation_Horizontal_Default_Option_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetOrientation(Options.DEFAULT_ORIENTATION)
					.Finish()
				.Rendering
					.Compress();
			
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Orientation_Vertical_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetOrientation(Fluqi.Core.Orientation.eOrientation.Vertical)
				.Finish()
				.Rendering
					.Compress();
			
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({orientation: \"vertical\"})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Orientation_Default_Option_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetOrientation(Fluqi.Core.Orientation.eOrientation.Horizontal)
				.Finish()
				.Rendering
					.Compress();
			
			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Range_Option_By_Bool_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetRange(true)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({range: true})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Range_Option_By_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetRange("min")
				.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({range: \"min\"})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Step_Is_Rendered_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetStep(3)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({step: 3})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Step_Default_Option_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetStep(Options.DEFAULT_STEP)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		


		[TestMethod]
		public void Ensure_Value_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetValue(4)
				.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({value: 4})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Value_Default_Option_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetValue(Options.DEFAULT_VALUE)
				.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		


		[TestMethod]
		public void Ensure_Values_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Slider sldr = TestHelper.SetupSimpleSliderObject(resp);

			// only testing raw output
			sldr
				.Options
					.SetValues(1, 2, 3, 4)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(sldr);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#mySlider\").slider({values: [ 1, 2, 3, 4 ]})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

	} // jSlider_Tests

} // ns
