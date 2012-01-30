using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;
using System.Text;

namespace Fluqi.Core
{

	/// <summary>
	/// Represents an "option" for a control, e.g. the "animated" option for the accordion control.
	/// </summary>
	/// <remarks>
	/// Fluqi tries to minimise the amount of generated JavaScript; One of the ways it does
	/// this is by only rendering options which aren't the default for jQuery UI.  For instance
	/// the Dialog control opens automatically by default, so we don't render "autoOpen: true" for 
	/// the Dialog control as there is no need.
	/// The ScriptOption class helps with all the rendering of these options.
	/// </remarks>
	public class ScriptOption {

		/// <summary>
		/// Each option of a control is added to a list of options (<see cref="ScriptOptions"/>).
		/// The Condition flag gives us a convenient way of saying whether an option is the default
		/// option or not (default options aren't rendered as JavaScript).
		/// </summary>
		public bool Condition { get; set; }

		/// <summary>
		/// Key value for the control option.  This is the name of control option, e.g. "autoOpen" or "closeText"
		/// in the Dialog control for instance and is rendered when the JavaScript for the control is generated.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Value of the control option.  For instance in the Dialog control we a boolean "autoOpen" option, so
		/// for this the Value might be "true" or "false" and the full option rendered as "autoOpen: false".
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Used for setting the function prototype for an event that can be fired by the jQuery UI 
		/// controls.  For instance in the Dialog control the "open" event has the signature "event, ui".
		/// This is used for rendering an inline function (the source for which is set through the MethodSource
		/// property).
		/// </summary>
		public string FunctionPrototype { get; set; }

		/// <summary>
		/// Sets the source code for the FunctionPrototype.
		/// </summary>
		public string MethodSource { get; set; }

		/// <summary>
		/// Stores any child options for this option.  For instance the Dialog control has a Position option
		/// which has a set of properties of it's own.  The Position option therefore becomes a set of ChildOptions
		/// </summary>
		public ScriptOptions ChildOptions { get; set; } 

		/// <summary>
		/// Flags that _this_ object is defining a child option.
		/// </summary>
		public bool IsChild { get; set; }


		/// <summary>
		/// Constructor
		/// </summary>
		public ScriptOption() {
			this.ChildOptions = new ScriptOptions(this);
			this.IsChild = false;
		}


		/// <summary>
		/// Queries whether this option is Key/Value pair option or not.
		/// </summary>
		/// <returns>
		/// Returns true if it's a key/value option
		/// Returns false otherwise
		/// </returns>
		public bool IsPropertyOption() {
			return !string.IsNullOrEmpty(this.Key) && !string.IsNullOrEmpty(this.Value);
		}


		/// <summary>
		/// Queries whether the option is storing the source code for an event fired by a control.
		/// </summary>
		/// <returns>
		/// Returns true if it source code for an event.
		/// Returns false otherwise.
		/// </returns>
		public bool IsEventOption() {
			return !string.IsNullOrEmpty(this.FunctionPrototype);
		}


		/// <summary>
		/// Queries whether there are any further Child options to be consider for _this_ option.
		/// Note that not only should there be child options, but at least one of the Child options
		/// should have their Condition as true.  That is _this_ option has child options and at least
		/// one will be rendered.
		/// </summary>
		/// <returns>
		/// Returns true if _this_ option has child options.
		/// Returns false otherwise.
		/// </returns>
		public bool HasChildren() {
			if (!this.ChildOptions.Any()) 
				// nothing to see here
				return false;

			// only return options that _are_ going to be rendered out
			return this.ChildOptions.Where(x=>x.Condition).Any();
		}

	} // ScriptOption

} // ns