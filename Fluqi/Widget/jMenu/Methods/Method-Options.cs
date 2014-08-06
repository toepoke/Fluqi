
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jMenu {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Disables the menu if set to true.
		/// </summary>
		public void GetDisabled() {
		  this.RenderGetOptionCall("disabled");
		}

		/// <summary>
		/// Disables the menu if set to true.
		/// </summary>
		/// <param name="value"></param>
		public void SetDisabled(bool value) {
		  this.RenderSetOptionCall("disabled", value);
		}

		/// <summary>
		/// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		public void GetIcons() {
		  this.RenderGetOptionCall("icons");
		}

		/// <summary>
		/// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="submenu"></param>
		public void SetIcons(string submenu) {
		  this.RenderSetOptionCall("icons", "{ submenu: " + submenu.InDoubleQuotes() + "}");
		}

		/// <summary>
		/// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="submenu"></param>
		public void SetIcons(Core.Icons.eIconClass submenu) {
			this.SetIcons(Core.Icons.ByEnum(submenu));
		}

		/// <summary>
		/// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		public void GetMenus() {
		  this.RenderGetOptionCall("menus");
		}
		
		/// <summary>
		/// Selector for the elements that serve as the menu container, including sub-menus.
		/// </summary>
		public void SetMenus(string menus) {
			this.RenderSetOptionCall("menus", menus.InDoubleQuotes());
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
		/// Customize the ARIA roles used for the menu and menu items. 
		/// The default uses "menuitem" for items. 
		/// Setting the role option to "listbox" will use "option" for items. 
		/// If set to null, no roles will be set, which is useful if the menu is being controlled by another element that is maintaining focus.
		/// </summary>
		public void GetRole() {
		  this.RenderGetOptionCall("role");
		}
		
		/// <summary>
		/// Customize the ARIA roles used for the menu and menu items. 
		/// The default uses "menuitem" for items. 
		/// Setting the role option to "listbox" will use "option" for items. 
		/// If set to null, no roles will be set, which is useful if the menu is being controlled by another element that is maintaining focus.
		/// </summary>
		/// <param name="role"></param>
		public void SetRole(string role) {
			if (role.Equals("null", StringComparison.InvariantCultureIgnoreCase))
				// no quotes
				this.RenderSetOptionCall("role", "null");
			else 
				this.RenderSetOptionCall("role", role.InDoubleQuotes());
		}

	}

}
