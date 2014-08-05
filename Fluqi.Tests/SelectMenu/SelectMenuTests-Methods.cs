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
	public partial class SelectMenu_Methods_Tests 
	{
		[TestMethod]
		public void Ensure_Close_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.Close();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"close\")", html);
		}

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.Destroy();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.Disable();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.Enable();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Instance_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.Instance();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"instance\")", html);
		}

		[TestMethod]
		public void Ensure_MenuWidget_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.MenuWidget();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"menuWidget\")", html);
		}

		[TestMethod]
		public void Ensure_Open_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.Open();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"open\")", html);
		}
		
		[TestMethod]
		public void Ensure_Refresh_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.Refresh();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"refresh\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleSelectMenuObject(resp);

		  ctl.Methods.Widget();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#mySelectMenu\").selectmenu(\"widget\")", html);
		}

	}

} // ns
