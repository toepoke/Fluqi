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
	public partial class AutoComplete_Options_Tests
	{

		[TestMethod]
		public void Ensure_Multiple_Options_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetDisabled(true)
					.SetMinimumLength(3)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({disabled: true,source: ['c++', 'java', 'php'],minLength: 3})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}
	
		[TestMethod]
		public void AutoComplete_Using_JavaScript_As_Source_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac.Rendering
				.Compress()
				.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}
	
		[TestMethod]
		public void AutoComplete_Option_AppendTo_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetAppendTo("#my-element")
					.Finish()
				.Rendering
					.Compress()
				.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],appendTo: \"#my-element\"})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_AppendTo_Default_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetAppendTo(Options.DEFAULT_APPEND_TO)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_AutoFocus_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetAutoFocus(true)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],autoFocus: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_Delay_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetDelay(50)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],delay: 50})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_Delay_Default_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetDelay(Options.DEFAULT_DELAY)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_Delay_With_Default_Does_Not_Render_Setting()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetDelay(300)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert (should be no delay setting as it's at the default)
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_MinimumLength_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetMinimumLength(5)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],minLength: 5})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_MinimumLength_Default_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetMinimumLength(Options.DEFAULT_MINIMUM_LENGTH)
					.Finish()
				.Rendering
					.Compress()
				.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_MinimumLength_With_Default_Value_Does_Not_Render_Setting()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.SetMinimumLength(1)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php']})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_Position_With_My_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetMy(Fluqi.Core.Position.ePosition.Bottom, Fluqi.Core.Position.ePosition.Right)
					.Finish()
			;



			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],position: {my: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_Position_With_At_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.Position
						.SetAt(Fluqi.Core.Position.ePosition.Bottom, Fluqi.Core.Position.ePosition.Right)
					.Finish()
				.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],position: {at: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_Position_With_Collision_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Options
					.Position
						.SetCollision(Fluqi.Core.Collision.eCollision.Fit)
					.Finish()
				.Finish()
				.Rendering
					.Compress()
				.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],position: {collision: \"fit\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_Position_With_Of_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetOf("#top-menu")
					.Finish()
				.Finish()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],position: {of: \"#top-menu\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void AutoComplete_Option_Position_With_My_And_At_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			AutoComplete ac = TestHelper.SetupSimpleAutoCompleteObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetMy(Fluqi.Core.Position.ePosition.Bottom, Fluqi.Core.Position.ePosition.Right)
						.SetAt(Fluqi.Core.Position.ePosition.Bottom, Fluqi.Core.Position.ePosition.Right)
					.Finish()
				.Finish()
			;

			// Act - Force output we'd see on the web page
			ac.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#ac\").autocomplete({source: ['c++', 'java', 'php'],position: {my: \"bottom right\",at: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // jAutoComplete_Tests

} // ns
