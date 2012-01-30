<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Fluqi.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">	
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Navigation" runat="server">	
	<ul id="nav">
		<li><a href="#about">What is Fluqi?</a></li>
		<li><a href="#getting-started">Getting Started</a></li>
		<li><a href="#demos">Demos</a></li>
		<li><a href="#source">Download</a></li>
		<li><%=Html.ActionLink("Builder", "Accordion", "Builder")%></li>
		<li><a href="http://www.twitter.com/toepoke_co_uk" title="For updates, follow toepoke_co_uk">Follow</a></li>
	</ul>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="content-wrap">
	<section id="main">

	<div class="intro-box">
		<h1>Fluqi</h1>
		<p>
			The <a href="http://jqueryui.com/demos/">jQuery UI widgets</a> are brilliant.  They speed up web development	
			no end with those easy to use controls.  The downside is remembering all the HTML mark-up and widget options!
		</p>
		<p>
			I don't know about you but when I was developing my 
			<a href="http://toepoke.co.uk" title="Organise your 5-a-side kickabout easily with toepoke">5-a-side management website</a> 
			I was forever going to the <a href="http://jqueryui.com/demos/">excellent jQuery UI documentation</a> to read 
			up on the HTML and settings required to achieve what I wanted.  
			Take this <a href="http://jqueryui.com/demos/accordion/">accordion</a> widget for instance ... hands up who knows the
			mark-up and JavaScript <span title="OK, maybe you do, but I don't :)" style="cursor: help">off the top of their head?</span>
		</p>
	</div>

	<div class="slider-wrapper">
		<div id="slider" class="nivoSlider">
			<img src="<%=Url.Content("~/Content/site/images/slides/slide1.png")%>" width="383" height="198" alt="" title="#builderCaption" />
			<img src="<%=Url.Content("~/Content/site/images/slides/slide2.png")%>" width="383" height="198" alt="" title="#wizardCaption" />
			<img src="<%=Url.Content("~/Content/site/images/slides/slide3.png")%>" width="383" height="198" alt="" title="#jsCaption" />
			<img src="<%=Url.Content("~/Content/site/images/slides/slide4.png")%>" width="383" height="198" alt="" title="#cSharpCaption" />
		</div>

		<div id="builderCaption" class="nivo-html-caption">
			Use the <%=Html.ActionLink("builder", "Accordion", "Builder")%> to set the widget options you want to use.
		</div>
		<div id="wizardCaption" class="nivo-html-caption">
			To quickly <%=Html.ActionLink("prototype", "Wizard", "Demo")%> a screen.
		</div>
		<div id="jsCaption" class="nivo-html-caption">
			Copy &amp; paste the generated HTML and JavaScript ...
		</div>
		<div id="cSharpCaption" class="nivo-html-caption">
			Or for .NET, build your widget requirements in code ...
		</div>
	
	</div>
	<div class="clearfix"></div>

	<div id="sample-container" class="row">
		<div id="sample-widget" class="align-left">
		<%
			var ac = Html.CreateAccordion("ac")
				.Options
					.SetCollapsible(true)
				.Finish()
				.Panels
					.Add("My Panel 1", true)
					.Add("My Panel 2")
					.Add("My Panel 3")
				.Finish();
		%>
		<%using (ac.RenderContainer()) { %>
			<%using (ac.Panels.RenderNextPane()) { %>
				<p>Oooh, this is panel 1.</p>
			<%} %>
			<%using (ac.Panels.RenderNextPane()) { %>
				<p>And this is panel 2.</p>
			<%} %>
			<%using (ac.Panels.RenderNextPane()) { %>
				<p>Funnily enough ... </p>
				<p>... this is panel 3.</p>
			<%} %>
		<%} %>
		</div>
		<div>
			<blockquote style="margin-top: 0px !important">
				Why isn't there a library that encapsulates all the HTML and JavaScript
				rules and build the widgets for us?
			</blockquote>
		</div>
	</div>
	<a class="back-to-top" href="#header-wrap">Back to Top</a>
</section> <%--main--%>

