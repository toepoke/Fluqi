using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;
using Fluqi.Widget.jToolTip;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class ToolTip_Core_Tests 
	{

		// ToolTip is a bit weird as there's no underlying element or anything, it's
		// just the title attribute we're attaching to, so lots of these test won't make any
		// sense.

		[TestMethod]
		public void Auto_Script_With_Selector_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tooltip = new ToolTip(resp, "myTipper");

		  // only testing raw output
		  tooltip.Rendering.Compress();

		  TestHelper.ForceRender(tooltip);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#myTipper\").tooltip()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Auto_Script_With_Document_Object_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

		  // only testing raw output
		  tooltip.Rendering.Compress();

		  TestHelper.ForceRender(tooltip);
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(document).tooltip()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

		  // only testing raw output
		  tooltip.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  TestHelper.ForceRender(tooltip);

		  tooltip.RenderStartUpScript();
			
		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(document).tooltip()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_Auto_Script_Is_Off()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

		  // only testing raw output
		  tooltip
		    .Rendering
		      .SetAutoScript(false)
		      .Compress()
		  ;

		  TestHelper.ForceRender(tooltip);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert - Note we expect empty as there's no tag associated with a tooltip
		  string expected = "";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

		  // only testing raw output
		  tooltip.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  tooltip.RenderStartUpScript(false/*incDocReady*/);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert
		  string expected = "$(document).tooltip();";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
		  // Arrange
		  var resp = new MockWriter();
		  ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

		  // only testing raw output
		  tooltip.Rendering
		    .SetAutoScript(false)
		    .Compress()
		  ;

		  TestHelper.ForceRender(tooltip);

		  // Act - Force output we'd see on the web page
		  string html = resp.Output.ToString();

		  // Assert - yup, nothing will come out here
		  Assert.IsFalse(html.Contains("$(document).tooltip()"));
		  Assert.IsFalse(html.Contains("$(document).ready("));
		}

	}

} // ns
