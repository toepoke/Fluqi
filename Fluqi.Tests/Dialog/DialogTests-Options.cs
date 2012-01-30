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
	public partial class Dialog_Options_Tests
	{

		[TestMethod]
		public void Ensure_Multiple_Options_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetDisabled(true)
					.SetPosition( Core.Position.ePosition.Left, Core.Position.ePosition.Top )
					.Finish()
				.Rendering
					.Compress()
			;
	
			TestHelper.ForceRender(dlg);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({disabled: true,position: [ 'left', 'top' ]})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Disabled_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetDisabled(true)
					.Finish()
				.Rendering
					.Compress()
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({disabled: true})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_AutoOpen_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetAutoOpen(false)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({autoOpen: false})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_CloseOnEscape_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetCloseOnEscape(false)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({closeOnEscape: false})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_CloseText_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetCloseText("please close")
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({closeText: \"please close\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_CloseText_Option_With_Default_Is_Not_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetCloseText(Options.DEFAULT_CLOSE_TEXT)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog()" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_DialogClass_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetDialogClass("pretty-dialog-class")
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({dialogClass: \"pretty-dialog-class\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Draggable_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetDraggable(false)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({draggable: false})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Height_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetHeight(987)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({height: 987})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Height_Option_With_Default_Is_Not_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetHeight(Options.DEFAULT_HEIGHT)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog()" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Hide_By_String_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetHideEffect("slide")
				.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({hide: \"slide\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Hide_By_Enum_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetHideEffect(Core.Animation.eAnimation.Slide)
				.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({hide: \"slide\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Hide_By_Function_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Options
				.SetHideMethod("function() { alert('bob'); }")
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({hide: function() { alert('bob'); }})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_MinWidth_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg
			// only testing raw output
				.Options
					.SetMinWidth(123)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({minWidth: 123})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_MinWidth_Option_With_Default_Is_Not_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetMinWidth(Options.DEFAULT_MIN_WIDTH)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog()" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_MaxWidth_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetMaxWidth(864)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({maxWidth: 864})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_MinHeight_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetMinHeight(468)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({minHeight: 468})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_MinHeight_Option_With_Default_Is_Not_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetMinHeight(Options.DEFAULT_MIN_HEIGHT)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog()" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_MaxHeight_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetMaxHeight(849)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({maxHeight: 849})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Modal_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetModal(true)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({modal: true})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Position_By_Enum_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetPosition(Fluqi.Core.Position.ePosition.Left, Fluqi.Core.Position.ePosition.Bottom)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({position: [ 'left', 'bottom' ]})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Position_By_String_XY_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetPosition("left", "bottom")
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({position: [ 'left', 'bottom' ]})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Position_By_String_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetPosition("bottom")
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({position: \"bottom\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Position_By_Numeric_Offset_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetPosition(10, 12)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({position: [ 10, 12 ]})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Resizable_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetResizable(false)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({resizable: false})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_ShowEffect_Option_By_String_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetShowEffect("blind")
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({show: \"blind\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_ShowEffect_Option_By_Enum_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetShowEffect(Core.Animation.eAnimation.Blind)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({show: \"blind\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Show_By_Function_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetShowMethod("function() { alert('bob'); }")
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({show: function() { alert('bob'); }})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Stack_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetStack(false)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({stack: false})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Title_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetTitle("my little title")
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({title: \"my little title\"})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Width_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetWidth(145)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({width: 145})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_Width_Option_With_Default_Is_Not_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetWidth(Options.DEFAULT_WIDTH)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog()" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_ZIndex_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetZIndex(1456)
					.Finish()
				.Rendering
				.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog({zIndex: 1456})" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Ensure_ZIndex_Option_With_Default_Is_Not_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.SetZIndex(Options.DEFAULT_ZINDEX)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myDlg\").dialog()" + 
					";});" + 
				"</script>";

			Assert.IsTrue(html.Contains(expected));
		}

	} // jDialog_Tests

} // ns
