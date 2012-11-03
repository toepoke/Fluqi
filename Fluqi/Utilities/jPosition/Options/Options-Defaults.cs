using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Fluqi.Core;

namespace Fluqi.Utilities.jPosition
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Position.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Holds the default "My" position setting for the position object.
		/// </summary>
		/// <remarks>Note the defaults vary by the consuming widget, hence we have to store it</remarks>
		protected internal string MyDefault { get; set; }

		/// <summary>
		/// Holds the default "At" position setting for the position object.
		/// </summary>
		/// <remarks>Note the defaults vary by the consuming widget, hence we have to store it</remarks>
		protected internal string AtDefault { get; set; }

		/// <summary>
		/// Holds the default "Of" position setting for the position object.
		/// </summary>
		/// <remarks>Note the defaults vary by the consuming widget, hence we have to store it</remarks>
		protected internal string OfDefault { get; set; }

		/// <summary>
		/// Holds the default "Collision" position setting for the position object.
		/// </summary>
		/// <remarks>Note the defaults vary by the consuming widget, hence we have to store it</remarks>
		protected	internal string CollisionDefault { get; set; }

		/// <summary>
		/// Holds the default "Using" position setting for the position object.
		/// </summary>
		/// <remarks>Note the defaults vary by the consuming widget, hence we have to store it</remarks>
		protected internal string UsingFunctionDefault { get; set; }

		/// <summary>
		/// Holds the default "Within" position setting for the position object.
		/// </summary>
		/// <remarks>Note the defaults vary by the consuming widget, hence we have to store it</remarks>
		protected internal string WithinDefault { get; set; }

	} // Options

} // ns Fluqi.jPosition
