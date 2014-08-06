using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jSlider {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="sldr">Slider object to call</param>
		public Methods(Slider sldr) : base(sldr)
		{
		}		


		/// <summary>
		/// Remove the slider functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		public void Destroy() {
			this.RenderMethodCall("destroy");
		}	

		/// <summary>
		/// Disable the slider.
		/// </summary>
		public void Disable() {
			this.RenderMethodCall("disable");
		}	

		/// <summary>
		/// Enable the slider.
		/// </summary>
		public void Enable() {
			this.RenderMethodCall("enable");
		}	

		/// <summary>
		/// Returns the .ui-slider element.
		/// </summary>
		public void Widget() {
			this.RenderMethodCall("widget");
		}	

	}

}
