
namespace Fluqi
{
	/// <summary>
	/// Just a list of stuff to do
	/// </summary>
	public class ToDo
	{
		// jQuery 1.9.0 upgrade
		// ToDo: Add some code into the position "using" callback to illustrate the properties now available (there's lots more)
		//       - see https://jqueryui.com/upgrade-guide/1.9/#added-positioning-feedback-to-the-using-callback
		// ToDo: Investigate viability of have a "test.aspx" page which has Fluqi output it's settings and run the inbuild jQuery UI tests against it?
		// ToDo: Still need to add in DEFAULTs for the animation (may need to be per control).  Also remember this effects the C# output.
		// ToDo: Accordion header needs adding
		// ToDo: Revisit show/hide in Dialog (and elsewhere) as we might be able to use the object version
		// ToDo: Add a way to publish a jsfiddle from the builder pages (see https://doc.jsfiddle.net/api/post.html and https://jsfiddle.net/zalun/sthmj/embedded/result/)
		// ToDo: Check the documentation for ALL controls against what we have.  E.g. we've missed the hide method on setting tabs
		// ToDo: Look to convert the Hide/Show functions to use the more generic jAnimation classes

		// jQuery 1.9 bugs to raise
		// easing not supported on tabs, should it be?


		// ToDo: Enhance the DiscoverOptions to use the child version everywhere (add it to the Core.Options base class too).  This way
		//       a) we're consistent, and b) every control options can be passed in as options to everything else.
		// ToDo: Verify that the CSS is compliant with the "Themeing" tab in the jQuery UI documentation against each control.
		// ToDo: Accordion with custom header doesn't work, you can't vary the content divs ... see FAQ in TP for example
		// ToDo: Accordion shouldn't demand an "ID", it doesn't necessarily need one, we may just been formatting ... perhaps convert the first panel text into an id if necessary?

		// SKIP: ButtonSet - too many permutations to be programmed up.
		// SKIP: Move the thing that generates the C# into the main Fluqi library ... seems daft not to expose that for others ..
		//       plus we could have all the demos have a button to show the code in a dialog?  Extension method?
		//       - Not convinced that's the right thing to do.
		// SKIP: Really need a "GetAltField", etc for the properties now we've made them protected.  
		//       - I don't think we get enough back by doing this.  As the end of the day the user know what they set anyway :)
		// SKIP: Test the EndAccordions, etc methods work as desired.
		//       - The using block works nicer, so I'm leaving it at that.
		// SKIP: Should we allow the user to put in their own ID in the interface.  
		//			 We could then use the demos as a kind of builder for people who don't have MVC or don't want it
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
