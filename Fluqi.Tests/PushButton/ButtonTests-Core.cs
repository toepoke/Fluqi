using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jPushButton;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Button_Core_Tests
	{
		
		[TestMethod]
		public void Button_With_No_CSS_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"btn\""));
		}
		
		[TestMethod]
		public void Button_RenderAs_Button_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert - <button ..>my button label</button>
			Assert.IsTrue(html.Contains(">my button label</button>"));
		}

		[TestMethod]
		public void Button_RenderAs_Hyperlink_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.RenderAsHyperlink("https://toepoke.co.uk")
				.Rendering				
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert - <button ..>my button label</button>
			Assert.IsTrue(html.Contains(">my button label</a>"));
			Assert.IsTrue(html.Contains("https://toepoke.co.uk"));
		}

		[TestMethod]
		public void Button_RenderAs_ResetButton_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.RenderAsResetButton()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("<input type=\"reset\""));
			Assert.IsTrue(html.Contains("value=\"my button label\""));
		}

		[TestMethod]
		public void Button_RenderAs_SubmitButton_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.RenderAsSubmitButton()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("<input type=\"submit\""));
			Assert.IsTrue(html.Contains("value=\"my button label\""));
		}

		[TestMethod]
		public void Button_With_Full_CSS_Delivers_Correct_CSS_Classes()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			btn
				.Rendering
					.ShowCSS()
					.Compress()		// only testing raw output
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("class=\"ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover\""));
		}


		[TestMethod]
		public void Button_With_Addition_CSS_Delivers_Is_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.WithCss("my-test-css-class")
				.Rendering
					.Compress()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("my-test-css-class"));
		}

		[TestMethod]
		public void Button_With_Addition_Attributes_Are_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton dlg = TestHelper.SetupSimpleButtonObject(resp);
						
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
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Script_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.SetAutoScript(false)			
				.Finish()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "<button id=\"btn\">my button label</button>";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
					.ShowCSS()
					.SetAutoScript(false)			
				.Finish()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			btn.RenderStartUpScript();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
					.ShowCSS()
					.SetAutoScript(false)			
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "$(\"#btn\").button()";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn.Rendering
				.SetAutoScript(false)
				.Compress()
				.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("id=\"btn\""));
		  Assert.IsFalse(html.Contains("$(document).ready("));
		}

	} // jButton_Tests

} // ns
