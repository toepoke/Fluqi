using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jTab
{

	public partial class Options: Core.Options
	{
		/// <summary>
		/// Sets the "disabled" flag
		/// </summary>
		/// <param name="disabled">
		/// True: sets disabled on
		/// False: sets disabled off
		/// </param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>Why you'd want to use this I have no idea!</remarks>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-disabled for details</remarks>
		public Options SetDisabled(bool disabled) {
			this.Disabled = disabled;
			return this;
		}


		/// <summary>
		/// An array containing the position of the tabs (zero-based index) that 
		/// should be disabled on initialization.
		/// </summary>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-disabled for details</remarks>
		public Options SetDisabled(List<int> disabled) {
			this.DisabledArray = disabled;
			return this;
		}


		/// <summary>
		/// An array containing the position of the tabs (zero-based index) that 
		/// should be disabled on initialization.
		/// </summary>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-disabled for details</remarks>
		public Options SetDisabled(params int[] disabledTabs) {
			this.DisabledArray = (from i in disabledTabs select i).ToList<int>();
			return this;
		}


		/// <summary>
		/// Sets whether the active tab is collapsible or not.
		/// </summary>
		/// <param name="collapsible">Flags whether collapsible is on or off</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-collapsible for details</remarks>
		public Options SetCollapsible(bool collapsible) {
			this.Collapsible = collapsible;
			return this;
		}


		/// <summary>
		/// Sets the event that opens a tab, e.g. "mouseover"
		/// </summary>
		/// <param name="evt">Event to use to open a tab</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-event for details</remarks>
		public Options SetEvent(string evt) {
			this.Evt = evt ?? "";

			// we'll be adding our own quotes when we render
			this.Evt = this.Evt.Trim(new char[] { '\"', '\'' });

			return this;
		}


		/// <summary>
		/// Sets the event that opens a tab, e.g. "mouseover"
		/// </summary>
		/// <param name="browserEvent">Event to use to open a tab</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-event for details</remarks>
		public Options SetEvent(Core.BrowserEvent.eBrowserEvent browserEvent) {
			return this.SetEvent( Core.BrowserEvent.BrowserEventToString(browserEvent) );
		}


		/// <summary>
		/// Controls the height of the accordion and each panel.  Possible values are "auto", "fill" and "content".
		/// </summary>
		/// <param name="style">Style to use</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-heightStyle for details</remarks>
		public Options SetHeightStyle(Core.HeightStyle.eHeightStyle style) {
			return this.SetHeightStyle( Core.HeightStyle.HeightStyleToString(style) );
		}


		/// <summary>
		/// Controls the height of the accordion and each panel.  Possible values are "auto", "fill" and "content".
		/// </summary>
		/// <param name="style">Style to use</param>
		/// <returns>Options object for chainability</returns>
		/// <remarks>See http://api.jqueryui.com/tabs/#option-heightStyle for details</remarks>
		public Options SetHeightStyle(string style) {
			this.HeightStyle = style ?? "";

			// we'll be adding our own quotes when we render
			this.HeightStyle = this.HeightStyle.Trim(new char[] { '\"', '\'' });

			return this;
		}

	} // Options

} // ns Fluqi.jTab
