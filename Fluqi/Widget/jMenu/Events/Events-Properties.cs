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

namespace Fluqi.Widget.jMenu
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Slider.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="menu">Menu object to configure events for</param>
		public Events(Menu menu)
		 : base()
		{
			this.Menu = menu;
			this.Reset();
		}

		/// <summary>
		/// Triggered when the menu loses focus.
		/// </summary>
		protected internal string BlurEvent { get; set; }

		/// <summary>
		/// Triggered when the menu is created.
		/// </summary>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// Triggered when a menu gains focus or when any menu item is activated.
		/// </summary>
		protected internal string FocusEvent { get; set; }

		/// <summary>
		/// Triggered when a menu item is selected.
		/// </summary>
		protected internal string SelectEvent { get; set; }
		
	} // Events

} // ns Fluqi.jAutoComplete
