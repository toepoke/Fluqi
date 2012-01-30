using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Fluqi.Core.Types;

namespace Fluqi.jAjax
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Ajax.
	/// </summary>
	public partial class Options: Core.Options
	{
		public const string DEFAULT_CONTENT_TYPE = "application/x-www-form-urlencoded";
		public const string DEFAULT_CONTEXT_TYPE = "";
		public readonly Map DEFAULT_CONVERTERS = { 
			{ "\"* text\"", "window.String" }, 
			{ "\"text html\"", "true" }, 
			{ "\"text json\"", "jQuery.parseJSON" }, 
			{ "\text xml\"", "jQuery.parseXML" }
		};


		public Options(Ajax ajax)
		 : base()
		{
			this.Ajax = ajax;
			this.Reset();
		}


		/// <summary>
		/// Holds a reference to the <see cref="Ajax"/> object these options are for
		/// </summary>
		public Ajax Ajax { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Tabs"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Tabs"/> object to return chaining to the Tabs collection</returns>
		public Ajax Finish() {
			return this.Ajax;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(GetAjaxScriptOption(false/*asChild*/));
		}


		/// <summary>
		/// Gets a script option defining the Ajax options (this is exposed as the Ajax control
		/// is used in other controls).
		/// </summary>
		/// <returns>Script option for the Ajax object</returns>
		protected internal Core.ScriptOption GetAjaxScriptOption() {
			return GetAjaxScriptOption(true/*asChild*/);
		}


		/// <summary>
		/// Gets a script option defining the Ajax options (this is exposed as the Ajax control
		/// is used in other controls).
		/// </summary>
		/// <param name="asChild">Flags that this option should be added a child</param>
		/// <returns>Script option for the Ajax object</returns>
		protected Core.ScriptOption GetAjaxScriptOption(bool asChild) {
			Core.ScriptOption parentOpts = new Core.ScriptOption() { 
				Key = "ajax",
				IsChild = asChild
			};
			Core.ScriptOptions childOpts = parentOpts.ChildOptions;

			
			// Any of the above actually going to render?
			parentOpts.Condition = childOpts.Where(x=>x.Condition).Any();
			return parentOpts;
		}

		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Accepts = new Map();
			this.Async = true;
			this.Contents = new Map();
			this.ContentType = DEFAULT_CONTENT_TYPE;
			this.Context = DEFAULT_CONTEXT_TYPE;
			this.Converters = DEFAULT_CONVERTERS;
			this.DataFilter = "";
			this.DataType = "";
			
			// Note I think this is sometimes set by jQuery on a per-request basis:
			// - Default: true
			// - false for dataType 'script' and 'jsonp'
			this.Cached = true;

			// Note I think this is set by jQuery on a per-request basis:
			// - false for same-domain requests
			// - true for cross-domain requests
			this.CrossDomain = true;
		}

	} // Options

} // ns Fluqi.jPosition