<section id="about">
	<h1>What is Fluqi?</h1>
	<p>
		<%=Html.ActionLink("Fluqi", "Home", "Home")%> was devised with the simple aim of making it easier to integrate
		<a href="http://jqueryui.com/demos/">jQuery UI widgets</a> into websites.  
		<%=Html.ActionLink("Fluqi", "Home", "Home")%> helps in two ways; Firstly with a widget builder for setting the various 
		options, and secondly with a .NET <abbr title="Application Programming Interface">API</abbr>.
	</p>
	<h2 id="builder">Builder</h2>
	<p>
		The <%=Html.ActionLink("Widget builder", "Accordion", "Builder")%> is a simple website you can use
		to configure your widget (tabs control, date picker, etc) no matter what 
		<a href="http://en.wikipedia.org/wiki/Server-side_scripting">server-side technology</a>
		you're using.
	</p>
	<p>
		Once your widget is configured, just click a button and we'll show you the HTML and JavaScript 
		to render your widget.  Simply copy &amp; paste the code into your own projects.
	</p>

	<h2 id="dotNet">Fluent Interface</h2>
	<p>
		<%=Html.ActionLink("Fluqi", "Home", "Home")%> itself is an <a href="http://www.asp.net">.NET</a> library for configuring the jQuery UI
		widgets programmatically with a fluent interface.  So how does it work?
	</p>
		<p>
			Let's say for example you want to use the <a href="http://jqueryui.com/demos/datepicker/">Datepicker widget</a>, 
			but not just with the default settings.  We also want:
		</p>
		<ul>
			<li>
				<a href="http://jqueryui.com/demos/datepicker/#option-numberOfMonths">Two</a> months shown at a time,
			</li>
			<li>
				With a <a href="http://jqueryui.com/demos/datepicker/#option-duration">slow</a> 
				<a href="http://jqueryui.com/demos/datepicker/#option-showAnim">explosion</a> effect when the picker opens, and
			</li>
			<li>
				We want the <a href="http://jqueryui.com/demos/datepicker/#option-showButtonPanel">button panel</a>
			showing too.
			</li>
		</ul>
		<p>
			I know what you're thinking ... I'll fire up <a href="http://www.google.co.uk/chrome">my favourite browser</a>, 
			<a href="http://jqueryui.com/demos/datepicker/">look up the settings</a> and start copy &amp; pasting.  
			With <%=Html.ActionLink("Fluqi", "Home", "Home")%> we just open our MVC View (or WebForm) and just type:
		</p>
		<pre class="brush: c#">
DatePicker dt = Html.CreateDatePicker("dt")
	.Options
		.SetDuration("slow")
		.SetNumberOfMonths(2)
		.SetShowAnim(Animation.eAnimation.Explode)
		.SetShowButtonPanel(true)
	.Finish()
.Render()
		</pre>
		<p>
			The above is fairly self-explantory, the important part from our perspective is the final line, <strong>.Render()</strong>.
			At this point <%=Html.ActionLink("Fluqi", "Home", "Home")%> will output the HTML required to build the Datepicker, like so:
		</p>
		<pre class="brush: html">
<input id="dt" type="text">
		</pre>
		<p>
			WOW...  OK, so that was a little disappointing :)  Perhaps the JavaScript that also gets rendered will be a little more
			exciting.
		</p>
		<pre class="brush: javascript">
<script type="text/javascript">
	$(document).ready(function () {
		$("#dt").datepicker({
			duration: "slow",
			numberOfMonths: 2,
			showAnim: "explode",
			showButtonPanel: true
		});
	});
</script>
		</pre>
<label for="dt_">And this is our finished Datepicker:</label>
<%
Html.CreateDatePicker("dt_")
	.Options
			.SetDuration("slow")
			.SetNumberOfMonths(2)
			.SetShowAnim(Animation.eAnimation.Explode)
			.SetShowButtonPanel(true)
	.Finish()
	.Render();
