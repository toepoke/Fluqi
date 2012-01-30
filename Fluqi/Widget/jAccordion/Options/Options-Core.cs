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
		/// Default heading to use for the accordion widget.
		/// </summary>
		public const string DEFAULT_HEADING = "h3";

		/// <summary>
		/// Default header icon for the accordion widget.
		/// </summary>
		public const string DEFAULT_HEADER_ICON_CLASS = "ui-icon-triangle-1-e";

		/// <summary>
		/// Default selected header icon for the accordion widget.
		/// </summary>
		public const string DEFAULT_HEADER_SELECTED_ICON_CLASS = "ui-icon-triangle-1-s";		

		/// <summary>
		/// Default animation for the accordion widget.
		/// </summary>
		public const string DEFAULT_ANIMATED = "slide";

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
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			options.Add(!this.IsNullEmptyOrDefault(this.Animated, DEFAULT_ANIMATED), "animated", this.Animated.InDoubleQuotes());
			options.Add(!this.AutoHeight, "autoHeight", this.AutoHeight.JsBool());
			options.Add(this.ClearStyle, "clearStyle", this.ClearStyle.JsBool());
			options.Add(this.Collapsible, "collapsible", this.Collapsible.JsBool());
			options.Add(this.FillSpace, "fillSpace", this.FillSpace.JsBool());
			options.Add(this.Navigation, "navigation", this.Navigation.JsBool());
			options.Add(!this.IsNullOrEmpty(this.NavigationFilter),"navigationFilter", this.NavigationFilter);
			options.Add(!this.IsNullEmptyOrDefault(this.Event, DEFAULT_EVENT), "event", this.Event.InSingleQuotes() );
			
			// icons have to be set as a pair
			bool addNormalIcon = !string.IsNullOrEmpty(this.HeaderIconClass) && this.HeaderIconClass != DEFAULT_HEADER_ICON_CLASS;
			bool addSelectedIcon = !string.IsNullOrEmpty(this.HeaderSelectedIconClass) && this.HeaderSelectedIconClass != DEFAULT_HEADER_SELECTED_ICON_CLASS;
			if (addNormalIcon || addSelectedIcon) {
				options.Add( "icons", "{{ 'header': '{0}', 'headerSelected': '{1}' }}", this.HeaderIconClass, this.HeaderSelectedIconClass );
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
			this.HeadingTag = DEFAULT_HEADING;
			this.HeaderIconClass = DEFAULT_HEADER_ICON_CLASS;
			this.HeaderSelectedIconClass = DEFAULT_HEADER_SELECTED_ICON_CLASS;
			this.AutoHeight = true;
			this.Animated = DEFAULT_ANIMATED;
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
