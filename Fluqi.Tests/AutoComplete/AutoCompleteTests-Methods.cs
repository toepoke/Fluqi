using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jAutoComplete;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class AutoComplete_Methods_Tests
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac.Methods.Destroy();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac.Methods.Disable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac.Methods.Enable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac.Methods.Widget();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_Search_With_Quotes_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac.Methods.Search("xyz");

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"search\",\"xyz\")", html);
		}

		[TestMethod]
		public void Ensure_Search_Without_Quotes_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac.Methods.SearchJS("some_javascript_variable");

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"search\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_Close_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ac.Methods.Close();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"close\")", html);
		}

	} // jAutoComplete_Tests

} // ns
