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
#pragma warning disable 1591
		public const bool DEFAULT_DISABLED = false;
		public const string DEFAULT_ICONS = "ui-icon-carat-1-e";
		public const string DEFAULT_MENUS = "ul";
		public const string DEFAULT_ROLE = "menu";
#pragma warning restore 1591

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="sldr">Menu to configure options of</param>
		public Options(Menu menu)
		 : base()
		{
			this.Menu = menu;
			this.Position = new PositionOptions(this);
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Menu"/> object these options are for
		/// </summary>
		public Menu Menu { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Menu"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Menu"/> object to return chaining to the Tabs collection</returns>
		public Menu Finish() {
			return this.Menu;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			options.Add(!this.IsNullEmptyOrDefault(this.Icons, DEFAULT_ICONS), "icons", "{{ submenu: {0} }}", this.Icons.InDoubleQuotes());
			options.Add(!this.IsNullEmptyOrDefault(this.Menus, DEFAULT_MENUS), "menus", this.Menus.InDoubleQuotes() );
			options.Add(!this.IsNullEmptyOrDefault(this.Role, DEFAULT_ROLE), "role", this.Role.InDoubleQuotes());

			// Position is a little bit different because it's an object, so just add it's options in
			options.Add(this.Position.Options.GetPositionScriptOption());
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Disabled = DEFAULT_DISABLED;
			this.Icons = DEFAULT_ICONS;
			this.Menus = DEFAULT_MENUS;
			this.Role = DEFAULT_ROLE;
			// Set the position utility defaults
			this.Position.Options.MyDefault = "left top";
			this.Position.Options.AtDefault = "right top";
		}

	} // Options

} // ns
