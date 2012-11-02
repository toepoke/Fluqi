using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jMenu;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Menu_Options_Tests 
	{

		[TestMethod]
		public void Ensure_Disabled_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Options
		      .SetDisabled(true)
		      .Finish()
		    .Rendering
		      .Compress();

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({disabled: true})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Icons_By_Enum_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Options
		      .SetIcons(Core.Icons.eIconClass.heart)
		      .Finish()
		    .Rendering
		      .Compress();

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({icons: { submenu: \"ui-icon-heart\" }})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Icons_By_String_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Options
		      .SetIcons("abcxyz")
		      .Finish()
		    .Rendering
		      .Compress();

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({icons: { submenu: \"abcxyz\" }})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Menus_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Options
		      .SetMenus("div")
		      .Finish()
		    .Rendering
		      .Compress();

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({menus: \"div\"})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_My_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Menu menu = TestHelper.SetupSimpleMenuObject(resp);

			// only testing raw output
			menu
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetMy(Fluqi.Core.Position.ePosition.Bottom, Fluqi.Core.Position.ePosition.Right)
					.Finish()
			;

			// Act - Force output we'd see on the web page
			menu.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({position: {my: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_At_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Menu menu = TestHelper.SetupSimpleMenuObject(resp);

			// only testing raw output
			menu
				.Options
					.Position
						.SetAt(Fluqi.Core.Position.ePosition.Bottom, Fluqi.Core.Position.ePosition.Right)
					.Finish()
				.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
			;

			// Act - Force output we'd see on the web page
			menu.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({position: {at: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_Collision_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Menu menu = TestHelper.SetupSimpleMenuObject(resp);

			// only testing raw output
			menu
				.Options
					.Position
						.SetCollision(Fluqi.Core.Collision.eCollision.Fit)
					.Finish()
				.Finish()
				.Rendering
					.Compress()
				.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			menu.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({position: {collision: \"fit\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_Of_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Menu menu = TestHelper.SetupSimpleMenuObject(resp);

			// only testing raw output
			menu
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetOf("#top-menu")
					.Finish()
				.Finish()
			;

			// Act - Force output we'd see on the web page
			menu.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({position: {of: \"#top-menu\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_My_And_At_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Menu menu = TestHelper.SetupSimpleMenuObject(resp);

			// only testing raw output
			menu
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetMy(Fluqi.Core.Position.ePosition.Bottom, Fluqi.Core.Position.ePosition.Right)
						.SetAt(Fluqi.Core.Position.ePosition.Bottom, Fluqi.Core.Position.ePosition.Right)
					.Finish()
				.Finish()
			;

			// Act - Force output we'd see on the web page
			menu.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({position: {my: \"bottom right\",at: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Role_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  // only testing raw output
		  menu
		    .Options
		      .SetRole("myRole")
		      .Finish()
		    .Rendering
		      .Compress();

		  TestHelper.ForceRender(menu);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myMenu\").menu({role: \"myRole\"})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

	}

} // ns
