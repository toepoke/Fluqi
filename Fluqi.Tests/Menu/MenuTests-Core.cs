using System;
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
				.Items()
					.Add("Item 1")
				.Finish()
		    .Rendering
		      .Compress()
		      .ShowCSS()
		  ;

		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert - UL root
			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<ul id=\"myMenu\" class=\"ui-menu ui-widget ui-widget-content ui-corner-all\">"));
			// Assert - LI
		  Assert.AreEqual(1, Utils.NumberOfMatches(html, "<li class=\"ui-menu-item\"><a href=\"#\" class=\"ui-corner-all\">Item 1</a></li>") );
			// Assert - A
			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<a href=\"#\" class=\"ui-corner-all\">Item 1</a>") );
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
		        "$(\"#myMenu\").menu()" + 
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
		public void Add_With_Title_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Items()
		        .Add("toepoke")
		      .Back()
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
		      "<li><a href=\"#\">toepoke</a></li>" + 
		    "</ul>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Add_With_Divider_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.AddDivider()
				.Finish()
				.Rendering
					.SetRenderCSS(true)
					.Compress()
			;
			
		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<ul id=\"myMenu\" class=\"ui-menu ui-widget ui-widget-content ui-corner-all\">" + 
		      "<li class=\"ui-widget-content ui-menu-divider\"></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Add_With_Title_And_URL_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Items()
		        .Add("toepoke", "http://toepoke.co.uk")
		      .Back()
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

		[TestMethod]
		public void Add_With_Title_And_Icon_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Items()
		        .Add("toepoke", Core.Icons.eIconClass.home)
		      .Back()
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
		      "<li><a href=\"#\"><span class=\"ui-icon ui-icon-home\"></span>toepoke</a></li>" + 
		    "</ul>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Add_With_Title_And_URL_And_Icon_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Items()
		        .Add("toepoke", "http://toepoke.co.uk", Core.Icons.eIconClass.home)
		      .Back()
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
		      "<li><a href=\"http://toepoke.co.uk\"><span class=\"ui-icon ui-icon-home\"></span>toepoke</a></li>" + 
		    "</ul>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Overriding_UL_Adjusts_MarkUp_Appropriately()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Options
					.SetMenus("div")
					.Finish()
		    .Items()
		        .Add("Item 1")
		        .Add("Item 2")
		        .Add("Item 3")
		        .Add("Item 4")
		        .Add("Item 5")
		      .Back()
		    .Finish()
		  .Rendering
		    .Compress()
		  ;

		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<div id=\"myMenu\">" + 
		      "<li><a href=\"#\">Item 1</a></li>" + 
		      "<li><a href=\"#\">Item 2</a></li>" + 
		      "<li><a href=\"#\">Item 3</a></li>" + 
		      "<li><a href=\"#\">Item 4</a></li>" + 
		      "<li><a href=\"#\">Item 5</a></li>" + 
		    "</div>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Overriding_LI_Adjusts_MarkUp_Appropriately()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Options
					.SetMenus("div")
					.Finish()
		    .Items()
		        .Add("Item 1")
		        .Add("Item 2")
		        .Add("Item 3")
							.Configure()
								.SetTag("span")
							.Finish()
		        .Add("Item 4")
		        .Add("Item 5")
		      .Back()
		    .Finish()
		  .Rendering
		    .Compress()
		  ;

		  TestHelper.ForceRender(menu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<div id=\"myMenu\">" + 
		      "<li><a href=\"#\">Item 1</a></li>" + 
		      "<li><a href=\"#\">Item 2</a></li>" + 
		      "<span><a href=\"#\">Item 3</a></span>" + 
		      "<li><a href=\"#\">Item 4</a></li>" + 
		      "<li><a href=\"#\">Item 5</a></li>" + 
		    "</div>";

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
		public void SubMenu_Menu_At_Level_3_MarkUp_Is_Correct()
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
							.SubMenu()
								.Add("Item 3-4-1")
								.Add("Item 3-4-2")
								.Add("Item 3-4-3")
								.Add("Item 3-4-4")
							.Back()
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
				      "<li><a href=\"#\">Item 3-4</a>" + 
								"<ul>" + 
						      "<li><a href=\"#\">Item 3-4-1</a></li>" + 
						      "<li><a href=\"#\">Item 3-4-2</a></li>" + 
						      "<li><a href=\"#\">Item 3-4-3</a></li>" + 
						      "<li><a href=\"#\">Item 3-4-4</a></li>" + 
								"</ul>" +
							"</li>" + 
				      "<li><a href=\"#\">Item 3-5</a></li>" + 
						"</ul>" +
					"</li>" + 
		      "<li><a href=\"#\">Item 4</a></li>" + 
		      "<li><a href=\"#\">Item 5</a></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Grouped_Menu_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.AddHtml("<strong>Group 1</strong>")
					.Add("Aberdeen")
					.Add("Ada")
					.Add("Adamsville")
					.Add("Addyston")
					.AddDivider()
					.AddHtml("<strong>Group 2</strong>")
					.Add("Delphi")
						.SubMenu()
							.Add("Ada")
							.Add("Saarland")
							.Add("Salzburg")
						.Back()
					.Add("Saarland")
					.AddDivider()
					.AddHtml("<strong>Group 3</strong>")
					.Add("Salzburg")
						.SubMenu()
							.Add("Delphi")
								.SubMenu()
									.Add("Ada")
									.AddDivider()
									.Add("Saarland")
									.AddDivider()
									.Add("Salzburg")
									.AddDivider()
								.Back()
							.Add("Delphi")
								.SubMenu()
									.Add("Ada")
									.Add("Saarland")
									.Add("Salzburg")
								.Back()
							.Add("Perch")
							.Back()
						.Back()
					.Add("Amesville")
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
		      "<li><strong>Group 1</strong></li>" + 
		      "<li><a href=\"#\">Aberdeen</a></li>" + 
		      "<li><a href=\"#\">Ada</a></li>" + 
		      "<li><a href=\"#\">Adamsville</a></li>" + 
		      "<li><a href=\"#\">Addyston</a></li>" + 
		      "<li></li>" + 
					"<li><strong>Group 2</strong></li>" +
					"<li>" +
						"<a href=\"#\">Delphi</a>" + 
						"<ul>" + 
				      "<li><a href=\"#\">Ada</a></li>" + 
				      "<li><a href=\"#\">Saarland</a></li>" + 
				      "<li><a href=\"#\">Salzburg</a></li>" + 
						"</ul>" +
					"</li>" + 
		      "<li><a href=\"#\">Saarland</a></li>" + 
		      "<li></li>" + 
					"<li><strong>Group 3</strong></li>" +
					"<li>" +
						"<a href=\"#\">Salzburg</a>" + 
						"<ul>" +
							"<li>" +
								"<a href=\"#\">Delphi</a>" + 
								"<ul>" +
									"<li><a href=\"#\">Ada</a></li>" + 
									"<li></li>" + 
									"<li><a href=\"#\">Saarland</a></li>" + 
									"<li></li>" + 
									"<li><a href=\"#\">Salzburg</a></li>" + 
									"<li></li>" + 
								"</ul>" +
							"</li>" + 
							"<li>" +
								"<a href=\"#\">Delphi</a>" + 
								"<ul>" +
									"<li><a href=\"#\">Ada</a></li>" + 
									"<li><a href=\"#\">Saarland</a></li>" + 
									"<li><a href=\"#\">Salzburg</a></li>" + 
								"</ul>" +
							"</li>" + 
							"<li><a href=\"#\">Perch</a></li>" + 
						"</ul>" +
					"</li>" + 
					"<li><a href=\"#\">Amesville</a></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Override_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);
			string addressTemplate = 
				"<a href=\"#\">" +
					"<span class=\"address-header\">{0}</span>" + 
					"<span class=\"address-content\">{1}</span>" + 
					"<span class=\"address-content\">{2}</span>" +
				"</a>";

		  // only testing raw output
		  menu
				.WithCss("menuElement")
				.Options
					.SetMenus("div")
				.Finish()
				.Items()
					.AddHtml(addressTemplate, "John Doe", "78 West Main St Apt 3A", "Bloomsburg, PA 12345")
						.Configure()
							.SetTag("div")
							.WithCss("address-item")
						.Finish()
					.AddHtml(addressTemplate, "Jane Doe", "78 West Main St Apt 3A", "Bloomsburg, PA 12345")
						.Configure()
							.SetTag("div")
							.WithCss("address-item")
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
		    "<div id=\"myMenu\" class=\"menuElement\">" + 
					"<div class=\"address-item\">" +
						"<a href=\"#\">" + 
							"<span class=\"address-header\">John Doe</span>" +
							"<span class=\"address-content\">78 West Main St Apt 3A</span>" +
							"<span class=\"address-content\">Bloomsburg, PA 12345</span>" +
						"</a>" + 
					"</div>" + 
					"<div class=\"address-item\">" +
						"<a href=\"#\">" + 
							"<span class=\"address-header\">Jane Doe</span>" +
							"<span class=\"address-content\">78 West Main St Apt 3A</span>" +
							"<span class=\"address-content\">Bloomsburg, PA 12345</span>" +
						"</a>" + 
					"</div>" + 
		    "</div>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Add_With_Url_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.Add("toepoke", "http://toepoke.co.uk")
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
							.SetIcon("ui-icon-home")
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
		public void Menu_SetTitle_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.Add("Phone Home")
						.Configure()
							.SetTitle("Mobile Phone") // should override "Phone Home"
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
		      "<li><a href=\"#\">Mobile Phone</a></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_SetTargetURL_Renders_Correctly()
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

		[TestMethod]
		public void Menu_Disabled_MenuItem_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
				.Items()
					.Add("toepoke")
						.Configure()
							.SetDisabled()
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
		      "<li class=\"ui-state-disabled\"><a href=\"#\">toepoke</a></li>" + 
		    "</ul>";

		  Assert.IsTrue(html.Contains(expected));
		}




	}

} // ns
