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
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Sets the tooltip function to use
		/// </summary>
		public Options SetContentByFunction(string content) {
			this.Content = content;
			return this;
		}

		/// <summary>
		/// Sets the tooltip to use
		/// </summary>
		public Options SetContentByString(string content) {
			this.Content = content.InDoubleQuotes();
			return this;
		}


		/// <summary>
		/// Disables the tooltip.
		/// </summary>
		public Options SetDisabled(bool disabled) {
		  this.Disabled = disabled;
		  return this;
		}

		/// <summary>
		/// A selector indicating which items should show tooltips. 
		/// Customize if you're using something other then the title attribute for the tooltip content, 
		/// or if you need a different selector for event delegation.
		/// When changing this option, you likely need to also change the content option.
		/// </summary>
		public Options SetItems(params string[] selectors) {
			if (selectors != null && selectors.Any()) {
				this.Items = string.Join(", ", selectors );
				this.Items = this.Items.InDoubleQuotes();
			}
			return this;
		}

		/// <summary>
		/// A selector indicating which items should show tooltips. 
		/// Use this option if you're referencing a jQuery object selector
		/// Customize if you're using something other then the title attribute for the tooltip content, 
		/// or if you need a different selector for event delegation.
		/// When changing this option, you likely need to also change the content option.
		/// </summary>
		public Options SetItemsObject(string objSelector) {
			this.Items = objSelector;
			return this;
		}

		/// <summary>
		/// A class to add to the widget, can be used to display various tooltip types, like warnings or errors.
		/// This may get replaced by the classes option.
		/// </summary>
		public Options SetToolTipClass(string cssClass) {
			this.ToolTipClass = cssClass;
			return this;
		}

		/// <summary>
		/// Whether the tooltip should track (follow) the mouse.
		/// </summary>
		public Options SetTrack(bool track) {
			this.Track = track;
			return this;
		}
				
	} // Options

} // ns
