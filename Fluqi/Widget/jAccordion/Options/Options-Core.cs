using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI Accordion.
	/// </summary>
	/// <remarks>
	/// Properties not yet supported:
	///   header
	/// </remarks>
	public partial class Options: Core.Options
	{
		/// <summary>
		/// Default HTML element to use for the accordion container
		/// </summary>
		public const string DEFAULT_CONTAINER_TAG = "div";

		/// <summary>
		/// Default heading to use for the accordion widget panel header.
		/// </summary>
		public const string DEFAULT_HEADING_TAG = "h3";

		/// <summary>
		/// Default tag to use for the accordion content HTML element.
		/// </summary>
		public const string DEFAULT_CONTENT_TAG = "div";

		/// <summary>
		/// Default header icon for the accordion widget.
		/// </summary>
		public const string DEFAULT_HEADER_ICON_CLASS = "ui-icon-triangle-1-e";

		/// <summary>
		/// Default selected header icon for the accordion widget.
		/// </summary>
		public const string DEFAULT_ACTIVE_HEADER_ICON_CLASS = "ui-icon-triangle-1-s";		

		/// <summary>
		/// Default animation for the accordion widget.
		/// </summary>
		public const string DEFAULT_ANIMATE = "slide";

		/// <summary>
		/// Default event for changing panels for the accordion widget.
		/// </summary>
		public const string DEFAULT_EVENT = "click";


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="accordion">Accordion object to be configured</param>
		public Options(Accordion accordion)
		 : base()
		{
			this.Accordion = accordion;
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Accordion"/> object these options are for
		/// </summary>
		public Accordion Accordion { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Accordion"/> object so we can continue defining Accordion attributes.
		/// </summary>
		/// <returns>Returns <see cref="Accordion"/> object to return chaining to the Accordion collection</returns>
		public Accordion Finish() {
			return this.Accordion;
		}


		/// <summary>
		/// Flags whether the panel header icons are going to be shown or not.
		/// </summary>
		/// <returns>true if (either) icon is on, false otherwise</returns>
		protected internal bool AreIconsEnabled() {
			bool areEnabled = true;

			if (string.IsNullOrEmpty(this.HeaderIconClass) && string.IsNullOrEmpty(this.activeHeaderIconClass))
				areEnabled = false;

			return areEnabled;
		}


		/// <summary>
		/// Flags whether the panel header icons are set to the defaults (that is if they are we don't need
		/// to render the javascript to render them as it's wasted)
		/// </summary>
		/// <returns>
		/// Returns true if icons are set to the jQuery UI defaults
		/// Returns false otherwise
		/// </returns>
		protected internal bool AreIconsDefaults() {
			if (!AreIconsEnabled())
				// can't be the defaults are they aren't enabled
				return false;

			if (this.HeaderIconClass == DEFAULT_HEADER_ICON_CLASS && this.activeHeaderIconClass == DEFAULT_ACTIVE_HEADER_ICON_CLASS)
				return true;

			return false;
		}
		

		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			options.Add(!this.IsNullEmptyOrDefault(this.Animate, DEFAULT_ANIMATE), "animate", this.Animate.InDoubleQuotes());
			options.Add(!this.AutoHeight, "autoHeight", this.AutoHeight.JsBool());
			options.Add(this.ClearStyle, "clearStyle", this.ClearStyle.JsBool());
			options.Add(this.Collapsible, "collapsible", this.Collapsible.JsBool());
			options.Add(!this.IsNullEmptyOrDefault(this.HeadingTag, DEFAULT_HEADING_TAG), "heading", this.HeadingTag.InDoubleQuotes());
			options.Add(this.FillSpace, "fillSpace", this.FillSpace.JsBool());
			options.Add(this.Navigation, "navigation", this.Navigation.JsBool());
			options.Add(!this.IsNullOrEmpty(this.NavigationFilter),"navigationFilter", this.NavigationFilter);
			options.Add(!this.IsNullEmptyOrDefault(this.Event, DEFAULT_EVENT), "event", this.Event.InSingleQuotes() );
			
			if (AreIconsEnabled()) {
				if (!AreIconsDefaults())
					options.Add( "icons", "{{ 'header': '{0}', 'activeHeader': '{1}' }}", this.HeaderIconClass, this.activeHeaderIconClass );
			} else {
				// icons disabled
				options.Add("icons", false.JsBool());
			}
			
			int activeIndex = this.Accordion.Panels.GetActivePaneIndex();
			if (activeIndex > 0) {
				options.Add( this.Accordion.Panels.HasActivePane(), "active", activeIndex.ToString() );
			}
		}

		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			// Set options to same defaults as jQuery UI
			this.ContainerTag = DEFAULT_CONTAINER_TAG;
			this.HeadingTag = DEFAULT_HEADING_TAG;
			this.ContentTag = DEFAULT_CONTENT_TAG;
			this.HeaderIconClass = DEFAULT_HEADER_ICON_CLASS;
			this.activeHeaderIconClass = DEFAULT_ACTIVE_HEADER_ICON_CLASS;
			this.AutoHeight = true;
			this.Animate = DEFAULT_ANIMATE;
			this.ClearStyle = false;
			this.Collapsible = false;
			this.Event = DEFAULT_EVENT;
			this.FillSpace = false;
			this.Navigation = false;
			this.NavigationFilter = "";
			this.Disabled = false;
		}

	} // Options

} // ns Fluqi.jTab
