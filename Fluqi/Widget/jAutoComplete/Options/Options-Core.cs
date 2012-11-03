using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAutoComplete
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Default length of delay before the available options are shown.
		/// </summary>
		public const int DEFAULT_DELAY = 300;

		/// <summary>
		/// Default number of characters that must be entered before the available options are shown.
		/// </summary>
		public const int DEFAULT_MINIMUM_LENGTH = 1;

		/// <summary>
		/// Default element options should be appended to.
		/// </summary>
		public const string DEFAULT_APPEND_TO = "body";


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="ac">Autocomplete object to be configured</param>
		public Options(AutoComplete ac)
		 : base()
		{
			this.AutoComplete = ac;
			this.Position = new PositionOptions(this);
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="AutoComplete"/> object these options are for
		/// </summary>
		public AutoComplete AutoComplete { get; set; }


		/// <summary>
		/// Identifies the position of the Autocomplete widget in relation to the associated input 
		/// element. The "of" option defaults to the input element, but you can specify another element 
		/// to position against. You can refer to the jQuery UI Position utility for more details 
		/// about the various options.
		/// </summary>
		/// <remarks>See http://api.jqueryui.com/autocomplete/#option-position for details</remarks>
		public PositionOptions Position { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="AutoComplete"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="AutoComplete"/> object to return chaining to the Tabs collection</returns>
		public AutoComplete Finish() {
			return this.AutoComplete;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			// default is "disable"
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());

			options.Add(!this.IsNullOrEmpty(this.Source), "source", this.Source);
			options.Add(!this.IsNullEmptyOrDefault(this.AppendTo, DEFAULT_APPEND_TO), "appendTo", this.AppendTo.InDoubleQuotes());
			options.Add(this.AutoFocus, "autoFocus", this.AutoFocus.JsBool());
			options.Add(!this.IsDefault(this.Delay, DEFAULT_DELAY), "delay", this.Delay.ToString());
			options.Add(!this.IsDefault(this.MinimumLength, DEFAULT_MINIMUM_LENGTH), "minLength", this.MinimumLength.ToString());

			// Position is a little bit different because it's an object, so just add it's options in
			options.Add(this.Position.Options.GetPositionScriptOption());
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Source = "";
			this.AppendTo = DEFAULT_APPEND_TO;
			this.Delay = DEFAULT_DELAY;
			this.MinimumLength = DEFAULT_MINIMUM_LENGTH;
			this.Disabled = false;
			// Set position defaults
			this.Position.Options.MyDefault = "left top";
			this.Position.Options.AtDefault = "left bottom";
			this.Position.Options.CollisionDefault = "none";
		}

	} // Options

} // ns Fluqi.jAutoComplete
