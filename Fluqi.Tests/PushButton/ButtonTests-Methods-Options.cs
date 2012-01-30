using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jPushButton;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Button_Methods_Options_Tests
	{

		[TestMethod]
		public void Ensure_Text_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleButtonObject(resp);

		  ctl.Methods.GetText();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#btn\").button(\"option\",\"text\")", html);
		}

		[TestMethod]
		public void Ensure_SetText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleButtonObject(resp);

		  ctl.Methods.SetText(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#btn\").button(\"option\",\"text\",false)", html);
		}

		[TestMethod]
		public void Ensure_GetIcons_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleButtonObject(resp);

		  ctl.Methods.GetIcons();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#btn\").button(\"option\",\"icons\")", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleButtonObject(resp);

		  ctl.Methods.SetIcons("ui-icon-icon1", "ui-icon-icon2");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#btn\").button(\"option\",\"icons\",{ primary: 'ui-icon-icon1', secondary: 'ui-icon-icon2' })", html);
		}

		[TestMethod]
		public void Ensure_SetIcons_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleButtonObject(resp);

		  ctl.Methods.SetIcons(Core.Icons.eIconClass.alert, Core.Icons.eIconClass.info);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#btn\").button(\"option\",\"icons\",{ primary: 'ui-icon-alert', secondary: 'ui-icon-info' })", html);
		}

		[TestMethod]
		public void Ensure_Label_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleButtonObject(resp);

		  ctl.Methods.GetLabel();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#btn\").button(\"option\",\"label\")", html);
		}

		[TestMethod]
		public void Ensure_SetLabel_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleButtonObject(resp);

		  ctl.Methods.SetLabelJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#btn\").button(\"option\",\"label\",some_javascript_variable)", html);
		}
		
		[TestMethod]
		public void Ensure_SetLabel_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleButtonObject(resp);

		  ctl.Methods.SetLabelJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#btn\").button(\"option\",\"label\",some_javascript_variable)", html);
		}

	} // Button_Methods_Options_Tests

} // ns
