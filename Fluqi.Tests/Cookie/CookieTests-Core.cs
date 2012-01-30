using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Utilities.jCookie;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Cookie_Core_Tests
	{

		[TestMethod]
		public void Auto_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl.Rendering.Compress();

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$.cookie()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Script_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl.Rendering
				.Compress()
				.SetAutoScript(false)			
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "$.cookie();";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl.Rendering
				.Compress()
				.SetAutoScript(false)			
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			ctl.RenderStartUpScript();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$.cookie()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl.Rendering
				.Compress()
				.SetAutoScript(false)			
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$.cookie()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl.Rendering.Compress();

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "$.cookie()";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl.Rendering
				.SetAutoScript(false)
				.Compress()
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("$.cookie"));
		  Assert.IsFalse(html.Contains("$(document).ready("));
		}

	} // Cookie_Tests

} // ns
