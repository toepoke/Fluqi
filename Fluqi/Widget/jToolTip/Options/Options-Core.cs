using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;
using Microsoft.VisualBasic;

namespace Fluqi.Widget.jToolTip
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI ToolTip.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{
#pragma warning disable 1591
		public const string DEFAULT_TARGET = "document";
		public const bool DEFAULT_TRACK = false;
		public const string DEFAULT_ITEMS = "[title]";
#pragma warning restore 1591

		public Options(ToolTip tooltip)
		 : base()
		{
			this.ToolTip = tooltip;
			this.Reset();
			this.Position = new PositionOptions(this);
			this.ShowAnimation = new AnimationOptions(this, "show");
			this.HideAnimation = new AnimationOptions(this, "hide");
		}

		/// <summary>
		/// Holds a reference to the <see cref="ToolTip"/> object these options are for
		/// </summary>
		public ToolTip ToolTip { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="ToolTip"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="ToolTip"/> object to return chaining to the Tabs collection</returns>
		public ToolTip Finish() {
			return this.ToolTip;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(!this.IsNullOrEmpty(this.Content) && !this.IsEmptyQuotes(this.Content), "content", this.Content);
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			options.Add(!this.IsNullEmptyOrDefault(this.Items, DEFAULT_ITEMS), "items", this.Items);
			options.Add(!this.IsNullOrEmpty(this.ToolTipClass), "tooltipClass", this.ToolTipClass.InDoubleQuotes());
			options.Add(this.Track, "track", this.Track.JsBool());			
			// Position and Animation is a little bit different because it's an object, so just add it's options in
			options.Add(this.Position.Options.GetPositionScriptOption());
			options.Add(this.ShowAnimation.Options.GetAnimationScriptOption());
			options.Add(this.HideAnimation.Options.GetAnimationScriptOption());
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Content = "";
			this.Disabled = false;
			this.Items = "";
			this.ToolTipClass = null;
			this.Track = DEFAULT_TRACK;
			this.Items = DEFAULT_ITEMS;
		}

	} // Options

} // ns
