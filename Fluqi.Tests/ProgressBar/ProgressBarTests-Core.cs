using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jProgressBar;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class ProgressBar_Core_Tests
	{
		
		[TestMethod]
		public void ProgressBar_With_No_CSS_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering
				.Compress()
			;

			TestHelper.ForceRender(pb);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"pb\""));
		}


		[TestMethod]
		public void ProgressBar_With_Full_CSS_Delivers_Correct_CSS_Classes()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb
				.Rendering
				.Compress()
				.ShowCSS()
			;

			TestHelper.ForceRender(pb);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"pb\""));

			Assert.AreEqual(1, Utils.NumberOfMatches(html, "class=\"ui-progressbar ui-widget ui-widget-content ui-corner-all\"") );
		}


		[TestMethod]
		public void ProgressBar_With_Addition_CSS_Delivers_Is_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			pb
				.WithCss("my-extra-css-class")
				.Rendering
				.Compress()		// only testing raw output
			;

			TestHelper.ForceRender(pb);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("my-extra-css-class"));
		}


		[TestMethod]
		public void ProgressBar_With_Addition_Attributes_Are_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			pb
				.WithAttribute("test-attribute-1", "test-value-a")
				.WithAttribute("test-attribute-2", "test-value-b")
				.Rendering
				.Compress()		// only testing raw output
			;

			TestHelper.ForceRender(pb);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("test-attribute-1=\"test-value-a\""));
			Assert.IsTrue(html.Contains("test-attribute-2=\"test-value-b\""));
		}


		[TestMethod]
		public void Auto_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering.Compress();

			TestHelper.ForceRender(pb);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#pb\").progressbar()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Script_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering
				.SetAutoScript(false)
			;

			TestHelper.ForceRender(pb);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = "<div id=\"pb\"></div>";
			Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering
				.SetAutoScript(false)
				.Compress()
			;

			TestHelper.ForceRender(pb);

			pb.RenderStartUpScript();
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#pb\").progressbar()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_Auto_Script_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering
				.SetAutoScript(false)
				.Compress()
			;

			TestHelper.ForceRender(pb);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#pb\").progressbar(()" + 
					";});" + 
				"</script>";
			Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Rendering
				.SetAutoScript(false)
				.Compress()
			;

			pb.RenderStartUpScript();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"$(\"#pb\").progressbar();";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			TestHelper.ForceRender(pb);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"pb\""));
			Assert.IsFalse(html.Contains("$(document).ready("));
		}

	} // jSlider_Tests

} // ns
