using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jDatePicker;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class DatePicker_Core_Tests
	{

		[TestMethod]
		public void DatePicker_With_No_CSS_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"dt\""));
			Assert.IsTrue(html.Contains("type=\"text\""));
		}


		[TestMethod]
		public void DatePicker_With_Full_CSS_Delivers_Correct_CSS_Classes()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering.Compress();

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

			// Assert - DatePicker has no additional styling
			Assert.IsFalse(html.Contains("class=\"\""));
		}


		[TestMethod]
		public void DatePicker_With_Addition_CSS_Delivers_Is_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dp = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			dp
				.WithCss("my-extra-css-class")
				.Rendering
					.Compress()
			;

			// Act - Force output we'd see on the web page
			dp.Render();
			string html = resp.Output.ToString();

			// Assert - DatePicker has no additional styling
			Assert.IsTrue(html.Contains("my-extra-css-class"));
		}

		[TestMethod]
		public void DatePicker_With_Addition_Attributes_Are_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dp = TestHelper.SetupSimpleDatePickerObject(resp);
						
			dp
				.WithAttribute("test-attribute-1", "test-value-a")
				.WithAttribute("test-attribute-2", "test-value-b")
				.Rendering
					.Compress();
			;

			// Act - Force output we'd see on the web page
			dp.Render();
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
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering.Compress().ShowCSS();

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Script_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering
				.SetAutoScript(false)			
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "<input id=\"dt\" type=\"text\" />";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
				.ShowCSS()
				.SetAutoScript(false)			
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			ac.RenderStartUpScript();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
				.ShowCSS()
				.SetAutoScript(false)			
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#dt\").datepicker()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering.Compress().ShowCSS();

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "$(\"#dt\").datepicker()";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker ac = TestHelper.SetupSimpleDatePickerObject(resp);

			// only testing raw output
			ac.Rendering
				.SetAutoScript(false)
				.Compress()
				.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("id=\"dt\""));
		  Assert.IsFalse(html.Contains("$(document).ready("));
		}

	} // DatePicker_Tests

} // ns
