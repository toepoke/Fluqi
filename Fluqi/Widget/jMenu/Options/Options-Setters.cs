using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Microsoft.VisualBasic;

namespace Fluqi.Widget.jMenu
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Menu.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables the menu if set to true.
		/// </summary>
		/// <param name="value">If true disables the menu, enabled otherwise</param>
		public Options SetDisabled(bool value) {
			this.Disabled = value;
			return this;
		}

		/// <summary>
		/// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="subMenuIcon">Sub menu icon to use</param>
		public Options SetIcons(Core.Icons.eIconClass subMenuIcon) {
			return this.SetIcons( Core.Icons.ByEnum(subMenuIcon) );
		}

		/// <summary>
		/// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="subMenuIcon">Sub menu icon to use</param>
		public Options SetIcons(string subMenuIcon) {
			this.Icons = subMenuIcon;
			return this;
		}

		/// <summary>
		/// Selector for the elements that serve as the menu container, including sub-menus.
		/// </summary>
		/// <param name="value"></param>
		public Options SetMenus(string value) {
			this.Menus = value;
			return this;
		}

		/// <summary>
		/// Customize the ARIA roles used for the menu and menu items. 
		/// The default uses "menuitem" for items. 
		/// Setting the role option to "listbox" will use "option" for items. 
		/// If set to null, no roles will be set, which is useful if the menu is being controlled by another element that is maintaining focus.
		/// </summary>
		/// <param name="role">Role to use</param>
		public Options SetRole(string role) {
			this.Role = role;
			return this;
		}
		
	} // Options

} // ns
