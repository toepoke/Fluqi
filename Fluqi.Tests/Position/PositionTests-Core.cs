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
	public partial class Position_Core_Tests
	{
		
		[TestMethod]
		public void Position_With_No_CSS_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos.Rendering.Compress();

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("#myPosition"));
		}


		[TestMethod]
		public void Auto_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos.Rendering.Compress();

			TestHelper.ForceRender(pos);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos.Rendering
				.SetAutoScript(false)
				.Compress()
			;

			TestHelper.ForceRender(pos);

			pos.RenderStartUpScript();
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_Auto_Script_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos.Rendering
				.SetAutoScript(false)
				.Compress()
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myPosition\").position()" + 
					";});" + 
				"</script>";
			Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos.Rendering
				.SetAutoScript(false)
				.Compress()
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = pos.GetControlScript();

			// Assert
			string expected = 
				"$(\"#myPosition\").position();";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			Position pos = TestHelper.SetupSimplePositionObject(resp);

			// only testing raw output
			pos.Rendering
				.SetAutoScript(false)
				.Compress()
			;

			TestHelper.ForceRender(pos);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("\"#myPosition\""));
			Assert.IsFalse(html.Contains("$(document).ready("));
		}

	} // jPosition_Tests

} // ns
