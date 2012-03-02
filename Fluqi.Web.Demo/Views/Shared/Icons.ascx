<%@ Import Namespace="System.Collections.Generic" %>
<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%
	// we're not getting them through the model, which is a little naughty, but "hey, it's a demo" :)
	var icons = Fluqi.Core.Icons.ToList();
%>
<ul id="icons" class="ui-widget ui-helper-clearfix">
<%foreach (string item in icons) { %>
<li class="ui-state-default ui-corner-all" title="<%=item%>">
	<span class="ui-icon <%=item%>"></span>
</li>
<%}%>
</ul>

