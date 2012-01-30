using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Utilities.jPosition;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Position_Option_Tests
	{

		[TestMethod]
		public void Ensure_Multiple_Options_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos				
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetOffset(10, 20)
					.SetMy(Fluqi.Core.Position.ePosition.Right)
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({my: \"right\",offset: \"10 20\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_My_Option_With_Position_Enum_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
				.Finish()
				.Options
					.SetMy(Fluqi.Core.Position.ePosition.Right)
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({my: \"right\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_My_Option_With_Two_Position_Enums_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetMy(Fluqi.Core.Position.ePosition.Top, Fluqi.Core.Position.ePosition.Right)
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({my: \"top right\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod, ExpectedException(typeof(ArgumentException))]
		public void Ensure_My_Option_With_Unknown_Position_Enum_Throws_Error()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
				.Finish()
				.Options
					.SetMy((Fluqi.Core.Position.ePosition) 99)
			;

			// exception happens when rendering
			TestHelper.ForceRender(pos);
		}

		[TestMethod]
		public void Ensure_My_Option_With_UpperCase_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetMy("TOP")				
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({my: \"top\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_My_Option_With_LowerCase_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetMy("bottom")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({my: \"bottom\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_My_Option_With_Two_Strings_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetMy("right", "bottom")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({my: \"right bottom\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_At_Option_With_Position_Enum_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetAt(Fluqi.Core.Position.ePosition.Right)
				;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({at: \"right\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_At_Option_With_Two_Position_Enums_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetAt(Fluqi.Core.Position.ePosition.Top, Fluqi.Core.Position.ePosition.Right)
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({at: \"top right\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod, ExpectedException(typeof(ArgumentException))]
		public void Ensure_At_Option_With_Unknown_Position_Enum_Throws_Error()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetAt((Fluqi.Core.Position.ePosition) 99)
			;

			// exception happens when rendering
			TestHelper.ForceRender(pos);
		}

		[TestMethod]
		public void Ensure_At_Option_With_UpperCase_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetAt("TOP")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({at: \"top\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_At_Option_With_LowerCase_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetAt("bottom")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({at: \"bottom\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_At_Option_With_Two_Strings_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetAt("right", "bottom")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({at: \"right bottom\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Of_Option_With_HashSelector_Is_Added_To_Script_Definition_With_Quotes()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetOf("#bob")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({of: \"#bob\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Of_Option_With_ClassSelector_Is_Added_To_Script_Definition_With_Quotes()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetOf(".bob")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({of: \".bob\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Of_Option_With_JQuery_Object_Is_Added_To_Script_Definition_Without_Quotes()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetOf("xyz")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({of: xyz})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Offset_Option_With_One_Param_Is_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetOffset(12)
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({offset: \"12\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Offset_Option_With_Two_Params_Is_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetOffset(12, 50)
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({offset: \"12 50\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}






		[TestMethod]
		public void Ensure_Collision_Option_With_Position_Enum_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetCollision(Fluqi.Core.Collision.eCollision.Fit)
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({collision: \"fit\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Collision_Option_With_Two_Position_Enums_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetCollision(Fluqi.Core.Collision.eCollision.Fit, Fluqi.Core.Collision.eCollision.Flip)
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({collision: \"fit flip\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod, ExpectedException(typeof(ArgumentException))]
		public void Ensure_Collision_Option_With_Unknown_Position_Enum_Throws_Error()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetCollision((Fluqi.Core.Collision.eCollision) 99)
			;

			// exception happens when rendering
			TestHelper.ForceRender(pos);
		}

		[TestMethod]
		public void Ensure_Collision_Option_With_UpperCase_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetCollision("FLIP")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({collision: \"flip\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
			// works
		}

		[TestMethod]
		public void Ensure_Collision_Option_With_LowerCase_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetCollision("flip")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({collision: \"flip\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Collision_Option_With_Two_Strings_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetCollision("fit", "flip")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({collision: \"fit flip\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Using_Option_With_Inline_Function_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetUsingFunction("function(using) { }")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({using: function(using) { }})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Using_Option_With_External_Function_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos
				.Rendering
					.Compress()
					.Finish()
				.Options
					.SetUsingFunction("myUsing")
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position({using: myUsing})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

	} // jPosition_Tests

} // ns
