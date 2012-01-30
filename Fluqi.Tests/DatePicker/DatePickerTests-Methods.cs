using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jDatePicker;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class DatePicker_Methods_Tests
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Destroy();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Disable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Enable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Widget();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_DatePicker_Dialog_With_DateTime_As_Start_Date_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Dialog(new DateTime(2012, 1, 20));

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"$(\"#dt\").datepicker(\"dialog\"," + 
					"$.datepicker.parseDate( \"yy-mm-dd\", \"2012-01-20\" )" + 
				")";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Ensure_DatePicker_Dialog_WithString_As_Start_Date_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Dialog("2000-02-01");

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = "$(\"#dt\").datepicker(\"dialog\",'2000-02-01')";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Ensure_DatePicker_Dialog_With_OnSelect_Function_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Dialog(new DateTime(2012, 1, 20), "alert('You selected ' + dateStr);");

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"$(\"#dt\").datepicker(\"dialog\"," + 
					"$.datepicker.parseDate( \"yy-mm-dd\", \"2012-01-20\" )," + 
					"function(dateStr, dateInst) { alert('You selected ' + dateStr); }" + 
				")";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Ensure_DatePicker_Dialog_With_NewOptions_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Dialog(new DateTime(2012, 1, 20), 
				null, 
				dt.Options
					.SetShowButtonPanel(true)
					.SetDuration("slow")
					.SetCloseText("OK")
					.SetShowAnim(Core.Animation.eAnimation.Fold)					
			);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"$(\"#dt\").datepicker(\"dialog\"," + 
					"$.datepicker.parseDate( \"yy-mm-dd\", \"2012-01-20\" )," + 
					"{closeText: \"OK\",duration: \"slow\",showAnim: \"fold\",showButtonPanel: true}" + 
				")";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Ensure_DatePicker_Dialog_With_Specified_Position_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Dialog(new DateTime(2012, 1, 20), 
				null,		// onSelect
				99,			// left
				98,			// top
				null		// options
			);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"$(\"#dt\").datepicker(\"dialog\"," + 
					"$.datepicker.parseDate( \"yy-mm-dd\", \"2012-01-20\" )," + 
					"[ 99, 98 ]" + 
				")";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Ensure_DatePicker_Dialog_With_Multiple_Parameters_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Dialog(new DateTime(2012, 1, 20), 
				"alert('You selected ' + dateStr);", 
				97,	// left
				3,		// top
				dt.Options
					.SetShowButtonPanel(true)
					.SetDuration("slow")
					.SetCloseText("OK")
					.SetShowAnim(Core.Animation.eAnimation.Fold)
			);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"$(\"#dt\").datepicker(\"dialog\"," + 
					"$.datepicker.parseDate( \"yy-mm-dd\", \"2012-01-20\" )," + 
					"function(dateStr, dateInst) { alert('You selected ' + dateStr); }," + 
					"{closeText: \"OK\",duration: \"slow\",showAnim: \"fold\",showButtonPanel: true}," + 
					"[ 97, 3 ]" +
				")";
		  Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Ensure_IsDisabled_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.IsDisabled();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"isDisabled\")", html);
		}

		[TestMethod]
		public void Ensure_Hide_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Hide();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"hide\")", html);
		}

		[TestMethod]
		public void Ensure_Show_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Show();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"show\")", html);
		}

		[TestMethod]
		public void Ensure_Refresh_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.Refresh();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"refresh\")", html);
		}

		[TestMethod]
		public void Ensure_GetDate_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.GetDate();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"getDate\")", html);
		}

		[TestMethod]
		public void Ensure_SetDate_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			DatePicker dt = TestHelper.SetupSimpleDatePickerObject(resp);

			dt.Methods.SetDate(new DateTime(2000, 1, 1));

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#dt\").datepicker(\"setDate\",$.datepicker.parseDate( \"yy-mm-dd\", \"2000-01-01\" ))", html);
		}

	} // DatePicker_Tests

} // ns
