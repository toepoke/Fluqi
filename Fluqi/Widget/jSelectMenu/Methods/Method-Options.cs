using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jSelectMenu {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Disables the control if set to true.
		/// </summary>
		public void GetDisabled() {
		  this.RenderGetOptionCall("disabled");
		}

		/// <summary>
		/// Disables the control if set to true.
		/// </summary>
		/// <param name="value">value</param>
		public void SetDisabled(bool value) {
		  this.RenderSetOptionCall("disabled", value);
		}

		/// <summary>
		/// Icons to use for opening the control, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		public void GetIcons() {
		  this.RenderGetOptionCall("icons");
		}

		/// <summary>
		/// Icons to use for opening the control, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="dropdownIcon"></param>
		public void SetIcons(string dropdownIcon) {
		  this.RenderSetOptionCall("icons", "{ button: " + dropdownIcon.InDoubleQuotes() + "}");
		}

		/// <summary>
		/// Icons to use for opening the control, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		/// <param name="dropdownIcon"></param>
		public void SetIcons(Core.Icons.eIconClass dropdownIcon) {
			this.SetIcons(Core.Icons.ByEnum(dropdownIcon));
		}

		/// <summary>
		/// Icons to use for opening the control, matching an icon defined by the jQuery UI CSS Framework.
		/// </summary>
		public void GetAppendTo() {
		  this.RenderGetOptionCall("appendTo");
		}
		
		/// <summary>
		/// Which element to append the menu to
		/// </summary>
		public void SetAppendTo(string appendTo) {
			this.RenderSetOptionCall("appendTo", appendTo.InDoubleQuotes());
		}

		/// <summary>
		/// Returns [in JavaScript] the current "position" setting.
		/// </summary>
		public void GetPosition() {
			this.RenderGetOptionCall("position");
		}

		/// <summary>
		/// Identifies the position of the menu in relation to the associated button element
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPositionJS(string position) {
			this.RenderSetOptionCall("position", position);
		}

		/// <summary>
		/// Identifies the position of the menu in relation to the associated button element
		/// </summary>
		/// <param name="position">New position setting</param>
		/// <param name="inDoubleQuotes">
		/// true  - double quotes (")
		/// false - single quotes (')
		/// </param>
		public void SetPosition(string position, bool inDoubleQuotes) {
			this.RenderSetOptionCall("position", position, inDoubleQuotes);
		}

		/// <summary>
		/// Identifies the position of the menu in relation to the associated button element
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPosition(string position) {
			this.SetPosition(position, true/*doubleQuotes*/);
		}

		/// <summary>
		/// Identifies the position of the menu in relation to the associated button element
		/// </summary>
		/// <param name="position">New position setting</param>
		public void SetPosition(Core.Position.ePosition position) {
			this.RenderSetOptionCall("position", Core.Position.PositionToString(position).InDoubleQuotes() );
		}
		
		/// <summary>
		/// Identifies the position of the menu in relation to the associated button element
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(string pos1, string pos2) {
			List<string> positions = new List<string>() { pos1, pos2 };
			this.RenderSetOptionCall("position", positions.JsArray(false/*singleQuotes*/));
		}

		/// <summary>
		/// Identifies the position of the menu in relation to the associated button element
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(Core.Position.ePosition pos1, Core.Position.ePosition pos2) {
			this.SetPosition( Core.Position.PositionToString(pos1), Core.Position.PositionToString(pos2) );
		}

		/// <summary>
		/// Identifies the position of the menu in relation to the associated button element
		/// </summary>
		/// <param name="pos1">First position setting</param>
		/// <param name="pos2">Second position setting</param>
		public void SetPosition(int pos1, int pos2) {
			List<int> positions = new List<int>() { pos1, pos2 };
			this.RenderSetOptionCall("position", positions.JsArray());
		}

		/// <summary>
		/// The width of the menu, in pixels.
		/// </summary>
		public void GetWidth() {
		  this.RenderGetOptionCall("width");
		}
		
		/// <summary>
		/// The width of the menu, in pixels.
		/// </summary>
		/// <param name="width">value</param>
		public void SetWidth(int? width) {
			if (!width.HasValue)
				// no quotes
				this.RenderSetOptionCall("width", "null");
			else 
				this.RenderSetOptionCall("width", width.ToString());
		}

	}

}
