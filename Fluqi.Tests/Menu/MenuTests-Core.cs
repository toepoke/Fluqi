﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;
using Fluqi.Widget.jMenu;
using Fluqi.Widget.jMenuItem;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Menu_Core_Tests 
	{

		[TestMethod]
		public void Menu_With_No_CSS_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			Menu m = TestHelper.SetupSimpleMenuObject(resp);

			// only testing raw output
			m.Rendering.Compress();

			TestHelper.ForceRender(m);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"myMenu\""));
		}


		[TestMethod]
		public void Menu_With_Full_CSS_Delivers_Correct_CSS_Classes()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Rendering
		      .Compress()
		      .ShowCSS()
		  ;

		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("id=\"myMenu\""));

		  Assert.AreEqual(1, Utils.NumberOfMatches(html, "class=\"ui-menu") );
		}
		
		[TestMethod]
		public void Menu_With_Addition_CSS_Delivers_Is_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu
		    .WithCss("my-extra-css-class")
		    .Rendering
		    .Compress()		// only testing raw output
		  ;

		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("my-extra-css-class"));
		}
		
		[TestMethod]
		public void Menu_With_Addition_Attributes_Are_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu
		    .WithAttribute("test-attribute-1", "test-value-a")
		    .WithAttribute("test-attribute-2", "test-value-b")
		    .Rendering
		    .Compress()		// only testing raw output
		  ;

		  TestHelper.ForceRender(menu);
			
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
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering.Compress();

		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Script_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering
		    .SetAutoScript(false)
		    .SetPrettyRender(false)
		  ;

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "<ul id=\"myMenu\"></ul>";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  TestHelper.ForceRender(menu);

		  menu.RenderStartUpScript();
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_Auto_Script_Is_Off()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Rendering
		      .SetAutoScript(false)
		      .Compress()
		  ;

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").slider()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  menu.RenderStartUpScript();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "$(\"#myMenu\").menu();";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("id=\"myMenu\""));
		  Assert.IsFalse(html.Contains("$(document).ready("));
		}

		[TestMethod]
		public void Simple_Menu_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Items()
		        .Add("Item 1")
		        .Add("Item 2")
		        .Add("Item 3")
		        .Add("Item 4")
		        .Add("Item 5")
		      .Back()
		    .Finish()
		    //.Menu()
		  .Rendering
		    .Compress()
		  ;

		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<ul id=\"myMenu\">" + 
		      "<li><a href=\"#\">Item 1</a></li>" + 
		      "<li><a href=\"#\">Item 2</a></li>" + 
		      "<li><a href=\"#\">Item 3</a></li>" + 
		      "<li><a href=\"#\">Item 4</a></li>" + 
		      "<li><a href=\"#\">Item 5</a></li>" + 
		    "</ul>";
		  Assert.IsTrue(html.Contains(expected));
		}
		
		[TestMethod]
		public void SubMenu_Menu_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.Add("Item 1")
					.Add("Item 2")
					.Add("Item 3")
					.SubMenu()
						.Add("Item 3-1")
						.Add("Item 3-2")
						.Add("Item 3-3")
						.Add("Item 3-4")
						.Add("Item 3-5")
					.Back()
					.Add("Item 4")
					.Add("Item 5")
				.Finish()
				.Rendering
					.Compress()
			;
			
		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<ul id=\"myMenu\">" + 
		      "<li><a href=\"#\">Item 1</a></li>" + 
		      "<li><a href=\"#\">Item 2</a></li>" + 
		      "<li><a href=\"#\">Item 3</a>" + 
						"<ul>" + 
				      "<li><a href=\"#\">Item 3-1</a></li>" + 
				      "<li><a href=\"#\">Item 3-2</a></li>" + 
				      "<li><a href=\"#\">Item 3-3</a></li>" + 
				      "<li><a href=\"#\">Item 3-4</a></li>" + 
				      "<li><a href=\"#\">Item 3-5</a></li>" + 
						"</ul>" +
					"</li>" + 
		      "<li><a href=\"#\">Item 4</a></li>" + 
		      "<li><a href=\"#\">Item 5</a></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_With_Icons_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.Add("Phone Home")
						.Configure()
							.SetIcon(Core.Icons.eIconClass.home)
							.Finish()
				.Finish()
				.Rendering
					.Compress()
			;
			
		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<ul id=\"myMenu\">" + 
		      "<li><a href=\"#\"><span class=\"ui-icon ui-icon-home\"></span>Phone Home</a></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_With_Icons_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.Add("Phone Home")
						.Configure()
							.SetIcon("home")
							.Finish()
				.Finish()
				.Rendering
					.Compress()
			;
			
		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<ul id=\"myMenu\">" + 
		      "<li><a href=\"#\"><span class=\"ui-icon ui-icon-home\"></span>Phone Home</a></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Set_TargetURL_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.Add("toepoke")
						.Configure()
							.SetTargetURL("http://toepoke.co.uk")
							.Finish()
				.Finish()
				.Rendering
					.Compress()
			;
			
		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<ul id=\"myMenu\">" + 
		      "<li><a href=\"http://toepoke.co.uk\">toepoke</a></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}
	}

} // ns
