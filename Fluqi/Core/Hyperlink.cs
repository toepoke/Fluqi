using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Core {

	/// <summary>
	/// Properies for a hyperlink.
	/// </summary>
	public class Hyperlink: Core.ControlBase {

		/// <summary>
		/// Specifies the Title that should appear in the hyperlink (i.e. the content of the a link).
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Destination link of the hyperlink
		/// </summary>
		public string URL { get; set; }

	}

}
