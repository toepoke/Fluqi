<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Builder.Master" Inherits="System.Web.Mvc.ViewPage<Fluqi.Models.AccordionModel>" %>
<%@ Import Namespace="Fluqi.Web.Demo.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DemoMainContent" runat="server">
<script src="<%=Url.Content("~/Scripts/accordion.js")%>" type="text/javascript"></script>
<%		
	var iconCheatDlg = Html.CreateDialog("icon-cheat");
	this.Model.ConfigureIconCheatSheetDialog(iconCheatDlg);

	var ac = Html.CreateAccordion("ac");
	this.Model.ConfigureAccordion(ac)	;

	using (ac.RenderContainer()) { %>

		<%using (ac.Panels.RenderNextPane()) {%>
			<p>
				Proin elit arcu, rutrum commodo, vehicula tempus, commodo a, risus. Curabitur nec arcu. Donec 
				sollicitudin mi sit amet mauris. Nam elementum quam ullamcorper ante. Etiam aliquet massa et 
				lorem. Mauris dapibus lacus auctor risus. Aenean tempor ullamcorper leo. Vivamus sed magna 
				quis ligula eleifend adipiscing. Duis orci. Aliquam sodales tortor vitae ipsum. Aliquam nulla. 
				Duis aliquam molestie erat. Ut et mauris vel pede varius sollicitudin. Sed ut dolor nec orci 
				tincidunt interdum. Phasellus ipsum. Nunc tristique tempus lectus.
			</p>
		<%} %>

		<%using (ac.Panels.RenderNextPane()) {%>
			<p>
				Morbi tincidunt, dui sit amet facilisis feugiat, odio metus gravida ante, ut pharetra massa 
				metus id nunc. Duis scelerisque molestie turpis. Sed fringilla, massa eget luctus malesuada, 
				metus eros molestie lectus, ut tempus eros massa ut dolor. Aenean aliquet fringilla sem. 
				Suspendisse sed ligula in ligula suscipit aliquam. Praesent in eros vestibulum mi adipiscing 
				adipiscing. Morbi facilisis. Curabitur ornare consequat nunc. Aenean vel metus. Ut posuere 
				viverra nulla. Aliquam erat volutpat. Pellentesque convallis. Maecenas feugiat, tellus 
				pellentesque pretium posuere, felis lorem euismod felis, eu ornare leo nisi vel felis. 
				Mauris consectetur tortor et purus.
			</p>
		<%} %>

		<%using (ac.Panels.RenderNextPane()) {%>
			<p>
				Mauris eleifend est et turpis. Duis id erat. Suspendisse potenti. Aliquam vulputate, pede vel vehicula accumsan, 
				mi neque rutrum erat, eu congue orci lorem eget lorem. Vestibulum non ante. Class aptent taciti sociosqu 
				ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce sodales. Quisque eu urna vel enim 
				commodo pellentesque. Praesent eu risus hendrerit ligula tempus pretium. Curabitur lorem enim, pretium nec, 
				feugiat nec, luctus a, lacus.
			</p>
			<p>
				Duis cursus. Maecenas ligula eros, blandit nec, pharetra at, semper at, magna. Nullam ac lacus. Nulla 
				facilisi. Praesent viverra justo vitae neque. Praesent blandit adipiscing velit. Suspendisse potenti. 
				Donec mattis, pede vel pharetra blandit, magna ligula faucibus eros, id euismod lacus dolor eget odio. 
				Nam scelerisque. Donec non libero sed nulla mattis commodo. Ut sagittis. Donec nisi lectus, feugiat 
				porttitor, tempor ac, tempor vitae, pede. Aenean vehicula velit eu tellus interdum rutrum. Maecenas commodo. 
				Pellentesque nec elit. Fusce in lacus. Vivamus a libero vitae lectus hendrerit hendrerit.
			</p>
		<%} %>
	 
<%} // using(accordion) %>

<%using (iconCheatDlg.RenderDialog()) { %>
	<%Html.RenderPartial("Icons");%>
<%} %>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="DemoExampleContent" runat="server">
<%
	var showIcons1 = Html.CreateButton("showIcons1", "...")
		.Rendering.SetPrettyRender(true).Finish()
		.Events
			.SetClickEvent("return openIconsDialog('headerIconClass');")
		.Finish()
	;

	var showIcons2 = Html.CreateButton("showIcons2", "...")
		.Rendering.SetPrettyRender(true).Finish()
		.Events
			.SetClickEvent("return openIconsDialog('headerSelectedIconClass');")
		.Finish()
	;
