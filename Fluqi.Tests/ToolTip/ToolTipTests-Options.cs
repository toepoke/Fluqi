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
	public partial class ToolTip_Options_Tests 
	{

		[TestMethod]
	  public void Ensure_Null_ContentByString_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetContentByString(null)
	        .Finish()
	      .Rendering
	        .Compress();

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
	  public void Ensure_Empty_ContentByString_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetContentByString("")
	        .Finish()
	      .Rendering
	        .Compress();

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
	  public void Ensure_Populated_ContentByString_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetContentByString("Awesome title!")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({content: \"Awesome title!\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Null_ContentByFunction_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetContentByFunction(null)
	        .Finish()
	      .Rendering
	        .Compress();

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
	  public void Ensure_Empty_ContentByFunction_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetContentByFunction("")
	        .Finish()
	      .Rendering
	        .Compress();

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
	  public void Ensure_Populated_Inline_ContentByFunction_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetContentByFunction("function() { return \"Awesome tooltip!\"; }")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({content: function() { return \"Awesome tooltip!\"; }})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Populated_Declared_ContentByFunction_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetContentByFunction("getCustomContent()")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({content: getCustomContent()})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Disabled_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetDisabled(true)
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({disabled: true})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Hide_Animation_Disabled_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
					.HideAnimation
						.SetDisabled()
						.Finish()
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({hide: false})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Hide_ByDuration_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .HideAnimation
						.SetDuration(333)
						.Finish()
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({hide: {duration: 333}})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }		
	 
	  [TestMethod]
	  public void Ensure_Hide_ByDetail_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
					.HideAnimation
						.SetEffect(Core.Animation.eAnimation.Bounce)
						.SetEasing(Core.Ease.eEase.easeInBack)
						.SetDuration(987)
						.Finish()
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({hide: {effect: \"bounce\",easing: \"easeInBack\",duration: 987}})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Items_BySingleSelection_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetItems("img[alt]")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({items: \"img[alt]\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Items_ByMultipleString_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetItems("img[alt], [data-geo], [title]")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({items: \"img[alt], [data-geo], [title]\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Items_ByMultipleSelection_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetItems("img[alt]", "[data-geo]", "[title]")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({items: \"img[alt], [data-geo], [title]\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }
		
		[TestMethod]
		public void ToolTip_Option_Position_With_My_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ToolTip ac = TestHelper.SetupSimpleToolTipObject(resp);

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
		        "$(document).tooltip({position: {my: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_Option_Position_With_At_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ToolTip ac = TestHelper.SetupSimpleToolTipObject(resp);

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
		        "$(document).tooltip({position: {at: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_Option_Position_With_Collision_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ToolTip ac = TestHelper.SetupSimpleToolTipObject(resp);

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
		        "$(document).tooltip({position: {collision: \"fit\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_Option_Position_With_Of_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ToolTip ac = TestHelper.SetupSimpleToolTipObject(resp);

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
		        "$(document).tooltip({position: {of: \"#top-menu\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_Option_Position_With_My_And_At_Set_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ToolTip ac = TestHelper.SetupSimpleToolTipObject(resp);

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
		        "$(document).tooltip({position: {my: \"bottom right\",at: \"bottom right\"}})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_My_Position_Set_To_Default_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			ToolTip ac = TestHelper.SetupSimpleToolTipObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetMy("left top+15")
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
		        "$(document).tooltip()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_At_Position_Set_To_Default_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			ToolTip ac = TestHelper.SetupSimpleToolTipObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetAt("left bottom")
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
		        "$(document).tooltip()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void ToolTip_Collision_Position_Set_To_Default_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			ToolTip ac = TestHelper.SetupSimpleToolTipObject(resp);

			// only testing raw output
			ac
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.Position
						.SetCollision("none")
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
		        "$(document).tooltip()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}
	  
	  [TestMethod]
	  public void Ensure_Show_Animation_Disabled_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
					.ShowAnimation
						.SetDisabled()
						.Finish()
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({show: false})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Show_ByDuration_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .ShowAnimation
						.SetDuration(333)
						.Finish()
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({show: {duration: 333}})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }		
			 
	  [TestMethod]
	  public void Ensure_Show_ByDetail_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
					.ShowAnimation
						.SetEffect(Core.Animation.eAnimation.Bounce)
						.SetEasing(Core.Ease.eEase.easeInBack)
						.SetDuration(987)
						.Finish()
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({show: {effect: \"bounce\",easing: \"easeInBack\",duration: 987}})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_TooltipClass_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetToolTipClass("my-class1 my-class2")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({tooltipClass: \"my-class1 my-class2\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }
		
	  [TestMethod]
	  public void Ensure_Track_On_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetTrack(true)
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(tooltip);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(document).tooltip({track: true})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Track_Off_Option_Is_NOT_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    ToolTip tooltip = TestHelper.SetupSimpleToolTipObject(resp);

	    // only testing raw output
	    tooltip
	      .Options
	        .SetTrack(false)
	        .Finish()
	      .Rendering
	        .Compress();

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

	}

} // ns
