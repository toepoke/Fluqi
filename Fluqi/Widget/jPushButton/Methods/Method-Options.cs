using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jPushButton {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {
	
		/// <summary>
		/// Returns [in JavaScript] the current "text" setting.
		/// </summary>
		public void GetText() {
			this.RenderGetOptionCall("text");
		}

		/// <summary>
		/// Whether to show any text 
		/// - when set to false (display no text), icon (see icon option) must be enabled, otherwise it'll be ignored.
		/// </summary>
		/// <param name="newValue">New text setting</param>
		public void SetText(bool newValue) {
			this.RenderSetOptionCall("text", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "icon" setting.
		/// </summary>
		public void GetIcons() {
			this.RenderGetOptionCall("icon");
		}

		/// <summary>
		/// Icon to display, with or without text (see text option). 
		/// </summary>
		/// <param name="icon">new unselected header setting</param>
		public void SetIcon(string icon) {
			icon = icon ?? "";
			this.RenderSetOptionCall("icon", icon.InSingleQuotes());
		}

		/// <summary>
		/// Icon to display, with or without text (see text option). 
		/// </summary>
		/// <param name="icon">new unselected header setting</param>
		public void SetIcon(Core.Icons.eIconClass icon) {
			string iconStr = Core.Icons.ByEnum(icon);
			this.RenderSetOptionCall("icon", iconStr.InSingleQuotes());
		}

		/// <summary>
		/// Icon to display, with or without text (see text option). Icon is displayed 
		/// as per <paramref name="iconPosition"/> parameter.
		/// </summary>
		/// <param name="icon">new unselected header setting</param>
		/// <param name="iconPosition">new selected header setting</param>
		public void SetIcon(string icon, string iconPosition) {
			icon = icon ?? "";
			iconPosition = iconPosition ?? "";
			this.RenderSetOptionCall("icon", icon);
			this.RenderSetOptionCall("iconPosition", iconPosition);
		}

		/// <summary>
		/// Icon to use for headers. Icon may be specified for 'header' and 'activeHeader', 
		/// and we recommend using the icon native to the jQuery UI CSS Framework manipulated by jQuery UI ThemeRoller
		/// </summary>
		/// <param name="icon">new unselected header setting</param>
		/// <param name="iconPosition">new selected header setting</param>
		public void SetIcon(Core.Icons.eIconClass icon, Core.IconPosition.eIconPosition iconPosition) {
			string prim = Core.Icons.ByEnum(icon);
			string sec = Core.IconPosition.ByEnum(iconPosition);

			this.SetIcon(prim, sec);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "label" setting.
		/// </summary>
		public void GetLabel() {
			this.RenderGetOptionCall("label");
		}

		/// <summary>
		/// Text to show on the button. When not specified (null), the element's html content is used, 
		/// or its value attribute when it's an input element of type submit or reset; or the html content of the 
		/// associated label element if its an input of type radio or checkbox
		/// This entry point does _not_ add quotes to the input value and is indended for passing JavaScript
		/// (that is when rendered, the input value will refer to a JavaScript variable for instance).
		/// </summary>
		/// <param name="newValue">New label setting</param>
		public void SetLabelJS(string newValue) {
			this.RenderSetOptionCall("label", newValue);
		}
		
		/// <summary>
		/// Text to show on the button. When not specified (null), the element's html content is used, 
		/// or its value attribute when it's an input element of type submit or reset; or the html content of the 
		/// associated label element if its an input of type radio or checkbox
		/// </summary>
		/// <param name="newValue">New label setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetLabel(string newValue, bool inDoubleQuotes) {
			this.RenderSetOptionCall("label", newValue, inDoubleQuotes);
		}

		/// <summary>
		/// Text to show on the button. When not specified (null), the element's html content is used, 
		/// or its value attribute when it's an input element of type submit or reset; or the html content of the 
		/// associated label element if its an input of type radio or checkbox
		/// </summary>
		/// <param name="newValue">New label setting</param>
		public void SetLabel(string newValue) {
			this.SetLabel(newValue, true/*doubleQuotes*/);
		}

	}

}
