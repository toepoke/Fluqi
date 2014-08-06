using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jProgressBar {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="pb">ProgressBar object to call</param>
		public Methods(ProgressBar pb) : base(pb)
		{
		}		

		/// <summary>
		/// Remove the ProgressBar functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	

		/// <summary>
		/// Disable the progressbar.
		/// </summary>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	

		/// <summary>
		/// Enable the progressbar.
		/// </summary>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	

		/// <summary>
		/// Returns the .ui-progressbar element.
		/// </summary>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	

	}

}
