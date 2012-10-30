using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jSpinner;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Spinner_Options_Tests 
	{

		[TestMethod]
	  public void Ensure_Null_Culture_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
	      .Options
	        .SetCulture(null)
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner()" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Culture_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
	      .Options
	        .SetCulture("fr")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({culture: \"fr\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Disabled_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
	      .Options
	        .SetDisabled(true)
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({disabled: true})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_SetBothIcons_ByEnum_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
	      .Options
	        .SetIcons(Core.Icons.eIconClass.arrow_1_e, Core.Icons.eIconClass.arrow_1_s)
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({icons: { down: \"ui-icon-arrow-1-e\", up: \"ui-icon-arrow-1-s\" }})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_SetBothIcons_ByString_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
	      .Options
	        .SetIcons("down-icon", "up-icon")
	        .Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({icons: { down: \"down-icon\", up: \"up-icon\" }})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Incremental_Default_True_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner()" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

	  [TestMethod]
	  public void Ensure_Incremental_False_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetIncremental(false)
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({incremental: false})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Incremental_Function_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetIncremental("function(step) { return step*2; }")
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({incremental: function(step) { return step*2; }})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Min_As_Default_Value_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner()" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Min_As_Number_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetMin(99)
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({min: 99})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Min_As_String_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetMin("abcxyz")
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({min: \"abcxyz\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }



		[TestMethod]
	  public void Ensure_Max_As_Default_Value_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner()" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Max_As_Number_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetMax(99)
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({max: 99})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Max_As_String_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetMax("abcxyz")
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({max: \"abcxyz\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_NumberFormat_As_Default_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner()" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_NumberFormat_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetNumberFormat("abcxyz")
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({numberFormat: \"abcxyz\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Page_As_Default_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner()" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Page_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetPage(99)
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({page: 99})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Step_As_Default_Option_Is_Not_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner()" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Step_As_Number_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetStep(99)
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({step: 99})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }

		[TestMethod]
	  public void Ensure_Step_As_String_Option_Is_Added_To_Script_Definition()
	  {
	    // Arrange
	    var resp = new MockWriter();
	    Spinner spinner = TestHelper.SetupSimpleSpinnerObject(resp);

	    // only testing raw output
	    spinner
				.Options
					.SetStep("abcxyz")
					.Finish()
	      .Rendering
	        .Compress();

	    TestHelper.ForceRender(spinner);

	    // Act - Force output we'd see on the web page
	    string html = resp.Output.ToString();

	    // Assert
	    string expected = 
	      "<script type=\"text/javascript\">" + 
	        "$(document).ready( function() {" + 
	          "$(\"#mySpinner\").spinner({step: \"abcxyz\"})" + 
	        ";});" + 
	      "</script>";

	    Assert.IsTrue(html.Contains(expected));
	  }



	}

} // ns
