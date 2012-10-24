using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Core
{
	/// <summary>
	/// Models a set of options that are common against all jQuery UI and the class library.  For instance
	/// "RenderCSS" is a decision you'd make across your application (i.e. do we care about non-JavaScript users
	/// or not).
	/// </summary>
	public class Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Options() {
		} 

		/// <summary>
		/// Shortcut for working out if the given parameter is null or empty
		/// </summary>
		/// <param name="value">Value to query</param>
		/// <returns></returns>
		protected bool IsNullOrEmpty(string value) {
			return string.IsNullOrEmpty(value);
		}


		/// <summary>
		/// Establishes if the given value is null, empty or the same as the default.  We look
		/// at the default value because if we're rendering the default we don't need to output
		/// the setting (as it's the default for the jQuery UI control) and thus we can reduce the
		/// JavaScript needed to initialise the control (which can be fairly big if you've got 20+ 
		/// options (never mind readability!))
		/// </summary>
		/// <param name="value">Options being set</param>
		/// <param name="defaultValue">Default for the option</param>
		/// <returns>
		/// Returns true if the value is null, empty or the same as the default
		/// Returns false otherwise
		/// </returns>
		protected bool IsNullEmptyOrDefault(string value, string defaultValue) {
			return Helpers.Utils.IsNullEmptyOrDefault(value, defaultValue);
		}


		/// <summary>
		/// Establishes if the given value is null, empty or the same as the default.  We look
		/// at the default value because if we're rendering the default we don't need to output
		/// the setting (as it's the default for the jQuery UI control) and thus we can reduce the
		/// JavaScript needed to initialise the control (which can be fairly big if you've got 20+ 
		/// options (never mind readability!))
		/// </summary>
		/// <param name="values">Options being set</param>
		/// <param name="defaultValues">Defaults for the option</param>
		/// <returns>
		/// Returns true if the value is null, empty or the same as the default
		/// Returns false otherwise
		/// </returns>
		protected bool IsNullEmptyOrDefault(List<string> values, List<string> defaultValues) {
			return Helpers.Utils.IsNullEmptyOrDefault(values, defaultValues);
		}


		/// <summary>
		/// Establishes if the given value is null, empty or the same as the default.  We look
		/// at the default value because if we're rendering the default we don't need to output
		/// the setting (as it's the default for the jQuery UI control) and thus we can reduce the
		/// JavaScript needed to initialise the control (which can be fairly big if you've got 20+ 
		/// options (never mind readability!))
		/// </summary>
		/// <param name="value">Options being set</param>
		/// <param name="defaultValue">Default for the option</param>
		/// <returns>
		/// Returns true if the value is null, empty or the same as the default
		/// Returns false otherwise
		/// </returns>
		protected bool IsDefault(int value, int defaultValue) {
			return (value == defaultValue);
		}


		/// <summary>
		/// Establishes if the given value is a numeric value or not (note +10 and -10 are considered numeric 
		/// too).
		/// </summary>
		/// <param name="value">Value to query</param>
		/// <returns>
		/// Returns true if the value is considered numeric
		/// Returns false otherwise
		/// </returns>
		protected bool IsNumeric(string value) {
			return Helpers.Utils.IsNumeric(value);
		}


		/// <summary>
		/// Establishes if the given value is a numeric value or not (note +10 and -10 are considered numeric 
		/// too).
		/// </summary>
		/// <param name="value">Value to query</param>
		/// <returns>
		/// Returns true if the value is considered numeric
		/// Returns false otherwise
		/// </returns>
		protected bool IsBool(string value) {
			return Helpers.Utils.IsBool(value);
		}


		/// <summary>
		/// Establishes whether the given value is considered to be a string representing
		/// a relative date.  Some jQuery UI controls (mainly DatePicker) allow you to 
		/// specify a relate date, "+10d" is "10 days in the future" and "-1m" is "one month in the past"
		/// </summary>
		/// <param name="value">Value to be queried</param>
		/// <returns>
		/// Returns true if the value is considered to be a relative date specification
		/// Returns false otherwise
		/// </returns>
		protected bool IsRelativeDateSpec(string value) {
			return Helpers.Utils.IsRelativeDateSpec(value);
		}

		/// <summary>
		/// Establishes whether the given value is considered to be a [jQuery] selector string
		/// </summary>
		/// <param name="value">Value to be queried</param>
		/// <returns></returns>
		protected bool IsSelector(string value) {
			return Helpers.Utils.IsSelector(value);
		}

		/// <summary>
		/// Establishes whether the given value is considered to be a JSON string
		/// </summary>
		/// <param name="value">Value to be queried</param>
		/// <returns>
		/// Returns true if value is deemed to be a JSON object
		/// Returns false otherwise
		/// </returns>
		/// <remarks>To determine this we simply look for the presence of "{", "}", "," or ":"</remarks>
		protected bool IsJSON(string value) {
			return Helpers.Utils.IsJSON(value);
		}

		/// <summary>
		/// Entry point for a widget to add a list of options that the widget should render
		/// when the JavaScript is written out.
		/// </summary>
		/// <param name="options">List of options to add widget settings to</param>
		protected internal virtual void DiscoverOptions(Core.ScriptOptions options) {
			throw new NotImplementedException("DiscoverOptions must be overriden.");
		}

		/// <summary>
		/// Renders the JavaScript required to set the options with 
		/// the settings that are configured for this widget.
		/// </summary>
		/// <returns>
		/// Returns the JavaScript to initialise the jQuery UI widget, given the configured options.
		/// </returns>
		public override string ToString() {
			Core.ScriptOptions scripting = new Core.ScriptOptions();
			this.DiscoverOptions(scripting);

			jStringBuilder sb = new jStringBuilder(false/*includeWhitespace*/, 0/*tabDepth*/);
			scripting.Render(sb);

			return sb.ToString();
		}

	} // Options

} // ns