%>

	<h2 style="margin-top: 1.5em">Delayed Rendering</h2>
	<p>
		Out of the box <%=Html.ActionLink("Fluqi", "Home", "Home")%> is set to work with the minimum of fuss.
		If you're thinking <i class="italic">&ldquo;Well this is all good, but I'm not having JavaScript being written out left, right and 
		centre&rdquo;</i>, don't worry, we're getting to that :).
	</p>
	<p>
		As well as configuring how the jQuery widgets behave we can also tell <%=Html.ActionLink("Fluqi", "Home", "Home")%> how
		to behave.  To stop the JavaScript being added automatically we simply turn that feature off:
	</p>
	<pre class="brush: c#">
DatePicker dt = Html.CreateDatePicker("dt")
	.Rendering
		.SetAutoScript(false)
	.Finish()
	.Options
		...
	.Finish()
.Render()
	</pre>
	<p>
		We can then choose to render our JavaScript later: 
	</p>
	<pre class="brush: c#">
dt.GetStartUpScript(false)
	</pre>
	<p class="footnote">
		The <strong>false</strong> flag indicates the <strong>document.ready</strong> jQuery start-up function should not be added.
	</p>

	<h2 style="margin-top: 1.5em">External JavaScript</h2>
	<p>
		Next on the <i class="italic">
		<a href="http://developer.yahoo.com/performance/rules.html">&ldquo;I'm liking this, but it isn't exactly best practice&rdquo;</i></a> 
		list is the fact that the examples above are all inline JavaScript on the same page as the HTML.  Whilst this is arguably OK if we're
		only using a single widget, it can soon become quite large, increasing the download footprint to our users.
	</p>
	<p>
		One way around this is to use the <%=Html.ActionLink("Builder", "Accordion", "Builder")%> to configure our widget options
		and copy &amp; paste the resulting code (urg!).  A better solution is to employ <a href="https://github.com/jetheredge/SquishIt">SquishIt</a>
		which recently added a means to add dynamically generated JavaScript, compress it and write it out externally and benefit
		from browser caching.  The code snippet above then becomes:
	</p>

	<pre class="brush: c#">
Bundle.JavaScript()
	.AddString( dt.GetStartUpScript(false) )
	.Render("~/_assets/fluqi-#.js")
</pre>
	<p>
		I won't detail <a href="http://www.codethinked.com/squishit-the-friendly-aspnet-javascript-and-css-squisher">SquishIt</a>
		here, but to summarise the above snippet takes the JavaScript for building our date-picker, 
		<a href="http://en.wikipedia.org/wiki/Minification_(programming)">minimises</a> the code and writes the result
		to an <strong>_assets</strong> folder.  When the page is delivered to the browser the above is replaced with 
		a normal link to the JavaScript, but to the compressed version.
	</p>
	<a class="back-to-top" href="#header-wrap">Back to Top</a>
</section><%--about--%>

