﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using static Fluqi.Core.IconPosition;

namespace Fluqi.Widget.jPushButton
{

	/// <summary>
	/// A set of events to apply to a set of jQuery UI Button.
	/// </summary>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Disables (true) or enables (false) the button. Can be set when initialising (first creating) 
		/// the button.
		/// </summary>
		/// <param name="disable">Whether the control is disabled or not</param>
		/// <returns>Options object for chainability</returns>
		public Options SetDisabled(bool disable) {
			this.Disabled = disable;
			return this;
		}


		/// <summary>
		/// Whether to show any text - when set to false (display no text), icons (see icons option) 
		/// must be enabled, otherwise it'll be ignored.
		/// </summary>
		/// <param name="text">New flag setting</param>
		/// <returns>Options object for chainability</returns>
		public Options SetText(bool text) {
			this.Text = text;
			return this;
		}


		/// <summary>
		/// Icons to display, with or without text (see text option). The primary icon is 
		/// displayed by default on the left of the label text, the secondary by default is on the right. 
		/// Value for the primary and secondary properties must be a classname (String), eg. "ui-icon-gear". 
		/// For using only one icon: icons: {primary:'ui-icon-locked'}. 
		/// For using two icons: icons: {primary:'ui-icon-gear',secondary:'ui-icon-triangle-1-s'}
		/// </summary>
		/// <param name="icon">New setting</param>
		/// <param name="iconPosition">New setting</param>
		/// <returns>Options object for chainability</returns>
		public Options SetIcon(string icon, string iconPosition) {
			this.Icon = icon ?? "";
			this.IconPosition = iconPosition ?? "";
			return this;
		}


		/// <summary>
		/// Icons to display, with or without text (see text option). The primary icon is 
		/// displayed by default on the left of the label text, the secondary by default is on the right. 
		/// Value for the primary and secondary properties must be a classname (String), eg. "ui-icon-gear". 
		/// For using only one icon: icons: {primary:'ui-icon-locked'}. 
		/// </summary>
		/// <param name="icon">New setting</param>
		/// <returns>Options object for chainability</returns>
		public Options SetIcon(string icon) {
			this.Icon = icon ?? "";
			return this;
		}


		/// <summary>
		/// Icons to display, with or without text (see text option). The primary icon is 
		/// displayed by default on the left of the label text, the secondary by default is on the right. 
		/// Value for the primary and secondary properties must be a classname (String), eg. "ui-icon-gear". 
		/// For using only one icon: icons: {primary:'ui-icon-locked'}. 
		/// </summary>
		/// <param name="iconClass">New setting</param>
		/// <returns>Options object for chainability</returns>
		public Options SetIcon(Core.Icons.eIconClass iconClass) {
			this.Icon = Core.Icons.ByEnum(iconClass);
			return this;
		}

	
		/// <summary>
		/// Icons to display, with or without text (see text option). The primary icon is 
		/// displayed by default on the left of the label text, the secondary by default is on the right. 
		/// Value for the primary and secondary properties must be a classname (String), eg. "ui-icon-gear". 
		/// For using only one icon: icons: {primary:'ui-icon-locked'}. 
		/// For using two icons: icons: {primary:'ui-icon-gear',secondary:'ui-icon-triangle-1-s'}
		/// </summary>
		/// <param name="icon">New setting</param>
		/// <param name="iconPosition">New setting</param>
		/// <returns>Options object for chainability</returns>
		public Options SetIcon(Core.Icons.eIconClass icon, Core.IconPosition.eIconPosition iconPosition) {
			this.Icon = Core.Icons.ByEnum(icon);
			this.IconPosition = Core.IconPosition.IconPositionToString(iconPosition);
			return this;
		}
		
	} // Options

} // ns Fluqi.jButton
