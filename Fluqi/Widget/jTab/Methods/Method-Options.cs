using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jTab {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Returns [in JavaScript] the current "collapsible" setting.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-collapsible for details</remarks>
		public void GetCollapsible() {
			this.RenderGetOptionCall("collapsible");
		}

		/// <summary>
		/// Set to true to allow an already selected tab to become unselected again upon reselection.
		/// </summary>
		/// <param name="newValue">New collapsible setting</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-collapsible for details</remarks>
		public void SetCollapsible(bool newValue) {
			this.RenderSetOptionCall("collapsible", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "event" setting.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-event for details</remarks>
		public void GetEvent() {
			this.RenderGetOptionCall("event");
		}

		/// <summary>
		/// The type of event to be used for selecting a tab.
		/// </summary>
		/// <param name="newValue">New event setting</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-event for details</remarks>
		public void SetEvent(Core.BrowserEvent.eBrowserEvent newValue) {
			this.RenderSetOptionCall("event", Core.BrowserEvent.BrowserEventToString(newValue).InDoubleQuotes());
		}

		/// <summary>
		/// The type of event to be used for selecting a tab.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New event setting</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-event for details</remarks>
		public void SetEventJS(string newValue) {
			this.RenderSetOptionCall("event", newValue);
		}

		/// <summary>
		/// The type of event to be used for selecting a tab.
		/// </summary>
		/// <param name="newValue">New event setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-event for details</remarks>
		public void SetEvent(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("event", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The type of event to be used for selecting a tab.
		/// </summary>
		/// <param name="newValue">New event setting</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-event for details</remarks>
		public void SetEvent(string newValue) {
			this.SetEvent(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Controls the height of the accordion and each panel.  Possible values are "auto", "fill" and "content".
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-heightStyle for details</remarks>
		public void GetHeightStyle() {
			this.RenderGetOptionCall("heightStyle");
		}

		/// <summary>
		/// Controls the height of the accordion and each panel.  Possible values are "auto", "fill" and "content".
		/// </summary>
		/// <param name="style">Style to use</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-heightStyle for details</remarks>
		public void SetHeightStyle(Core.HeightStyle.eHeightStyle style) {
			string styleString = Core.HeightStyle.HeightStyleToString(style);
			this.SetHeightStyle(styleString);
		}

		/// <summary>
		/// Controls the height of the accordion and each panel.  Possible values are "auto", "fill" and "content".
		/// </summary>
		/// <param name="hs">Style to use</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-heightStyle for details</remarks>
		public void SetHeightStyle(string hs) {
			this.RenderSetOptionCall("heightStyle", hs, true/*inDoubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "hide" setting.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-hide for details</remarks>
		public void GetHide() {
			this.RenderGetOptionCall("hide");
		}

		/// <summary>
		/// Disables animation, panel is hidden immediately.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-hide for details</remarks>
		public void DisableHide() {
			this.RenderSetOptionCall("hide", false);
		}

		/// <summary>
		/// When <paramref name="value"/> is a string, the panels are hidden using the specified [named] effect. 
		/// When the value is a JSON object, it is passed directly to the hide method.
		/// </summary>
		/// <param name="value">String/JSON object</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-hide for details</remarks>
		public void SetHide(string value) {
			if (IsJSON(value) || IsNumeric(value))
				this.RenderSetOptionCall("hide", value);
			else 
				this.RenderSetOptionCall("hide", value.ToString(), true/*inDoubleQuotes*/);
		}

		/// <summary>
		/// Panel will fade out with the specified duration and default easing.
		/// </summary>
		/// <param name="duration">Time in milliseconds for the animation to run</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-hide for details</remarks>
		public void SetHide(int duration) {
			this.RenderSetOptionCall("hide", duration.ToString());
		}

		/// <summary>
		/// Panel will be hidden using the specified parameters.
		/// </summary>
		/// <param name="effect">Effect to use, e.g. "slideUp" or "fold"</param>
		/// <param name="easing">Easing property to adopt</param>
		/// <param name="duration">Time (in milliseconds) the animation should execute for</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-hide for details</remarks>
		public void SetHide(Core.Animation.eAnimation effect, Core.Ease.eEase easing, int duration) {
			string hiding = string.Format("{{ effect: \"{0}\", easing: \"{1}\", duration: {2} }}",
				Core.Animation.AnimationToString(effect),
				Core.Ease.EaseToString(easing),
				duration
			);

			this.SetHide(hiding);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "show" setting.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-show for details</remarks>
		public void GetShow() {
			this.RenderGetOptionCall("show");
		}

		/// <summary>
		/// Disables animation, panel is shown immediately.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-show for details</remarks>
		public void DisableShow() {
			this.RenderSetOptionCall("show", false);
		}

		/// <summary>
		/// When <paramref name="value"/> is a string, the panels are shown using the specified [named] effect. 
		/// When the value is a JSON object, it is passed directly to the show method.
		/// </summary>
		/// <param name="value">String/JSON object</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-show for details</remarks>
		public void SetShow(string value) {
			if (IsJSON(value) || IsNumeric(value))
				this.RenderSetOptionCall("show", value);
			else 
				this.RenderSetOptionCall("show", value.ToString(), true/*inDoubleQuotes*/);
		}

		/// <summary>
		/// Panel will fade in with the specified duration and default easing.
		/// </summary>
		/// <param name="duration">Time in milliseconds for the animation to run</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-show for details</remarks>
		public void SetShow(int duration) {
			this.RenderSetOptionCall("show", duration.ToString());
		}

		/// <summary>
		/// Panel will be shown using the specified parameters.
		/// </summary>
		/// <param name="effect">Effect to use, e.g. "slideUp" or "fold"</param>
		/// <param name="easing">Easing property to adopt</param>
		/// <param name="duration">Time (in milliseconds) the animation should execute for</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-show for details</remarks>
		public void SetShow(Core.Animation.eAnimation effect, Core.Ease.eEase easing, int duration) {
			string hiding = string.Format("{{ effect: \"{0}\", easing: \"{1}\", duration: {2} }}",
				Core.Animation.AnimationToString(effect),
				Core.Ease.EaseToString(easing),
				duration
			);

			this.SetShow(hiding);
		}
		
		/// <summary>
		/// Returns [in JavaScript] the active setting.
		/// To set all tabs to unselected pass -1 as value.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-active for details</remarks>
		public void GetActive() {
			this.RenderGetOptionCall("active");
		}

		/// <summary>
		/// Zero-based index of the tab to be active on initialization. 
		/// To set all tabs to unselected pass -1 as value.
		/// </summary>
		/// <param name="newValue">New active value</param>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-active for details</remarks>
		public void SetActive(int newValue) {
			this.RenderSetOptionCall("active", newValue.ToString()); 
		}

	}

}
