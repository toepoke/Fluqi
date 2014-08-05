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
	public partial class SelectMenu_Methods_Options_Tests 
	{
		[TestMethod]
		public void Ensure_GetAppendTo_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.GetAppendTo();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"appendTo\")", html);
		}

		[TestMethod]
		public void Ensure_SetAppendTo_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetAppendTo("#someElem");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"appendTo\",\"#someElem\")", html);
		}

		[TestMethod]
		public void Ensure_GetDisabled_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.GetDisabled();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"disabled\")", html);
		}

		[TestMethod]
		public void Ensure_SetDisabled_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetDisabled(true);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"disabled\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetPosition_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.GetPosition();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"position\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"position\",\"right\")", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Top, Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"position\",[ 'top', 'right' ])", html);
		}
		
		[TestMethod]
		public void Ensure_SetPosition_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetPositionJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"position\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetPosition("center");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"position\",\"center\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetPosition("top", "right");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"position\",[ 'top', 'right' ])", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetPosition(222, 333);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"position\",[ 222, 333 ])", html);
		}

		[TestMethod]
		public void Ensure_GetWidth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.GetWidth();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"width\")", html);
		}

		[TestMethod]
		public void Ensure_SetWidth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetWidth(200);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"width\",200)", html);
		}

		[TestMethod]
		public void Ensure_GetIcons_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.GetIcons();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"icons\")", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetIcons(Core.Icons.eIconClass.heart);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"icons\",{ button: \"ui-icon-heart\"})", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.SetIcons("abcxyz");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"option\",\"icons\",{ button: \"abcxyz\"})", html);
		}

	}

} // ns