%>
<%using (Html.BeginForm("Accordion", "Builder")) {%>
	<input type="submit" value="UPDATE" />
	<ul>
		<li><%=Html.LabelFor(vm=>vm.collapsible)%>             <%=Html.CheckBoxFor(vm=>vm.collapsible, "Panels can be collapsed (hiding the content of the panel).")%></li>
		<li><%=Html.LabelFor(vm=>vm.disabled)%>                <%=Html.CheckBoxFor(vm=>vm.disabled, "Disables all panels, changing the opacity and stops the panels from being clickable.")%></li>
		<li><%=Html.LabelFor(vm=>vm.animate)%>                 <%=Html.TextBoxFor(vm=>vm.animate, "wide", "How panel opening/closing should be animated, for example 'easeOutBounce' (with quotes)")%></li>
		<li><%=Html.LabelFor(vm=>vm.evt)%>                     <%=Html.DropDownTipListFor(vm=>vm.evt, List.BrowserEventItems(), "Event to use to expand/contract the panels.")%></li>
		<li><%=Html.LabelFor(vm=>vm.autoHeight)%>              <%=Html.CheckBoxFor(vm=>vm.autoHeight, "Makes all the panels the same height, so the rest of the content on the page stays in a consistent location.")%></li>
		<li><%=Html.LabelFor(vm=>vm.clearStyle)%>              <%=Html.CheckBoxFor(vm=>vm.clearStyle, "Clears height and overflow styles after finishing animations. This enables accordion to work with dynamic content. Won't work together with autoHeight")%></li>
		<li><%=Html.LabelFor(vm=>vm.fillSpace)%>               <%=Html.CheckBoxFor(vm=>vm.fillSpace, "Accordion completely fills the height of the parent element. Overrides autoheight.")%></li>
		<li><%=Html.LabelFor(vm=>vm.navigation)%>              <%=Html.CheckBoxFor(vm=>vm.navigation, "Looks for the anchor that matches location.href and activates it. Great for href-based state-saving. Use navigationFilter to implement your own matcher.")%></li>
		<li><%=Html.LabelFor(vm=>vm.navigationFilter)%>        <%=Html.TextBoxFor(vm=>vm.navigationFilter, "wide", "Overwrite the default location.href-matching with your own matcher.")%></li>
		<li><%=Html.LabelFor(vm=>vm.activePanel)%>             <%=Html.TextBoxFor(vm=>vm.activePanel, "Pick an alternative selected panel on page load, in this example pick between 0 and 2.")%></li>
		<li><%=Html.LabelFor(vm=>vm.headerIconClass) %>        <%=Html.DropDownTipListFor(vm=>vm.headerIconClass, List.IconListNames(), "Overrides the icon for the unselected panel, try 'ui-icon-plusthick' for example.")%> <%showIcons1.Render();%>  </li> 
		<li><%=Html.LabelFor(vm=>vm.headerSelectedIconClass)%> <%=Html.DropDownTipListFor(vm=>vm.headerSelectedIconClass, List.IconListNames(), "Overrides the icon for the selected panel, try 'ui-icon-minusthick' for example.")%> <%showIcons2.Render();%> </li>
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
	var ac = Html.CreateAccordion("ac");
	this.Model.ConfigureAccordion(ac)	;
%>	
<%=this.Model.CSharpCode(ac)%>
</asp:Content>



<asp:Content ID="Content4" ContentPlaceHolderID="DemoHtmlContent" runat="server">
<%
	var ac = Html.CreateAccordion("ac");
	this.Model.ConfigureAccordion(ac);

	ac
		.Rendering
			// SetAutoScript off as we want to show the JavaScript separately
			.SetAutoScript(false)
		.Finish();
%>
<%using (ac.RenderContainer()) {%>
<%	using (ac.Panels.RenderNextPane()) {%><p>Proin ...</p><%}%>
<%	using (ac.Panels.RenderNextPane()) {%><p>Morbi ...</p><%}%>
<%	using (ac.Panels.RenderNextPane()) {%><p>Mauris ...</p><%}%>
<%}%>
</asp:Content>



<asp:Content ID="Content5" ContentPlaceHolderID="DemoJavaScriptCodeContent" runat="server">
<%
	var ac = Html.CreateAccordion("ac");
	this.Model.ConfigureAccordion(ac)	;
%>	
<%=this.Model.JavaScriptCode(ac)%>
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="DemoMethodsContent" runat="server">
	<ul class="horizontal">
		<li><button id="activate-1" title="Activates the first panel.">activate pane #1</button></li>
		<li><button id="activate-2" title="Activates the second panel.">activate pane #2</button></li>
		<li><button id="activate-3" title="Activates the third panel.">activate pane #3</button></li>
	</ul>
	<ul class="clear horizontal">
		<li><button id="enable" title="Enables the accordion.">Enable</button></li>
		<li><button id="disable" title="Disables the accordion.">Disable</button></li>
		<li><button id="destroy" title="Returns the accordion back to it's pre-init state.">Destroy</button></li>
		<li><button id="refresh" title="Recomputes height of the accordion when using the fillSpace option.">Resize</button></li>
	</ul>
<%
	var ac = Html.CreateAccordion("ac");
	this.Model.ConfigureAccordion(ac)	;
%>	
	<script type="text/javascript">
	$(document).ready(function() {
		$("#activate-1").click(function() { <%ac.Methods.Activate(0);%>; });
		$("#activate-2").click(function() { <%ac.Methods.Activate(1);%>; });
		$("#activate-3").click(function() { <%ac.Methods.Activate(2);%>; });
		$("#enable").click(function() { <%ac.Methods.Enable();%>; });
		$("#disable").click(function() { <%ac.Methods.Disable();%>; });
		$("#destroy").click(function() {  if (confirm("are you sure you want to destroy the accordion?")) <%ac.Methods.Destroy();%>; });
		$("#refresh").click(function() { <%ac.Methods.Refresh();%>; });
	});
	</script>
</asp:Content>
