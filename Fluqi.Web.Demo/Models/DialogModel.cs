using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;
using Fluqi.Widget.jDialog;
using Fluqi.Helpers;
using System.IO;


namespace Fluqi.Models
{
	/// <summary>
	/// Takes all the Initial Settings defined on the view and configures the control accordingly.
	/// Also displays the JavaScript and C# required to make the jQuery UI control do what we want
	/// For instance on the DatePicker screen we can change the "ShowAnim" setting to "Explode"
	/// this class takes what the model tells us and would then configure the DatePicker (or whatever
	/// control we're looking at).
	/// </summary>
	/// <remarks>
	/// Note all the files in this project are for demo purposes and certainly aren't "best practice" by
	/// any stretch of the imagination.
	/// </remarks>
	public class DialogModel: BaseModel {

		public DialogModel() : base() {
			this.Disabled = false;
			this.AutoOpen = true;
			this.CloseOnEscape = true;
			this.CloseText = Options.DEFAULT_CLOSE_TEXT;
			this.DialogClass = "";
			this.Draggable = true;
			this.Height = Options.DEFAULT_HEIGHT;
			this.HideEffect = Core.Animation.AnimationToString( Core.Animation.eAnimation.None );
			this.MinWidth = Options.DEFAULT_MIN_WIDTH;
			this.MaxWidth = "false";
			this.MinHeight = Options.DEFAULT_MIN_HEIGHT;
			this.MaxHeight = "false";
			this.Modal = false;
			this.Position1 = Core.Position.PositionsToString(new List<Core.Position.ePosition>() { Core.Position.ePosition.Center });
			this.Position2 = Core.Position.PositionsToString(new List<Core.Position.ePosition>() { Core.Position.ePosition.Center });
			this.Resizable = true;
			this.ShowEffect = Core.Animation.AnimationToString( Core.Animation.eAnimation.None );
			this.Stack = true;
			this.Title = "";
			this.Width = Options.DEFAULT_WIDTH;
			this.ZIndex = Options.DEFAULT_ZINDEX;
		}

		public bool Disabled { get; set; }
		public bool AutoOpen { get; set; }
		public bool CloseOnEscape { get; set; }
		public string CloseText { get; set; }
		public string DialogClass { get; set; }
		public bool Draggable { get; set; }
		public string Height { get; set; }
		public string HideEffect { get; set; }
		public int MinHeight { get; set; }
		public string MaxHeight { get; set; }
		public int MinWidth { get; set; }
		public string MaxWidth { get; set; }
		public bool Modal  { get; set; }
		public string Position1 { get; set; }
		public string Position2 { get; set; }
		public bool Resizable { get; set; }
		public string ShowEffect { get; set; }
		public bool Stack { get; set; }
		public string Title { get; set; }
		public int Width { get; set; }
		public int ZIndex { get; set; }
		

		public Dialog BuildDialogFromModel(TextWriter writer, string id) {
			Dialog dlg = new Dialog(writer, id);

			dlg.Options
				.SetDisabled(this.Disabled)
				.SetAutoOpen(this.AutoOpen)
				.SetCloseOnEscape(this.CloseOnEscape)
				.SetCloseText(this.CloseText)
				.SetDialogClass(this.DialogClass)
				.SetDraggable(this.Draggable)
				.SetHeight(this.Height)
				.SetHideEffect(this.HideEffect)
				.SetMaxHeight(this.MaxHeight)
				.SetMaxWidth(this.MaxWidth)
				.SetModal(this.Modal)
				.SetPosition(this.Position1, this.Position2)
				.SetResizable(this.Resizable)
				.SetShowEffect(this.ShowEffect)
				.SetStack(this.Stack)
				.SetTitle(this.Title)
				.SetWidth(this.Width)
				.SetZIndex(this.ZIndex)
				.AddButton("OK", "OKClicked(this); 	$(this).dialog(\"close\");")
				.AddButton("Cancel", "CancelClicked(this);   	$(this).dialog(\"close\");")
			.Finish();

			if (this.showEvents) {
				dlg
					.Events
						.SetCreateEvent("return createEvent(event, ui);")
						.SetBeforeCloseEvent("return beforeClose(event, ui);")
						.SetOpenEvent("return openEvent(event, ui);")
						.SetFocusEvent("return focusEvent(event, ui);")
						.SetDragStartEvent("return dragStartEvent(event, ui);")
						.SetDragEvent("return dragEvent(event, ui);")
						.SetDragStopEvent("return dragStopEvent(event, ui);")
						.SetResizeStartEvent("return resizeStartEvent(event, ui);")
						.SetResizeEvent("return resizeEvent(event, ui);")
						.SetResizeStopEvent("return resizeStopEvent(event, ui);")
						.SetCloseEvent("return closeEvent(event, ui);")
					.Finish();
			}
			if (!this.prettyRender)
				dlg.Rendering.Compress();
			if (this.renderCSS)
				dlg.Rendering.ShowCSS();

			return dlg;
		}

