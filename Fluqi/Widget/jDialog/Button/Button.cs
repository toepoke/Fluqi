using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jDialog {

	/// <summary>
	/// Stores how the button will appear on the dialog.
	/// </summary>	
	public class Button {
		
		/// <summary>
		/// What prompt the user will see on the button.
		/// </summary>
		public string Label { get; set; }

		/// <summary>
		/// What JavaScript will be executed when the user clicks the button
		/// </summary>
		public string ClickEvent { get; set; }
	}

}
