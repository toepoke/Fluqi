using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jPushButton {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="btn">PushButton object to call</param>
		public Methods(PushButton btn) : base(btn)
		{
		}		

		/// <summary>
		/// Remove the Button functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/button/#method-destroy for details.</remarks>
		public void Destroy() {
			base.RenderMethodCall("destroy");
		}	


		/// <summary>
		/// Disable the Button.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/button/#method-disable for details.</remarks>
		public void Disable() {
			base.RenderMethodCall("disable");
		}	


		/// <summary>
		/// Enable the Button.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/button/#method-enable for details.</remarks>
		public void Enable() {
			base.RenderMethodCall("enable");
		}	


		/// <summary>
		/// Returns the .ui-button element.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/button/#method-widget for details.</remarks>
		public void Widget() {
			base.RenderMethodCall("widget");
		}	
		

		/// <summary>
		/// Refreshes the visual state of the button. Useful for updating button state after the native 
		/// element's checked or disabled state is changed programatically.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/button/#method-refresh for details.</remarks>
		public void Refresh() {
			base.RenderMethodCall("refresh");
		}	

		/// <summary>
		/// Returns [in JavaScript] the current "text" setting.
		/// </summary>
		public void GetText() {
			this.RenderGetOptionCall("text");
		}

		/// <summary>
		/// Whether to show any text 
		/// - when set to false (display no text), icons (see icons option) must be enabled, otherwise it'll be ignored.
		/// </summary>
		/// <param name="newValue">New text setting</param>
		public void SetText(bool newValue) {
			this.RenderSetOptionCall("text", newValue);
		}

		/// <summary>
		/// Returns [in JavaScript] the current "icons" setting.
		/// </summary>
		public void GetIcons() {
			this.RenderGetOptionCall("icons");
		}
				
		/// <summary>
		/// Icons to display, with or without text (see text option). The primary icon is displayed by 
		/// default on the left of the label text, the secondary by default is on the right. 
		/// Value for the primary and secondary properties must be a classname (String), 
		/// eg. "ui-icon-gear". For using only one icon: icons: {primary:'ui-icon-locked'}. 
		/// For using two icons: icons: {primary:'ui-icon-gear',secondary:'ui-icon-triangle-1-s'}
		/// </summary>
		/// <param name="primary">new unselected header setting</param>
		/// <param name="secondary">new selected header setting</param>
		public void SetIcons(string primary, string secondary) {
			primary = primary ?? "";
			secondary = secondary ?? "";
			this.RenderSetOptionCall("icons", 
				string.Format("{{ primary: '{0}', secondary: '{1}' }}", primary, secondary) 
			);
		}

		/// <summary>
		/// Icons to use for headers. Icons may be specified for 'header' and 'activeHeader', 
		/// and we recommend using the icons native to the jQuery UI CSS Framework manipulated by jQuery UI ThemeRoller
		/// </summary>
		/// <param name="primary">new unselected header setting</param>
		/// <param name="secondary">new selected header setting</param>
		public void SetIcons(Core.Icons.eIconClass primary, Core.Icons.eIconClass secondary) {
			string prim = Core.Icons.ByEnum(primary);
			string sec = Core.Icons.ByEnum(secondary);

			this.SetIcons(prim, sec);
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
