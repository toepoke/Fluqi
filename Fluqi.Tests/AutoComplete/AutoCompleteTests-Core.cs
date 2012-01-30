using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jAutoComplete;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class AutoComplete_Core_Tests
	{
		
		[TestMethod]
		public void AutoComplete_With_No_CSS_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Rendering
				.Compress()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"ac\""));
			Assert.IsTrue(html.Contains("autocomplete=\"off\""));
		}


		[TestMethod]
		public void AutoComplete_With_Full_CSS_Delivers_Correct_CSS_Classes()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac
				.Rendering
					.ShowCSS()
					.Compress()		// only testing raw output
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("class=\"ui-autocomplete-input\""));
		}

		[TestMethod]
		public void AutoComplete_With_Custom_CSS_But_No_jQuery_Framework_CSS_Delivers_Correct_Classes()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac
				.Rendering
					.Compress()		// only testing raw output
					.Finish()
				.WithCss("bob")
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.StartsWith("<input id=\"ac\" class=\"bob\""));
		}

		[TestMethod]
		public void AutoComplete_With_Addition_CSS_Delivers_Is_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.WithCss("my-test-css-class")
				.Rendering
					.Compress()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("my-test-css-class"));
		}

		[TestMethod]
		public void AutoComplete_With_Addition_Attributes_Are_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete dlg = TestHelper.SetupSimpleAutoCompleteObject(resp);
						
			dlg
				.WithAttribute("test-attribute-1", "test-value-a")
				.WithAttribute("test-attribute-2", "test-value-b")
				.Rendering
					.Compress()		// only testing raw output
			;

			// Act - Force output we'd see on the web page
			dlg.Render();
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
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac.Rendering.Compress().ShowCSS();

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Script_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Rendering
					.SetAutoScript(false)			
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "<input id=\"ac\" autocomplete=\"off\" />";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

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
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

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
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac.Rendering.Compress().ShowCSS();

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Rendering
					.SetAutoScript(false)
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("id=\"ac\""));
		  Assert.IsFalse(html.Contains("$(document).ready("));
		}

	} // jAutoComplete_Tests

} // ns
