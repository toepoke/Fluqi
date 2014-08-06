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
	/// <remarks>
	/// Properties not yet supported:
	/// </remarks>
	public partial class Options: Core.Options
	{

		/// <summary>
		/// Adds a button onto the dialog.
		/// </summary>
		/// <param name="label">Label on the button the user will see.</param>
		/// <param name="methodSource">JavaScript to call when the button is clicked.</param>
		/// <returns></returns>
		public Options AddButton(string label, string methodSource) {
			this.ButtonOptions.AddButton(label, methodSource);
			return this;
		}


		/// <summary>
		/// Disables (true) or enables (false) the dialog. Can be set when initialising (first creating) the dialog.
		/// </summary>
		public Options SetDisabled(bool disable) {
			this.Disabled = disable;
			return this;
		}


		/// <summary>
		/// When autoOpen is true the dialog will open automatically when dialog is called. If false it will stay 
		/// hidden until .dialog("open") is called on it.
		/// </summary>
		public Options SetAutoOpen(bool autoOpen) {
			this.AutoOpen = autoOpen;
			return this;
		}

		/// <summary>
		/// Specifies whether the dialog should close when it has focus and the user presses 
		/// the esacpe (ESC) key.
		/// </summary>
		public Options SetCloseOnEscape(bool closeOnEscape) {
			this.CloseOnEscape = closeOnEscape;
			return this;
		}


		/// <summary>
		/// Specifies the text for the close button. Note that the close text is visibly hidden 
		/// when using a standard theme.
		/// </summary>
		public Options SetCloseText(string closeText) {
			this.CloseText = closeText;
			return this;
		}


		/// <summary>
		/// The specified class name(s) will be added to the dialog, for additional theming.
		/// </summary>
		public Options SetDialogClass(string dialogClass) {
			this.DialogClass = dialogClass;
			return this;
		}


		/// <summary>
		/// If set to true, the dialog will be draggable will be draggable by the titlebar.
		/// </summary>
		public Options SetDraggable(bool draggable) {
			this.Draggable = draggable;
			return this;
		}


		/// <summary>
		/// The height of the dialog, in pixels. Specifying 'auto' is also supported to make 
		/// the dialog adjust based on its content.
		/// </summary>
		public Options SetHeight(string height) {
			this.Height = height;
			return this;
		}


		/// <summary>
		/// The height of the dialog, in pixels. Specifying 'auto' is also supported to make 
		/// the dialog adjust based on its content.
		/// </summary>
		public Options SetHeight(int height) {
			this.Height = height.ToString();
			return this;
		}


		/// <summary>
		/// The effect to be used when the dialog is closed.
		/// </summary>
		public Options SetHideEffect(string hide) {
			if (string.IsNullOrEmpty(hide))
				// nothing to see here
				return this;

			// remove any quotes so we can reliably add our own
			hide = Helpers.Utils.TrimQuotes(hide);
			this.Hide = "\"" + hide + "\"";
			return this;
		}


		/// <summary>
		/// The effect to be used when the dialog is closed.
		/// </summary>
		public Options SetHideEffect(Core.Animation.eAnimation effect) {
			return this.SetHideEffect( Core.Animation.AnimationToString(effect) );
		}


		/// <summary>
		/// Function to use when the dialog is closed.
		/// </summary>
		public Options SetHideMethod(string hideMethod) {
			this.Hide = hideMethod;
			return this;
		}


		/// <summary>
		/// The maximum height to which the dialog can be resized, in pixels.
		/// </summary>
		public Options SetMaxHeight(string maxHeight) {
			this.MaxHeight = maxHeight;
			return this;
		}


		/// <summary>
		/// The maximum height to which the dialog can be resized, in pixels.
		/// </summary>
		public Options SetMaxHeight(int maxHeight) {
			this.MaxHeight = maxHeight.ToString();
			return this;
		}


		/// <summary>
		/// The maximum width to which the dialog can be resized, in pixels.
		/// </summary>
		public Options SetMaxWidth(string maxWidth) {
			this.MaxWidth = maxWidth;
			return this;
		}


		/// <summary>
		/// The maximum width to which the dialog can be resized, in pixels.
		/// </summary>
		public Options SetMaxWidth(int maxWidth) {
			return this.SetMaxWidth(maxWidth.ToString());
		}

		/// <summary>
		/// The minimum height to which the dialog can be resized, in pixels.
		/// </summary>
		public Options SetMinHeight(int minHeight) {
			this.MinHeight = minHeight;
			return this;
		}


		/// <summary>
		/// The minimum width to which the dialog can be resized, in pixels.
		/// </summary>
		public Options SetMinWidth(int minWidth) {
			this.MinWidth = minWidth;
			return this;
		}


		/// <summary>
		/// If set to true, the dialog will have modal behavior; other items on the page will be 
		/// disabled (i.e. cannot be interacted with). Modal dialogs create an overlay below the 
		/// dialog but above other page elements.
		/// </summary>
		public Options SetModal(bool modal) {
			this.Modal = modal;
			return this;
		}


		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		///   A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// </summary>
		public Options SetPosition(string position) {
			if (string.IsNullOrEmpty(position)) 
				// nothing to see here
				return this;

			this.Position.Clear();
			this.Position.Add(position);
			return this;
		}


		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		///   Two strings containing x,y position string values (e.g. ['right','top'] for top right corner)
		/// </summary>
		public Options SetPosition(string x, string y) {
			if (string.IsNullOrEmpty(x) && string.IsNullOrEmpty(y)) 
				// nothing to see here
				return this;

			this.Position.Clear();
			if (!string.IsNullOrEmpty(x))
				this.Position.Add(x);
			if (!string.IsNullOrEmpty(y))
				this.Position.Add(y);
			return this;
		}


		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		///   A single string representing position within viewport: 'center', 'left', 'right', 'top', 'bottom'. 
		/// </summary>
		public Options SetPosition(Core.Position.ePosition position) {
			string strPos = Core.Position.PositionToString(position);

			return this.SetPosition(strPos);
		}


		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		///   Two strings containing x,y position string values (e.g. ['right','top'] for top right corner)
		/// </summary>
		public Options SetPosition(Core.Position.ePosition x, Core.Position.ePosition y) {
			string strX = Core.Position.PositionToString(x);
			string strY = Core.Position.PositionToString(y);

			return this.SetPosition(strX, strY);
		}


		/// <summary>
		/// Specifies where the dialog should be displayed. Possible values: 
		///   Two values containing an x,y coordinate pair in pixel offset from left, top corner of viewport 
		///   (e.g. 350, 100) 
		/// </summary>
		public Options SetPosition(int x, int y) {
			this.Position.Clear();
			this.Position.Add(x.ToString());
			this.Position.Add(y.ToString());
			return this;
		}


		/// <summary>
		/// If set to true, the dialog will be resizable.
		/// </summary>
		public Options SetResizable(bool resizable) {
			this.Resizable = resizable;
			return this;
		}


		/// <summary>
		/// The effect to be used when the dialog is opened.
		/// </summary>
		public Options SetShowEffect(string show) {
			if (string.IsNullOrEmpty(show))
				// nothing to see here
				return this;

			// remove any quotes so we can reliably add our own
			show = Helpers.Utils.TrimQuotes(show);
			this.Show = "\"" + show + "\"";
			return this;
		}


		/// <summary>
		/// The effect to be used when the dialog is opened.
		/// </summary>
		public Options SetShowEffect(Core.Animation.eAnimation effect) {
			return this.SetShowEffect( Core.Animation.AnimationToString(effect) );
		}


		/// <summary>
		/// The effect to be used when the dialog is opened.
		/// </summary>
		public Options SetShowMethod(string showMethod) {
			this.Show = showMethod;
			return this;
		}


		/// <summary>
		/// Specifies whether the dialog will stack on top of other dialogs. This will cause 
		/// the dialog to move to the front of other dialogs when it gains focus.
		/// </summary>
		public Options SetStack(bool stack) {
			this.Stack = stack;
			return this;
		}


		/// <summary>
		/// Specifies the title of the dialog. Any valid HTML may be set as the title. 
		/// The title can also be specified by the title attribute on the dialog source element.
		/// </summary>
		public Options SetTitle(string title) {
			this.Title = title;
			return this;
		}


		/// <summary>
		/// The width of the dialog, in pixels.
		/// </summary>
		public Options SetWidth(int width) {
			this.Width = width;
			return this;
		}


		/// <summary>
		/// The starting z-index for the dialog.
		/// </summary>
		public Options SetZIndex(int zIndex) {
			this.ZIndex = zIndex;
			return this;
		}

	} // Options

} // ns Fluqi.jAutoComplete
