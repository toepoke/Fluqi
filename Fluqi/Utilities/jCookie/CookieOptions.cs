using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Utilities.jCookie {
	
	/// <summary>
	/// Models the rendering of the options a Cookie can use.
	/// </summary>
	public class CookieOptions {
		
		/// <summary>
		/// Holds the set of options set for the Cookie plugin.
		/// </summary>
		protected internal Utilities.jCookie.Options Options { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="cookie">Cookie object the options are being defined for</param>
		public CookieOptions(Cookie cookie)
		 : base()
		{
			this.Cookie = cookie;
		}


		/// <summary>
		/// Holds a reference to the <see cref="Cookie"/> object these options are for
		/// </summary>
		protected internal Cookie Cookie { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Cookie"/> object so we can continue defining attributes.
		/// </summary>
		/// <returns>Returns <see cref="Cookie"/> object to return chaining to the parent object</returns>
		public jCookie.Cookie Finish() {
		  return this.Cookie;
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
