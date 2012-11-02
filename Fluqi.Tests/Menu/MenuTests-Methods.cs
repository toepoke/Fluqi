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
	public partial class Menu_Methods_Tests 
	{
		[TestMethod]
		public void Ensure_Blur_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Blur();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"blur\")", html);
		}

		[TestMethod]
		public void Ensure_Collapse_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Collapse();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"collapse\")", html);
		}

		[TestMethod]
		public void Ensure_CollapseAll_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.CollapseAll();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"collapseAll\")", html);
		}

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Destroy();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Disable();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Enable();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Expand_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Expand();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"expand\")", html);
		}

		[TestMethod]
		public void Ensure_Focus_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Focus("menu.find('.ul-menu-item:last')");

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"focus\", null, menu.find('.ul-menu-item:last'))", html);
		}

		[TestMethod]
		public void Ensure_IsFirstItem_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.IsFirstItem();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"isFirstItem\")", html);
		}
		
		[TestMethod]
		public void Ensure_IsLastItem_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.IsLastItem();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"isLastItem\")", html);
		}

		[TestMethod]
		public void Ensure_Next_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Next();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"next\")", html);
		}

		[TestMethod]
		public void Ensure_NextPage_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.NextPage();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"nextPage\")", html);
		}

		[TestMethod]
		public void Ensure_Previous_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Previous();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"previous\")", html);
		}

		[TestMethod]
		public void Ensure_PreviousPage_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.PreviousPage();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"previousPage\")", html);
		}

		[TestMethod]
		public void Ensure_Refresh_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Refresh();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"refresh\")", html);
		}

		[TestMethod]
		public void Ensure_Select_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Select();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"select\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  Menu menu = TestHelper.SetupSimpleMenuObject(resp);

		  menu.Methods.Widget();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myMenu\").menu(\"widget\")", html);
		}

	}

} // ns
