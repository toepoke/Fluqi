using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jDialog
{

	/// <summary>
	/// A set of properties to apply to a set of jQuery UI AutoComplete.
	/// </summary>
	public partial class Options: Core.Options
	{
#pragma warning disable 1591
		public const string DEFAULT_CLOSE_TEXT = "close";
		public const string DEFAULT_HEIGHT = "auto";
		public const int    DEFAULT_MIN_WIDTH = 150;
		public const string DEFAULT_MAX_WIDTH = "false";
		public const int    DEFAULT_MIN_HEIGHT = 150;
		public const string DEFAULT_MAX_HEIGHT = "false";
		public const int    DEFAULT_WIDTH = 300;
		public const int    DEFAULT_ZINDEX = 1000;
		public const string DEFAULT_POSITION = "center";
#pragma warning restore 1591

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dlg">Dialog to configure options of</param>
		public Options(Dialog dlg)
		 : base()
		{
			this.Dialog = dlg;
			this.ButtonOptions = new ButtonOptions(this);
			this.Reset();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Dialog"/> object these options are for
		/// </summary>
		public Dialog Dialog { get; set; }

		/// <summary>
		/// Stores all the buttons that are added through the interface, so they can be rendered later.
		/// </summary>
		public ButtonOptions ButtonOptions { get; set; }

		/// <summary>
		/// Used to flag that configuration of <see cref="Options"/> has finished, and 
		/// returns the <see cref="Dialog"/> object so we can continue defining Tabs attributes.
		/// </summary>
		/// <returns>Returns <see cref="Dialog"/> object to return chaining to the Dialog object</returns>
		public Dialog Finish() {
			return this.Dialog;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(this.Disabled, "disabled", this.Disabled.JsBool());
			options.Add(!this.AutoOpen, "autoOpen", this.AutoOpen.JsBool());
			options.Add(!this.CloseOnEscape, "closeOnEscape", this.CloseOnEscape.JsBool());
			options.Add(!this.IsNullEmptyOrDefault(this.CloseText, DEFAULT_CLOSE_TEXT), "closeText", this.CloseText.InDoubleQuotes());
			options.Add(!this.IsNullOrEmpty(this.DialogClass), "dialogClass", this.DialogClass.InDoubleQuotes());
			options.Add(!this.Draggable, "draggable", this.Draggable.JsBool());

			if (!this.IsNullEmptyOrDefault(this.Height, DEFAULT_HEIGHT)) {
				if (this.IsNumeric(this.Height))
					options.Add("height", this.Height);
				else 
					options.Add("height", this.Height.InDoubleQuotes());
			}

			options.Add(!this.IsNullOrEmpty(this.Hide), "hide", this.Hide);
			options.Add(this.MinWidth != DEFAULT_MIN_WIDTH, "minWidth", this.MinWidth.ToString());
			options.Add(!this.IsNullEmptyOrDefault(this.MaxWidth, DEFAULT_MAX_WIDTH), "maxWidth", this.MaxWidth);
			options.Add(this.MinHeight != DEFAULT_MIN_HEIGHT, "minHeight", this.MinHeight.ToString());
			options.Add(!this.IsNullEmptyOrDefault(this.MaxHeight, DEFAULT_MAX_HEIGHT), "maxHeight", this.MaxHeight);
			options.Add(this.Modal, "modal", this.Modal.JsBool());

			if (this.Position != null && this.Position.Any() && !this.Position[0].IgnorantEquals(Options.DEFAULT_POSITION)) {
				if (this.Position.Count() == 1) {
					// only "left", "right", etc is supported in single mode
					options.Add("position", this.Position[0].InDoubleQuotes());

				} else {
					// if it's a numeric list, don't add quotes otherwise we do
					if (this.IsNumeric(this.Position[0]))
						options.Add("position", this.Position.JsArray());
					else 
						options.Add("position", this.Position.JsArray(false/*singleQuotes*/));
				}
			}

			options.Add(!this.Resizable, "resizable", this.Resizable.JsBool());
			options.Add(!this.IsNullOrEmpty(this.Show), "show", this.Show);
			options.Add(!this.Stack, "stack", this.Stack.JsBool());
			options.Add(!this.IsNullOrEmpty(this.Title), "title", this.Title.InDoubleQuotes());
			options.Add(this.Width != DEFAULT_WIDTH, "width", this.Width.ToString());
			options.Add(this.ZIndex != DEFAULT_ZINDEX, "zIndex", this.ZIndex.ToString());

			if (this.ButtonOptions != null && this.ButtonOptions.Buttons.Any()) {
				options.Add(this.ButtonOptions.GetButtonsScriptOptions());
			}
		}


		/// <summary>
		/// Resets all the control properties back to their default settings (i.e. the
		/// defaults as documented by jQuery UI library
		/// </summary>
		protected void Reset() {
			this.Disabled = false;
			this.AutoOpen = true;
			this.CloseOnEscape = true;
			this.CloseText = DEFAULT_CLOSE_TEXT;
			this.DialogClass = "";
			this.Draggable = true;
			this.Height = DEFAULT_HEIGHT;
			this.Hide = "";
			this.MaxHeight = "false";
			this.MaxWidth = "false";
			this.MinHeight = DEFAULT_MIN_HEIGHT;
			this.MinWidth = DEFAULT_MIN_WIDTH;
			this.Modal = false;
			this.Position = new List<string>() { "center" };
			this.Resizable = true;
			this.Show = "";
			this.Stack = true;
			this.Title = "";
			this.Width = DEFAULT_WIDTH;
			this.ZIndex = DEFAULT_ZINDEX;
		}

	} // Options

} // ns Fluqi.jAutoComplete
