using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jToolTip {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Returns [in JavaScript] the current "content" setting.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-content for details</remarks>
		public void GetContent() {
		  this.RenderGetOptionCall("content");
		}

		/// <summary>
		/// The content of the tooltip.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-culture for details.</remarks>
		public void SetContentByString(string content) {
			this.RenderSetOptionCall("content", content.InDoubleQuotes());
		}

		/// <summary>
		/// The content of the tooltip.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-culture for details.</remarks>
		public void SetContentByFunction(string content) {
			this.RenderSetOptionCall("content", content);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "disabled" setting.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-disabled for details</remarks>
		public void GetDisabled() {
			this.RenderGetOptionCall("disabled");
		}

		/// <summary>
		/// Disables the tooltip.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-disabled for details</remarks>
		public void SetDisabled(bool disabled) {
			this.RenderSetOptionCall("disabled", disabled);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "hide" setting.
		/// </summary>
		public void GetHide() {
			this.RenderGetOptionCall("hide");
		}

		/// <summary>
		/// Hide by Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately. 
		/// When set to true, the tooltip will fade out with the default duration and the default easing.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-hide for details.</remarks>
		public void DisabledHideEffect() {
			this.RenderSetOptionCall("hide", false);
		}

		/// <summary>
		/// Hide by Number: The tooltip will fade out with the specified duration and the default easing.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-hide for details.</remarks>
		public void SetHide(int duration) {
			this.RenderSetOptionCall("hide", "{{ duration: {0} }}", duration.ToString());
		}

		/// <summary>
		/// Hide by Number: The tooltip will fade out with the specified duration and the default easing.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-hide for details.</remarks>
		public void SetHide(Core.Animation.eAnimation effect, Core.Ease.eEase easing, int duration) {
			this.RenderSetOptionCall("hide", "{{ effect: \"{0}\", easing: \"{1}\", duration: {2} }}", 
				Core.Animation.AnimationToString(effect),
				Core.Ease.EaseToString(easing),
				duration.ToString()
			);
		}

		/// <summary>
		/// Hide by Number: The tooltip will fade out with the specified duration and the default easing.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-hide for details.</remarks>
		public void SetHide(string json) {
			this.RenderSetOptionCall("hide", json);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "show" setting.
		/// </summary>
		public void GetShow() {
			this.RenderGetOptionCall("show");
		}

		/// <summary>
		/// Show by Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately. 
		/// When set to true, the tooltip will fade out with the default duration and the default easing.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-show for details.</remarks>
		public void DisabledShowEffect() {
			this.RenderSetOptionCall("show", false);
		}

		/// <summary>
		/// Show by Number: The tooltip will fade out with the specified duration and the default easing.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-show for details.</remarks>
		public void SetShow(Core.Animation.eAnimation effect, Core.Ease.eEase easing, int duration) {
			this.RenderSetOptionCall("show", "{{ effect: \"{0}\", easing: \"{1}\", duration: {2} }}", 
				Core.Animation.AnimationToString(effect),
				Core.Ease.EaseToString(easing),
				duration.ToString()
			);
		}

		/// <summary>
		/// Show by Number: The tooltip will fade out with the specified duration and the default easing.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-show for details.</remarks>
		public void SetShow(int duration) {
			this.RenderSetOptionCall("show", "{{ duration: {0} }}", duration.ToString());
		}
		
		/// <summary>
		/// Show by Object: 
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-show for details.</remarks>
		public void SetShow(string json) {
			this.RenderSetOptionCall("show", json);
		}

		/// <summary>
		/// A selector indicating which items should show tooltips. 
		/// Customize if you're using something other then the title attribute for the tooltip content, or if you need a different selector for event delegation.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-items for details</remarks>
		public void GetItems() {
			this.RenderGetOptionCall("items");
		}

		/// <summary>
		/// A selector indicating which items should show tooltips. 
		/// Customize if you're using something other then the title attribute for the tooltip content, or if you need a different selector for event delegation.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-items for details</remarks>
		public void SetItems(params string[] items) {
			this.RenderSetOptionCall("items", string.Join(", ", items).InDoubleQuotes() );
		}

		/// <summary>
		/// Returns [in JavaScript] the current "tooltipClass" setting.
		/// </summary>
		public void GetTooltipClass() {
			this.RenderGetOptionCall("tooltipClass");
		}

		/// <summary>
		/// Tooltip class to add
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-tooltipClass for details</remarks>
		public void SetTooltipClass(string tooltipClass) {
			this.RenderSetOptionCall("tooltipClass", tooltipClass.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "track" setting.
		/// </summary>
		public void GetTrack() {
			this.RenderGetOptionCall("track");
		}

		/// <summary>
		/// Whether the tooltip should track the mouse
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/tooltip/#option-track for details</remarks>
		public void SetTrack(bool track) {
			this.RenderSetOptionCall("track", track.JsBool());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "position" setting.
		/// </summary>
		public void GetPosition() {
			this.RenderGetOptionCall("position");
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPositionJS(string position) {
			this.RenderSetOptionCall("position", position);
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// </summary>
		/// <param name="position">New position setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetPosition(string position, bool inDoubleQuotes) {
			this.RenderSetOptionCall("position", position, inDoubleQuotes);
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPosition(string position) {
			this.SetPosition(position, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPosition(Core.Position.ePosition position) {
			this.RenderSetOptionCall("position", Core.Position.PositionToString(position).InDoubleQuotes() );
		}
		
		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// An array containing x,y position string values (e.g. ['right','top'] for top right corner)
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(string pos1, string pos2) {
			List<string> positions = new List<string>() { pos1, pos2 };
			this.RenderSetOptionCall("position", positions.JsArray(false/*singleQuotes*/));
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// An array containing x,y position string values (e.g. ['right','top'] for top right corner)
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			this.SetPosition( Core.Position.PositionToString(pos1), Core.Position.PositionToString(pos2) );
		}

		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		/// An array containing an x,y coordinate pair in pixel offset from left, top corner of viewport (e.g. [350,100]) 
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(int pos1, int pos2) {
			List<int> positions = new List<int>() { pos1, pos2 };
			this.RenderSetOptionCall("position", positions.JsArray());
		}


	}

}
