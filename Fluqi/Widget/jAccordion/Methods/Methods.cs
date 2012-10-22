using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="ac">Accordion object to call</param>
		public Methods(Accordion ac) 
			: base(ac) 
		{
		}		

		
		/// <summary>
		/// Remove the accordion functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-destroy for details.</remarks>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	


		/// <summary>
		/// Disable the accordion.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-disable for details.</remarks>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	


		/// <summary>
		/// Enable the accordion.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-enable for details.</remarks>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	


		/// <summary>
		/// Returns the .ui-accordion element.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-widget for details.</remarks>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	


		/// <summary>
		/// Activate a content part of the Accordion programmatically.
		/// <param name="panelIndex">
		/// zero-indexed number to match the position of the header to activate. 
		/// </param>
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-activate for details.</remarks>
		public void Active(int panelIndex) {
			this.RenderMethodCall("active", panelIndex);
		}

		/// <summary>
		/// Selects the given content part (the "Select" method is the same as "Activate"
		/// and is here for ease of discover).
		/// <param name="panelIndex">
		/// zero-indexed number to match the position of the header to activate. 
		/// </param>
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-activate for details.</remarks>
		public void Select(int panelIndex) {
			this.Active(panelIndex);
		}

		/// <summary>
		/// Collapses all accordion panels (only possible when collapsible is true).
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/accordion/#method-activate for details.</remarks>
		public void CollapseAll() {
			this.RenderMethodCall("active", "false");
		}
		
		/// <summary>
		/// Recompute heights of the accordion contents when using the heightStyle option and the 
		/// container height changed. For example, when the container is a resizable, this method 
		/// should be called by its resize-event.
		/// </summary>
		/// <remarks>
		/// See http://api.jqueryui.com/accordion/#method-refresh for details.
		/// Note previous to jQuery 1.9 this was called the "resize" method
		/// </remarks>
		public void Refresh() {
			this.RenderMethodCall("refresh");
		}	

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
		public void SetAnimation(string value) {
			this.SetAnimate(value, true/*doubleQuotes*/);
		}

		/// <summary>
		/// If and how to animate changing panels.
		/// </summary>
		/// <param name="value">new animation</param>
		/// <param name="inDoubleQuotes">
		/// true - double quotes(")
		/// false - single quotes (')
		/// </param>
		public void SetAnimate(string value, bool inDoubleQuotes) {
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
		/// <param name="newValue">new value</param>
		public void SetHeightStyle(Core.HeightStyle.eHeightStyle style) {
			this.RenderSetOptionCall("heightStyle", Core.HeightStyle.HeightStyleToString(style), true/*inDoubleQuotes*/);
		}
		
		/// <summary>
		/// Sets the heightStyle of the accordion
		/// </summary>
		/// <param name="newValue">new value</param>
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

		/// <summary>
		/// Returns [in JavaScript] the current "header" setting.
		/// </summary>
		public void GetNavigation() {
			this.RenderGetOptionCall("navigation");
		}

		/// <summary>
		/// If set, looks for the anchor that matches location.href and activates it. 
		/// Great for href-based state-saving. Use navigationFilter to implement your own matcher.
		/// </summary>
		/// <param name="newValue">New navigation value</param>
		public void SetNavigation(bool newValue) {
			this.RenderSetOptionCall("navigation", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "navigationFilter" setting.
		/// </summary>
		public void GetNavigationFilter() {
			this.RenderGetOptionCall("navigationFilter");
		}

		/// <summary>
		/// Overwrite the default location.href-matching with your own matcher.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New navigationFilter value</param>
		public void SetNavigationFilterJS(string newValue) {
			this.RenderSetOptionCall("navigationFilter", newValue);
		}
				
		/// <summary>
		/// Overwrite the default location.href-matching with your own matcher.
		/// </summary>
		/// <param name="newValue">New navigationFilter value</param>
		public void SetNavigationFilter(string newValue) {
			// It's not appropriate to have a quoted version of the NavigationFilter, so this
			// entry point is merely to be consistent from a method signature perspective.
			this.SetNavigationFilterJS(newValue);
		}

	}

}