<section id="getting-started">
	<h1>Getting Started</h1>
	<p>
		To get Fluqi up and running with ASP.NET is really simple.  The easiest way is to install the 
		<a href="http://nuget.org/packages/fluqi">NuGet package</a>.  If this isn't possible, the manual steps 
		are pretty easy too.
	</p>
	<ol>
		<li>
			Download the latest assembly from <a href="https://github.com/toepoke/fluqi/downloads">github</a>.
		</li>
		<li>
			Open a new or existing .NET project (MVC or WebForms .. it's all good) and add the <strong>fluqi.dll</strong> reference.
			<sub><a href="#intellisense">*</a></sub>
		</li>
		<li>
			Add the following namespaces to your web.config (configuration/system.web/pages/namespaces
<pre class="brush: html">
	<add namespace="Fluqi"></add>
	<add namespace="Fluqi.Core"></add>
	<add namespace="Fluqi.Widget.jAccordion"></add>
	<add namespace="Fluqi.Widget.jPushButton"></add>
	<add namespace="Fluqi.Widget.jAutoComplete"></add>
	<add namespace="Fluqi.Widget.jDatePicker"></add>
	<add namespace="Fluqi.Widget.jDialog"></add>
	<add namespace="Fluqi.Widget.jProgressBar"></add>
	<add namespace="Fluqi.Widget.jSlider"></add>
	<add namespace="Fluqi.Widget.jTab"></add>
	<add namespace="Fluqi.Utilities.jCookie"></add>
	<add namespace="Fluqi.Utilities.jPosition"></add>
	<add namespace="Fluqi.Extension"></add>
</pre>
			<p>This isn't 100% necessary, but does save having to add the namespaces you need on each page.</p>
		</li>
		<li>Open up your View or WebForm and type &ldquo;<strong>&lt;% Html.Create</strong>&rdquo; and 
		Visual Studio intellisense will show you the way ..</li>
	</ol>
	<p id="intellisense" class="footnote">
		Make sure you copy the fluqi.xml file along with the assembly ... this gives you the intellisense goodness.
	</p>
	<a class="back-to-top" href="#header-wrap">Back to Top</a>
</section><%--getting-started--%>

<section id="demos">
	<h1>Demos</h1>
	<p>
		Hopefully we've given you an idea of what <%=Html.ActionLink("Fluqi", "Home", "Home")%> can do for
		you.  Why not have a play with the demonstration projects, these are all included in the <a href="#source">source</a>
		code too.
	</p>
	<div class="row">
		<section class="col" style="width: 420px">
			<h2><%=Html.ActionLink("Altogether", "Wizard", "Demo")%></h2>
			<p>
				Single page demo using <strong><%=Html.ActionLink("Fluqi", "Home", "Home")%></strong>
				to build a pseudo application with many <a href="http://jqueryui.com/demos/">widgets</a>
				working together.
			</p>
			<%=Html.ActionLink("Wizard Demo", "Wizard", "Demo", null, new {@class = "align-right"})%>
		</section>
		<section class="col mid" style="width: 420px">
			<h2><a href="<%=Url.Content("~/WebForms/QuickDemo.aspx")%>">WebForms</a></h2>
			<p>
				Not into ASP.NET MVC?  No problem, you can use <%=Html.ActionLink("Fluqi", "Home", "Home")%>
				in <a href="http://www.asp.net/web-forms">WebForms</a> too.
			</p>
			<a href="<%=Url.Content("~/WebForms/QuickDemo.aspx")%>" class="align-right">WebForms Demo</a>
		</section>
	</div>
	<a class="back-to-top" href="#header-wrap">Back to Top</a>
</section><%--demos--%>

<section id="source">
	<h1>Download</h1>
	<p>
		The <%=Html.ActionLink("Fluqi", "Home", "Home")%> library is open source and available
		for download in source and binary form <a href="https://github.com/toepoke/fluqi">github</a>.
	</p>
	<a class="back-to-top" href="#header-wrap">Back to Top</a>
</section><%--source--%>

<section id="share">
	<h1>Share</h1>
	<ul class="link-list social">
		<li class="facebook"><a href='http://www.facebook.com/sharer.php?u=<%=Url.Action("Home", "Home", null, "http", "")%>&t=Wow, finding jQuery UI development even easier with Fluqi by @toepoke_co_uk'>Facebook</a></li>
		<li class="googleplus"><a href='https://plusone.google.com/_/+1/confirm?hl=en&url=<%=Url.Action("Home", "Home", null, "http", "")%>'>Google+</a></li>
		<li class="twitter"><a href='http://twitter.com/intent/tweet?status=Wow, finding jQuery UI development even easier with Fluqi by @toepoke_co_uk : <%=Url.Action("Home", "Home", null, "http", "")%>'>Twitter</a></li>
		<li class="delicious"><a href='http://del.icio.us/post?url=<%=Url.Action("Home", "Home", null, "http", "")%>&title=Wow, finding jQuery UI development even easier with Fluqi by @toepoke_co_uk'>Delicious</a></li>
	</ul>
</section>

</div> <%--content-wrap--%>

	<script type="text/javascript">
	$(document).ready(function() {
		// hide the bits here so non-js/spiders see them
		SyntaxHighlighter.all();
		$('#sample-code').hide();
		//$('#demos').hide();
	});
	</script>
</asp:Content>
