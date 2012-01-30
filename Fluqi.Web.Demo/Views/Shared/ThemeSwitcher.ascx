<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Assembly Name="Fluqi" %>
<%@ Import Namespace="Fluqi.Extension" %>

<%
	var switchPanel = Html.CreateAccordion("switchPanel")
		.Panels
			.Add("jQuery UI Theme Switcher")
		.Finish()
		.Rendering
			.Compress()
		.Finish()
	;
	%>
<%using (switchPanel.RenderContainer()) {%>
	<%using (switchPanel.Panels.RenderNextPane()) { %>
		<div id="themeswitcher"></div>
	<%} %>
<%} %>

