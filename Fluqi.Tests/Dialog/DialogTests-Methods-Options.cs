using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jDialog;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Dialog_Methods_Options_Tests
	{

		[TestMethod]
		public void Ensure_GetCloseOnEscape_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetCloseOnEscape();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"closeOnEscape\")", html);
		}

		[TestMethod]
		public void Ensure_SetCloseOnEscape_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetCloseOnEscape(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"closeOnEscape\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetCloseText_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetCloseText();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"closeText\")", html);
		}

		[TestMethod]
		public void Ensure_SetCloseText_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetCloseTextJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"closeText\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetCloseText_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetCloseTextJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"closeText\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_GetDialogClass_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetDialogClass();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"dialogClass\")", html);
		}

		[TestMethod]
		public void Ensure_SetDialogClass_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetDialogClassJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"dialogClass\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetDialogClass_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetDialogClass("my-class");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"dialogClass\",\"my-class\")", html);
		}

		[TestMethod]
		public void Ensure_GetDraggable_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetDraggable();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"draggable\")", html);
		}

		[TestMethod]
		public void Ensure_SetDraggable_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetDraggable(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"draggable\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetHeight_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetHeight();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"height\")", html);
		}

		[TestMethod]
		public void Ensure_SetHeight_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetHeight(333);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"height\",333)", html);
		}

		[TestMethod]
		public void Ensure_SetHeightToAuto_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetHeightToAuto();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"height\",\"auto\")", html);
		}

		[TestMethod]
		public void Ensure_GetHideEffect_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetHideEffect();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"hide\")", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetHideEffect(Core.Animation.eAnimation.Bounce);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"hide\",\"bounce\")", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetHideEffectJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"hide\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetHideEffect("bounce");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"hide\",\"bounce\")", html);
		}

		[TestMethod]
		public void Ensure_GetMaxHeight_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetMaxHeight();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"maxHeight\")", html);
		}

		[TestMethod]
		public void Ensure_SetMaxHeight_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetMaxHeight(234);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"maxHeight\",234)", html);
		}

		[TestMethod]
		public void Ensure_GetMaxWidth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetMaxWidth();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"maxWidth\")", html);
		}

		[TestMethod]
		public void Ensure_SetMaxWidth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetMaxWidth(432);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"maxWidth\",432)", html);
		}

		[TestMethod]
		public void Ensure_GetMinHeight_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetMinHeight();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"minHeight\")", html);
		}

		[TestMethod]
		public void Ensure_SetMinHeight_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetMinHeight(333);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"minHeight\",333)", html);
		}

		[TestMethod]
		public void Ensure_GetMinWidth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetMinWidth();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"minWidth\")", html);
		}

		[TestMethod]
		public void Ensure_SetMinWidth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetMinWidth(2221);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"minWidth\",2221)", html);
		}

		[TestMethod]
		public void Ensure_GetModal_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetModal();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"modal\")", html);
		}

		[TestMethod]
		public void Ensure_SetModal_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetModal(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"modal\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetPosition_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetPosition();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"position\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"position\",\"right\")", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_Enum_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetPosition(Core.Position.ePosition.Top, Core.Position.ePosition.Right);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"position\",[ 'top', 'right' ])", html);
		}


		[TestMethod]
		public void Ensure_SetPosition_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetPositionJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"position\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetPosition("center");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"position\",\"center\")", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_String_With_Two_Positions_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetPosition("top", "right");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"position\",[ 'top', 'right' ])", html);
		}

		[TestMethod]
		public void Ensure_SetPosition_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetPosition(222, 333);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"position\",[ 222, 333 ])", html);
		}

		[TestMethod]
		public void Ensure_GetResizable_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetResizable();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"resizable\")", html);
		}

		[TestMethod]
		public void Ensure_SetResizable_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetResizable(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"resizable\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetShowEffect_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetShowEffect();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"show\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetShowEffect(Core.Animation.eAnimation.Fade);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"show\",\"fade\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetShowEffectJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"show\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetShowEffect("blind");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"show\",\"blind\")", html);
		}

		[TestMethod]
		public void Ensure_GetStack_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetStack();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"stack\")", html);
		}

		[TestMethod]
		public void Ensure_SetStack_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetStack(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"stack\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetTitle_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetTitle();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"title\")", html);
		}

		[TestMethod]
		public void Ensure_SetTitle_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetTitleJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"title\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetTitle_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetTitle("my new title");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"title\",\"my new title\")", html);
		}

		[TestMethod]
		public void Ensure_GetWidth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetWidth();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"width\")", html);
		}

		[TestMethod]
		public void Ensure_SetWidth_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetWidth(9898);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"width\",9898)", html);
		}

		[TestMethod]
		public void Ensure_GetZIndex_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.GetZIndex();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"zIndex\")", html);
		}

		[TestMethod]
		public void Ensure_SetZIndex_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleDialogObject(resp);

		  ctl.Methods.SetZIndex(123);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"option\",\"zIndex\",123)", html);
		}
		
	} // Dialog_Methods_Options_Tests

} // ns
