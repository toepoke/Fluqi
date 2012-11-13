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

namespace Fluqi.Widget.jToolTip
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI ToolTip.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tip">ToolTip object to configure events for</param>
		public Events(ToolTip tip)
		 : base()
		{
			this.ToolTip = tip;
			this.Reset();
		}

		/// <summary>
		/// Triggered when a tooltip is closed, triggered on focusout or mouseleave.
		/// </summary>
		protected internal string CloseEvent { get; set; }

		/// <summary>
		/// Triggered when the ToolTip is created.
		/// </summary>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// Triggered when a tooltip is shown, triggered on focusin or mouseover.
		/// </summary>
		protected internal string OpenEvent { get; set; }

	} // Events

} // ns Fluqi.jAutoComplete
