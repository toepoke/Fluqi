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
	public partial class Dialog_Button_Tests
	{

		[TestMethod]
		public void Ensure_One_Button_And_Other_Options_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.AddButton("OK", "addToLog('OK button clicked.');")
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
						"$(\"#myDlg\").dialog({disabled: true,position: [ 'left', 'top' ],buttons: {\"OK\": function() {addToLog('OK button clicked.');}}})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

	[TestMethod]
		public void Ensure_Two_Buttons_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Dialog dlg = TestHelper.SetupSimpleDialogObject(resp);

			// only testing raw output
			dlg
				.Options
					.AddButton("OK", "addToLog('OK button clicked.');")
					.AddButton("Cancel", "addToLog('Cancel button clicked.');")
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
						"$(\"#myDlg\").dialog({buttons: {\"OK\": function() {addToLog('OK button clicked.');},\"Cancel\": function() {addToLog('Cancel button clicked.');}}})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

	} // jDialog_Tests

} // ns
