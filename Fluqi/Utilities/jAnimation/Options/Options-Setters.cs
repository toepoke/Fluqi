using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Fluqi.Core;

namespace Fluqi.Utilities.jAnimation
{

	public partial class Options: Core.Options
	{

		/// <summary>
		/// The effect to use when showing/hiding.
		/// </summary>
		/// <param name="animation">Effect enum to use</param>
		/// <returns>Object for chainability</returns>
		public Options SetEffect(Core.Animation.eAnimation animation) {
			return this.SetEffect( Core.Animation.AnimationToString(animation) );
		}

		/// <summary>
		/// The effect to use when showing/hiding.
		/// </summary>
		/// <param name="effect">Effect as a string to use</param>
		/// <returns>Object for chainability</returns>
		public Options SetEffect(string effect) {
			this.Effect = effect;
			return this;
		}

		/// <summary>
		/// The easing effect to use when showing/hiding.
		/// </summary>
		/// <param name="easing">Easing enum to use</param>
		/// <returns>Object for chainability</returns>
		public Options SetEasing(Core.Ease.eEase easing) {
			return this.SetEasing( Core.Ease.EaseToString(easing) );
		}

		/// <summary>
		/// The easing effect to use when showing/hiding.
		/// </summary>
		/// <param name="easing">Easing name to use</param>
		/// <returns>Object for chainability</returns>
		public Options SetEasing(string easing) {
			this.Easing = easing;
			return this;
		}

		/// <summary>
		/// The duration the effect should play for (in milliseconds).
		/// </summary>
		/// <param name="duration">Duration (milliseconds) to use.</param>
		/// <returns>Object for chainability</returns>
		public Options SetDuration(int duration) {
			this.Duration = duration.ToString();
			return this;
		}

		/// <summary>
		/// The duration the effect should play for.
		/// </summary>
		/// <param name="duration">Duration to use, can be milliseconds, or "fast", "slow" or "normal".</param>
		/// <returns>Object for chainability</returns>
		public Options SetDuration(string duration) {
			this.Duration = duration;
			return this;
		}

		/// <summary>
		/// The duration the effect should play for.
		/// </summary>
		/// <param name="speed">Duration enum to use.</param>
		/// <returns>Object for chainability</returns>
		public Options SetDuration(Core.Speed.eSpeed speed) {
			this.Duration = Core.Speed.SpeedToString(speed);
			return this;
		}

		/// <summary>
		/// Sets the effects as a JSON object
		/// </summary>
		/// <param name="json">JSON object to use</param>
		/// <returns>Object for chainability</returns>
		public Options SetJSON(string json) {
			this.JSON = json;
			return this;
		}

		/// <summary>
		/// Turns off the animation
		/// </summary>
		/// <returns>Object for chainability</returns>
		public Options SetDisabled() {
			this.Disable = true;
			return this;
		}
		
	} // Options

} // ns Fluqi.jCookie
