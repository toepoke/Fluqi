using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension;

namespace Fluqi.Widget.jToolTip {
	
	/// <summary>
	/// The "Methods" are called after the control has been initialised.  If for instance you want to change
	/// the value of a property, or invoke "some" action on the control (e.g. "open" or "close") you 
	/// call the "Method" rather than through the "Options" (as Options is about the initialisation of the control).
	/// </summary>
	public partial class Methods: Core.Methods {

		/// <summary>
		/// Holds a reference to the <see cref="ToolTip"/> object these options are for
		/// </summary>
		public ToolTip ToolTip { get; set; }
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tooltip">ToolTip object to call</param>
		public Methods(ToolTip tooltip) : base(tooltip)
		{
			// need a reference back to the control that created us
			this.ToolTip = tooltip;
		}		


		/// <summary>
		/// Removes the ToolTip functionality completely. This will return the element back to its pre-init state.
		/// </summary>
		public void Destroy() {
		  this.RenderMethodCall("destroy");
		}

		/// <summary>
		/// Disables the tooltip.
		/// </summary>
		public void Disable() {
		  this.RenderMethodCall("disable");
		}	

		/// <summary>
		/// Enable the tooltip.
		/// </summary>
		public void Enable() {
		  this.RenderMethodCall("enable");
		}	

		/// <summary>
		/// Returns a jQuery object containing the generated wrapper.
		/// </summary>
		public void Widget() {
		  this.RenderMethodCall("widget");
		}	

		/// <summary>
		/// Programmatically open a tooltip. This is only intended to be called for non-delegated tooltips.
		/// </summary>
		public void Open() {
		  this.RenderMethodCall("open");
		}	

		/// <summary>
		/// Closes a tooltip. This is only intended to be called for non-delegated tooltips.
		/// </summary>
		public void Close() {
		  this.RenderMethodCall("close");
		}	


		/// <summary>
		/// Builds up the JavaScript required to call a given method.
		/// </summary>
		/// <param name="methodName">Name of the method to call (as define in the jQuery UI documentation for the control.</param>
		/// <param name="args">Set of arguments to pass to String.Format</param>
		/// <returns>JavaScript required to call the jQuery UI control method</returns>
		protected override internal string BuildMethodCall(string methodName, params object[] args) {
			if (!this.ToolTip.IsGlobal())
				// targetting a specific element, so use the base class version
				return base.BuildMethodCall(methodName, args);

			List<string> argList = (from a in args where a != null select a.ToString()).ToList<string>();
			string arguments = argList.ToSeparated(",");
			string selector = _ID;

			if (!string.IsNullOrEmpty(arguments))
				// additional arguments
				return string.Format("$({0}).{1}(\"{2}\",{3})", selector, this._PlugInName, methodName, arguments);
			else 
				// single argument
				return string.Format("$({0}).{1}(\"{2}\")", selector, this._PlugInName, methodName);
		}
		
	}

}
