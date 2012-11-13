using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jSlider;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class ToolTip_Methods_Options_Tests 
	{

		[TestMethod]
		public void Ensure_GetContent_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.GetContent();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"content\")", html);
		}

		[TestMethod]
		public void Ensure_SetContent_ByString_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetContentByString("Awesome tooltip!");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"content\",\"Awesome tooltip!\")", html);
		}

		[TestMethod]
		public void Ensure_SetContent_ByFunction_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetContentByFunction("function() { return 'Awesome tooltip!'; }");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"content\",function() { return 'Awesome tooltip!'; })", html);
		}
		
		[TestMethod]
		public void Ensure_GetDisabled_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.GetDisabled();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"disabled\")", html);
		}

		[TestMethod]
		public void Ensure_SetDisabled_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetDisabled(true);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"disabled\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetHide_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.GetHide();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"hide\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Hide_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.DisabledHideEffect();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"hide\",false)", html);
		}

		[TestMethod]
		public void Ensure_SetHide_ByDuration_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetHide(987);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"hide\",{ duration: 987 })", html);
		}

		[TestMethod]
		public void Ensure_SetHide_ByDetail_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetHide(Core.Animation.eAnimation.Blind, Core.Ease.eEase.easeInCirc, 123);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"hide\",{ effect: \"blind\", easing: \"easeInCirc\", duration: 123 })", html);
		}

		[TestMethod]
		public void Ensure_SetHide_ByJSON_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetHide("{ effect: \"Blind\", duration: 456 }");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"hide\",{ effect: \"Blind\", duration: 456 })", html);
		}

		[TestMethod]
		public void Ensure_GetShow_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.GetShow();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"show\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Show_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.DisabledShowEffect();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"show\",false)", html);
		}

		[TestMethod]
		public void Ensure_SetShow_ByDuration_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetShow(987);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"show\",{ duration: 987 })", html);
		}

		[TestMethod]
		public void Ensure_SetShow_ByDetail_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetShow(Core.Animation.eAnimation.Blind, Core.Ease.eEase.easeInCirc, 123);

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"show\",{ effect: \"blind\", easing: \"easeInCirc\", duration: 123 })", html);
		}

		[TestMethod]
		public void Ensure_SetShow_ByJSON_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetShow("{ effect: \"Blind\", duration: 456 }");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"show\",{ effect: \"Blind\", duration: 456 })", html);
		}

		[TestMethod]
		public void Ensure_GetItems_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.GetItems();

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"items\")", html);
		}

		[TestMethod]
		public void Ensure_SetItems_Singluar_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetItems("img[alt]");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"items\",\"img[alt]\")", html);
		}

		[TestMethod]
		public void Ensure_SetItems_Multiple_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
		  var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetItems("img[alt], [data-geo], [title]");

		  // Act
		  string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"items\",\"img[alt], [data-geo], [title]\")", html);
		}

		[TestMethod]
		public void Ensure_GetPosition_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.GetPosition();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"position\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"position\",\"right\")", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Top, Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"position\",[ 'top', 'right' ])", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetPositionJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"position\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetPosition("center");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"position\",\"center\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetPosition("top", "right");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"position\",[ 'top', 'right' ])", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetPosition(222, 333);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"position\",[ 222, 333 ])", html);
		}

		[TestMethod]
		public void Ensure_GetTooltipClass_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.GetTooltipClass();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"tooltipClass\")", html);
		}

		[TestMethod]
		public void Ensure_SetTooltipClass_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetTooltipClass("my-class");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"tooltipClass\",\"my-class\")", html);
		}

		[TestMethod]
		public void Ensure_GetTrack_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.GetTrack();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"track\")", html);
		}

		[TestMethod]
		public void Ensure_SetTrack_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleToolTipObject(resp);

		  ctl.Methods.SetTrack(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(document).tooltip(\"option\",\"track\",true)", html);
		}
		
	}

} // ns

