using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jTab
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Tabs.
	/// </summary>
	public partial class Options: Core.Options
	{
#pragma warning disable 1591
		public const string DEFAULT_EVENT = "click";
		public const string DEFAULT_HEIGHT_STYLE = "auto";
		public const string DEFAULT_PANEL_TEMPLATE = "<div></div>";
		public const string DEFAULT_TAB_TEMPLATE = "<li><a href=\"#{href}\"><span>#{label}</span></a></li>";
#pragma warning restore 1591

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="tabs">Tabs to configure options of</param>
		public Options(Tabs tabs)
		 : base()
		{
			this.Tabs = tabs;
			this.Cookie = new CookieOptions(this);
			this.ShowAnimation = new AnimationOptions(this, "show");
			this.HideAnimation = new AnimationOptions(this, "hide");
			this.Evt = DEFAULT_EVENT;
			this.Collapsible = false;			
			this.DisabledArray = new List<int>();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Tabs"/> object these options are for
		/// </summary>
		public Tabs Tabs { get; set; }


		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Tabs"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Tabs"/> object to return chaining to the Tabs collection</returns>
		public Tabs Finish() {
			return this.Tabs;
		}
		

		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			if (this.Disabled) {
				// BUG: There seems to be a bug in jQuery UI meaning disabling all the tabs
				// doesn't work, so disable each tab manually. The overall "disabled" flag
				// is kept as false so we use the List<int> entry point instead.
				this.DisabledArray.Clear();
				for (int i=0; i < this.Tabs._Panes._Panes.Count(); i++) {
					this.DisabledArray.Add(i);
				}				
				// Following line is left here for when the jQuery UI library is fixed.
				//options.Add(this.Disabled, "disable", this.Disabled.JsBool());
			}
			if (this.DisabledArray != null && this.DisabledArray.Count() > 0) {
				options.Add("disabled", this.DisabledArray.JsArray());
			}
			options.Add(!this.IsNullEmptyOrDefault(this.Evt, DEFAULT_EVENT), "event", this.Evt.InDoubleQuotes());
			options.Add(!this.IsNullEmptyOrDefault(this.HeightStyle, DEFAULT_HEIGHT_STYLE), "heightStyle", this.HeightStyle.InDoubleQuotes());
			options.Add(this.Collapsible, "collapsible", this.Collapsible.JsBool() );
			// Cookie, show and hide are a little bit different because it's an object, so just add it's options in
			options.Add(this.Cookie.Options.GetCookieScriptOption());
			options.Add(this.ShowAnimation.Options.GetAnimationScriptOption());
			options.Add(this.HideAnimation.Options.GetAnimationScriptOption());
			if (this.Tabs.Panes.HasActiveTab() && this.Tabs.Panes.GetActiveTab().Index > 0) {
				options.Add( this.Tabs.Panes.HasActiveTab(), "active", this.Tabs.Panes.GetActiveTab().Index.ToString() );
			}
		}

	} // Options

} // ns Fluqi.jTab
