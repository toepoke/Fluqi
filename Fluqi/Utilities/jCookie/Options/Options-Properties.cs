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
	/// A set of properties to apply to a set of jQuery UI Cookie.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Specifies when the cookie should expire
		/// </summary>
		/// <remarks>
		/// If no expiration is specified the cookie expires at the end of the browsing session.
		/// </remarks>
		protected internal int Expires { get; set; }

		/// <summary>
		/// Specifies the path the cookie is valid within.  So "/" means the whole site, "/demos" 
		/// means it's only applicable in the "demos" subfolder.
		/// </summary>
		protected internal string Path { get; set; }

		/// <summary>
		/// Specifies the domain the cookie should be saved to.  So you could have a subdomain
		/// so the cookie is only saved there.
		/// </summary>
		protected internal string Domain { get; set; }

		/// <summary>
		/// If true, the secure attribute of the cookie will be set and the cookie transmission will
		/// require a secure protocol (like HTTPS).
		/// </summary>
		protected internal bool Secure { get; set; }

	} // Options

} // ns Fluqi.jCookie


