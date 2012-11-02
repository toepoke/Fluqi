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
	public partial class Menu_Methods_Options_Tests 
	{

		[TestMethod]
		public void Ensure_GetDisabled_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.GetDisabled();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"disabled\")", html);
		}

		[TestMethod]
		public void Ensure_SetDisabled_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetDisabled(true);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"disabled\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetIcons_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.GetIcons();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"icons\")", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetIcons(Core.Icons.eIconClass.heart);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"icons\",{ submenu: \"ui-icon-heart\"})", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetIcons("abcxyz");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"icons\",{ submenu: \"abcxyz\"})", html);
		}

		[TestMethod]
		public void Ensure_GetMenus_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.GetMenus();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"menus\")", html);
		}

		[TestMethod]
		public void Ensure_SetMenus_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetMenus("dd");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"menus\",\"dd\")", html);
		}

		[TestMethod]
		public void Ensure_GetPosition_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.GetPosition();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"position\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"position\",\"right\")", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Top, Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"position\",[ 'top', 'right' ])", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetPositionJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"position\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetPosition("center");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"position\",\"center\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetPosition("top", "right");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"position\",[ 'top', 'right' ])", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetPosition(222, 333);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"position\",[ 222, 333 ])", html);
		}

		[TestMethod]
		public void Ensure_GetRole_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.GetRole();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"role\")", html);
		}

		[TestMethod]
		public void Ensure_SetRole_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleMenuObject(resp);

		  ctl.Methods.SetRole("listbox");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"option\",\"role\",\"listbox\")", html);
		}

	}

} // ns

