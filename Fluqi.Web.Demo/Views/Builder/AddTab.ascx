<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<int>" %>

<p>
	Tab <strong><%=this.Model%></strong> was added on <%=DateTime.Now.ToLongDateString()%> at <%=DateTime.Now.ToLongTimeString()%>.
</p>