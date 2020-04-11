<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Builder.Master" Inherits="System.Web.Mvc.ViewPage<Fluqi.Models.DatePickerModel>" %>
<%@ Import Namespace="Fluqi.Web.Demo.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DemoMainContent" runat="server">
<script src="<%=Url.Content("~/Scripts/date-picker.js")%>" type="text/javascript"></script>
<label for="mypicker" style="width: 100px">DatePicker:</label>
<%=Html.TextBox("dt", "", new{@class="wide"})%>
<label for="selectedDate" style="margin-left: 50px; width: 100px;">Selected Date:</label>
<input id="selectedDate" type="text" class="wide" title="Set the AltField to '#selectedDate' to have the selected date appear here" />
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="DemoExampleContent" runat="server">
<p>
	This section configures the look &amp; feel of the Datepicker control as it initially appears. 
	This corresponds to the options that appear on the <a href="https://jqueryui.com/demos/datepicker/#options" title="Note not all properties are featured">Datepicker options page</a>.
</p>
<%using (Html.BeginForm("DatePicker", "Builder")) {%>
	<input type="submit" value="UPDATE" />
	<ul>
			
		<li class="nested">
			<i>Activation Options</i>
			<ul>
				<li><%=Html.LabelFor(vm=>vm.Disabled)         %><%=Html.CheckBoxFor(vm=>vm.Disabled, "Disables the textbox where the datepicker is attached (note the whole textbox input is disabled).")%></li>
				<li><%=Html.LabelFor(vm=>vm.ShowAnim)         %><%=Html.DropDownTipListFor(vm=>vm.ShowAnim, List.AnimationItems(), "Animation to use when showing the picker; For example try 'fold'.")%></li>
				<li><%=Html.LabelFor(vm=>vm.Duration)         %><%=Html.TextBoxFor(vm=>vm.Duration, "wide", "Speed of the animation used; For example try 'slow' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.ShowOn)           %><%=Html.TextBoxFor(vm=>vm.ShowOn, "wide", "How the user activates the picker; For example try 'button' or 'both' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.ButtonText)       %><%=Html.TextBoxFor(vm=>vm.ButtonText, "wide", "Text to appear on the button (when 'ShowOn' is 'button'); For example try 'Browse' (without the quotes)")                %></li>
				<li><%=Html.LabelFor(vm=>vm.AutoSize)         %><%=Html.CheckBoxFor(vm=>vm.AutoSize, "Re-sizes the textbox to fit whatever resulting date is picked") %></li>
				<li><%=Html.LabelFor(vm=>vm.ButtonImage)      %><%=Html.TextBoxFor(vm=>vm.ButtonImage, "extra-wide", "'ShowOn' must be 'button' or 'both'")%></li>
				<li><%=Html.LabelFor(vm=>vm.ButtonImageOnly)  %><%=Html.CheckBoxFor(vm=>vm.ButtonImageOnly, "'ShowOn' must be 'button' or 'both'")%></li>
				<li><%=Html.LabelFor(vm=>vm.ConstrainInput)   %><%=Html.CheckBoxFor(vm=>vm.ConstrainInput, "Only allows characters expressed in formatDate")%></li>
				<li><%=Html.LabelFor(vm=>vm.DateFormat)       %><%=Html.TextBoxFor(vm=>vm.DateFormat, "wide", "For example try 'yy-mm-dd'")%></li>
				<li><%=Html.LabelFor(vm=>vm.DefaultDate)      %><%=Html.TextBoxFor(vm=>vm.DefaultDate, "wide", "Date to be highlighted when DatePicker is first opened; For example try '+1m +7d' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.FirstDay)         %><%=Html.TextBoxFor(vm=>vm.FirstDay, "First day of the week (for regionalisation); For example try '3' (no quotes) for 'Wednesday'", "")%></li>
				<li><%=Html.LabelFor(vm=>vm.GotoCurrent)      %><%=Html.CheckBoxFor(vm=>vm.GotoCurrent, "Current day link moves to the currently selected date instead of today")%></li>
				<li><%=Html.LabelFor(vm=>vm.ShortYearCutoff)  %><%=Html.TextBoxFor(vm=>vm.ShortYearCutoff, "wide", "Sets cut-off year for determining which century we're talking about when 2 digit for the year are used; For example try '11' (without the quotes)")%></li>
			</ul>
		</li>

		<li class="nested">
			<i>Button Panel</i>
			<ul>
				<li><%=Html.LabelFor(vm=>vm.ShowButtonPanel)  %><%=Html.CheckBoxFor(vm=>vm.ShowButtonPanel, "Picker dialog will show Today/Done links at the bottom.") %></li>
				<li><%=Html.LabelFor(vm=>vm.CloseText)        %><%=Html.TextBoxFor(vm=>vm.CloseText, "wide", "Change the Close dialog text ('ShowButtonPanel' must be active); For example try 'OK'")%></li>
				<li><%=Html.LabelFor(vm=>vm.CurrentText)      %><%=Html.TextBoxFor(vm=>vm.CurrentText, "wide", "Change the Today dialog text ('ShowButtonPanel' must be active); For example try 'NOW'")%></li>
			</ul>
		</li>

		<li class="nested">
			<i>Show Options</i>
			<ul>
				<li><%=Html.LabelFor(vm=>vm.ShowInline)        %><%=Html.CheckBoxFor(vm=>vm.ShowInline, "Picker is shown as part of the page, no user intervention required to show it.") %></li>
				<li><%=Html.LabelFor(vm=>vm.NumberOfMonths)    %><%=Html.TextBoxFor(vm=>vm.NumberOfMonths, "Number of months to show when DatePicker is open; For example try '3' (without the quotes)", "")%></li>
				<li><%=Html.LabelFor(vm=>vm.StepMonths)        %><%=Html.TextBoxFor(vm=>vm.StepMonths, "How many months to move when clicking Next/Prev; For example try '2' (without the quotes)", "")%></li>
				<li><%=Html.LabelFor(vm=>vm.ShowCurrentAtPos)  %><%=Html.TextBoxFor(vm=>vm.ShowCurrentAtPos, "Where the current month is displayed when 'NumberOfMonths' is active.", "")%></li>
				<li><%=Html.LabelFor(vm=>vm.ShowMonthAfterYear)%><%=Html.CheckBoxFor(vm=>vm.ShowMonthAfterYear, "Label shows '2011 December' or 'December 2011'")%></li>
				<li><%=Html.LabelFor(vm=>vm.ShowOtherMonths)   %><%=Html.CheckBoxFor(vm=>vm.ShowOtherMonths, "Shows days in other months (for example if the current month is March, the last few days of February are also shown.")%></li>
				<li><%=Html.LabelFor(vm=>vm.SelectOtherMonths) %><%=Html.CheckBoxFor(vm=>vm.SelectOtherMonths, "'ShowOtherMonths' must be on - you can then select days in next/prev month as well as show them.")%></li>
				<li><%=Html.LabelFor(vm=>vm.ShowWeek)          %><%=Html.CheckBoxFor(vm=>vm.ShowWeek, "Shows the week number in the dialog too.")%></li>
				<li><%=Html.LabelFor(vm=>vm.WeekHeader)        %><%=Html.TextBoxFor(vm=>vm.WeekHeader, "wide", "Header for the week column ('ShowWeek' must be active); For example try 'WEEK' (without the quotes)")             %></li>
				<li><%=Html.LabelFor(vm=>vm.ChangeMonth)       %><%=Html.CheckBoxFor(vm=>vm.ChangeMonth, "Enables month selection for navigating dates.")%></li>
				<li><%=Html.LabelFor(vm=>vm.ChangeYear)        %><%=Html.CheckBoxFor(vm=>vm.ChangeYear, "Enabled year selection for navigating dates.")%></li>
				<li><%=Html.LabelFor(vm=>vm.YearRange)         %><%=Html.TextBoxFor(vm=>vm.YearRange, "wide", "Specifies what years are available in the year dropdown; For example try 'c-1:c+1' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.YearSuffix)        %><%=Html.TextBoxFor(vm=>vm.YearSuffix, "Suffix for the year in title of the DatePicker; For example try 'yr' (without the quotes)", "")%></li>
				<li><%=Html.LabelFor(vm=>vm.AltField)          %><%=Html.TextBoxFor(vm=>vm.AltField, "wide", "Specifies an alternative element to add the selected date to; For example try '#selectedDate' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.AltFormat)         %><%=Html.TextBoxFor(vm=>vm.AltFormat, "wide", "Specifies an alternative format for the selected date (to be added to the alternative element [see above]); For example try 'DD, dd MM yy' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.AppendText)        %><%=Html.TextBoxFor(vm=>vm.AppendText, "wide", "Prompt to add next to the DatePicker input field; For example try (yyyy-mm-dd) (with the brackets)")%></li>
				<li><%=Html.LabelFor(vm=>vm.HideIfNoPrevNext)  %><%=Html.CheckBoxFor(vm=>vm.HideIfNoPrevNext, "Hides the next/prev month buttons (when outside maxDate/minDate)") %></li>
				<li><%=Html.LabelFor(vm=>vm.MinDate)           %><%=Html.TextBoxFor(vm=>vm.MinDate, "wide", "Minimum date that can be entered; For example try '-1w' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.MaxDate)           %><%=Html.TextBoxFor(vm=>vm.MaxDate, "wide", "Maximum date that can be entered; For example try '+1w' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.NextText)          %><%=Html.TextBoxFor(vm=>vm.NextText, "wide", "Text to appear for the Next button; For example try 'Next Month ...' (without the quotes)")%></li>
				<li><%=Html.LabelFor(vm=>vm.PrevText)          %><%=Html.TextBoxFor(vm=>vm.PrevText, "wide", "Text to appear for the Previous button; For example try 'Last Month ...' (without the quotes)")%></li>
			</ul>
		</li>

		<li class="nested">
			<i>Misc Options</i>
			<ul>
				<li><%=Html.LabelFor(vm=>vm.CalculateWeek)    %><%=Html.TextBoxFor(vm=>vm.CalculateWeek, "extra-wide", "Refer to jQuery UI documentation for further details.")%></li>
				<li><%=Html.LabelFor(vm=>vm.IsRTL)            %><%=Html.CheckBoxFor(vm=>vm.IsRTL, "Enables right-to-left for culture support (datepicker rendering reversed).")%></li>
			</ul>
		</li>

		<li class="nested">
			<i>Day/Month Names</i>
			<ul>
				<li><%=Html.LabelFor(vm=>vm.FakeDayNamesChange)   %><%=Html.CheckBoxFor(vm=>vm.FakeDayNamesChange, "Illustrates support for changing the names of days in the picker.")%></li>
				<li><%=Html.LabelFor(vm=>vm.FakeMonthNamesChange) %><%=Html.CheckBoxFor(vm=>vm.FakeMonthNamesChange, "Illustrates support for changing the names of months in the picker.")%></li>
			</ul>
		</li>

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
<%
	var dt = Html.CreateDatePicker("dt");
	this.Model.ConfigureDatePicker(dt);
%>
<%=this.Model.CSharpCode(dt)%>
</asp:Content>



<asp:Content ID="Content4" ContentPlaceHolderID="DemoHtmlContent" runat="server">
<%
	var dt = Html.CreateDatePicker("dt");
	this.Model.ConfigureDatePicker(dt);
		
	dt
		.Rendering
			// SetAutoScript off as we want to show the JavaScript separately
			.SetAutoScript(false)
		.Finish()
	.Render();
%>
</asp:Content>



<asp:Content ID="Content5" ContentPlaceHolderID="DemoJavaScriptCodeContent" runat="server">
<%
	var dt = Html.CreateDatePicker("dt");
	this.Model.ConfigureDatePicker(dt);
%>
<%=this.Model.JavaScriptCode(dt)%>
</asp:Content>



<asp:Content ID="Content6" ContentPlaceHolderID="DemoMethodsContent" runat="server">
	<ul class="horizontal">
		<li><button id="disable" title="Disables the picker.">Disable</button></li>
		<li><button id="enable" title="Enables the picker.">Enable</button></li>
		<li><button id="widget" title="Shows the HTML for the .ui-datepicker element.">Widget</button></li>
		<li><button id="inDialog" title="Opens the DatePicker in a dialog (we've changed a few of the options to illustrate you can, check the DatePicker.aspx source code to see how).">In-Dialog</button></li>
		<li><button id="isDisabled" title="Reports if the datepicker is currently disabled.">IsDisabled</button></li>
		<li><button id="getDate" title="Shows the picker.">GetDate</button></li>
		<li><button id="setDate" title="Emulates the date being set (to 01/01/2000).">SetDate</button></li>
		<li><button id="refresh" title="Redraws the datepicker after _some_ external modification.">Refresh</button></li>
		<li><button id="destroy" title="Returns the button to it's pre-init state.">Destroy</button></li>
	</ul>
	<ul class="clear horizontal">
		<li><button id="show" title="Shows the picker.">Show</button></li>
		<li><button id="hide" title="Hides the picker.">Hide</button></li>
	</ul>
<%
	var dt = Html.CreateDatePicker("dt");
	this.Model.ConfigureDatePicker(dt);
	DateTime newDate = new DateTime(2000, 1, 1);
%>

	<script type="text/javascript">
	$(document).ready(function() {
		$("#enable").click(function() { <%dt.Methods.Enable();%>; });
		$("#disable").click(function() { <%dt.Methods.Disable();%>; });
		$("#widget").click(function() { alert( "Widget HTML:\n\n" + <%dt.Methods.Widget();%>.html() ); });
		$("#inDialog").click(function() { 
			<%dt.Methods.Dialog("2000-12-31", "alert('you picked ' + dateStr);", 100, 100,
				new Fluqi.Widget.jDatePicker
					.Options(dt)
						.SetShowButtonPanel(true)
						.SetDuration("slow")
						.SetCloseText("OK") 
			);%>;

			// https://stackoverflow.com/questions/715677/trouble-with-jquery-dialog-and-datepicker-plugins
			$("#ui-datepicker-div").css("z-index", "1003");
		});
		$("#isDisabled").click(function() { alert( "IsDisabled reports:\n\n" + <%dt.Methods.IsDisabled();%> ); });
		$("#hide").click(function() { <%dt.Methods.Hide();%>; });
		$("#show").click(function() { <%dt.Methods.Show();%>; });
		$("#getDate").click(function() { alert( "GetDate reports:\n\n" + <%dt.Methods.GetDate();%> ); });
		$("#setDate").click(function() { <%dt.Methods.SetDate( newDate );%>; });
		$("#refresh").click(function() { <%dt.Methods.Refresh();%>; });
		$("#destroy").click(function() {  if (confirm("are you sure you want to destroy the datepicker?")) <%dt.Methods.Destroy();%>; });
	});
	</script>
</asp:Content>

