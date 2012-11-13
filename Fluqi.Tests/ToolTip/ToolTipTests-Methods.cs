using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jToolTip;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class ToolTip_Methods_Tests 
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip ToolTip = TestHelper.SetupSimpleToolTipObject(resp);

		  ToolTip.Methods.Destroy();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip ToolTip = TestHelper.SetupSimpleToolTipObject(resp);

		  ToolTip.Methods.Disable();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip ToolTip = TestHelper.SetupSimpleToolTipObject(resp);

		  ToolTip.Methods.Enable();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip ToolTip = TestHelper.SetupSimpleToolTipObject(resp);

		  ToolTip.Methods.Widget();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_Open_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip ToolTip = TestHelper.SetupSimpleToolTipObject(resp);

		  ToolTip.Methods.Open();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"open\")", html);
		}

		[TestMethod]
		public void Ensure_Close_Method_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip ToolTip = TestHelper.SetupSimpleToolTipObject(resp);

		  ToolTip.Methods.Close();

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"close\")", html);
		}
		
	}

} // ns
