<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/WebForms.Master" AutoEventWireup="true" CodeBehind="QuickDemo.aspx.cs" Inherits="Fluqi.Web.Demo.WebForms.QuickDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<script src="../Scripts/autocomplete-results.js" type="text/javascript"></script>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
	<section id="main">
	<p>
		This is just a small demonstration illustrating that <strong>Fluqi</strong> can be used with WebForms too.
		There is a small coding difference, just include the <strong>Fluqi.Extension</strong> namespace on your page
		as normal, but the call <strong title="CreateAccordion, CreateTabs, etc">Page.Create methods</strong> 
		instead.
	</p>
	<div id="themeswitcher"></div>
<%
	var ac = this.BuildAccordion();
	
	using (ac.RenderContainer()) {

		using (ac.Panels.RenderNextPane()) { %>
			<p>Little demo showing how to code up a tab control with 3 tabs.</p>
			<%
			// Accordion pane: Tabs Demo
			var tabs = this.BuildTabs();%>

			<%using (tabs.RenderHeader()) { %>
				<%using (tabs.Panes.RenderNextPane()) { %>
					<p>This is tab #1</p>
				<%} %>
				<%using (tabs.Panes.RenderNextPane()) { %>
				<p>This is tab #2</p>
				<%} %>
				<%using (tabs.Panes.RenderNextPane()) { %>
				<p>This is tab #3</p>
				<%} %>
			<%} %>
			<p>Note in the designer source how <strong>using</strong> blocks define the content of the tab panels.</p>
		<%} %>


		<%
		 // Accordion pane: AutoComplete Demo
		 using (ac.Panels.RenderNextPane()) { %>
			<p>
				Demo showing how to attach auto-complete functionality to an ASP.NET TextBox control
				defined on the page.
			</p>
			<label for="<%=languageAutocomplete.ClientID%>">Which language?</label>
			<asp:TextBox ID="languageAutocomplete" runat="server" CssClass="wide"></asp:TextBox>
			<%
				// availableTags is a JS array in the "autocomplete-results.js" script
				var txtAutoComplete = this.CreateAutoComplete(languageAutocomplete.ClientID, "availableTags");	
				txtAutoComplete.Options.SetDelay(1).Finish();		 
				txtAutoComplete.RenderStartUpScript();
		  %>
		<%} %>


		<%
		 // Accordion pane: DatePicker Demo
		 using (ac.Panels.RenderNextPane()) { %>
			<p>
				Demo showing how to attach date-picker functionality to an ASP.NET TextBox control
				defined on the page.
			</p>
			<label for="<%=txtBirthday.ClientID%>">Your birthday?</label>
			<asp:TextBox ID="txtBirthday" runat="server" CssClass="wide"></asp:TextBox>
			<%
				var birthday = this.CreateDatePicker(txtBirthday.ClientID);
				birthday
					.Options
						.SetShowAnim(Fluqi.Core.Animation.eAnimation.Explode)
						.SetButtonText("Open")
					.Finish()
					.RenderStartUpScript()
				;
			%>
		<%} %>


		<%
		 // Accordion pane: Slider Demo
		 using (ac.Panels.RenderNextPane()) { %>
			<p>
				Demo showing how to create a slider control, and have <strong>Fluqi</strong> render
				the resulting HTML on our behalf.  
			</p>
			<%
				var sldr = this.CreateSlider("sldr");
				sldr
					.Options
						.SetValues(3, 4)		
						.SetRange(true)
					.Finish()
					.Render()
				;
			%>
			<p>
				Want to attach to an existing <strong>div</strong>?
				Just drop the call to <strong><i>Render</i></strong>.
			</p>
		<%} %>


		<%
		 // Accordion pane: ProgressBar Demo
		 using (ac.Panels.RenderNextPane()) { %>
			<p>Progress bar set to 33% complete.</p>
			<%
				var pb = this.CreateProgressBar("pb");
				pb
					.Options
						.SetValue(33)
					.Finish()
					.Render();
			%>
		<%} %>


		<%
		 // Accordion pane: Dialog Demo
		 using (ac.Panels.RenderNextPane()) { %>
			<p>Demo showing how to build a dialog.</p>
			<%
				var dlg = this.CreateDialog("confirm");
				dlg
						.Options
							.SetAutoOpen(false)
							.SetTitle("My Dialog")
						.AddButton("OK", "$(this).dialog(\"close\");")
						.Finish()
				;				
		  %>
			<%using (dlg.RenderDialog()) { %>
				<p>Here's the dialog you asked for!</p>
			<%} %>
			<p><a href="#" onclick='<%dlg.Methods.Open();%>'>Clicking here will open it.</a></p>
		<%} %>


		<%
		 // Accordion pane: PushButton Demo
		 using (ac.Panels.RenderNextPane()) { %>
			<p>Demo showing how we can have Fluqi render a button for us, like this one</p>
			<%
				var btn1 = this.CreateButton("btn1", "Fluqi created link")
					.Options
						.SetIcons(Fluqi.Core.Icons.eIconClass.locked, Fluqi.Core.Icons.eIconClass.unlocked)
					.Finish()
					.Events
						.SetClickEvent("alert('Click from a Fluqi rendered created and rendered link!'); return false;")
					.Finish()
					.RenderAs(Fluqi.Core.ButtonType.eButtonType.Hyperlink)
				;
				btn1.Render();	
			%>
			<p>And this shows how we can have a normal ASP.NET button and have it styled by jQuery UI (via Fluqi!)</p>
			<!-- 
				Note that Icons won't work with asp:Button as it renders as an input HTML element, for further details see 
				http://jqueryui.com/demos/button/#overview
			-->
			<asp:Button ID="btn2" runat="server" Text="ASP.NET button" />
			<%
				var myBtn = this.CreateButton(btn2.ClientID, "x")
					.Events
						.SetClickEvent("alert('Click from an ASP.NET server-side button'); return false;")
					.Finish()
				;
				myBtn.RenderStartUpScript();		
			%>
		<%} %>

	<%} %>
	</section>
	<script type="text/javascript" src="http://jqueryui.com/themeroller/themeswitchertool/"></script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="Navigation" runat="server">
	<ul>
		<li><asp:HyperLink Text="Home" NavigateUrl="~/" runat="server"></asp:HyperLink></li>
		<li><asp:HyperLink Text="Builder" NavigateUrl="~/Builder/Accordion" runat="server"></asp:HyperLink></li>
	</ul>
</asp:Content>
