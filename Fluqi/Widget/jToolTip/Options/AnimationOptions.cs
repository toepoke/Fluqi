using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Utilities.jAnimation;

namespace Fluqi.Widget.jToolTip {

	/// <summary>
	/// Models the Animation child for setting placement of the ToolTip control.
	/// </summary>
	public class AnimationOptions {

		/// <summary>
		/// Reference to the ToolTip object to return control to.
		/// </summary>
		protected internal jToolTip.Options _ToolTipOptions { get; set; }

		/// <summary>
		/// Holds the Animation options object for configuration.
		/// </summary>
		protected internal Utilities.jAnimation.Options Options { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="toolTipOptions">ToolTip options object</param>
		/// <param name="caller">
		/// Specifies the type of caller using the animation.  For instance it's common for the animation properties
		/// to be used by both "show" and "hide" methods on a widget.  We need to differentiate between the two
		/// when rendering the script output.
		/// </param>
		public AnimationOptions(jToolTip.Options toolTipOptions, string caller)
		 : base()
		{
			this._ToolTipOptions = toolTipOptions;
			this.Options = new Utilities.jAnimation.Options(null, caller);
		}

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Options"/> object so we can continue defining attributes.
		/// </summary>
		/// <returns>Returns <see cref="Options"/> object to return chaining to the parent object</returns>
		public jToolTip.Options Finish() {
		  return this._ToolTipOptions;
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
		/// The easing to use when showing/hiding.
		/// </summary>
		/// <param name="ease">Ease enum to use</param>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetEasing(Core.Ease.eEase ease) {
			this.Options.SetEasing(ease);
			return this;
		}

		/// <summary>
		/// The easing to use when showing/hiding.
		/// </summary>
		/// <param name="ease">Ease as a string to use</param>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetEasing(string ease) {
			this.Options.SetEasing(ease);
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

		/// <summary>
		/// The json object specifing the animation properties.
		/// </summary>
		/// <param name="json">JSON string</param>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetJSON(string json) {
			this.Options.SetJSON(json);
			return this;
		}

		/// <summary>
		/// Turns off the animation
		/// </summary>
		/// <returns>Object for chainability</returns>
		public AnimationOptions SetDisabled() {
			this.Options.SetDisabled();
			return this;
		}

	}

}