		public string JavaScriptCode() {
			Dialog dlg = BuildDialogFromModel(this.Writer, "js_dlg");
			dlg.Rendering.SetPrettyRender(true);
			
			return dlg.GetStartUpScript();
		}

		public string CSharpCode() {
			Dialog dlg = BuildDialogFromModel(this.Writer, "js_dlg");
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsLineIf("Dialog dlg = Html.CreateDialog(\"dlg\")");

			string optionsCode = OptionsCSharpCode();
			string showEventsCode = ShowEventsCSharpCode();
			string renderCode = base.RenderCSharpCode();
			bool showOptions = (optionsCode.Length > 0 || showEventsCode.Length > 0 || renderCode.Length > 0);

			if (showOptions) {
				sb.IncIndent();

				if (optionsCode.Length > 0) {
					sb.AppendTabsLineIf(".Options");
					sb.IncIndent();
					sb.Append(optionsCode);			
					sb.DecIndent();
					sb.AppendTabsLineIf(".Finish()");
				}	
				if (showEventsCode.Length > 0) {
					sb.AppendTabsLineIf(".Events");
					sb.IncIndent();
					sb.Append(showEventsCode);
					sb.DecIndent();
					sb.AppendTabsLineIf(".Finish()");
				}

				if (renderCode.Length > 0)
					sb.Append(renderCode);
				sb.DecIndent();
			}
			
			sb.AppendTabsLineIf(";");
			sb.AppendTabsLineIf("%>");
			sb.AppendLineIf();
			sb.AppendTabsLineIf("<%using (dlg.RenderDialog()) {%>");
			sb.AppendTabsLineIf("\t<p>Proin ...</p>");
			sb.AppendTabsLineIf("<%}%>");

			return sb.ToString();
		}

