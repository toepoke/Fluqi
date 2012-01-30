using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;

namespace Fluqi.Core
{
	/// <summary>
	/// Holds a list of script options that have multiple properties that
	/// are latered rendered into one string of JavaScript.
	/// </summary>
	public class ScriptOptions: List<ScriptOption>
	{
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ScriptOptions() {
		}


		/// <summary>
		/// Constructor - used for create a set of child options (for instance the Position control
		/// appears as part of other control).
		/// </summary>
		/// <param name="parent">Parent control</param>
		public ScriptOptions(ScriptOption parent) {
		}


		/// <summary>
		/// Adds a new option into the list, if the <paramref name="condition"/> holds true.
		/// </summary>
		/// <param name="condition">
		/// If true the identified option is added to the list
		/// If false the option isn't added to the list
		/// </param>
		/// <param name="key">Name of the property being added to the list</param>
		/// <param name="value">Value of the property being added to the list</param>
		public void Add(bool condition, string key, string value)
		{
			if (!condition)
				// nothing to see here
				return;

			ScriptOption opt = new ScriptOption() { 
				Condition = condition, 
				Key = key, 
				Value = value 
			};
			base.Add(opt);
		}


		/// <summary>
		/// Adds a new option into the list
		/// </summary>
		/// <param name="key">Name of the property being added to the list</param>
		/// <param name="value">Value of the property being added to the list</param>
		public void Add(string key, string value)
		{
			this.Add(true, key, value);
		}


		/// <summary>
		/// Adds a new option into the list, if the <paramref name="condition"/> holds true.
		/// </summary>
		/// <param name="condition">
		/// If true the identified option is added to the list
		/// If false the option isn't added to the list
		/// </param>
		/// <param name="key">Name of the property being added to the list</param>
		/// <param name="fmt">Set of instructions for formatting a string (to be used in a String.Format call)</param>
		/// <param name="args">Set of arguments for the String.Format call</param>
		public void Add(bool condition, string key, string fmt, params string[] args)
		{
			this.Add(condition, key, string.Format(fmt, args) );
		}


		/// <summary>
		/// Adds a new option into the list.
		/// </summary>
		/// <param name="key">Name of the property being added to the list</param>
		/// <param name="fmt">Set of instructions for formatting the value (to be used in a String.Format call)</param>
		/// <param name="args">Set of arguments to formatulate the value from the String.Format call</param>
		public void Add(string key, string fmt, params string[] args) 
		{
			this.Add(true, key, string.Format( fmt, args ) );
		}


		/// <summary>
		/// Adds a new [date] option into the list.
		/// </summary>
		/// <param name="key">Name of the property being added to the list</param>
		/// <param name="dateStr">
		/// Value considered to be a date - can be a date in a string (e.g. "01/01/2000")
		/// a numerical relative date (e.g. +4, -3) or a relative date specification like "+1w -1d" where some
		/// of them need quotes, but others don't.
		/// </param>
		/// <remarks>
		/// If <paramref name="dateStr"/> is null or empty nothing is added to the list.
		/// </remarks>
		public void AddDate(string key, string dateStr) {
			if (string.IsNullOrEmpty(dateStr))
				// no point adding nothing
				return;

			if (Helpers.Utils.AddQuotesToJQueryDate(dateStr)) {
				this.Add(key, dateStr.InDoubleQuotes());
			} else {
				this.Add(key, dateStr);
			}
		}


		/// <summary>
		/// Adds a date option to the list of options.
		/// </summary>
		/// <param name="key">Name of the property being added to the list</param>
		/// <param name="dt">Date to add</param>
		public void AddDate(string key, DateTime dt) {
			this.Add(key, dt.JsDate());
		}
		
		/// <summary>
		/// Adds a date option to the list of options.
		/// </summary>
		/// <param name="key">Name of the property being added to the list</param>
		/// <param name="dt">Date to add</param>
		public void AddDate(string key, DateTime? dt) {
			if (!dt.HasValue)
				// no point adding nothing
				return;

			AddDate(key, dt.Value);
		}

