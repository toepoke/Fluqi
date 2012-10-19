<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Assembly Name="Fluqi" %>
<%@ Import Namespace="Fluqi.Extension" %>

<%
	var switchPanel = Html.CreateAccordion("switchPanel")
		.Panels
			.Add("jQuery UI Theme Switcher")
		.Finish()
		.Rendering
			.Compress().SetRenderCSS(true).SetAutoScript(false)
		.Finish()
	;
	%>
<%--<%using (switchPanel.RenderContainer()) {%>
	<%using (switchPanel.Panels.RenderNextPane()) { %>
--%>

	<div id="switchPanel" class="ui-accordion-header ui-helper-reset ui-state-default ui-state-active ui-corner-top">
		<h3 class="ui-accordion-header ui-helper-reset ui-state-default ui-state-active ui-corner-top"><a href="#">jQuery UI Theme Switcher</a></h3>
		<div class="ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom ui-accordion-content-active">
			<div id="themeswitcher"></div>
		</div>
	</div>

<%--	<%} %>
<%} %>
--%>
