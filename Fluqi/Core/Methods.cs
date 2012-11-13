using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using System.IO;

namespace Fluqi.Core
{
	/// <summary>
	/// Models methods that can be applied to a jQuery UI control.
	/// </summary>
	public class Methods: Options
	{
		/// <summary>
		/// Name of the plugin.
		/// </summary>
		protected internal string _PlugInName = "";

		/// <summary>
		/// Object the control should write itself to.
		/// </summary>
		protected internal TextWriter _Writer = null;

		/// <summary>
		/// ID of the control.
		/// </summary>
		protected internal string _ID = "";

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="ictl">Control methods are being defined for</param>
		public Methods(Interfaces.IControl ictl) {
			this._PlugInName = ictl.PlugInName;
			this._Writer = ictl.Writer;
			this._ID = ictl.ID;
		} // ctor

		/// <summary>
		/// Works out what type of date value or object is being passed in (i.e. is a string date like "01/01/2000",
		/// a numerical date value like "3" for 3 days, or a relateive date specification like "+1w -1d" where some
		/// of them need quotes, but other don't.
		/// </summary>
		/// <param name="dateValue">Value to be queried</param>
		/// <returns></returns>
		protected virtual internal bool AddQuotesToDate(string dateValue) {
			return Helpers.Utils.AddQuotesToJQueryDate(dateValue);
		}

		/// <summary>
		/// Writes the JavaScript required to do a "Get" against a control option.
		/// </summary>
		/// <param name="optionName">Name of the option to get the value of</param>
		protected virtual internal void RenderGetOptionCall(string optionName) {
			string js = this.BuildMethodCall("option", optionName.InDoubleQuotes());
			this._Writer.Write(js);
		}

		/// <summary>
		/// Writes the JavaScript required to do a "Set" against a control option.
		/// </summary>
		/// <param name="optionName">Name of the option to get the value of</param>
		/// <param name="newValue">New value for the control option.</param>
		protected virtual internal void RenderSetOptionCall(string optionName, string newValue) {
			string js = this.BuildMethodCall("option", optionName.InDoubleQuotes(), newValue.ToString());
			this._Writer.Write(js);
		}

		/// <summary>
		/// Writes the JavaScript required to do a "Set" against a control option.
		/// </summary>
		/// <param name="optionName">Name of the option to get the value of</param>
		/// <param name="format">String.Format string argument - format</param>
		/// <param name="args">array of arguments to pass to String.Format</param>
		protected virtual internal void RenderSetOptionCall(string optionName, string format, params string[] args) {
			this.RenderSetOptionCall(optionName, string.Format(format, args) );
		}

		/// <summary>
		/// Writes the JavaScript required to do a "Set" against a control option.
		/// </summary>
		/// <param name="optionName">Name of the option to get the value of</param>
		/// <param name="newValue">New value for the control option.</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		protected virtual internal void RenderSetOptionCall(string optionName, string newValue, bool inDoubleQuotes) {
			if (inDoubleQuotes)
				newValue = newValue.InDoubleQuotes();
			else 
				newValue = newValue.InSingleQuotes();

			string js = this.BuildMethodCall("option", optionName.InDoubleQuotes(), newValue);
			this._Writer.Write(js);
		}

		/// <summary>
		/// Writes the JavaScript required to do a "Set" against a control option.
		/// </summary>
		/// <param name="optionName">Name of the option to get the value of</param>
		/// <param name="newValue">New value for the control option.</param>
		protected virtual internal void RenderSetOptionCall(string optionName, DateTime newValue) {
			this.RenderSetOptionCall(optionName, newValue.JsDate());
		}

		/// <summary>
		/// Writes the JavaScript required to do a "Set" against a control option.
		/// </summary>
		/// <param name="optionName">Name of the option to get the value of</param>
		/// <param name="newValue">New value for the control option.</param>
		protected virtual internal void RenderSetOptionCall(string optionName, bool newValue) {
			this.RenderSetOptionCall(optionName, newValue.JsBool());
		}

		/// <summary>
		/// Writes the JavaScript required to do a "Set" against a control option.
		/// </summary>
		/// <param name="optionName">Name of the option to get the value of</param>
		/// <param name="newValue">New value for the control option.</param>
		protected virtual internal void RenderSetOptionCall(string optionName, int newValue) {
			this.RenderSetOptionCall(optionName, newValue.ToString());
		}

		/// <summary>
		/// Writes the JavaScript required to call a given method on the jQuery UI control.
		/// </summary>
		/// <param name="methodName">Name of the method to call (as define in the jQuery UI documentation for the control.</param>
		/// <param name="args">Set of arguments to pass to String.Format</param>
		protected virtual internal void RenderMethodCall(string methodName, params object[] args) {
			string js = this.BuildMethodCall(methodName, args);
			this._Writer.Write(js);
		}


		/// <summary>
		/// Builds up the JavaScript required to call a given method.
		/// </summary>
		/// <param name="methodName">Name of the method to call (as define in the jQuery UI documentation for the control.</param>
		/// <param name="args">Set of arguments to pass to String.Format</param>
		/// <returns>JavaScript required to call the jQuery UI control method</returns>
		protected virtual internal string BuildMethodCall(string methodName, params object[] args) {
			List<string> argList = (from a in args where a != null select a.ToString()).ToList<string>();
			string arguments = argList.ToSeparated(",");

			if (!string.IsNullOrEmpty(arguments))
				// additional arguments
				return string.Format("$(\"#{0}\").{1}(\"{2}\",{3})", _ID, this._PlugInName, methodName, arguments);
			else 
				// single argument
				return string.Format("$(\"#{0}\").{1}(\"{2}\")", _ID, this._PlugInName, methodName);
		}

	} // Methods

} // ns

