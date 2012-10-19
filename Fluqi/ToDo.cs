
namespace Fluqi
{
	/// <summary>
	/// Just a list of stuff to do
	/// </summary>
	public class ToDo
	{
		// jQuery 1.9.0 upgrade
		// ToDo: Need to modify links in documentation as the location is now api.jqueryui.com

		// ToDo: Integrate appHarbor for integration with github source code.
		// ToDo: Check the source that comes out of the demo still matches the actual code required (copy and paste somewhere).
		// ToDo: Enhance the DiscoverOptions to use the child version everywhere (add it to the Core.Options base class too).  This way
		//       a) we're consistent, and b) every control options can be passed in as options to everything else.
		// ToDo: Verify that the CSS is compliant with the "Themeing" tab in the jQuery UI documentation against each control.
		// ToDo: Look at refactoring the ScriptOption as it's got dual purpose at the moment ... plus the name's a bit crap.
		// ToDo: Fix razor integration, see razor.txt
		// ToDo: Accordion with custom header doesn't work, you can't vary the content divs ... see FAQ in TP for example
		// ToDo: Accordion shouldn't demand an "ID", it doesn't necessarily need one, we may just been formatting ... perhaps convert the first panel text into an id if necessary?
		
		

		// DONE: Fix warnings (mainly XML documentation)
		// SKIP: ButtonSet - too many permutations to be programmed up.
		// DONE: Review the Overview section of each control on the jQuery UI documentation and make sure we're covered.
		//       - Need to check all the properties against the jQuery documentation
		// SKIP: Move the thing that generates the C# into the main Fluqi library ... seems daft not to expose that for others ..
		//       plus we could have all the demos have a button to show the code in a dialog?  Extension method?
		//       - Not convinced that's the right thing to do.
		// DONE: Fast, Normal & Slow should really be enums
		// DONE: Add fork me on github badge
		// DONE: Re-organise the controllers and views so we have /Demo/Tabs, /Demo/DatePicker, /Demo/Wizard as it's a bit of a mess at the moment.
		// DONE: Rename Button to just "Btn" - renamed to "PushButton" (as it clashes with UI.Button from the .NET framework)
		// FIXED: Think there's a problem with setting the caption on the button example (see http://localhost:2322/Home/Button)
		// DONE: Need to change the Tabs control to support dynamic loading of tabs, see http://jqueryui.com/demos/tabs/#Ajax_mode for details
		//       - Added "AsDynamic" fluent entry point to configure dynamic loading.
		// DONE: Also knock up a toepoke icon we can still in the footer.
		//       - Done but I reckon we'll create a dedicated page
		// SKIP: Really need a "GetAltField", etc for the properties now we've made them protected.  
		//       - I don't think we get enough back by doing this.  As the end of the day the user know what they set anyway :)
		// SKIP: Test the EndAccordions, etc methods work as desired.
		//       - The using block works nicer, so I'm leaving it at that.
		// DONE: Need a combined view that brings all the controls on one page so we can verify everything works as we expect
		//       - Added wizard view which brings it all together quite nicely.
		// DONE: Need to add interfacing for methods.  Whilst there's only a couple that actually _need_ them but we should
		//       really add them.
		//       - Pretty happy with what we have now .. any more refactoring will just be tinkering for no good reason
		// DONE: In the SetOption(x) the underlying property should be protected/internal
		// DONE: Check from the API perspective that we only see what we should be able to see.
		//       - Pretty happy with what's there now.
		// DONE: Have a "Fluqi.Extensions.MVC" and a "Fluqi.Extensions.WebForms" namespace and build interfaces for 
		//       WebForms apps (need a sample demo?  Perhaps just an "all together" page illustrating usage?
		//       As it happens WebForms is piece of ....
		// DONE: NumberOfMonths as rows/cols
		// DONE: Have the event log show relevant stuff, e.g. slider value
		// DONE: Need to review how the API looks.  I'm thinking the "SetEvents" should hang under an "Events" hierachy like the "Rendering" and "Options" does.
		//       Should probably re-work the DiscoverOptions methods to separate out and allow multiple "options" to be added as we'll need
		//       to join the "Options" and "Events" together when rendering initially.  Methods are OK as these will have to be separate
		//       anyway as they aren't part of the initialisation.
		// DONE: Need unit tests for the methods
		// DONE: Need to add Option test methods
		// DONE: Tabs and Accordions exposes the underlying List/Dictionary to the end user, it should be hidden
		//       and only expose what the user is interested in, i.e. AddPanel, RenderContainer, RenderPanel, etc
		// DONE: Add better Enums support for Tabs.Evt, Accordion.Evt, Accordion.Animated
		// DONE: Check we've got tooltips for everything
		// DONE: Position class
		// DONE: Fix issue with offset both
		// DONE: Move events to dock on right
		// DONE: download image and use locally
		// DONE: Put Update buttons at top and bottom on all screens
		// DONE: Name = Fluqi (something about Fluent [j] Query UI interface (bit tenuous, but it' catchy)
		// DONE: Output javascript (capture the render and replace <> with &gt; &lt;
		// DONE: Refactor the Enums better
		// DONE: Need tests for the Dialog Buttons
		// DONE: Entry points to add additional CSS classes and Html attributes (attribute encoding)
		// DONE: Incorporate theme selector (through CDN?)
		// DONE: Add in manyMail?  (didn't add it, don't think it fits)
		// DONE: Move the RenderCSS, SlimCSS, etc options into the main control rather than hanging off Options.
		// DONE: Add a single test in each plug-in that verifies the pretty output is correct
		// DONE: Need to fix conflict with SyntaxHighlighter and IE (jQuery/jQueryUI script file conflict).
		// DONE: The Views shouldn't really call into the GetTagHtml marlarky, except for the C# bit.  Perhaps the 
		//       GetTagHtml should be protected and then have an extension that reflects into GetTagHtml so it can get the C#
		//       sharp code?  Or perhaps re-use our mocked HttpResponse for this?  In fact look at this we don't even use GetTagHtml
		//       for the C# code (for the dialog)?!?!?  Why have we changed it to expose GetTagHtml?!!
		// SKIP: Should we allow the user to put in their own ID in the interface.  
		//			 We could then use the demos as a kind of builder for people who don't have MVC or don't want it
		// DONE: Once we've added the "methods" in (e.g. Dialog.show) go back to the "OKClicked" and the "CancelClicked" 
		//       C# written events and add the calling of the "close" dialog to illustrate how they can be used 
		//			 (and automatically add it in?).
		// SKIP: Look at milestone build (anything we can add in?)
		//       - Don't think we should include anything that may change at a point we're not expecting it.
		// SKIP: Ensure BeginTab/BeginAccordion and EndTab/EndAccordion work correctly (using block is fine).
		// SKIP: Think about ripping out the bits that generate the controls.  
		//       We only need to initialise against a given div on some of the control, like datePicker and autoComplete.  We need it for
		//       rendering Tabs/Accordions, etc
		//			 : Skipped because we can actually do this already, we just don't call the .Render, we just call the .RenderStartUpScript
		//       : to create the jQuery UI initialisation.  So we already have the best of both worlds.
	}
}
