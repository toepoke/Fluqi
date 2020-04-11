using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jTab;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Tab_Core_Tests
	{
		
		[TestMethod]
		public void Tabs_With_No_CSS_Renders_Correct_Structure()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Rendering
					.Compress()
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"myTabs\""));

			// Should be:
			// 1 UL
			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<ul") );
			Assert.AreEqual(1, Utils.NumberOfMatches(html, "</ul") );

			// 3 LI
			Assert.AreEqual(3, Utils.NumberOfMatches(html, "<li") );
			Assert.AreEqual(3, Utils.NumberOfMatches(html, "</li") );

			// 3 content panels
			Assert.AreEqual(3, Utils.NumberOfMatches(html, "<div id=\"tab") );
		}


		[TestMethod]
		public void Tabs_With_Full_CSS_Delivers_Correct_CSS_Classes()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Rendering
					.Compress()
					.ShowCSS()
			;

			TestHelper.ForceRender(tabs);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"myTabs\""));

			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<div id=\"myTabs\" class=\"ui-tabs ui-widget ui-widget-content ui-corner-all\">") );
			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<ul class=\"ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all\">") );

			// Should be 3 of these (one for each LI header, but first one is selected)
			Assert.AreEqual(1, Utils.NumberOfMatches(html, "<li class=\"ui-state-default ui-corner-top ui-tabs-active ui-state-active\">") );
			Assert.AreEqual(2, Utils.NumberOfMatches(html, "<li class=\"ui-state-default ui-corner-top\">") );

			// Should be 3 of these (one for each content pane)
			Assert.AreEqual(3, Utils.NumberOfMatches(html, "class=\"ui-tabs-panel ui-widget-content ui-corner-bottom\"") );
		}


		[TestMethod]
		public void Tabs_With_Addition_CSS_Delivers_Is_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs
				.WithCss("my-extra-css-class")
				.Rendering
					.Compress()		// only testing raw output
			;

			TestHelper.ForceRender(tabs);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("my-extra-css-class"));
		}


		[TestMethod]
		public void Tabs_With_Addition_Attributes_Are_Rendered()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			tabs
				.WithAttribute("test-attribute-1", "test-value-a")
				.WithAttribute("test-attribute-2", "test-value-b")
				.Rendering
					.Compress()		// only testing raw output
			;

			TestHelper.ForceRender(tabs);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("test-attribute-1=\"test-value-a\""));
			Assert.IsTrue(html.Contains("test-attribute-2=\"test-value-b\""));
		}


		[TestMethod]
		public void Auto_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs.Rendering.Compress();

			TestHelper.ForceRender(tabs);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myTabs\").tabs()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Pretty_Static_Tabs_Script_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Rendering
					.SetAutoScript(false)
					.SetPrettyRender(true)
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<div id=\"myTabs\">" + Environment.NewLine +
				"	<ul>" + Environment.NewLine + 
				"		<li>" + Environment.NewLine +
				"			<a href=\"#tab1\" title=\"Tab 1\">Tab 1</a>" + Environment.NewLine +
				"		</li>" + Environment.NewLine +
				"		<li>" + Environment.NewLine +
				"			<a href=\"#tab2\" title=\"Tab 2\">Tab 2</a>" + Environment.NewLine +
				"		</li>" + Environment.NewLine +
				"		<li>" + Environment.NewLine +
				"			<a href=\"#tab3\" title=\"Tab 3\">Tab 3</a>" + Environment.NewLine +
				"		</li>" + Environment.NewLine +
				"	</ul>" + Environment.NewLine +
				"	<div id=\"tab1\">" + Environment.NewLine +
				"" + Environment.NewLine +
				"	</div>" + Environment.NewLine +
				"	<div id=\"tab2\">" + Environment.NewLine +
				"" + Environment.NewLine +
				"	</div>" + Environment.NewLine +
				"	<div id=\"tab3\">" + Environment.NewLine +
				"" + Environment.NewLine +
				"	</div>" + Environment.NewLine +
				"</div>" + Environment.NewLine;

			Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Pretty_Dynamic_Tabs_Script_Renders_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = new Tabs(resp, "myTabs");

			// define the test tabs
			tabs
				.AsDynamic()
				.Panes
				.Add("https://someurl.com/tab1", "Tab 1")
				.Add("https://someurl.com/tab2", "Tab 2")
				.Add("https://someurl.com/tab3", "Tab 3")
			;

			// only testing raw output
			tabs
				.Rendering
					.SetAutoScript(false)
					.SetPrettyRender(true)
			;

			using (tabs.RenderHeader()) {
			}

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<div id=\"myTabs\">" + Environment.NewLine +
				"	<ul>" + Environment.NewLine + 
				"		<li>" + Environment.NewLine +
				"			<a href=\"https://someurl.com/tab1\"><span>Tab 1</span></a>" + Environment.NewLine +
				"		</li>" + Environment.NewLine +
				"		<li>" + Environment.NewLine +
				"			<a href=\"https://someurl.com/tab2\"><span>Tab 2</span></a>" + Environment.NewLine +
				"		</li>" + Environment.NewLine +
				"		<li>" + Environment.NewLine +
				"			<a href=\"https://someurl.com/tab3\"><span>Tab 3</span></a>" + Environment.NewLine +
				"		</li>" + Environment.NewLine +
				"	</ul>" + Environment.NewLine +
				"</div>" + Environment.NewLine;

			Assert.AreEqual(expected, html);
		}

		[TestMethod]
		public void Manual_Script_With_DocReady_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			TestHelper.ForceRender(tabs);

			tabs.RenderStartUpScript();
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myTabs\").tabs()" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Script_Is_Rendered_When_Auto_Script_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myTabs\").tabs()" + 
					";});" + 
				"</script>";
			Assert.IsFalse(html.Contains(expected));
		}

		[TestMethod]
		public void Manual_Script_Delivers_Correct_Rendering()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = tabs.RenderScript();

			// Assert
			string expected = 
				"$(\"#myTabs\").tabs();";
			Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void No_Document_Ready_Section_When_AutoScript_Is_Off()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			Assert.IsTrue(html.Contains("id=\"myTabs\""));
			Assert.IsFalse(html.Contains("$(document).ready("));
		}

		[TestMethod]
		public void Changing_Selected_Tab_Changes_The_Tab_Ordering_Accordingly_And_Only_Leaves_One_Tab_Selected()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// Change the selected tab before we render out
			tabs.Panes.ToDictionary()["tab3"].IsActive = true;
			tabs.Panes.ToDictionary()["tab2"].IsActive = true;

			// only testing raw output
			tabs.Rendering.Compress();

			TestHelper.ForceRender(tabs);
			
			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

			// Assert
			string expected = 
				"<script type=\"text/javascript\">" + 
					"$(document).ready( function() {" + 
						"$(\"#myTabs\").tabs({active: 1})" + 
					";});" + 
				"</script>";
			Assert.IsTrue(html.Contains(expected));

			// Ensure "tab2" is selected
			Assert.AreEqual(1, (from t in tabs.Panes.ToDictionary() where t.Value.IsActive && t.Value.IDOrLocation == "tab2" select t).Count() );

			// Ensure only 1 tab is selected (.Single will throw a wobbler if there's > 1 selected)
			var selectedTab = (from t in tabs.Panes.ToDictionary() where t.Value.IsActive select t).Single();
		}

		[TestMethod, ExpectedException(typeof(System.NotSupportedException))]
		public void RenderNextPane_Throws_Exception_When_Tabs_Are_Added_Dynamically()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = new Tabs(resp, "myTabs");

			// define the test tabs
			tabs
				.AsDynamic()
				.Panes
				.Add("https://someurl.com/tab1", "Tab 1")
				.Add("https://someurl.com/tab2", "Tab 2")
				.Add("https://someurl.com/tab3", "Tab 3")
			;

			// only testing raw output
			tabs
				.Rendering
					.SetAutoScript(false)
					.Compress()
			;

			// This should throw a wobbler
			TestHelper.ForceRender(tabs);

			Assert.Fail("NotSupportedException should have been thrown.");
		}

	} // jTab_Tests

} // ns
