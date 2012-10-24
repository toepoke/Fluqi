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

namespace Fluqi.Utilities.jAnimation
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Animation.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Corresponds to <see cref="Core.Animation.eAnimation"/>
		/// </summary>
		protected internal string Effect { get; set; }

		/// <summary>
		/// Corresponds to <see cref="Core.Ease.eEase"/>
		/// </summary>
		protected internal string Easing { get; set; }

		/// <summary>
		/// String (as it can be "slow"/"fast", etc - think you can stil do this)
		/// </summary>
		protected internal string Duration { get; set; }

	} // Options

} // ns Fluqi.jCookie


