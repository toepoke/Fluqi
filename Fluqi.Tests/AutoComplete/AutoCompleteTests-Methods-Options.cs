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
	public partial class AutoComplete_Methods_Options_Tests
	{

		[TestMethod]
		public void Ensure_GetAppendTo_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ac.Methods.GetAppendTo();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"appendTo\")", html);
		}

		[TestMethod]
		public void Ensure_SetAppendTo_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ac.Methods.SetAppendToJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"appendTo\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetAppendTo_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ac.Methods.SetAppendTo("body");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"appendTo\",\"body\")", html);
		}

		[TestMethod]
		public void Ensure_GetAutoFocus_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.GetAutoFocus();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"autoFocus\")", html);
		}

		[TestMethod]
		public void Ensure_SetAutoFocus_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetAutoFocus(false);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"autoFocus\",false)", html);
		}

		[TestMethod]
		public void Ensure_GetDelay_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.GetDelay();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"delay\")", html);
		}

		[TestMethod]
		public void Ensure_SetDelay_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetDelay(123);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"delay\",123)", html);
		}

		[TestMethod]
		public void Ensure_GetMinLength_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.GetMinLength();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"minLength\")", html);
		}

		[TestMethod]
		public void Ensure_SetMinLength_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetMinLength(234);
			
		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"minLength\",234)", html);
		}

		[TestMethod]
		public void Ensure_GetPosition_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.GetPosition();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"position\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"position\",\"right\")", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Top, Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"position\",[ 'top', 'right' ])", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetPositionJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"position\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetPosition("center");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"position\",\"center\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetPosition("top", "right");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"position\",[ 'top', 'right' ])", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

		  ctl.Methods.SetPosition(222, 333);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"position\",[ 222, 333 ])", html);
		}

		[TestMethod]
		public void Ensure_SetSource_By_String_List_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ctl.Methods.SetSource("http://some.url");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"source\",\"http://some.url\")", html);
		}

		[TestMethod]
		public void Ensure_SetSource_By_Source_Items_List_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleAutoCompleteObject(resp);

			ctl.Methods.SetSource("item #1", "item #2", "item #3", "item #4");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#ac\").autocomplete(\"option\",\"source\",[ \"item #1\", \"item #2\", \"item #3\", \"item #4\" ])", html);
		}

	} // AutoComplete_Methods_Options_Tests

} // ns
