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

namespace Fluqi.Widget.jSelectMenu
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI SelectMenu.
	/// </summary>
	public partial class Events: Core.Options
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="selectMenu">SelectMenu object to configure events for</param>
		public Events(SelectMenu selectMenu)
		 : base()
		{
			this.SelectMenu = selectMenu;
			this.Reset();
		}

		/// <summary>
		/// Triggered when the control changes.
		/// </summary>
		protected internal string ChangeEvent { get; set; }

		/// <summary>
		/// Triggered when the control is closed.
		/// </summary>
		protected internal string CloseEvent { get; set; }

		/// <summary>
		/// Triggered when the control is created.
		/// </summary>
		protected internal string CreateEvent { get; set; }

		/// <summary>
		/// Triggered when the control gains focus or when any menu item is activated.
		/// </summary>
		protected internal string FocusEvent { get; set; }

		/// <summary>
		/// Triggered when an item is selected.
		/// </summary>
		protected internal string SelectEvent { get; set; }

		/// <summary>
		/// Triggered when the control item is opened.
		/// </summary>
		protected internal string OpenEvent { get; set; }
		
	} // Events

} // ns Fluqi.jSelectMenu
