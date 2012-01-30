using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Core.Interfaces {
	
	interface IControlRenderer {
		
		/// <summary>
		/// Signals the control to be written to the reponse stream (as configured)
		/// </summary>
		void Render();

	} // IControlRenderer

} // Fluqi.Core.Interfaces

