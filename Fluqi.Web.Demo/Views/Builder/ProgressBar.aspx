﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Builder.Master" Inherits="System.Web.Mvc.ViewPage<Fluqi.Models.ProgressBarModel>" %>
<%@ Import Namespace="Fluqi.Web.Demo.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DemoMainContent" runat="server">
<script src="<%=Url.Content("~/Scripts/progress-bar.js")%>" type="text/javascript"></script>
<% 
	ProgressBar pb = Html.CreateProgressBar("pb");
	this.Model.ConfigureProgressBar(pb);
	pb.Render();
%>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="DemoExampleContent" runat="server">
<%using (Html.BeginForm("ProgressBar", "Builder")) {%>
	<input type="submit" value="UPDATE" />
	<ul>
		<li><%=Html.LabelFor(vm=>vm.disabled)  %><%=Html.CheckBoxFor(vm=>vm.disabled, "Styles the progress bar as if it's disabled, however the value can still be updated.")%></li>
		<li><%=Html.LabelFor(vm=>vm.value)     %><%=Html.TextBoxFor(vm=>vm.value, "Value of the progress bar (i.e. what % of the way through your process you are).", "")%></li>
	</ul>
	<hr />
	<h2>Test Harness Options</h2>
	<ul>
		<li><%=Html.LabelFor(vm=>vm.showEvents)    %><%=Html.CheckBoxFor(vm=>vm.showEvents, "Shows how events are wired up.")%></li>
		<li><%=Html.LabelFor(vm=>vm.renderCSS)     %><%=Html.CheckBoxFor(vm=>vm.renderCSS, "Shows the CSS generated by jQuery UI (so non-JavaScript users still see the layout/colours).")%></li>
		<li><%=Html.LabelFor(vm=>vm.prettyRender)  %><%=Html.CheckBoxFor(vm=>vm.prettyRender, "Shows the rendered control/JavaScript in a readable layout.  Turn this option off to see the compressed version (which is the default in a RELEASE build).")%></li>
	</ul>
	<input type="submit" value="UPDATE" />
<%}//form%>
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="DemoCodeContent" runat="server">
<% 
	ProgressBar pb = Html.CreateProgressBar("pb");
	this.Model.ConfigureProgressBar(pb);
%>
<%=this.Model.CSharpCode(pb)%>
</asp:Content>



<asp:Content ID="Content4" ContentPlaceHolderID="DemoHtmlContent" runat="server">
<% 
	ProgressBar pb = Html.CreateProgressBar("pb");
	this.Model.ConfigureProgressBar(pb);
	pb
		.Rendering
			// SetAutoScript off as we want to show the JavaScript separately
			.SetAutoScript(false)
		.Finish()
	.Render();
%>
</asp:Content>



<asp:Content ID="Content5" ContentPlaceHolderID="DemoJavaScriptCodeContent" runat="server">
<% 
	ProgressBar pb = Html.CreateProgressBar("pb");
	this.Model.ConfigureProgressBar(pb);
%>
<%=this.Model.JavaScriptCode(pb)%>
</asp:Content>



<asp:Content ID="Content6" ContentPlaceHolderID="DemoMethodsContent" runat="server">
	<ul class="horizontal">
		<li><button id="disable" title="Disables the progressbar.">Disable</button></li>
		<li><button id="enable" title="Enables the progressbar.">Enable</button></li>
		<li><button id="widget" title="Shows the HTML for the .ui-progressbar element.">Widget</button></li>
		<li><button id="getValue" title="Gets the current value of the progressbar control.">Get Value</button></li>
		<li><button id="setValue" title="Illustrates setting the progressbar value (to 50%).">Set Value</button></li>
		<li><button id="destroy" title="Returns the button to it's pre-init state.">Destroy</button></li>
	</ul>
<% 
	ProgressBar pb = Html.CreateProgressBar("pb");
	this.Model.ConfigureProgressBar(pb);
%>
	<script type="text/javascript">
	$(document).ready(function() {
		$("#enable").click(function() { <%pb.Methods.Enable();%>; });
		$("#disable").click(function() { <%pb.Methods.Disable();%>; });
		$("#widget").click(function() { alert( "Widget HTML:\n\n" + <%pb.Methods.Widget();%>.html() ); });
		$("#getValue").click(function() { alert( "Current value is:\n\n" + <%pb.Methods.GetValue();%> ); });
		$("#setValue").click(function() { <%pb.Methods.SetValue(50);%> });
		$("#destroy").click(function() {  if (confirm("are you sure you want to destroy the progressbar?")) <%pb.Methods.Destroy();%>; });
	});
</script>
</asp:Content>

<asp:Content ID="Content8" ContentPlaceHolderID="Outro" runat="server">
<p class="small-top-margin">
	You can also change the theme used by jQuery UI using the switcher.  Also note you can see
	the events for the control as they happen in the <strong>jQuery Events log</strong> (this
	also adds the event code to the <strong>JS Code</strong> tab ... uncheck the 
	<strong>Show &amp; Render Events</strong> option to stop this).
</p>
<p>
	Note in order to update the value (and therefore how far through the process the progress bar
	should display) is handled through a javascript function (that is not through the initialisation
	presented here).  
</p>
<p>
	To see how you <strong>could</strong> update the progress bar, please see the 
	<strong>Scripts/progress-bar.js</strong> in the demo website source code.
</p>
<p>
	Finally, you can use an animated gif as part of your progress bar through CSS.  For
	details please see the <a href="http://jqueryui.com/demos/progressbar/#animated">jQuery UI website</a>.
</p>
</asp:Content>
