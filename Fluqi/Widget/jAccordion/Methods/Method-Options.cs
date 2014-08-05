using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Gets the animation currently being used.
		/// </summary>
		public void GetAnimation() {
			this.RenderGetOptionCall("animate");
		}

		/// <summary>
		/// If and how to animate changing panels.
		/// </summary>
		/// <param name="value">new animation</param>
		public void SetAnimateJSON(string value) {
			this.RenderSetOptionCall("animate", value);
		}

		/// <summary>
		/// Shows the default animation for <paramref name="duration"/> milli-seconds.
		/// </summary>
		/// <param name="duration">Duration (in milli-seconds) of the animate</param>
		public void SetAnimate(int duration) {
			this.RenderSetOptionCall("animate", duration.ToString());
		}

		/// <summary>
		/// If and how to animate changing panels.
		/// </summary>
		/// <param name="value">new animation</param>
		public void SetEffect(string value) {
			this.SetEffect(value, true/*doubleQuotes*/);
		}

		/// <summary>
		/// If and how to animate changing panels.
		/// </summary>
		/// <param name="value">new animation</param>
		/// <param name="inDoubleQuotes">
		/// true - double quotes(")
		/// false - single quotes (')
		/// </param>
		public void SetEffect(string value, bool inDoubleQuotes) {
			this.RenderSetOptionCall("animate", value, inDoubleQuotes);
		}

		/// <summary>
		/// Sets the animation to the given easing method, using the default duration
		/// </summary>
		/// <param name="ease">Easing method to use</param>
		public void SetAnimate(Core.Ease.eEase ease) {
			this.RenderSetOptionCall("animate", Core.Ease.EaseToString(ease), true/*inDoubleQuotes*/);
		}
		
		/// <summary>
		/// Sets the animation to the given easing method and duration
		/// </summary>
		/// <param name="ease">Easing method to use</param>
		/// <param name="duration">Duration to use</param>
		public void SetAnimate(Core.Ease.eEase ease, int duration) {
			string easeMethod = Core.Ease.EaseToString(ease);
			string durationStr = duration.ToString();

			this.RenderSetOptionCall("animate", 
				string.Format("{{easing:\"{0}\",duration:{1}}}", easeMethod, durationStr)
			);
		}
		
		/// <summary>
		/// Sets the up and down animations to the given easing method and duration
		/// </summary>
		/// <param name="easeUp">Easing method to use (on the up)</param>
		/// <param name="durationUp">Duration to use (on the up)</param>
		/// <param name="easeDown">Easing method to use (on the down)</param>
		/// <param name="durationDown">Duration to use (on the down)</param>
		public void SetAnimate(Core.Ease.eEase easeUp, int durationUp, Core.Ease.eEase easeDown, int durationDown) {
			string easeUpMethod = Core.Ease.EaseToString(easeUp);
			string easeDownMethod = Core.Ease.EaseToString(easeDown);
			
			if (easeUpMethod == "") easeUpMethod = Core.Ease.EaseToString(Core.Ease.eEase.linear);
			if (easeDownMethod == "") easeUpMethod = Core.Ease.EaseToString(Core.Ease.eEase.linear);
			
			this.RenderSetOptionCall("animate",
				string.Format("{{easing:\"{0}\",duration:{1},down:{{easing:\"{2}\",duration:{3}}}}}",
					easeUpMethod, durationUp.ToString(),
					easeDownMethod, durationDown.ToString()
				)
			);
		}

		/// <summary>
		/// Disable animation
		/// </summary>
		public void DisableAnimation() {
			this.RenderSetOptionCall("animate", false );
		}

		/// <summary>
		/// Returns [in JavaScript] the current "collapsible" setting.
		/// Whether all the sections can be closed at once. 
		/// Allows collapsing the active section by the triggering event (click is the default).
		/// </summary>
		public void GetCollapsible() {
			this.RenderGetOptionCall("collapsible");
		}

		/// <summary>
		/// Whether all the sections can be closed at once. 
		/// Allows collapsing the active section by the triggering event (click is the default).
		/// </summary>
		/// <param name="newValue"></param>
		public void SetCollapsible(bool newValue) {
			this.RenderSetOptionCall("collapsible", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "event" setting.
		/// </summary>
		public void GetEvent() {
			this.RenderGetOptionCall("event");
		}

		/// <summary>
		/// The event on which to trigger the accordion.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">new setting</param>
		public void SetEventJS(string newValue) {
			this.RenderSetOptionCall("event", newValue);
		}

		/// <summary>
		/// The event on which to trigger the accordion.
		/// </summary>
		/// <param name="newValue">new setting</param>
		public void SetEvent(string newValue) {
			this.SetEvent(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// The event on which to trigger the accordion.
		/// </summary>
		/// <param name="newValue">new setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetEvent(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("event", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "heightStyle" setting.
		/// </summary>
		public void GetHeightStyle() {
			this.RenderGetOptionCall("heightStyle");
		}

		/// <summary>
		/// Sets the heightStyle of the accordion
		/// </summary>
		/// <param name="style">new value</param>
		public void SetHeightStyle(Core.HeightStyle.eHeightStyle style) {
			this.RenderSetOptionCall("heightStyle", Core.HeightStyle.HeightStyleToString(style), true/*inDoubleQuotes*/);
		}
		
		/// <summary>
		/// Sets the heightStyle of the accordion
		/// </summary>
		/// <param name="style">new value</param>
		public void SetHeightStyle(string style) {
			this.RenderSetOptionCall("heightStyle", style, true/*inDoubleQuotes*/);
		}
		
		/// <summary>
		/// Returns [in JavaScript] the current "header" setting.
		/// </summary>
		public void GetHeader() {
			this.RenderGetOptionCall("header");
		}

		/// <summary>
		/// Selector for the header element.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New header setting</param>
		public void SetHeaderJS(string newValue) {
			this.RenderSetOptionCall("header", newValue);
		}

		/// <summary>
		/// Selector for the header element.
		/// </summary>
		/// <param name="newValue">New header setting</param>
		public void SetHeader(string newValue) {
			this.SetHeader(newValue, true/*doubleQuotes*/);
		}
		
		/// <summary>
		/// Selector for the header element.
		/// </summary>
		/// <param name="newValue">New header setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetHeader(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("header", newValue, inDoubleQuotes);
		}
		
		/// <summary>
		/// Returns [in JavaScript] the current "icons" setting.
		/// </summary>
		public void GetIcons() {
			this.RenderGetOptionCall("icons");
		}
				
		/// <summary>
		/// Icons to use for headers. Icons may be specified for 'header' and 'activeHeader', 
		/// and we recommend using the icons native to the jQuery UI CSS Framework manipulated by jQuery UI ThemeRoller
		/// </summary>
		/// <param name="unselectedHeader">new unselected header setting</param>
		/// <param name="selectedHeader">new selected header setting</param>
		public void SetIcons(string unselectedHeader, string selectedHeader) {
			unselectedHeader = unselectedHeader ?? "";
			selectedHeader = selectedHeader ?? "";
			this.RenderSetOptionCall("icons", 
				string.Format("{{ 'header': '{0}', 'activeHeader': '{1}' }}", unselectedHeader, selectedHeader) 
			);
		}

		/// <summary>
		/// Icons to use for headers. Icons may be specified for 'header' and 'activeHeader', 
		/// and we recommend using the icons native to the jQuery UI CSS Framework manipulated by jQuery UI ThemeRoller
		/// </summary>
		/// <param name="unselectedHeader">new unselected header setting</param>
		/// <param name="selectedHeader">new selected header setting</param>
		public void SetIcons(Core.Icons.eIconClass unselectedHeader, Core.Icons.eIconClass selectedHeader) {
			string unselected = Core.Icons.ByEnum(unselectedHeader);
			string selected = Core.Icons.ByEnum(selectedHeader);

			this.SetIcons(unselected, selected);
		}

	}

}
