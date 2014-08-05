﻿using System;
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
using Fluqi.Widget.jToolTip;
using System.IO;
using Fluqi.Helpers;

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
	public class ToolTipModel: BaseModel {

		public ToolTipModel() : base(SUPPORTS_POSITION) {
			this.disabled = false;
		}

		public string content { get; set; }
		public bool disabled { get; set; }
		public string hideEffect { get; set; }
		public string showEffect { get; set; }
		public bool track { get; set; }

		public void ConfigureToolTip(ToolTip tip) {
			tip
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options 
					.SetDisabled(this.disabled)
					.ShowAnimation
						.SetEffect(this.showEffect)
						.Finish()
					.HideAnimation
						.SetEffect(this.hideEffect)
						.Finish()
					.Position
						.SetAt(this.At1, this.At2)
						.SetMy(this.My1, this.My2)
						.SetCollision(this.Collision1, this.Collision2)
						.Finish()
					.SetTrack(this.track)
				.Finish();

			if (this.showEvents) {
				tip
					.Events
						.SetCreateEvent("return createEvent(event, ui);")
						.SetOpenEvent("return openEvent(event, ui);")
						.SetCloseEvent("return closeEvent(event, ui);")
					.Finish();
			}
			if (!this.prettyRender)
				tip.Rendering.Compress();
			if (this.renderCSS)
				tip.Rendering.ShowCSS();
		}

		public string JavaScriptCode(ToolTip tip) {
			tip.Rendering.SetPrettyRender(true);
			return tip.GetStartUpScript();
		}

		public string CSharpCode(ToolTip tip) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsLineIf("Html.CreateToolTip(\"name\")");

			string optionsCode = OptionsCSharpCode();
			string positionOptionsCode = PositionsCSharpCode();
			string showEventsCode = ShowEventsCSharpCode();
			string renderCode = base.RenderCSharpCode();
			bool showOptions = (optionsCode.Length > 0 || showEventsCode.Length > 0 || renderCode.Length > 0);
			
			if (showOptions) {
				sb.IncIndent();

				if (optionsCode.Length > 0 || positionOptionsCode.Length > 0) {
					sb.AppendTabsLineIf(".Options");
					sb.IncIndent();
					sb.Append(optionsCode);
					sb.DecIndent();
					sb.AppendTabsLineIf(".Finish()");
				}	
				if (positionOptionsCode.Length > 0) {
					sb.AppendTabsLineIf(".Options");
					sb.IncIndent();
					sb.Append(optionsCode);
					if (positionOptionsCode.Length > 0) {
						sb.AppendTabsLineIf(".Position");
						sb.Append(positionOptionsCode);
						sb.AppendTabsLineIf(".Finish()");
					}
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
			sb.AppendTabsLineIf(".Render();");
			sb.AppendTabsLineIf("%>");

			return sb.ToString();
		}

		protected string OptionsCSharpCode() {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			if (this.disabled) 
				sb.AppendTabsLineIf(".SetDisabled(true)");
			if (!string.IsNullOrEmpty(this.showEffect)) 
				sb.AppendTabsFormatLineIf(".ShowAnimation.SetEffect(\"{0}\").Finish()", this.showEffect);
			if (!string.IsNullOrEmpty(this.hideEffect)) 
				sb.AppendTabsFormatLineIf(".HideAnimation.SetEffect(\"{0}\").Finish()", this.hideEffect);
			if (this.track)
				sb.AppendTabsFormatLineIf(".SetTrack({0})", this.track.JsBool());
			
			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetCreateEvent(\"return createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetOpenEvent(\"return openEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetCloseEvent(\"return closeEvent(event, ui);\")");

			return sb.ToString();
		}

	}

}

