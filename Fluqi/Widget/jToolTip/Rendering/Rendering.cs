﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Widget.jToolTip
{

	/// <summary>
	/// Responsible for setting how the control should be rendered to the page.  For instance
	/// should the control CSS be rendered, should pretty layout be used, etc.
	/// </summary>
	public class Rendering: Core.RenderBase {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tooltip">ToolTip object to set rendering options of</param>
		public Rendering(ToolTip tooltip)
		 : base()
		{
			this.ToolTip = tooltip;
		}

		/// <summary>
		/// Used to flag that configuration has finished, and 
		/// returns the <see cref="ToolTip"/> object so we can continue defining ToolTip attributes.
		/// </summary>
		/// <returns>Returns <see cref="ToolTip"/> object to return chaining to the ToolTip collection</returns>
		public ToolTip Finish() {
			return this.ToolTip;
		}

		/// <summary>
		/// Holds a reference to the <see cref="ToolTip"/> object these options are for
		/// </summary>
		public ToolTip ToolTip { get; set; }

		/// <summary>
		/// Forces pretty rendering off so you can see the output whilst in DEBUG mode if you wish
		/// </summary>
		new public Rendering Compress() {
			base.Compress();
			return this;
		}


		/// <summary>
		/// Specifies if the HTML/JavaScript which is rendered should be indented in a more readable 
		/// manner (as opposed to when <see cref="Compress()"/> is active (i.e. PrettyRender=false)
		/// which keeps everything in one line to keep the script size down)
		/// </summary>
		/// <param name="prettyRender">Flags pretty rendering on or off</param>
		new public Rendering SetPrettyRender(bool prettyRender) {
			base.SetPrettyRender(prettyRender);
			return this;
		}


		/// <summary>
		/// Writes slim CSS to the browser (jQuery UI classes aren't expanded for non-JS users)
		/// </summary>
		/// <returns>ToolTip object for chainability</returns>
		new public Rendering ShowCSS() {
			base.ShowCSS();
			return this;
		}


		/// <summary>
		/// Specifies that the CSS class the jQuery UI library should be written as part of widget
		/// rendering.  This is useful if you still want your pages to look "jQuery UI-ified" when
		/// your user has JavaScript disabled.
		/// </summary>
		/// <param name="renderCSS">Flags writing CSS class names on or off</param>
		new public Rendering SetRenderCSS(bool renderCSS) {
			base.SetRenderCSS(renderCSS);
			return this;
		}


		/// <summary>
		/// Specifies that when writing in pretty HTML mode (see <see cref="Compress"/>) 
		/// the Html helper should start writing at a particular tab depth (so everything lines
		/// up nicely when you view the source).
		/// </summary>
		/// <param name="indentation">How far the Html helper should indent the rendered HTML</param>
		/// <returns>ToolTip object for chainability</returns>
		new public Rendering SetTabDepth(int indentation) {
			base.SetTabDepth(indentation);
			return this;
		}


		/// <summary>
		/// Specifies whether the control should be self-initialising (with it's own $(document).ready
		/// section, or if this should be left to the view to declare on purpose.
		/// </summary>
		/// <param name="autoScript">
		/// If true the control initialises itself
		/// If false the initialisation is left to the [calling] view
		/// </param>
		/// <returns>ToolTip object for chainability</returns>
		new public Rendering SetAutoScript(bool autoScript) {
			base.SetAutoScript(autoScript);
			return this;
		}

	}

}
