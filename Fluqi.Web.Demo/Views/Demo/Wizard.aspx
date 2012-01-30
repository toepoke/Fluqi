<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Demo.Parent.Master" Inherits="System.Web.Mvc.ViewPage<Fluqi.Models.WizardModel>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
	<link href="<%=Url.Content("~/Content/Wizard.css")%>" rel="stylesheet" type="text/css" />
	<script src="<%=Url.Content("~/Scripts/wizard.js")%>" type="text/javascript"></script>
</asp:Content>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<section id="main">
		<p>
			This demo merely illustrates using the <strong>Fluqi</strong> library in a semi-realistic scenario.  Illustrating
			all the widget entry points together.
		</p>
		<div id="themeswitcher"></div>
		<%
		var sidebar = Html.CreateAccordion("sidebar");
		var wizard = Html.CreateTabs("wizard");
		var next = Html.CreateButton("next-button", "Next");
		var back = Html.CreateButton("back-button", "Back");
		var finish = Html.CreateButton("finish-button", "Finish");
		var dobPicker = Html.CreateDatePicker("DateOfBirth");
		var progress = Html.CreateProgressBar("progress");
		var sldr = Html.CreateSlider("sldr")
			.Options.SetMin(18).SetMax(99).SetAnimate(true).Finish()
			.Events.SetSlideEvent("return changeAge(event, ui);").Finish()
		;
		var autoComplete = Html.CreateAutoComplete("HowOften", "playFrequency")
			.Options.SetMinimumLength(0).SetDelay(1).SetAutoFocus(true).Finish()
		;
		var confirmDlg = Html.CreateDialog("confirmDlg")
			.Options
				.SetAutoOpen(false)
				.SetTitle("Please confirm your selection.")
				.AddButton("OK", "$(\"#confirmDlg\").dialog(\"close\");")
			.Finish()		
		;

		this.Model.ConfigureSideBar(sidebar);
		this.Model.ConfigureTabs(wizard);
		this.Model.ConfigureButtons(back, next, finish);
		this.Model.ConfigureDatePicker(dobPicker);
		%>

		<div id="sidebar-container">
			<div id="progress"></div>
			<%using (sidebar.RenderContainer()) { %>
				<%using (sidebar.Panels.RenderNextPane()) { %>
					<p>We need to know a few things about you.</p>
				<%} %>
				<%using (sidebar.Panels.RenderNextPane()) { %>
					<p>Tell us about the game <a href="http://toepoke.co.uk">toepoke</a> is going to organise for you.</p>
				<%} %>
				<%using (sidebar.Panels.RenderNextPane()) { %>
					<p>Cool, we're done.</p>
				<%} %>
			<%} %>
		</div>

		<%using (wizard.RenderHeader()) { %>
			<% using (wizard.Panes.RenderNextPane()) { %>
				<ul>
					<li>
						<%=Html.LabelFor(m=>m.Name)%>
						<%=Html.TextBoxFor(m=>m.Name, new {@class = "extra-wide"})%>
					</li>
					<li>
						<%=Html.LabelFor(m=>m.DateOfBirth)%>
						<%=Html.TextBoxFor(m=>m.DateOfBirth, new {@class = "wide"})%>
					</li>
					<li>
						<div id="sldr"></div>
						<%=Html.LabelFor(m=>m.Age)%>
						<%=Html.TextBoxFor(m=>m.Age)%>
					</li>
				</ul>
			<% } %>
			<% using (wizard.Panes.RenderNextPane()) { %>
				<ul>
					<li>
						<%=Html.LabelFor(m=>m.HowOften)%>
						<%=Html.TextBoxFor(m=>m.HowOften, new {@class = "extra-wide"})%>
					</li>
					<li>
						<%=Html.LabelFor(m=>m.Duration)%>
						<%=Html.DropDownListFor(m=>m.Duration, Model.PlayingTimes(), "Select")%>
					</li>
				</ul>
			<% } %>
			<% using (wizard.Panes.RenderNextPane()) { %>
			<p>Your selections are:</p>
			<ul id="summary">
			</ul>
			<% } %>
			<div id="wizard-bar">
				<div id="button-bar">
					<%back.Render();%><%next.Render();%><%finish.Render();%>
				</div>
			</div>
		<%} %>
		<div class="clear"></div>
		<%using (confirmDlg.RenderDialog()) { %>
			<p>Are you sure you are happy with your settings?</p>
		<%} %>
	</section><%--main--%>


<script type="text/javascript">
	$(document).ready(function() {
<%sidebar.RenderStartUpScript(false);%>
<%wizard.RenderStartUpScript(false);%>
<%back.RenderStartUpScript(false);%>
<%next.RenderStartUpScript(false);%>
<%finish.RenderStartUpScript(false);%>
<%dobPicker.RenderStartUpScript(false);%>
<%progress.RenderStartUpScript(false);%>
<%sldr.RenderStartUpScript(false);%>
<%autoComplete.RenderStartUpScript(false);%>
<%confirmDlg.RenderStartUpScript(false);%>
		initView();
	});
</script>
<script type="text/javascript" src="http://jqueryui.com/themeroller/themeswitchertool/"></script>
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="Navigation" runat="server">
	<ul>
		<li><%=Html.ActionLink("Home", "Home", "Home")%></li>
		<li><%=Html.ActionLink("Builder", "Accordion", "Builder")%></li>
	</ul>
</asp:Content>
