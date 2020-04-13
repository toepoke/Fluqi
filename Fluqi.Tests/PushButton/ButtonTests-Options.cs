using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jPushButton;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Button_Options_Tests
	{

		[TestMethod]
		public void Ensure_Multiple_Options_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Rendering
					.Compress()
					.ShowCSS()
					.Finish()
				.Options
					.SetDisabled(true)
					.SetText(false)
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button({disabled: true,text: false})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}
	
		[TestMethod]
		public void Button_Option_Disabled_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Options
					.SetDisabled(true)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button({disabled: true})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Button_Option_Disabled_Default_Is_Not_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Options
					.SetDisabled(false)
				.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button()" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Button_Option_Text_As_False_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Options
					.SetText(false)
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button({text: false})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Button_Option_Icon_Only_ByEnum_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Options
					.SetIcon( Core.Icons.eIconClass.alert )
				.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
				"$(document).ready( function() {" + 
				"$(\"#btn\").button({icon: 'ui-icon-alert'})" + 
				";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Button_Option_Icon_ByEnum_With_Position_ByEnum_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Options
					.SetIcon( Core.Icons.eIconClass.alert, Core.IconPosition.eIconPosition.Top )
				.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button({icon: 'ui-icon-alert',iconPosition: 'top'})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Button_Option_Icons_ByString_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Options
					.SetIcon( "ui-icon-alert", "beginning" )
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

		  // Assert
		  string expected = 
		    "<script type=\"text/javascript\">" + 
		      "$(document).ready( function() {" + 
		        "$(\"#btn\").button({icon: 'ui-icon-alert',iconPosition: 'beginning'})" + 
		      ";});" + 
		    "</script>";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Button_Option_Primary_Icon_Only_ByString_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			PushButton btn = TestHelper.SetupSimpleButtonObject(resp);

			// only testing raw output
			btn
				.Options
					.SetIcon( "ui-icon-alert" )
					.Finish()
				.Rendering
					.Compress()
					.ShowCSS()
			;

			// Act - Force output we'd see on the web page
			btn.Render();
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
				"$(document).ready( function() {" + 
				"$(\"#btn\").button({icon: 'ui-icon-alert'})" + 
				";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}

	} // jButton_Tests

} // ns
