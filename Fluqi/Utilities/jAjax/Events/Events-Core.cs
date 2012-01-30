using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Microsoft.VisualBasic;

namespace Fluqi.jAjax
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Ajax.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Holds a reference to the <see cref="Ajax"/> object these events are for
		/// </summary>
		public Ajax Ajax { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Events"/> has finished, and 
		/// returns the <see cref="Ajax"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Ajax"/> object to return chaining to the Tabs collection</returns>
		public Ajax Finish() {
			return this.Ajax;
		}


		/// <summary>
		/// Builds up a set of events the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {

		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.BeforeSend = "";
			this.Complete = "";
		}

	} // Events

} // ns Fluqi.jAjax
