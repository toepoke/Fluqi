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
	public partial class Tab_Methods_Tests
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs.Methods.Destroy();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs.Methods.Disable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Panes_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs.Methods.Disable(1, 3);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"disable\",[ 1, 3 ])", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs.Methods.Enable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Pane_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs.Methods.Enable(3);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"enable\",3)", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs.Methods.Widget();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_Refresh_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs.Methods.Refresh();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"refresh\")", html);
		}

		[TestMethod]
		public void Ensure_Load_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs.Methods.Load(3);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"load\",3)", html);
		}

	} // jTab_Tests

} // ns
