using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jDialog {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Returns [in JavaScript] the current "closeOnEscape" setting.
		/// </summary>
		public void GetCloseOnEscape() {
			this.RenderGetOptionCall("closeOnEscape");
		}

		/// <summary>
		/// Specifies whether the dialog should close when it has focus and the user 
		/// presses the esacpe (ESC) key.
		/// </summary>
		/// <param name="newValue">New closeOnEscape setting</param>
		public void SetCloseOnEscape(bool newValue) {
			this.RenderSetOptionCall("closeOnEscape", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "closeText" setting.
		/// </summary>
		public void GetCloseText() {
			this.RenderGetOptionCall("closeText");
		}

		/// <summary>
		/// Specifies the text for the close button. 
		/// Note that the close text is visibly hidden when using a standard theme.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New closeText setting</param>
		public void SetCloseTextJS(string newValue) {
			this.RenderSetOptionCall("closeText", newValue);
		}

		/// <summary>
		/// Specifies the text for the close button. 
		/// Note that the close text is visibly hidden when using a standard theme.
		/// </summary>
		/// <param name="newValue">New closeText setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetCloseText(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("closeText", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Specifies the text for the close button. 
		/// Note that the close text is visibly hidden when using a standard theme.
		/// </summary>
		/// <param name="newValue">New closeText setting</param>
		public void SetCloseText(string newValue) {
			this.SetCloseText(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "dialogClass" setting.
		/// </summary>
		public void GetDialogClass() {
			this.RenderGetOptionCall("dialogClass");
		}

		/// <summary>
		/// The specified class name(s) will be added to the dialog, for additional theming.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New dialogClass setting</param>
		public void SetDialogClassJS(string newValue) {
			this.RenderSetOptionCall("dialogClass", newValue);
		}

		/// <summary>
		/// The specified class name(s) will be added to the dialog, for additional theming.
		/// </summary>
		/// <param name="newValue">New dialogClass setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetDialogClass(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("dialogClass", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// The specified class name(s) will be added to the dialog, for additional theming.
		/// </summary>
		/// <param name="newValue">New dialogClass setting</param>
		public void SetDialogClass(string newValue) {
			this.SetDialogClass(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "draggable" setting.
		/// </summary>
		public void GetDraggable() {
			this.RenderGetOptionCall("draggable");
		}

		/// <summary>
		/// If set to true, the dialog will be draggable will be draggable by the titlebar.
		/// </summary>
		/// <param name="newValue">New draggable setting</param>
		public void SetDraggable(bool newValue) {
			this.RenderSetOptionCall("draggable", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "height" setting.
		/// </summary>
		public void GetHeight() {
			this.RenderGetOptionCall("height");
		}

		/// <summary>
		/// The height of the dialog, in pixels. 
		/// </summary>
		/// <param name="newValue">New height setting</param>
		public void SetHeight(int newValue) {
			this.RenderSetOptionCall("height", newValue.ToString());
		}

		/// <summary>
		/// The height of the dialog, in pixels. 
		/// Specifying 'auto' is also supported to make the dialog adjust based on its content.		
		/// </summary>
		public void SetHeightToAuto() {
			this.RenderSetOptionCall("height", "auto".InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "hide" setting.
		/// </summary>
		public void GetHideEffect() {
			this.RenderGetOptionCall("hide");
		}

		/// <summary>
		/// The effect to be used when the dialog is closed.
		/// </summary>
		/// <param name="newValue">New hide setting</param>
		public void SetHideEffect(Core.Animation.eAnimation newValue) {
			string animationStr = Core.Animation.AnimationToString(newValue);
			this.RenderSetOptionCall("hide", animationStr.InDoubleQuotes() );
		}

		/// <summary>
		/// The effect to be used when the dialog is closed.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New hide setting</param>
		public void SetHideEffectJS(string newValue) {
			this.RenderSetOptionCall("hide", newValue );
		}

		/// <summary>
		/// The effect to be used when the dialog is closed.
		/// </summary>
		/// <param name="newValue">New hide setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetHideEffect(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("hide", newValue, inDoubleQuotes );
		}

		/// <summary>
		/// The effect to be used when the dialog is closed.
		/// </summary>
		/// <param name="newValue">New hide setting</param>
		public void SetHideEffect(string newValue) {
			this.SetHideEffect(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "maxHeight" setting.
		/// </summary>
		public void GetMaxHeight() {
			this.RenderGetOptionCall("maxHeight");
		}

		/// <summary>
		/// The maximum height to which the dialog can be resized, in pixels.
		/// </summary>
		/// <param name="newValue">New maxHeight setting</param>
		public void SetMaxHeight(int newValue) {
			this.RenderSetOptionCall("maxHeight", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "maxWidth" setting.
		/// </summary>
		public void GetMaxWidth() {
			this.RenderGetOptionCall("maxWidth");
		}

		/// <summary>
		/// The maximum width to which the dialog can be resized, in pixels
		/// </summary>
		/// <param name="newValue">New maxWidth setting</param>
		public void SetMaxWidth(int newValue) {
			this.RenderSetOptionCall("maxWidth", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "minHeight" setting.
		/// </summary>
		public void GetMinHeight() {
			this.RenderGetOptionCall("minHeight");
		}

		/// <summary>
		/// The minimum height to which the dialog can be resized, in pixels.
		/// </summary>
		/// <param name="newValue">New minHeight setting</param>
		public void SetMinHeight(int newValue) {
			this.RenderSetOptionCall("minHeight", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "minWidth" setting.
		/// </summary>
		public void GetMinWidth() {
			this.RenderGetOptionCall("minWidth");
		}

		/// <summary>
		/// The minimum width to which the dialog can be resized, in pixels.
		/// </summary>
		/// <param name="newValue">New minWidth setting</param>
		public void SetMinWidth(int newValue) {
			this.RenderSetOptionCall("minWidth", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "modal" setting.
		/// </summary>
		public void GetModal() {
			this.RenderGetOptionCall("modal");
		}

		/// <summary>
		/// If set to true, the dialog will have modal behavior; other items on the 
		/// page will be disabled (i.e. cannot be interacted with). Modal dialogs 
		/// create an overlay below the dialog but above other page elements.
		/// </summary>
		/// <param name="newValue">New modal setting</param>
		public void SetModal(bool newValue) {
			this.RenderSetOptionCall("modal", newValue);
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

		/// <summary>
		/// Returns [in JavaScript] the current "reisizable" setting.
		/// </summary>
		public void GetResizable() {
			this.RenderGetOptionCall("resizable");
		}

		/// <summary>
		/// If set to true, the dialog will be resizeable.
		/// </summary>
		/// <param name="newValue">New reisizable setting</param>
		public void SetResizable(bool newValue) {
			this.RenderSetOptionCall("resizable", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "show" setting.
		/// </summary>
		public void GetShowEffect() {
			this.RenderGetOptionCall("show");
		}

		/// <summary>
		/// The effect to be used when the dialog is opened.
		/// </summary>
		/// <param name="newValue">New show setting</param>
		public void SetShowEffect(Core.Animation.eAnimation newValue) {
			string animationStr = Core.Animation.AnimationToString(newValue);
			this.RenderSetOptionCall("show", animationStr.InDoubleQuotes() );
		}

		/// <summary>
		/// The effect to be used when the dialog is opened.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New show setting</param>
		public void SetShowEffectJS(string newValue) {
			this.RenderSetOptionCall("show", newValue );
		}

		/// <summary>
		/// The effect to be used when the dialog is opened.
		/// </summary>
		/// <param name="newValue">New show setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetShowEffect(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("show", newValue, inDoubleQuotes );
		}

		/// <summary>
		/// The effect to be used when the dialog is opened.
		/// </summary>
		/// <param name="newValue">New show setting</param>
		public void SetShowEffect(string newValue) {
			this.SetShowEffect(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "stack" setting.
		/// </summary>
		public void GetStack() {
			this.RenderGetOptionCall("stack");
		}

		/// <summary>
		/// Specifies whether the dialog will stack on top of other dialogs. 
		/// This will cause the dialog to move to the front of other dialogs when 
		/// it gains focus.
		/// </summary>
		/// <param name="newValue">New stack setting</param>
		public void SetStack(bool newValue) {
			this.RenderSetOptionCall("stack", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "title" setting.
		/// </summary>
		public void GetTitle() {
			this.RenderGetOptionCall("title");
		}

		/// <summary>
		/// Specifies the title of the dialog. Any valid HTML may be set as the title. 
		/// The title can also be specified by the title attribute on the dialog source element.
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New title setting</param>
		public void SetTitleJS(string newValue) {
			this.RenderSetOptionCall("title", newValue);
		}

		/// <summary>
		/// Specifies the title of the dialog. Any valid HTML may be set as the title. 
		/// The title can also be specified by the title attribute on the dialog source element.
		/// </summary>
		/// <param name="newValue">New title setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetTitle(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("title", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Specifies the title of the dialog. Any valid HTML may be set as the title. 
		/// The title can also be specified by the title attribute on the dialog source element.
		/// </summary>
		/// <param name="newValue">New title setting</param>
		public void SetTitle(string newValue) {
			this.SetTitle(newValue, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "width" setting.
		/// </summary>
		public void GetWidth() {
			this.RenderGetOptionCall("width");
		}

		/// <summary>
		/// The width of the dialog, in pixels.
		/// </summary>
		/// <param name="newValue">New width setting</param>
		public void SetWidth(int newValue) {
			this.RenderSetOptionCall("width", newValue.ToString());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "zIndex" setting.
		/// </summary>
		public void GetZIndex() {
			this.RenderGetOptionCall("zIndex");
		}

		/// <summary>
		/// The starting z-index for the dialog.
		/// </summary>
		/// <param name="newValue">New zIndex setting</param>
		public void SetZIndex(int newValue) {
			this.RenderSetOptionCall("zIndex", newValue.ToString());
		}

	}

}
