using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Utilities.jCookie;

namespace Fluqi.Widget.jTab {

	/// <summary>
	/// Models the Cookie child for setting placement of the tab control.
	/// </summary>
	public class CookieOptions {

		/// <summary>
		/// Reference to the Tab object to return control to.
		/// </summary>
		protected internal jTab.Options _TabOptions { get; set; }

		/// <summary>
		/// Holds the Cookie options object for configuration.
		/// </summary>
		protected internal Utilities.jCookie.Options Options { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tabOptions">Tab options object</param>
		public CookieOptions(jTab.Options tabOptions)
		 : base()
		{
			this._TabOptions = tabOptions;
			this.Options = new Utilities.jCookie.Options(null);
		}

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Options"/> object so we can continue defining attributes.
		/// </summary>
		/// <returns>Returns <see cref="Options"/> object to return chaining to the parent object</returns>
		public jTab.Options Finish() {
		  return this._TabOptions;
		}


		/// <summary>
		/// Specifies when the cookie should expire
		/// </summary>
		/// <param name="days">Number of days in which the expiry page</param>
		/// <remarks>
		/// If no expiration is specified the cookie expires at the end of the browsing session.
		/// </remarks>
		public CookieOptions SetExpiry(int days) {
			this.Options.SetExpiry(days);
			return this;
		}


		/// <summary>
		/// Specifies the path the cookie is valid within.  So "/" means the whole site, "/demos" 
		/// means it's only applicable in the "demos" subfolder.
		/// </summary>
		/// <param name="path">Path of the cookie</param>
		public CookieOptions SetPath(string path) {
			this.Options.SetPath(path);
			return this;
		}


		/// <summary>
		/// Specifies the domain the cookie should be saved to.  So you could have a subdomain
		/// so the cookie is only saved there.
		/// </summary>
		/// <param name="domain">Domain of the cookie</param>
		public CookieOptions SetDomain(string domain) {
			this.Options.SetDomain(domain);
			return this;
		}


		/// <summary>
		/// If true, the secure attribute of the cookie will be set and the cookie transmission will
		/// require a secure protocol (like HTTPS).
		/// </summary>
		/// <param name="secure">
		/// true for a secure cookie
		/// false for non-secure cookie
		/// </param>
		/// <remarks>
		/// Naturally true only works if you're running under SSL.
		/// </remarks>
		public CookieOptions SetSecure(bool secure) {
			this.Options.SetSecure(secure);
			return this;
		}

	}
}
