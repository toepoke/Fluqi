using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension.Helpers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;
using Fluqi.Core.Interfaces;
using System.IO;

namespace Fluqi.Widget.jPushButton
{
	public partial class PushButton: Core.ControlBase, IControlRenderer, IScriptRenderer, Core.Interfaces.IControl
	{
		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		/// <remarks>
		/// For the Button control, this is "button".
		/// </remarks>
		public string PlugInName { get; protected internal set; }

		/// <summary>
		/// ID of the jQuery UI object.  Must be unique on the page.
		/// </summary>
		public string ID { get; protected internal set; }

		/// <summary>
		/// Response object to write the control to.
		/// </summary>
		public TextWriter Writer { get; protected internal set; }

		/// <summary>
		/// Label to display on the button (can flag not to show the text (but still appear as an ALT tooltip)
		/// by setting the flag.
		/// </summary>
		public string Label { get; set; }

		/// <summary>
		/// Specifies how the button will be rendered.  As Fluqi [can] does the rendering of the input as well as
		/// the JavaScript, it needs to know how you want the button to be rendered (i.e. as an actual 
		/// Button (the default), Hyperlink, Submit button, etc).
		/// </summary>
		public Core.ButtonType.eButtonType InputType { get; set; }

		/// <summary>
		/// Specifies the hyperlink destination (when rendering is a Hyperlink).
		/// </summary>		
		public string Href { get; set; }

		/// <summary>
		/// Specifies the options to be adopted for this object (see <see cref="Options"/> class
		/// for full details)
		/// </summary>
		public Options Options { get; protected internal set; }

		/// <summary>
		/// Specifies the events to be adopted for this set of Button (see <see cref="Events"/> class
		/// for full details)
		/// </summary>
		public Events Events { get; protected internal set; }

		/// <summary>
		/// Specifies the events to be adopted for this set of Button (see <see cref="Methods"/> class
		/// for full details)
		/// </summary>
		public Methods Methods { get; protected internal set; }

		/// <summary>
		/// Specifies the settings to be adopted when rendering the control (e.g. whether to compress the JavaScript, 
		/// include jQuery UI class names, etc.
		/// </summary>
		public Rendering Rendering { get; protected internal set; }

		
		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">Response object to write to</param>
		/// <param name="id">ID of the button, this must be unique for the page</param>
		/// <param name="label">Text to appear in the button</param>
		public PushButton(TextWriter writer, string id, string label)
			: base()
		{
			this.PlugInName = "button";
			this.Writer = writer;
			this.ID = id;
			this.Label = label;
			this.InputType = Core.ButtonType.eButtonType.Button;
			this.Options = new Options(this);
			this.Events = new Events(this);
			this.Methods = new Methods(this);			
			this.Rendering = new Rendering(this);

			// id/text are mandatory
			if (string.IsNullOrEmpty(id))
				throw new ArgumentException("ID is mandatory for the Button plug-in", "id");
			if (string.IsNullOrEmpty(label))
				throw new ArgumentException("Label is mandatory for the Button plug-in", "text");				
		}


		/// <summary>
		/// Specifies how the button will be rendered.  As Fluqi [can] does the rendering of the input as well as
		/// the JavaScript, it needs to know how you want the button to be rendered (i.e. as an actual 
		/// Button (the default), Hyperlink, Submit button, etc).
		/// </summary>
		public PushButton RenderAs(Core.ButtonType.eButtonType inputType) {
			this.InputType = inputType;
			return this;
		}


		/// <summary>
		/// Renders the Button as a hyperlink
		/// </summary>
		/// <returns></returns>
		public PushButton RenderAsHyperlink(string href) {
			if (string.IsNullOrEmpty(href))
				throw new ArgumentException("Hyperlink button must have an href.", "href");
			this.Href = href;
			return RenderAs(Core.ButtonType.eButtonType.Hyperlink);
		}

		
		/// <summary>
		/// Renders the Button as a Reset button
		/// </summary>
		/// <returns></returns>
		public PushButton RenderAsResetButton() {
			return RenderAs(Core.ButtonType.eButtonType.Reset);
		}


		/// <summary>
		/// Renders the Button as a Submit button
		/// </summary>
		/// <returns></returns>
		public PushButton RenderAsSubmitButton() {
			return RenderAs(Core.ButtonType.eButtonType.Submit);
		}


