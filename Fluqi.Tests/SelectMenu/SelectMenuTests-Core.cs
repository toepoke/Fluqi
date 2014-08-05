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
using Fluqi.Widget.jSelectMenu;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class SelectMenu_Core_Tests 
	{

		[TestMethod]
		public void With_No_CSS_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			SelectMenu m = TestHelper.SetupSimpleSelectMenuObject(resp);

			// only testing raw output
			m.Rendering.Compress();

			TestHelper.ForceRender(m);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"mySelectMenu\""));
		}

		/// THE "SelectMenu" CONTROL REPLACES THE UNDERLYING SELECT CONTROL.
		/// BASICALLY IT CAN'T BE USED IN ISOLATION SO HAVING THE CORRECT CSS CLASSES IS OF NO VALUE
		//[TestMethod]
		//public void With_Full_CSS_Delivers_Correct_CSS_Classes()
		//{
		//  throw new NotImplementedException();

		//  // Arrange
		//  var resp = new MockWriter();
		//  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		//  // only testing raw output
		//  //selectMenu
		//  //  .Items()
		//  //    .Add("Item 1")
		//  //  .Finish()
		//  //  .Rendering
		//  //    .Compress()
		//  //    .ShowCSS()
		//  //;

		//  TestHelper.ForceRender(selectMenu);
			
		//  // Act - Force output we'd see on the web page
		//  string html = resp.Output.ToString();

		//  // Assert - UL root
		//  Assert.AreEqual(1, Utils.NumberOfMatches(html, "<ul id=\"mySelectMenu\" class=\"ui-menu ui-widget ui-widget-content ui-corner-all\">"));
		//  // Assert - LI
		//  Assert.AreEqual(1, Utils.NumberOfMatches(html, "<li class=\"ui-menu-item\"><a href=\"#\" class=\"ui-corner-all\">Item 1</a></li>") );
		//  // Assert - A
		//  Assert.AreEqual(1, Utils.NumberOfMatches(html, "<a href=\"#\" class=\"ui-corner-all\">Item 1</a>") );
		//}
		
		[TestMethod]
		public void With_Addition_CSS_Delivers_Is_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);
			
			selectMenu
				.WithCss("select-extra-css")
				.Items()
					.Add("Item 1", "1")
						.Configure()
							.WithCss("option-extra-css")
						.Finish()
					.Finish()
			;

		  TestHelper.ForceRender(selectMenu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("select-extra-css"));
		  Assert.IsTrue(html.Contains("option-extra-css"));
		}
		
		[TestMethod]
		public void With_Addition_Attributes_Are_Rendered()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

			selectMenu
				.WithAttribute("name", "select-name")
				.Items()
					.Add("Item 1", "1")
						.Configure()
							.WithAttribute("data-class", "podcast")
						.Finish()
					.Finish()
			;

		  TestHelper.ForceRender(selectMenu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("name=\"select-name\""));
		  Assert.IsTrue(html.Contains("data-class=\"podcast\""));
		}

		[TestMethod]
		public void With_Addition_Attributes_Are_Rendered_With_Encoding()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

			selectMenu
				.WithAttribute("name", "select-name")
				.Items()
					.Add("Item 1", "1")
						.Configure()
							.WithAttribute("data-style", "background-image: url('http://gravatar.com/avatar/xyz?a=b&x=y')")
						.Finish()
					.Finish()
			;

		  TestHelper.ForceRender(selectMenu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("data-style=\"background-image: url(&#39;http://gravatar.com/avatar/xyz?a=b&amp;x=y&#39;)\""));
		}


		[TestMethod]
		public void Auto_Script_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  selectMenu.Rendering.Compress();

		  TestHelper.ForceRender(selectMenu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Script_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  selectMenu.Rendering
		    .SetAutoScript(false)
		    .SetPrettyRender(false)
		  ;

		  TestHelper.ForceRender(selectMenu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "<select id=\"mySelectMenu\"></select>";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  selectMenu.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  TestHelper.ForceRender(selectMenu);

		  selectMenu.RenderStartUpScript();
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_Auto_Script_Is_Off()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  selectMenu
		    .Rendering
		      .SetAutoScript(false)
		      .Compress()
		  ;

		  TestHelper.ForceRender(selectMenu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  selectMenu.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  selectMenu.RenderStartUpScript();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "$(\"#mySelectMenu\").selectmenu();";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  selectMenu.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  TestHelper.ForceRender(selectMenu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.IsTrue(html.Contains("id=\"mySelectMenu\""));
		  Assert.IsFalse(html.Contains("$(document).ready("));
		}

		[TestMethod]
		public void Add_With_Title_MarkUp_Is_Correct()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
			selectMenu
				.Items()
					.Add("Item 1", "1")
					.Finish()
				.Rendering
					.Compress()
				.Finish()
			;


		  TestHelper.ForceRender(selectMenu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<select id=\"mySelectMenu\">" + 
		      "<option value=\"1\">Item 1</option>" + 
		    "</select>";
		  Assert.IsTrue(html.Contains(expected));
		}
		
		[TestMethod]
		public void SetTitle_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
			//selectMenu
			//  .Items()
			//    .Add("Phone Home")
			//      .Configure()
			//        .SetTitle("Mobile Phone") // should override "Phone Home"
			//        .Finish()
			//  .Finish()
			//  .Rendering
			//    .Compress()
			//;

			selectMenu
				.Items()
					.Add("Item 1", "1")
						.Configure()
							.SetTitle("Item X")  // should override "Item 1"
							.SetValue(99)        // should override "99"
						.Finish()
					.Finish()
				.Rendering
					.Compress()
					.Finish()
			;

			
		  TestHelper.ForceRender(selectMenu);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<select id=\"mySelectMenu\">" + 
		      "<option value=\"99\">Item X</option>" + 
		    "</select>";

		  Assert.IsTrue(html.Contains(expected));
		}

		//[TestMethod]
		//public void Disabled_MenuItem_Renders_Correctly()
		//{
		//  // Arrange
		//  var resp = new MockWriter();
		//  SelectMenu selectMenu = TestHelper.SetupSimpleSelectMenuObject(resp);

		//  // only testing raw output
		//  selectMenu
		//    .Items()
		//      .Add("Item 1", "1")
		//        .Configure()
		//          .SetDisabled()
		//        .Finish()
		//      .Finish()
		//    .Rendering
		//      .Compress()
		//  ;
			
		//  TestHelper.ForceRender(selectMenu);
			
		//  // Act - Force output we'd see on the web page
		//  string html = resp.Output.ToString();

		//  // Assert
		//  string expected = 
		//    "<select id=\"mySelectMenu\">" + 
		//      "<option class=\"ui-state-disabled\">Item 1</option>" + 
		//    "</select>";

		//  Assert.IsTrue(html.Contains(expected));
		//}

	}

} // ns
