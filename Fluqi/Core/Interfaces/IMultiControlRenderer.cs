using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Core.Interfaces {

	interface IMultiControlRenderer {
		
		/// <summary>
		/// Responsible for writing the underlying DIV for the container of the control (and it's panels).  
		/// </summary>
		/// <returns>
		/// Returns the HTML required to render the underlying HTML element used by the control.
		/// </returns>
		string GetTagContainerHtml();

		/// <summary>
		/// Writes <see cref="GetTagContainerHtml"/> to the Response stream
		/// </summary>
		void RenderContainer();

		/// <summary>
		/// Responsible for generating the HTML for any panel (e.g. accordion control)
		/// </summary>
		/// <returns>HTML for the panel</returns>
		string GetTagPaneHtml();

		/// <summary>
		/// Renders the tab content pane to the Response.
		/// </summary>
		void RenderPane();

	} // IControlRenderer

} // Fluqi.Core.Interfaces

