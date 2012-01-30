using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Utilities.jCookie
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Cookie.
	/// </summary>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Default expiry time (as defined by jQuery).
		/// </summary>
		public const int DEFAULT_EXPIRY = -1;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="cookie">Cookie object to define options for</param>
		public Options(Cookie cookie)
		 : base()
		{
			this.Cookie = cookie;
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Cookie"/> object these options are for
		/// </summary>
		public Cookie Cookie { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Cookie"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Cookie"/> object to return chaining to the Tabs collection</returns>
		public Cookie Finish() {
		  return this.Cookie;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(GetCookieScriptOption(false/*asChild*/));
		}


		/// <summary>
		/// Gets a script option defining the Cookie options (this is exposed as the Cookie control
		/// is used in other controls).
		/// </summary>
		/// <returns>Script option for the Cookie object</returns>
		protected internal Core.ScriptOption GetCookieScriptOption() {
			return GetCookieScriptOption(true/*asChild*/);
		}


		/// <summary>
		/// Gets a script option defining the Cookie options (this is exposed as the Cookie control
		/// is used in other controls).
		/// </summary>
		/// <param name="asChild">Flags that this option should be added a child</param>
		/// <returns>Script option for the Cookie object</returns>
		protected Core.ScriptOption GetCookieScriptOption(bool asChild) {
			Core.ScriptOption parentOpts = new Core.ScriptOption() { 
				Key = "cookie",
				IsChild = asChild
			};
			Core.ScriptOptions childOpts = parentOpts.ChildOptions;
			
			childOpts.Add(this.Expires != DEFAULT_EXPIRY, "expires", this.Expires.ToString());
			childOpts.Add(!this.IsNullOrEmpty(this.Path), "path", this.Path.InSingleQuotes());
			childOpts.Add(!this.IsNullOrEmpty(this.Domain), "domain", this.Domain.InSingleQuotes());
			childOpts.Add(this.Secure, "secure", this.Secure.JsBool());
			
			// Any of the above actually going to render?
			parentOpts.Condition = childOpts.Where(x=>x.Condition).Any();
			return parentOpts;
		}

		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Expires = -1;
			this.Path = "";
			this.Domain = "";
			this.Secure = false;
		}

	} // Options

} // ns Fluqi.jPosition
