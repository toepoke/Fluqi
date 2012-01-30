using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Core {

	/// <summary>
	/// Base class for implementing common Rendering options for controls.
	/// (Rendering options fluently hang off a control, i.e. as well as "Button.Options" we also
	/// have "Button.Rendering" for setting rendering options).  
	/// </summary>
	public class RenderBase {

		/// <summary>
		/// Constructor
		/// </summary>
		public RenderBase() {
			this.RenderCSS = false;
#if DEBUG
			// In DEBUG mode we use pretty rendering to make the rendered JavaScript code easier to read
			this.PrettyRender = true;
#else
			// In RELEASE mode we use compressed mode which is harded to read, but has a reduced footprint 
			// (less to download at the browser side).
			this.PrettyRender = false;
#endif
			this.TabDepth = 0;
			this.AutoScript = true;
		}

		/// <summary>
		/// Flags whether the output when rendering should omit any whitespace and newlines we can
		/// </summary>
		/// <remarks>
		/// By default this is set depending on the build type.  In DEBUG you get indenting and newlines
		/// to make it easier to read.  In RELEASE we remove whitespace.  
		/// </remarks>
		protected internal bool PrettyRender { get; set; }

		/// <summary>
		/// Flags whether the CSS classes jQuery UI adds via JavaScript are rendered at run-time.  This
		/// is useful if you want to same "look" as jQuery UI to non-JavaScript users.  Naturally non-JS
		/// users will get the "look" but not the "feel".
		/// </summary>
		/// <remarks>
		/// By default RenderCSS is false, so the CSS is _not_ shown.  Also note that the jQuery UI
		/// documentation recommends that you _do_not_ include the CSS (hence by default we don't).
		/// </remarks>
		protected internal bool RenderCSS { get; set; }

		/// <summary>
		/// If the output is in pretty rendering mode (see <see cref="PrettyRender"/>), this stipulates 
		/// where the tabbing should start (so all your output HTML lines up :)
		/// </summary>
		protected internal int TabDepth { get; set; }

		/// <summary>
		/// Flags whether the HtmlHelper should render it's document $(document).ready section (and init script)
		/// once the control has been rendered or not (i.e. leave it to the developer to call the RenderScript).
		/// </summary>
		/// <remarks>
		/// If true a $(document).ready section is rendered, with the init of the helper
		/// If false nothing is rendered and the view must call the "RenderScript" to init the HtmlHelper
		/// </remarks>
		protected internal bool AutoScript { get; set; }

		/// <summary>
		/// Forces pretty rendering off so you can see the output whilst in DEBUG mode if you wish
		/// </summary>
		public void Compress() {
			this.PrettyRender = false;
		}


		/// <summary>
		/// Writes full CSS to the browser (jQuery UI classes are expanded for non-JS users)
		/// </summary>
		/// <returns>Control for chainability</returns>
		public void ShowCSS() {
			this.RenderCSS = true;
		}


		/// <summary>
		/// Specifies that when writing in pretty HTML mode (see <see cref="Compress"/>) 
		/// the Html helper should start writing at a particular tab depth (so everything lines
		/// up nicely when you view the source).
		/// </summary>
		/// <param name="indentation">How far the Html helper should indent the rendered HTML</param>
		/// <returns>Control for chainability</returns>
		public void SetTabDepth(int indentation) {
			this.TabDepth = indentation;
		}


		/// <summary>
		/// Specifies whether the control should be self-initialising (with it's own $(document).ready
		/// section, or if this should be left to the view to declare on purpose.
		/// </summary>
		/// <param name="autoScript">
		/// If true the control initialises itself
		/// If false the initialisation is left to the [calling] view
		/// </param>
		/// <returns>Control for chainability</returns>
		public void SetAutoScript(bool autoScript) {
			this.AutoScript = autoScript;
		}

	}
}
