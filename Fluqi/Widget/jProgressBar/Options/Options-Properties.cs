using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jProgressBar
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI ProgressBar.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables (true) or enables (false) the progressbar. Can be set when initialising (first creating) the progressbar.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/progressbar/#option-disabled for details</remarks>
		protected internal bool Disabled { get; set; }

		/// <summary>
		/// The value of the progressbar.
		/// </summary>
		/// <remarks>See http://jqueryui.com/demos/progressbar/#option-value for details</remarks>
		protected internal int Value { get; set; }

	} // Options

} // ns Fluqi.jProgressBar
