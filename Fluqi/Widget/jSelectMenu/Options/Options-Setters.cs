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

namespace Fluqi.Widget.jSelectMenu
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI SelectMenu.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Which element to append the menu to
		/// </summary>
		/// <param name="value">value</param>
		public Options SetAppendTo(string value) {
			this.AppendTo = value;
			return this;
		}
		
		/// <summary>
		/// Disables the control if set to true.
		/// </summary>
		/// <param name="value">If true disables the control, enabled otherwise</param>
		public Options SetDisabled(bool value) {
			this.Disabled = value;
			return this;
		}

		/// <summary>
		/// Icons to use for opening the control, matching an icon defined by the jQuery UI CSS Framework.
		/// (string, default: "ui-icon-triangle-1-s")
		/// </summary>
		/// <param name="selectMenuIcon">Dropdown icon to use</param>
		public Options SetIcons(Core.Icons.eIconClass selectMenuIcon) {
			return this.SetIcons( Core.Icons.ByEnum(selectMenuIcon) );
		}

		/// <summary>
		/// Icons to use for opening the control, matching an icon defined by the jQuery UI CSS Framework.
		/// (string, default: "ui-icon-triangle-1-s")
		/// </summary>
		/// <param name="selectMenuIcon">Dropdown icon to use</param>
		public Options SetIcons(string selectMenuIcon) {
			this.Icons = selectMenuIcon;
			return this;
		}

		/// <summary>
		/// The width of the menu, in pixels
		/// </summary>
		/// <param name="width">width</param>
		public Options SetWidth(int width) {
			this.Width = width;
			return this;
		}
		
	} // Options

} // ns