		protected string OptionsCSharpCode() {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			if (this.Disabled) sb.AppendTabsLineIf(".SetDisabled(true)");
			if (!this.AutoOpen) sb.AppendTabsLineIf(".SetAutoOpen(false)");
			if (!this.CloseOnEscape) sb.AppendTabsLineIf(".SetCloseOnEscape(false)");
			if (!Utils.IsNullEmptyOrDefault(this.CloseText, Options.DEFAULT_CLOSE_TEXT)) sb.AppendTabsFormatLineIf(".SetCloseText(\"{0}\")", this.CloseText);
			if (!string.IsNullOrEmpty(this.DialogClass)) sb.AppendTabsFormatLineIf(".SetDialogClass(\"{0}\")", this.DialogClass);
			if (!this.Draggable) sb.AppendTabsLineIf(".SetDraggable(false)");
			if (!Utils.IsNullEmptyOrDefault(this.Height, Options.DEFAULT_HEIGHT)) {
				if (Utils.IsNumeric(this.Height))
					sb.AppendTabsFormatLineIf(".SetHeight({0})", this.Height);
				else 
					sb.AppendTabsFormatLineIf(".SetHeight(\"{0}\")", this.Height);
			}
			if (!string.IsNullOrEmpty(this.HideEffect)) sb.AppendTabsFormatLineIf(".SetHideEffect(\"{0}\")", this.HideEffect);
			if (this.MinWidth != Options.DEFAULT_MIN_WIDTH) sb.AppendTabsFormatLineIf(".SetMinWidth({0})", this.MinWidth);
			if (!Utils.IsNullEmptyOrDefault(this.MaxWidth, Options.DEFAULT_MAX_WIDTH)) {
				if (Utils.IsNumeric(this.MaxWidth))
					sb.AppendTabsFormatLineIf(".SetMaxWidth({0})", this.MaxWidth);
				else 
					sb.AppendTabsFormatLineIf(".SetMaxWidth(\"{0}\")", this.MaxWidth);
			}
			if (this.MinHeight != Options.DEFAULT_MIN_HEIGHT) sb.AppendTabsFormatLineIf(".SetMinHeight({0})", this.MinHeight);
			if (!Utils.IsNullEmptyOrDefault(this.MaxHeight, Options.DEFAULT_MAX_HEIGHT)) {
				if (Utils.IsNumeric(this.MaxHeight))
					sb.AppendTabsFormatLineIf(".SetMaxHeight({0})", this.MaxHeight);
				else 
					sb.AppendTabsFormatLineIf(".SetMaxHeight(\"{0}\")", this.MaxHeight);
			}
			if (this.Modal) sb.AppendTabsFormatLineIf(".SetModal(true)");

			if (!Utils.IsNullEmptyOrDefault(this.Position1, Options.DEFAULT_POSITION)) {
				// first one is populated, so there's something of interest here
				sb.AppendTabsIf(".SetPosition(");
				if (Utils.IsNumeric(this.Position1)) 
					sb.Append(this.Position1);
				else 
					sb.AppendFormat("\"{0}\"", this.Position1);

				if (!string.IsNullOrEmpty(this.Position2)) {
					// second one is populated too
					if (Utils.IsNumeric(this.Position2))
						sb.AppendFormat(", {0}", this.Position2);
					else 
						sb.AppendFormat(", \"{0}\"", this.Position2);
				}
					
				// and close
				sb.AppendLineIf(")");
			}

			if (!this.Resizable) sb.AppendTabsFormatLineIf(".SetResizable(false)");
			if (!string.IsNullOrEmpty(this.ShowEffect)) sb.AppendTabsFormatLineIf(".SetShowEffect(\"{0}\")", this.ShowEffect);
			if (!this.Stack) sb.AppendTabsLineIf(".SetStack(true)");
			if (!string.IsNullOrEmpty(this.Title)) sb.AppendTabsFormatLineIf(".SetTitle(\"{0}\")", this.Title);
			if (this.Width != Options.DEFAULT_WIDTH) sb.AppendTabsFormatLineIf(".SetWidth({0})", this.Width);
			if (this.ZIndex != Options.DEFAULT_ZINDEX) sb.AppendTabsFormatLineIf(".SetZIndex({0})", this.ZIndex);

			// buttons are always added in the demo
			sb.AppendTabsLineIf(".AddButton(\"OK\", \"return OKClicked();\")");
			sb.AppendTabsLineIf(".AddButton(\"Cancel\", \"return CancelClicked();\")");

			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetCreateEvent(\"createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetBeforeCloseEvent(\"beforeCloseEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetOpenEvent(\"openEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetFocusEvent(\"focusEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetDragStartEvent(\"dragStartEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetDragEvent(\"dragEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetDragStopEvent(\"dragStopEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetResizeStartEvent(\"resizeStartEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetResizeEvent(\"resizeEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetResizeStopEvent(\"resizeStopEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetCloseEvent(\"closeEvent(event, ui);\")");

			return sb.ToString();
		}



	}

}

