using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jTab;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Tab_Methods_Options_Tests
	{

		[TestMethod]
		public void Ensure_GetCache_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetCache();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"cache\")", html);
		}

		[TestMethod]
		public void Ensure_SetCache_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetCache(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"cache\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetCollapsible_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetCollapsible();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"collapsible\")", html);
		}

		[TestMethod]
		public void Ensure_SetCollaspsible_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetCollapsible(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"collapsible\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetCoookie_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetCookie();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"cookie\")", html);
		}

		[TestMethod]
		public void Ensure_SetCookie_Expires_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetCookieExpiry(3);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"cookie\",{ expires: 3 })", html);
		}

		[TestMethod]
		public void Ensure_SetCookie_Path_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetCookiePath("/my-folder");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"cookie\",{ path: '/my-folder' })", html);
		}

		[TestMethod]
		public void Ensure_SetCookie_Domain_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetCookieDomain("BLOG.TOEPOKE.CO.UK");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"cookie\",{ domain: 'BLOG.TOEPOKE.CO.UK' })", html);
		}

		[TestMethod]
		public void Ensure_SetCookie_AsSecure_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetCookieSecure(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"cookie\",{ secure: true })", html);
		}

		[TestMethod]
		public void Ensure_SetCookie_AsUnSecure_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetCookieSecure(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"cookie\",{ secure: false })", html);
		}

		[TestMethod]
		public void Ensure_GetEvent_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetEvent();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"event\")", html);
		}

		[TestMethod]
		public void Ensure_SetEvent_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetEvent(Core.BrowserEvent.eBrowserEvent.DblClick);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"event\",\"dblclick\")", html);
		}
				
		[TestMethod]
		public void Ensure_SetEvent_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetEventJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"event\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetEvent_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetEvent("dblclick");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"event\",\"dblclick\")", html);
		}

		[TestMethod]
		public void Ensure_GetEffect_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetEffect();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"fx\")", html);
		}

		[TestMethod]
		public void Ensure_SetEffect_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetEffect(123);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"fx\",123)", html);
		}

		[TestMethod]
		public void Ensure_SetEffect_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetEffect(Core.Speed.eSpeed.Fast);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"fx\",\"fast\")", html);
		}

		[TestMethod]
		public void Ensure_GetIdPrefix_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetIdPrefix();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"idPrefix\")", html);
		}

		[TestMethod]
		public void Ensure_SetIdPrefix_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetIdPrefixJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"idPrefix\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetIdPrefix_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetIdPrefix("ui-tabs-new");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"idPrefix\",\"ui-tabs-new\")", html);
		}

		[TestMethod]
		public void Ensure_GetPanelTemplate_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetPanelTemplate();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"panelTemplate\")", html);
		}

		[TestMethod]
		public void Ensure_SetPanelTemplate_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetPanelTemplateJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"panelTemplate\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetPanelTemplate_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetPanelTemplate("<h3>bob</h3>");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"panelTemplate\",\"<h3>bob</h3>\")", html);
		}

		[TestMethod]
		public void Ensure_GetSpinner_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetSpinner();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"spinner\")", html);
		}

		[TestMethod]
		public void Ensure_SetSpinner_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetSpinnerJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"spinner\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetSpinner_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetSpinner("<span>Loading...</span>");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"spinner\",\"<span>Loading...</span>\")", html);
		}

		[TestMethod]
		public void Ensure_GetSelected_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetSelected();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"selected\")", html);
		}

		[TestMethod]
		public void Ensure_SetSelected_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetSelected(3);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"selected\",3)", html);
		}

		[TestMethod]
		public void Ensure_GetTabTemplate_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetTabTemplate();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"tabTemplate\")", html);
		}

		[TestMethod]
		public void Ensure_SetTabTemplate_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetTabTemplateJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"tabTemplate\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetTabTemplate_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetTabTemplate("<div><p>my new tab</p></div>");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"tabTemplate\",\"<div><p>my new tab</p></div>\")", html);
		}

	} // jTab_Tests

} // ns
