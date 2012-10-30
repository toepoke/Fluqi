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

namespace Fluqi.Widget.jSpinner
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Spinner.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
#pragma warning disable 1591
		public const string DEFAULT_UP_ICON_CLASS = "ui-icon-triangle-1-s";
		public const string DEFAULT_DOWN_ICON_CLASS = "ui-icon-triangle-1-n";
		public const string DEFAULT_MIN_VALUE = null;
		public const string DEFAULT_MAX_VALUE = null;
		public const string DEFAULT_NUMBER_FORMAT = null;
		public const int DEFAULT_PAGE = 10;
		public const string DEFAULT_STEP = "1";
#pragma warning restore 1591

		/// <summary>
		/// Holds a reference to the <see cref="Spinner"/> object these options are for
		/// </summary>
		public Spinner Spinner { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Spinner"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Spinner"/> object to return chaining to the Tabs collection</returns>
		public Spinner Finish() {
			return this.Spinner;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			//bool bValue = false; int nValue = 0;

			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			options.Add(!this.IsNullOrEmpty(this.Culture), "culture", this.Culture.InDoubleQuotes());

			if (!this.IsNullEmptyOrDefault(this.DownIconClass, DEFAULT_DOWN_ICON_CLASS) && !this.IsNullEmptyOrDefault(this.UpIconClass, DEFAULT_UP_ICON_CLASS)) {
				// output both
				options.Add("icons", "{{ down: {0}, up: {1} }}", this.DownIconClass.InDoubleQuotes(), this.UpIconClass.InDoubleQuotes());
			} else if (!this.IsNullEmptyOrDefault(this.DownIconClass, DEFAULT_DOWN_ICON_CLASS)) {
				// just down
				options.Add("icons", "{{ down: {0} }}", this.DownIconClass.InDoubleQuotes());
			} else if (!this.IsNullEmptyOrDefault(this.UpIconClass, DEFAULT_UP_ICON_CLASS)) {
				// just up
				options.Add("icons", "{{ up: {0} }}", this.UpIconClass.InDoubleQuotes());
			}

			if (this.IsBool(this.Incremental)) {
				bool value = bool.Parse(this.Incremental);
				options.Add(!value, "incremental", value.JsBool());
			} else {
				// assume it's using the function method
				options.Add(!this.IsNullOrEmpty(this.Incremental), "incremental", this.Incremental );
			}

			if (!this.IsNullEmptyOrDefault(this.Min, DEFAULT_MIN_VALUE)) {
				options.Add(this.IsNumeric(this.Min), "min", this.Min);
				options.Add(!this.IsNumeric(this.Min), "min", this.Min.InDoubleQuotes());
			}
			if (!this.IsNullEmptyOrDefault(this.Max, DEFAULT_MAX_VALUE)) {
				options.Add(this.IsNumeric(this.Max), "max", this.Max);
				options.Add(!this.IsNumeric(this.Max), "max", this.Max.InDoubleQuotes());
			}

			options.Add(!this.IsNullEmptyOrDefault(this.NumberFormat, DEFAULT_NUMBER_FORMAT), "numberFormat", this.NumberFormat.InDoubleQuotes());
			options.Add(!this.IsDefault(this.Page, DEFAULT_PAGE), "page", this.Page.ToString());

			if (!this.IsNullEmptyOrDefault(this.Step, DEFAULT_STEP)) {
				options.Add(this.IsNumeric(this.Step), "step", this.Step);
				options.Add(!this.IsNumeric(this.Step), "step", this.Step.InDoubleQuotes());
			}
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Culture = null;
			this.Disabled = false;
			this.Min = DEFAULT_MIN_VALUE;
			this.Max = DEFAULT_MAX_VALUE;
			this.NumberFormat = DEFAULT_NUMBER_FORMAT;
			this.Page = DEFAULT_PAGE;
			this.Step = DEFAULT_STEP.ToString();
		}

	} // Options

} // ns
