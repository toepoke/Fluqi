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
	public partial class Button_Methods_Tests
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			btn.Methods.Destroy();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#btn\").button(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			btn.Methods.Disable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#btn\").button(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			btn.Methods.Enable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#btn\").button(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			btn.Methods.Widget();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#btn\").button(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_Refresh_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			btn.Methods.Refresh();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#btn\").button(\"refresh\")", html);
		}

	} // jButton_Tests

} // ns
