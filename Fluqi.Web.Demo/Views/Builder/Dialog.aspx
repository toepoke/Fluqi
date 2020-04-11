﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Builder.Master" Inherits="System.Web.Mvc.ViewPage<Fluqi.Models.DialogModel>" %>
<%@ Import Namespace="Fluqi.Web.Demo.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DemoMainContent" runat="server">
<script src="<%=Url.Content("~/Scripts/dialog.js")%>" type="text/javascript"></script>
<%
	Dialog dlg = this.Model.BuildDialogFromModel(this.ViewContext.Writer, "sample_dlg");
%>
<%using (dlg.RenderDialog()) { %>
	<p>
		Proin elit arcu, rutrum commodo, vehicula tempus, commodo a, risus. Curabitur nec arcu. Donec 
		sollicitudin mi sit amet mauris. Nam elementum quam ullamcorper ante. Etiam aliquet massa et 
		lorem. Mauris dapibus lacus auctor risus. Aenean tempor ullamcorper leo. Vivamus sed magna 
		quis ligula eleifend adipiscing. Duis orci. Aliquam sodales tortor vitae ipsum. Aliquam nulla. 
		Duis aliquam molestie erat. Ut et mauris vel pede varius sollicitudin. Sed ut dolor nec orci 
		tincidunt interdum. Phasellus ipsum. Nunc tristique tempus lectus.
	</p>
<%}//using dlg %>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="DemoExampleContent" runat="server">
<%using (Html.BeginForm("Dialog", "Builder")) {%>
	<input type="submit" value="UPDATE" />
	<ul class="small-label">
		<li><%=Html.LabelFor(vm=>vm.Disabled)      %><%=Html.CheckBoxFor(vm=>vm.Disabled, "Disables the dialog, so it appears translucent.")%></li>
		<li><%=Html.LabelFor(vm=>vm.AutoOpen)      %><%=Html.CheckBoxFor(vm=>vm.AutoOpen, "Dialog opens automatically.")%></li>
		<li><%=Html.LabelFor(vm=>vm.CloseOnEscape) %><%=Html.CheckBoxFor(vm=>vm.CloseOnEscape, "Flags pressing escape key (ESC) closes the dialog.")%></li>
		<li><%=Html.LabelFor(vm=>vm.CloseText)     %><%=Html.TextBoxFor(vm=>vm.CloseText, "wide", "Text for the close button (text is visible hidden when using the standard theme).")%></li>
		<li><%=Html.LabelFor(vm=>vm.DialogClass)   %><%=Html.TextBoxFor(vm=>vm.DialogClass, "wide", "Specified class name is added to the dialog to enable further styling options.")%></li>
		<li><%=Html.LabelFor(vm=>vm.Draggable)     %><%=Html.CheckBoxFor(vm=>vm.Draggable, "Flags that the dialog can be dragged around by the titlebar handle.")%></li>
		<li><%=Html.LabelFor(vm=>vm.Height)        %><%=Html.TextBoxFor(vm=>vm.Height, "The height of the dialog, in pixels.  'Auto' adjusts the height based on the content in the dialog.", "")%></li>
		<li>
			<strong>Note that effects can have an impact on how the widget behaves.</strong><br />
			<%=Html.LabelFor(vm=>vm.ShowEffect)    %><%=Html.DropDownTipListFor(vm=>vm.ShowEffect, List.AnimationItems(), "Effect to use when the dialog is opened.")%>
		</li>
		<li><%=Html.LabelFor(vm=>vm.HideEffect)    %><%=Html.DropDownTipListFor(vm=>vm.HideEffect, List.AnimationItems(), "Effect to use when the dialog is closed.")%></li>
		<li><%=Html.LabelFor(vm=>vm.MaxHeight)     %><%=Html.TextBoxFor(vm=>vm.MaxHeight, "Maximum height to which the dialog can be resized, in pixels.", "")%></li>
		<li><%=Html.LabelFor(vm=>vm.MaxWidth)      %><%=Html.TextBoxFor(vm=>vm.MaxWidth, "Maximum width to which the dialog can be resized, in pixels.", "")%></li>
		<li><%=Html.LabelFor(vm=>vm.Modal)         %><%=Html.CheckBoxFor(vm=>vm.Modal, "Flags that the dialog will be modal; other items on the page will be disabled.")%></li>
		<li><%=Html.Label("Position")              %><%=Html.DropDownTipListFor(vm=>vm.Position1, List.DirectionItems(), "Specifies where the dialog should be displayed. Possible values: an array containing x,y position string values (e.g. ['right','top'] for top right corner).")%> 
		                                             <%=Html.DropDownTipListFor(vm=>vm.Position2, List.DirectionItems(), "Specifies where the dialog should be displayed. Possible values: an array containing x,y position string values (e.g. ['right','top'] for top right corner).")%>
		</li>
		<li><%=Html.LabelFor(vm=>vm.Resizable)     %><%=Html.CheckBoxFor(vm=>vm.Resizable, "Flags that the dialog can be resized.")%></li>
		<li><%=Html.LabelFor(vm=>vm.Stack)         %><%=Html.CheckBoxFor(vm=>vm.Stack, "Flags whether the dialog stacks on top of other dialogs, causing the dialog to move to the front of other dialogs to gain focus.")%></li>
		<li><%=Html.LabelFor(vm=>vm.Title)         %><%=Html.TextBoxFor(vm=>vm.Title, "wide", "Text to appear in the titlebar of the dialog.")%></li>
		<li><%=Html.LabelFor(vm=>vm.Width)         %><%=Html.TextBoxFor(vm=>vm.Width, "The width of the dialog, in pixels.", "")%></li>
		<li><%=Html.LabelFor(vm=>vm.ZIndex)        %><%=Html.TextBoxFor(vm=>vm.ZIndex, "The starting z-index of the dialog.", "")%></li>
	</ul>
	<hr />
	<h2>Test Harness Options</h2>
	<ul>
		<li><%=Html.LabelFor(vm=>vm.showEvents)    %><%=Html.CheckBoxFor(vm=>vm.showEvents, "Shows how events are wired up.")%></li>
		<li><%=Html.LabelFor(vm=>vm.renderCSS)     %><%=Html.CheckBoxFor(vm=>vm.renderCSS, "Shows the CSS generated by jQuery UI (so non-JavaScript users still see the layout/colours).")%></li>
		<li><%=Html.LabelFor(vm=>vm.prettyRender)  %><%=Html.CheckBoxFor(vm=>vm.prettyRender, "Shows the rendered control/JavaScript in a readable layout.  Turn this option off to see the compressed version (which is the default in a RELEASE build).")%></li>
	</ul>
	<input type="submit" value="UPDATE" />
<%}//form %>
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="DemoCodeContent" runat="server">
<%=this.Model.CSharpCode()%>
</asp:Content>