		/// <summary>
		/// Adds an event handler script opion to the list.  In effect we create a small JavaScript inline function and add 
		/// the <paramref name="methodSource"/> to the inline function.
		/// </summary>
		/// <param name="key">Name of the event to add</param>
		/// <param name="functionPrototype">Function signature documented by jQuery UI for the event handler</param>
		/// <param name="methodSource">Source code to add to the event handler</param>
		public void AddEventHandler(string key, string functionPrototype, string methodSource) 
		{
			string eventHandlerCall = string.Format("function({0}) {{\n{1}\n}}", functionPrototype, methodSource);
			bool render = !string.IsNullOrEmpty(methodSource);

			this.Add( 
				new ScriptOption() { 
					Condition = render,
					Key = key, 
					FunctionPrototype = functionPrototype, 
					MethodSource = methodSource 
				} 
			);
		}


		/// <summary>
		/// Generates the JavaScript for a control required to initialise it's properties
		/// and event handlers that have been defined in the list.
		/// </summary>
		/// <param name="sb">The string builder used to add the JavaScript code to.</param>
		/// <returns>
		/// </returns>
		public void Render(jStringBuilder sb) {
			if (this.Count() == 0 || !this.Where(x=>x.Condition).Any())
				// nothing to see here
				return;

			List<ScriptOption> activeOptions = this.Where(x => x.Condition).ToList();
			
			// main plug-in outer brace (open)
			sb.AppendLineIf("{");
			sb.IncIndent();

			RenderOptionList(sb, activeOptions);

			// main plug-in outer brace (close)
			sb.DecIndent();
			sb.AppendLineIf();
			sb.AppendTabsIf();
			sb.Append("}");
		}


		/// <summary>
		/// Goes through each option and rendered the JavaScript required for the property/event handler.
		/// JavaScript is then added to the provided string builder.
		/// </summary>
		/// <param name="sb">String builder to add the options to</param>
		/// <param name="activeOptions">List of options to add to the string builder.</param>
		protected void RenderOptionList(jStringBuilder sb, List<ScriptOption> activeOptions) {
			for (int optNdx=0; optNdx < activeOptions.Count(); optNdx++) {
				ScriptOption option = activeOptions[optNdx];

				if (optNdx > 0) {
					sb.Append(",");
					sb.AppendLineIf();
				}
				RenderOption(sb, option);
			} 
		}


		/// <summary>
		/// Renders an individual property/event handler to the given string builder.
		/// </summary>
		/// <param name="sb">String builder to add the JavaScript to.</param>
		/// <param name="activeOption">Option to the string builder.</param>
		protected void RenderOption(jStringBuilder sb, ScriptOption activeOption) {
			sb.AppendTabsIf();

			if (activeOption.HasChildren()) {
				// add the propertyName, and then call the list version to render ourselves out
				if (activeOption.IsChild) {
				  sb.AppendFormatLineIf("{0}: {{", activeOption.Key);
				  // indent the builder so it looks nice in PrettyRender mode
				  sb.IncIndent();
				}
				RenderOptionList(sb, activeOption.ChildOptions);
				if (activeOption.IsChild) {
					// Finished off an object, so trip off any trailing stuff
				  sb.DecIndent();
					sb.AppendLineIf();
				  sb.AppendTabsIf("}");
				}
			
			} else {

				if (activeOption.IsPropertyOption())
					RenderPropertyOption(sb, activeOption);
				else 
					// must be a function
					RenderFunctionOption(sb, activeOption);
			}
		}


		/// <summary>
		/// Takes the provided option and renders the JavaScript required to initialise 
		/// the option as a property key/value pair.
		/// </summary>
		/// <param name="sb">String builder to add the JavaScript to</param>
		/// <param name="option">Option being rendered</param>
		protected void RenderPropertyOption(jStringBuilder sb, ScriptOption option) {
			sb.AppendFormat("{0}: {1}", option.Key, option.Value);
		}


		/// <summary>
		/// Takes the provided option and renders the JavaScript required to initialise
		/// the calling of the function.
		/// </summary>
		/// <param name="sb">String builder to add the JavaScript to</param>
		/// <param name="option">Option being rendered</param>
		protected void RenderFunctionOption(jStringBuilder sb, ScriptOption option) {
			sb.AppendFormatLineIf("{0}: function({1}) {{", option.Key, option.FunctionPrototype);

			// indent provided source code if required
			string fmtSource = option.MethodSource ?? "";
			if (sb.RespectWs) {
				string indent = new string('\t', sb.IndentLevel + 1);
				fmtSource = indent + fmtSource.Replace("\n", "\n" + indent);
			}
			// and add into the rendered code
			sb.Append(fmtSource);

			sb.AppendLineIf();
			sb.AppendTabsIf("}");
		}

	} // ScriptOptions

} // ns