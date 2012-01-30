<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Assembly Name="Fluqi" %>
<%@ Import Namespace="Fluqi.Extension" %>
<div>
	<%
		var jqEvtPanel = Html.CreateAccordion("logPanel")
			.Panels
				.Add("jQuery Events Log")
			.Finish()
			.Options
				.SetCollapsible(true)
				.Finish()
			.Rendering
				.Compress()
			.Finish()
		;
		%>
	<%using (jqEvtPanel.RenderContainer()) {%>
		<%using (jqEvtPanel.Panels.RenderNextPane()) { %>
			<div id="log">
				<p>
					Tick the <strong>Show & Render Events</strong> checkbox
					to start showing the events (and click <strong>Update</strong>).
				</p>
			</div>
		<%} %>
	<%} %>
	<input type="button" id="ResetLog" value="Reset" />
</div>