<asp:Content ID="Content4" ContentPlaceHolderID="DemoHtmlContent" runat="server">
<%
	// have to use a different ID here otherwise we'll end up with 2 dialogs appearing and now HTML!
	var dlg = this.Model.BuildDialogFromModel(this.ViewContext.Writer, "html_dlg");
	dlg.Rendering
		// SetAutoScript off as we want to show the JavaScript separately
		.SetAutoScript(false)
	.Finish();

using (dlg.RenderDialog()) {%>
	<p>Proin ...</p>
<%}%>
</asp:Content>



<asp:Content ID="Content5" ContentPlaceHolderID="DemoJavaScriptCodeContent" runat="server">
<%=this.Model.JavaScriptCode()%>
</asp:Content>



<asp:Content ID="Content6" ContentPlaceHolderID="DemoMethodsContent" runat="server">
	<%Dialog dlg = this.Model.BuildDialogFromModel(this.ViewContext.Writer, "sample_dlg");  %>
	<ul class="horizontal">
		<li><button id="open" title="Opens the dialog (if it's closed).">Open</button></li>
		<li><button id="close" title="Closes the dialog (if it's open).">Close</button></li>
		<li><button id="destroy" title="Returns the dialog back to it's pre-init state.">Destroy</button></li>
		<li><button id="disable" title="Disables the dialog.">Disable</button></li>
		<li><button id="enable" title="Enables the dialog.">Enable</button></li>
		<li><button id="isOpen" title="Queries if the dialog is currently open.">Is Open</button></li>
		<li><button id="moveToTop" title="Moves the dialog to the top of the dialog stack (useful when there are multiple dialogs on the page).">Move To Top</button></li>
	</ul>
	<script type="text/javascript">
	$(document).ready(function() {
		$("#open").click(function() { <%dlg.Methods.Open();%>; });
		$("#close").click(function() { <%dlg.Methods.Close();%>; });
		$("#destroy").click(function() { if (confirm("are you sure you want to destroy the dialog?")) <%dlg.Methods.Destroy();%>; });
		$("#disable").click(function() { <%dlg.Methods.Disable();%>; });
		$("#enable").click(function() { <%dlg.Methods.Enable();%>; });
		$("#isOpen").click(function() { alert("Dialog IsOpen returned [" + <%dlg.Methods.IsOpen();%> + "]"); });
		$("#moveToTop").click(function() { <%dlg.Methods.MoveToTop();%>; });
	});
	</script>
</asp:Content>

