using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jProgressBar;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class ProgressBar_Options_Tests
	{

		[TestMethod]
		public void Ensure_Disabled_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb
				.Options
					.SetDisabled(true)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(pb);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#pb\").progressbar({disabled: true})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Disabled_Option_With_Default_Is_Not_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb.Options
				.SetDisabled(false)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(pb);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#pb\").progressbar()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

		[TestMethod]
		public void Ensure_Value_Option_Is_Added_To_Script_Definition()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			// only testing raw output
			pb
				.Options
					.SetValue(55)
					.Finish()
				.Rendering
					.Compress();

			TestHelper.ForceRender(pb);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#pb\").progressbar({value: 55})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}		

	} // jSlider_Tests

} // ns
