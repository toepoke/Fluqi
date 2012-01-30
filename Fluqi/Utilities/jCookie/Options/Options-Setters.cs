using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Fluqi.Core;

namespace Fluqi.Utilities.jCookie
{

	/// <summary>
	/// A set of properties to apply to for the Cookie plug-in (required for some of the other controls, e.g. tabs).
	/// </summary>
	public partial class Options: Core.Options
	{

		/// <summary>
		/// Specifies when the cookie should expire
		/// </summary>
		/// <param name="days">Number of days in which the expiry page</param>
		/// <remarks>
		/// If no expiration is specified the cookie expires at the end of the browsing session.
		/// </remarks>
		public Options SetExpiry(int days) {
			this.Expires = days;
			return this;
		}


		/// <summary>
		/// Specifies the path the cookie is valid within.  So "/" means the whole site, "/demos" 
		/// means it's only applicable in the "demos" subfolder.
		/// </summary>
		/// <param name="path">Path of the cookie</param>
		public Options SetPath(string path) {
			this.Path = path;
			return this;
		}


		/// <summary>
		/// Specifies the domain the cookie should be saved to.  So you could have a subdomain
		/// so the cookie is only saved there.
		/// </summary>
		/// <param name="domain">Domain of the cookie</param>
		public Options SetDomain(string domain) {
			this.Domain = domain;
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
		public Options SetSecure(bool secure) {
			this.Secure = secure;
			return this;
		}

	} // Options

} // ns Fluqi.jCookie
