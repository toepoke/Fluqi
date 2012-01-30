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
	public partial class Dialog_Methods_Tests
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg.Methods.Destroy();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg.Methods.Disable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg.Methods.Enable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"enable\")", html);
		}
		
		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg.Methods.Widget();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_IsOpen_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg.Methods.IsOpen();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"isOpen\")", html);
		}

		[TestMethod]
		public void Ensure_MoveToTop_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg.Methods.MoveToTop();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"moveToTop\")", html);
		}

		[TestMethod]
		public void Ensure_Open_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg.Methods.Open();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"open\")", html);
		}

		[TestMethod]
		public void Ensure_Close_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			dlg.Methods.Close();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#myDlg\").dialog(\"close\")", html);
		}

	} // jDialog_Tests

} // ns
