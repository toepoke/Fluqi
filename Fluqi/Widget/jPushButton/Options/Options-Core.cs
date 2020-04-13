using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using static Fluqi.Core.IconPosition;

namespace Fluqi.Widget.jPushButton
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Button.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="btn">PushButton to configure options of</param>
		public Options(PushButton btn)
		 : base()
		{
			this.Button = btn;
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="PushButton"/> object these options are for
		/// </summary>
		public PushButton Button { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="PushButton"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="PushButton"/> object to return chaining to the Tabs collection</returns>
		public PushButton Finish() {
			return this.Button;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			options.Add(!this.Text, "text", this.Text.JsBool());
			
			if (!this.IsNullOrEmpty(this.Icon)) {
				options.Add("icon", this.Icon.InSingleQuotes());
				if (!this.IsNullOrEmpty(this.IconPosition)) {
					options.Add("iconPosition", this.IconPosition.InSingleQuotes());
				}
			}
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Disabled = false;
			this.Text = true;
			this.Icon = "";
			this.IconPosition = "";
		}

	} // Options

} // ns Fluqi.jButton
