using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Core.Interfaces {

	interface IScriptRenderer {

		/// <summary>
		/// Responsible for constructing the JavaScript initalisation script for the control, including the 
		/// document.ready code and the control itself (including any options enabled).  The generated JavaScript 
		/// is then added to the response stream.
		/// </summary>
		void RenderStartUpScript();

	}

}
