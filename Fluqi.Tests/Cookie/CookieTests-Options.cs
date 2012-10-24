using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Utilities.jCookie;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Cookie_Options_Tests
	{
	
		[TestMethod]
		public void Cookie_SetDomain_Options_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl
				.Options
					.SetDomain("toepoke.co.uk")					
					.Finish()
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$.cookie({domain: 'toepoke.co.uk'});", html);
		}

		[TestMethod]
		public void Cookie_SetPath_Options_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl
				.Options
					.SetPath("/some-folder")
					.Finish()
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$.cookie({path: '/some-folder'});", html);
		}

		[TestMethod]
		public void Cookie_SetExpiry_Options_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl
				.Options
					.SetExpiry(3)
					.Finish()
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$.cookie({expires: 3});", html);
		}


		[TestMethod]
		public void Cookie_SetExpiry_By_Number_Options_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl
				.Options
					.SetExpiry(12)
					.Finish()
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$.cookie({expires: 12});", html);
		}

		[TestMethod]
		public void Cookie_SetSecure_Options_Renders_Correctly_When_True()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl
				.Options
					.SetSecure(true)
					.Finish()
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$.cookie({secure: true});", html);
		}

		[TestMethod]
		public void Cookie_SetSecure_Options_Renders_Correctly_When_False()
		{
			// Arrange
			var resp = new MockWriter();
			Cookie ctl = TestHelper.SetupSimpleCookieObject(resp);

			// only testing raw output
			ctl
				.Options
					.SetSecure(false)
					.Finish()
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			// Act - Force output we'd see on the web page
			ctl.Render();
			string html = resp.Output.ToString();

		  // Assert - secure shouldn't be present as false is the default
		  Assert.AreEqual("$.cookie();", html);
		}
		
	} // Cookie_Tests

} // ns
