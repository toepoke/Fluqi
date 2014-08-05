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
	public partial class SelectMenu_Options_Tests 
	{

		[TestMethod]
		public void Ensure_AppendTo_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  ctl
		    .Options
		      .SetAppendTo("#someElem")
		      .Finish()
		    .Rendering
		      .Compress()
				.Finish()
			;

		  TestHelper.ForceRender(ctl);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({appendTo: \"#someElem\"})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Disabled_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  ctl
		    .Options
		      .SetDisabled(true)
		      .Finish()
		    .Rendering
		      .Compress()
				.Finish()
			;

		  TestHelper.ForceRender(ctl);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({disabled: true})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Icons_By_Enum_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  ctl
		    .Options
		      .SetIcons(Core.Icons.eIconClass.heart)
		      .Finish()
		    .Rendering
		      .Compress()
				.Finish()
			;

		  TestHelper.ForceRender(ctl);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({icons: { button: \"ui-icon-heart\" }})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Icons_By_String_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  ctl
		    .Options
		      .SetIcons("abcxyz")
		      .Finish()
		    .Rendering
		      .Compress();

		  TestHelper.ForceRender(ctl);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({icons: { button: \"abcxyz\" }})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_My_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

			// only testing raw output
			ctl
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
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({position: {my: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_At_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

			// only testing raw output
			ctl
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
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({position: {at: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_Collision_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

			// only testing raw output
			ctl
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
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({position: {collision: \"fit\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_Of_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

			// only testing raw output
			ctl
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
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({position: {of: \"#top-menu\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Menu_Option_Position_With_My_And_At_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

			// only testing raw output
			ctl
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
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({position: {my: \"bottom right\",at: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Width_Option_Is_Added_To_Script_Definition()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  // only testing raw output
		  ctl
		    .Options
		      .SetWidth(222)
		      .Finish()
		    .Rendering
		      .Compress();

		  TestHelper.ForceRender(ctl);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#mySelectMenu\").selectmenu({width: 222})" + 
		      ";});" + 
		    "</script>";

		  Assert.IsTrue(html.Contains(expected));
		}

	}

} // ns
