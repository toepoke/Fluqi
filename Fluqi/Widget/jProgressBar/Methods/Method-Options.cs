using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jProgressBar {
	
	/// <summary>
	/// Methods for changing options (after initialisation).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Gets the current value of the progressbar.
		/// </summary>
		public void GetValue() {
			this.RenderMethodCall("value");
		}
		
		/// <summary>
		/// Sets the current value of the progressbar.
		/// </summary>
		public void SetValue(int newValue) {
			this.RenderMethodCall("value", newValue);
		}

	}

}
