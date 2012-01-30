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
	public partial class ProgressBar_Method_Tests
	{

		[TestMethod]
		public void Ensure_Destroy_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			pb.Methods.Destroy();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#pb\").progressbar(\"destroy\")", html);
		}

		[TestMethod]
		public void Ensure_Disable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			pb.Methods.Disable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#pb\").progressbar(\"disable\")", html);
		}

		[TestMethod]
		public void Ensure_Enable_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			pb.Methods.Enable();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#pb\").progressbar(\"enable\")", html);
		}

		[TestMethod]
		public void Ensure_Widget_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			pb.Methods.Widget();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#pb\").progressbar(\"widget\")", html);
		}

		[TestMethod]
		public void Ensure_GetValue_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			pb.Methods.GetValue();

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#pb\").progressbar(\"value\")", html);
		}

		[TestMethod]
		public void Ensure_SetValue_Method_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			ProgressBar pb = TestHelper.SetupSimpleProgressBarObject(resp);

			pb.Methods.SetValue(49);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
		  Assert.AreEqual("$(\"#pb\").progressbar(\"value\",49)", html);
		}

	} // jSlider_Tests

} // ns
