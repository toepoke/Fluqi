namespace Fluqi.Utilities.jAnimation {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Fluqi.Extension;
	using Fluqi.Extension.Helpers;


	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Animation.
	/// </summary>
	public partial class Options: Core.Options {
		/// <summary>
		/// Default expiry time (as defined by jQuery).
		/// </summary>
		public const string DEFAULT_DURATION = "400";

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="Animation">Animation object to define options for</param>
		public Options(Animation ani, string caller)
		 : base()
		{
			this.Animation = ani;
			this.Caller = caller;
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Animation"/> object these options are for
		/// </summary>
		public Animation Animation { get; set; }

		/// <summary>
		/// Specifies the type of caller using the animation.  For instance it's common for the animation properties
		/// to be used by both "show" and "hide" methods on a widget.  We need to differentiate between the two
		/// when rendering the script output.
		/// </summary>
		/// <remarks>
		/// So if you're calling from a "show" you'll get something like 
		///		{ show: { effect: "blind", duration: 500 } }
		///	for example
		/// </remarks>
		public string Caller { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Animation"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Animation"/> object to return chaining to the Tabs collection</returns>
		public Animation Finish() {
		  return this.Animation;
		}

		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(GetAnimationScriptOption(false/*asChild*/));
		}

		/// <summary>
		/// Gets a script option defining the Animation options (this is exposed as the Animation control
		/// is used in other controls).
		/// </summary>
		/// <returns>Script option for the Animation object</returns>
		protected internal Core.ScriptOption GetAnimationScriptOption() {
			return GetAnimationScriptOption(true/*asChild*/);
		}

		/// <summary>
		/// Gets a script option defining the Animation options (this is exposed as the Animation control
		/// is used in other controls).
		/// </summary>
		/// <param name="asChild">Flags that this option should be added a child</param>
		/// <returns>Script option for the Animation object</returns>
		protected Core.ScriptOption GetAnimationScriptOption(bool asChild) {
			Core.ScriptOption parentOpts = new Core.ScriptOption() { 
				Key = this.Caller,
				IsChild = asChild
			};
			Core.ScriptOptions childOpts = parentOpts.ChildOptions;
			
			string durationString = (this.IsNumeric(this.Duration) ? this.Duration.ToString() : this.Duration.InDoubleQuotes());

			childOpts.Add(!this.IsNullOrEmpty(this.Effect), "effect", this.Effect.InDoubleQuotes());
			childOpts.Add(!this.IsNullOrEmpty(this.Easing), "easing", this.Easing.InDoubleQuotes());
			childOpts.Add(!this.IsNullEmptyOrDefault(this.Duration, DEFAULT_DURATION), "duration", durationString);				

			// Any of the above actually going to render?
			parentOpts.Condition = childOpts.Where(x=>x.Condition).Any();
			return parentOpts;
		}

		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			// ToDo: What are the defaults for these?
			this.Duration = DEFAULT_DURATION;
			this.Effect = Core.Animation.AnimationToString(Core.Animation.eAnimation.None);
			this.Easing = Core.Ease.EaseToString(Core.Ease.eEase.None);
		}
	}

}
