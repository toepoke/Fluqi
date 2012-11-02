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
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables the menu if set to true.
		/// </summary>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.
		/// submenu (string, default: "ui-icon-carat-1-e")
		/// </summary>
		protected internal string Icons { get; set; }

		/// <summary>
		/// Selector for the elements that serve as the menu container, including sub-menus.
		/// </summary>
		protected internal string Menus { get; set; }

		/// <summary>
		/// Customize the ARIA roles used for the menu and menu items. 
		/// The default uses "menuitem" for items. 
		/// Setting the role option to "listbox" will use "option" for items. 
		/// If set to null, no roles will be set, which is useful if the menu is being controlled by another element that is maintaining focus.
		/// </summary>
		protected internal string Role { get; set; }

	} 

} // ns
