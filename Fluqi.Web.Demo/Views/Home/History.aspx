<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Fluqi.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Fluqi.Web.Demo.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">	
	<script type="text/javascript" src="<%=Url.Content("~/Scripts/fluqi-helpers.js")%>"></script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Navigation" runat="server">	
	<ul id="nav">
		<li><%=Html.ActionLink("Home", "Home", "Home")%></li>
	</ul>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="content-wrap">
	<section id="main">

	<div class="intro-box">
		<h1>Change Log</h1>
		<p>
			I never expected <%=Html.ActionLink("Fluqi", "Home", "Home")%> to 
			<a href="<%=Url.Content("~/Content/asp-net-front-page.jpg")%>" 
				title="Fluqi on the asp.net home page, second only 'the guth', I can live with that :)">gather such interest so soon</a> 
			and it's fantastic that it has.
		</p>
		<p>
			I've noticed, and fixed, a couple of issues since the first release.  Here are the details of
			these changes, which may help you with migrating your existing code.
		</p>
	</div>

	<div class="slider-wrapper">
		<div id="" style="margin-left: 20px; margin-top: 20px;">
			<a href="<%=Url.Content("~/Content/asp-net-front-page.jpg")%>" title="Fluqi on the asp.net home page">
				<img src="<%=Url.Content("~/Content/asp-net-front-page-thumb.jpg")%>" alt="Fluqi on the asp.net home page" />
			</a>
		</div>
	</div>
	<div class="clearfix"></div>

	<h2>1.9.0 - breaking build</h2>
	<p>
		<a href="http://jqueryui.com/">jQuery UI 1.9.0</a> was released a few weeks back.  This brings some major changes
		including the new <a href="http://jqueryui.com/menu/">menu</a>, <a href="http://jqueryui.com/spinner/">spinner</a>
		and <a href="http://jqueryui.com/tooltip/">tooltip</a> widgets.  Naturally this version of Fluqi add support
		for these new widgets.
	</p>
	<p>
		As part of this release the jQuery UI team have depreciated quite a few methods.  I've taken the step
		of removing these entry points to Fluqi rather than mark them as 
		<a href="http://msdn.microsoft.com/en-us/library/system.obsoleteattribute.aspx">obsolete</a>.  
		This is to discourage users from using something that will disappear later.  Some methods have also 
		been renamed, and Fluqi has had it's entry points renamed too.
	</p>
	<p>
		If you need to use any of the entry points laid out in the 
		<a href="http://jqueryui.com/upgrade-guide/1.9">jQuery UI 1.9 Upgrade Guide</a>
		I suggest you hold fire on version <strong>0.1.6</strong> of Fluqi.
	</p>
	<p>
		In any case I implore you to review the <a href="http://jqueryui.com/upgrade-guide/1.9/">upgrade guide</a>
		for jQuery UI <strong>before</strong> upgrading to Fluqi 1.9.0.
	</p>
	<p>
		New users of Fluqi should use version 1.9.0 if their application can also take 1.9.0 of jQuery UI.
	</p>
	<p>
		In an attempt to reduce confusion I intend to keep the version of Fluqi in line with the version of jQuery UI
		required.  Hence the massive jump from 0.1.6 to 1.9.0.
	</p>

	<h2>0.1.6</h2>
	<ul>
		<li>
		Fix for <a href="https://github.com/toepoke/Fluqi/issues/1">Issue #1</a>.
		</li>
		<li>
		Added <i>cheat sheet</i> in the Accordion and PushButton builder screens so you can pick the icon from a dialog rather than
		<i>guess</i> through the dropdown list.
		</li>
		<li>
		Added <strong>Articles</strong> to the home page to add any articles referencing Fluqi.  Got one?  
		<a href="mailto:contact[at]toepoke.co.uk">Let us know :)</a>
		</li>
	</ul>

	<h2>0.1.5</h2>
	<p>
		0.1.5 was a bad build, please ignore.  Use 0.1.6 instead.
	</p>

	<h2>0.1.4</h2>
	<ul>
		<li>
		Accordion panels can now be configured fluently more easily with the addition of a <strong>Configure()</strong>
		method after the panel has been added.  Please see the <a href="https://raw.github.com/toepoke/Fluqi/master/Fluqi.Tests/Accordion/AccordionTests-Core.cs">Accordion_Can_Set_ID_On_Panel()</a> test
		for an illustration.
		</li>
		<li>
		Accordion control incorrectly added <strong>ui-accordion-icons</strong> class even if icons weren't being displayed.
		</li>
		<li>
		The HTML mark-up used by the Accordion control can now be overriden, see 
		<a href="https://raw.github.com/toepoke/Fluqi/master/Fluqi.Tests/Accordion/AccordionTests-Core.cs">Accordion_Can_Override_Container_HTML_And_Header_HTML_And_Content_HTML_Tags</a>
		test for an illustration.
		</li>
	</ul>

	<h2>0.1.3</h2>
	<ul>
		<li>
			Razor engine requires additional entries in the web.config to include the namespaces. These have now been added.
			Note this is only present in the <a href="http://nuget.org/packages/fluqi">nuget package</a>, however
			it is included in the 0.1.4 release on <a href="https://github.com/toepoke/Fluqi/downloads">github</a>.
		</li>
	</ul>

	<h2>0.2.0</h2>
	<ul>
		<li>Initial <a href="http://nuget.org/packages/fluqi">nuget package</a> released</li>
	</ul>

	<h2>0.1.0</h2>
	<ul>
		<li>Initial version</li>
	</ul>

	<a class="back-to-top" href="#header-wrap">Back to Top</a>
</section> <%--main--%>

</div> <%--content-wrap--%>

</asp:Content>