		/// <summary>
		/// Builds up the HTML for the Button control and adds to the response stream.
		/// JavaScript initialisation for the control is also added to the response stream if the
		/// AutoScript rendering option is true.
		/// </summary>
		public void Render() {
			string tagHTML = this.GetTagHtml();
			Writer.Write(tagHTML);
		}


		/// <summary>
		/// Builds up the HTML for the Button control and options (and returns the generated HTML).
		/// </summary>
		/// <returns>Generated HTML for the control.</returns>
		protected internal string GetTagHtml() {
			// ID/text properties are _mandatory_
			if (string.IsNullOrEmpty(this.ID))
				throw new ArgumentException("Button ID property _must_ be supplied.");
			if (string.IsNullOrEmpty(this.Label))
				throw new ArgumentException("Button Label property _must_ be supplied.");

			bool prettyRender = this.Rendering.PrettyRender;
			bool renderCss = this.Rendering.RenderCSS;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);
			
			this.WithID(this.ID);
			if (renderCss) 
				this.WithCss("ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only ui-state-hover");
			
			sb.AppendTabsIf();
			RenderOpeningTag(sb);

			this.RenderAttributes(sb);
			
			RenderTagContent(sb);

			RenderClosingTag(sb);

			if (this.Rendering.AutoScript) {
				sb.AppendLineIf();
				sb.Append(this.GetStartUpScript());
			}

			return sb.ToString();
		}
		

		/// <summary>
		/// Writes out the calling script for the jQuery Tabs plugin, adding options that have been
		/// a defined.
		/// </summary>
		/// <param name="tabDepth">
		/// How far to indent the script code setting.
		/// </param>
		/// <returns>
		/// Returns rendered initialisation script
		/// </returns>
		protected internal string GetControlScript(int tabDepth) {
			jStringBuilder sb = new jStringBuilder(this.Rendering.PrettyRender, this.Rendering.TabDepth);
			
			sb.IncIndent();
			sb.AppendTabsFormatIf("$(\"#{0}\").button(", this.ID);
			Core.ScriptOptions options = new Core.ScriptOptions();
			this.Options.DiscoverOptions(options);
			this.Events.DiscoverOptions(options);
			options.Render(sb);
			sb.Append(");");
			if (!string.IsNullOrEmpty(this.Events.ClickEvent)) {
				// as ClickEvent isn't a "real" jQuery UI button event, it has to be wired up separately
				sb.AppendLineIf();
				sb.AppendTabsFormatLineIf("$(\"#{0}\").click(function() {{", this.ID);
				sb.Append(this.Events.ClickEvent);
				sb.AppendLineIf();
				sb.AppendTabsLineIf("});");
			}
			sb.DecIndent();
						
			return sb.ToString();
		}

		/// <summary>
		/// Renders the opening tag for the PushButton control.
		/// </summary>
		/// <param name="sb">StringBuilder to add the opening tag to</param>
		protected void RenderOpeningTag(jStringBuilder sb) {
			switch (this.InputType) {
				// intentional fallthrough
				case Core.ButtonType.eButtonType.Reset:
				case Core.ButtonType.eButtonType.Submit:
					sb.AppendFormat("<input type=\"{0}\" value=\"{1}\"", Core.ButtonType.ButtonTypeToString(this.InputType), this.Label);
					break; 
				case Core.ButtonType.eButtonType.Hyperlink:
					sb.AppendFormat("<a href=\"{0}\"", this.Href);
					break;
				case Core.ButtonType.eButtonType.Button:
					sb.Append("<button");
					break;
				default:
					throw new NotSupportedException(string.Format("Tag type {0} is not supported.", this.InputType.ToString()));
			}

		}

		/// <summary>
		/// Adds the content to appear between the opening and closing tags of the PushButton control.
		/// </summary>
		/// <param name="sb"></param>
		protected void RenderTagContent(jStringBuilder sb) {
			if (!Core.ButtonType.IsInputButton(this.InputType) && !string.IsNullOrEmpty(this.Label)) {
				// Label applied through the Value attribute for an INPUT tag, so only add tag content
				// for "a" and "button" tags
				sb.Append(">");
				sb.Append(this.Label);
			}
		}

		/// <summary>
		/// Renders the closing tag for the PushButton control.
		/// </summary>
		/// <param name="sb">StringBuilder to add the closing tag to</param>
		protected void RenderClosingTag(jStringBuilder sb) {
			if (Core.ButtonType.IsInputButton(this.InputType)) 
				sb.Append(" />");
			else 
				sb.AppendFormat("</{0}>", Core.ButtonType.ButtonTypeToString(this.InputType));
		}

	}

}
