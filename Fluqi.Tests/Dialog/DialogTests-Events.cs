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
	public partial class Dialog_Events_Tests
	{

		[TestMethod]
		public void Dialog_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetCreateEvent("addToLog('Create event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_BeforeClose_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Rendering
					.Compress()
				.Finish()
				.Events
					.SetBeforeCloseEvent("addToLog('beforeClose event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "beforeClose: function(event, ui) {addToLog('beforeClose event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_Open_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetOpenEvent("addToLog('Open event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "open: function(event, ui) {addToLog('Open event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_Focus_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetFocusEvent("addToLog('Focus event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "focus: function(event, ui) {addToLog('Focus event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_DragStart_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetDragStartEvent("addToLog('DragStart event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "dragStart: function(event, ui) {addToLog('DragStart event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_Drag_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetDragEvent("addToLog('Drag event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "drag: function(event, ui) {addToLog('Drag event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_DragStop_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetDragStopEvent("addToLog('DragStop event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "dragStop: function(event, ui) {addToLog('DragStop event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_ResizeStart_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetResizeStartEvent("addToLog('ResizeStart event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "resizeStart: function(event, ui) {addToLog('ResizeStart event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_Resize_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetResizeEvent("addToLog('Resize event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "resize: function(event, ui) {addToLog('Resize event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_ResizeStop_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetResizeStopEvent("addToLog('ResizeStop event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "resizeStop: function(event, ui) {addToLog('ResizeStop event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Dialog_With_Close_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg.Rendering.Compress();

			dlg.Events
				.SetCloseEvent("addToLog('Close event called');")
			;

			TestHelper.ForceRender(dlg);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "close: function(event, ui) {addToLog('Close event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}
		
	} // jDialog_Tests

} // ns
