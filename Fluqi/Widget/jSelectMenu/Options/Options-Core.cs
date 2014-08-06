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
#pragma warning disable 1591
		public const bool DEFAULT_DISABLED = false;
		public const string DEFAULT_ICONS = "ui-icon-triangle-1-s";
#pragma warning restore 1591

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="selectMenu">SelectMenu to configure options of</param>
		public Options(SelectMenu selectMenu)
		 : base()
		{
			this.SelectMenu = selectMenu;
			this.Position = new PositionOptions(this);
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="SelectMenu"/> object these options are for
		/// </summary>
		public SelectMenu SelectMenu { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="SelectMenu"/> object so we can continue defining attributes.
		/// </summary>
		/// <returns>Returns <see cref="SelectMenu"/> object to return chaining</returns>
		public SelectMenu Finish() {
			return this.SelectMenu;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(!this.IsNullOrEmpty(this.AppendTo), "appendTo", this.AppendTo.InDoubleQuotes());
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			options.Add(!this.IsNullEmptyOrDefault(this.Icons, DEFAULT_ICONS), "icons", "{{ button: {0} }}", this.Icons.InDoubleQuotes());
			options.Add(this.Position.Options.GetPositionScriptOption());
			if (this.Width.HasValue) {
				options.Add(this.Width.HasValue, "width", this.Width.Value.ToString());
			}
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.AppendTo = null;
			this.Disabled = false;
			this.Icons = DEFAULT_ICONS;
			this.Width = null;
		}

	} // Options

} // ns
