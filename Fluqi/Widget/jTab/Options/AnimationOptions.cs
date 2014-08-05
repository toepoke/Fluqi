using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Utilities.jAnimation;

namespace Fluqi.Widget.jTab {

	/// <summary>
	/// Models the Animation child for setting placement of the tab control.
	/// </summary>
	public class AnimationOptions {

		/// <summary>
		/// Reference to the Tab object to return control to.
		/// </summary>
		protected internal jTab.Options _TabOptions { get; set; }

		/// <summary>
		/// Holds the Animation options object for configuration.
		/// </summary>
		protected internal Utilities.jAnimation.Options Options { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tabOptions">Tab options object</param>
		/// <param name="caller">
		/// Specifies the type of caller using the animation.  For instance it's common for the animation properties
		/// to be used by both "show" and "hide" methods on a widget.  We need to differentiate between the two
		/// when rendering the script output.
		/// </param>
		public AnimationOptions(jTab.Options tabOptions, string caller)
		 : base()
		{
			this._TabOptions = tabOptions;
			this.Options = new Utilities.jAnimation.Options(null, caller);
		}

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Options"/> object so we can continue defining attributes.
		/// </summary>
		/// <returns>Returns <see cref="Options"/> object to return chaining to the parent object</returns>
		public jTab.Options Finish() {
		  return this._TabOptions;
		}

		/// <summary>
		/// The effect to use when showing/hiding.
		/// </summary>
		/// <param name="effect">Effect enum to use</param>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetEffect(Core.Animation.eAnimation effect) {
			this.Options.SetEffect(effect);
			return this;
		}

		/// <summary>
		/// The effect to use when showing/hiding.
		/// </summary>
		/// <param name="effect">Effect as a string to use</param>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetEffect(string effect) {
			this.Options.SetEffect(effect);
			return this;
		}

		/// <summary>
		/// The duration the effect should play for (in milliseconds).
		/// </summary>
		/// <param name="duration">Duration (milliseconds) to use.</param>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetDuration(int duration) {
			this.Options.SetDuration(duration);
			return this;
		}

		/// <summary>
		/// The duration the effect should play for.
		/// </summary>
		/// <param name="duration">Duration to use, can be milliseconds, or "fast", "slow" or "normal".</param>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetDuration(string duration) {
			this.Options.SetDuration(duration);
			return this;
		}

		/// <summary>
		/// The duration the effect should play for.
		/// </summary>
		/// <param name="speed">Duration enum to use.</param>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetDuration(Core.Speed.eSpeed speed) {
			this.Options.SetDuration(speed);
			return this;
		}

	}

}
