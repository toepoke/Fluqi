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
using Fluqi.Widget.jAutoComplete;
using Fluqi.Web.Demo.Helpers;
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
	public class AutoCompleteModel: BaseModel {

		public AutoCompleteModel() : base() {
			this.disabled = false;
			this.appendTo = "";
			this.autoFocus = false;
			this.delay = 300;
			this.minLength = 1;
			this.source = "";
			this.useRemoteSource = false;
			this.useJSCallBack = false;
			this.My1 = Core.Position.PositionToString( Core.Position.ePosition.Left );
			this.My2 = Core.Position.PositionToString( Core.Position.ePosition.Top );
			this.At1 = Core.Position.PositionToString( Core.Position.ePosition.Left );
			this.At2 = Core.Position.PositionToString( Core.Position.ePosition.Bottom );
			this.Collision1 = Core.Collision.CollisionToString( Core.Collision.eCollision.None );
			this.Collision2 = Core.Collision.CollisionToString( Core.Collision.eCollision.None );
		}

		public bool disabled { get; set; }
		public string appendTo { get; set; }
		public bool autoFocus { get; set; }
		public int delay { get; set; }
		public int minLength { get; set; }
		public string source { get; set; }
		
		public string My1 { get; set; }
		public string My2 { get; set; }
		public string At1 { get; set; }
		public string At2 { get; set; }
		public string Collision1 { get; set; }
		public string Collision2 { get; set; }
		public int Offset1 { get; set; }
		public int Offset2 { get; set; }

		public bool useRemoteSource { get; set; }
		public bool useJSCallBack { get; set; }

		public void ConfigureAutoComplete(AutoComplete ac) {
			ac
				.Rendering
					.SetPrettyRender(true)
				.Finish()
				.Options
					.SetDisabled(this.disabled)
					.SetAppendTo(this.appendTo)
					.SetAutoFocus(this.autoFocus)
					.SetDelay(this.delay)
					.SetMinimumLength(this.minLength)
					.Position
						.SetAt(this.At1, this.At2)
						.SetMy(this.My1, this.My2)
						.SetCollision(this.Collision1, this.Collision2)
						.SetOffset(this.Offset1, this.Offset2)
					.Finish()				
				.Finish()
			;

			if (this.showEvents) {
				ac.Events
					.SetCreateEvent("createEvent(event, ui);")
					.SetSearchEvent("searchEvent(event, ui);")
					.SetOpenEvent("openEvent(event, ui);")
					.SetFocusEvent("focusEvent(event, ui);")
					.SetSelectEvent("selectEvent(event, ui);")
					.SetCloseEvent("closeEvent(event, ui);")
					.SetChangeEvent("changeEvent(event, ui);")
				.Finish();
			}
			if (!this.prettyRender)
				ac.Rendering.Compress();
			if (this.renderCSS)
				ac.Rendering.ShowCSS();
		}

		public string JavaScriptCode(AutoComplete ac) {
			return ac.GetStartUpScript();
		}

		public string CSharpCode(AutoComplete ac) {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 0);

			sb.AppendTabsLineIf("<%");
			sb.AppendTabsFormatLineIf("Html.CreateAutoComplete(\"{0}\", {1})", ac.ID, this.GetSource());

			string optionsCode = OptionsCSharpCode();
			string positionOptionsCode = PositionsCSharpCode();
			string showEventsCode = ShowEventsCSharpCode();
			string renderCode = base.RenderCSharpCode();
			bool showOptions = (optionsCode.Length > 0 || positionOptionsCode.Length > 0 || showEventsCode.Length > 0 || renderCode.Length > 0);
			
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
			if (!Utils.IsNullEmptyOrDefault(this.appendTo, Options.DEFAULT_APPEND_TO))
				sb.AppendTabsFormatLineIf(".SetAppendTo(\"{0}\")", this.appendTo);
			if (this.autoFocus)
				sb.AppendTabsLineIf(".SetAutoFocus(true)");
			if (this.delay != Options.DEFAULT_DELAY)
				sb.AppendTabsFormatLineIf(".SetDelay({0})", this.delay);
			if (this.minLength != Options.DEFAULT_MINIMUM_LENGTH)
				sb.AppendTabsFormatLineIf(".SetMinimumLength({0})", this.minLength);

			return sb.ToString();			
		}

		protected string PositionsCSharpCode() {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 3);

			if (!string.IsNullOrEmpty(this.At1) && !string.IsNullOrEmpty(this.At2)) {
				sb.AppendTabsFormatLineIf(".SetAt(\"{0}\", \"{1}\")", this.At1, this.At2);
			} else if (!string.IsNullOrEmpty(this.At1)) {
				sb.AppendTabsFormatLineIf(".SetAt(\"{0}\")", this.At1);
			} else if (!string.IsNullOrEmpty(this.At2)) {
				sb.AppendTabsFormatLineIf(".SetAt(\"{0}\")", this.At2);
			}

			if (!string.IsNullOrEmpty(this.My1) && !string.IsNullOrEmpty(this.My2)) {
				sb.AppendTabsFormatLineIf(".SetMy(\"{0}\", \"{1}\")", this.My1, this.My2);
			} else if (!string.IsNullOrEmpty(this.My1)) {
				sb.AppendTabsFormatLineIf(".SetMy(\"{0}\")", this.My1);
			} else if (!string.IsNullOrEmpty(this.My2)) {
				sb.AppendTabsFormatLineIf(".SetMy(\"{0}\")", this.My2);
			}

			if (this.Offset1 != 0 && this.Offset2 != 0) {
				sb.AppendTabsFormatLineIf(".SetOffset({0}, {1})", this.Offset1, this.Offset2);				
			} else if (this.Offset1 != 0) {
				sb.AppendTabsFormatLineIf(".SetOffset({0})", this.Offset1);				
			} else if (this.Offset2 != 0) {
				sb.AppendTabsFormatLineIf(".SetOffset({0})", this.Offset2);				
			}

			if (!Utils.IsNullEmptyOrDefault(this.Collision1, "none") && !Utils.IsNullEmptyOrDefault(this.Collision2, "none")) {
				sb.AppendTabsFormatLineIf(".SetCollision(\"{0}\", \"{1}\")", this.Collision1, this.Collision2);
			} else if (!Utils.IsNullEmptyOrDefault(this.Collision1, "none")) {
				sb.AppendTabsFormatLineIf(".SetCollision(\"{0}\")", this.Collision1);
			} else if (!Utils.IsNullEmptyOrDefault(this.Collision2, "none")) {
				sb.AppendTabsFormatLineIf(".SetCollision(\"{0}\")", this.Collision2);
			}

			return sb.ToString();
		}

		protected string ShowEventsCSharpCode() {
			if (!this.showEvents)
				// nothing to see here
				return "";

			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 2);

			sb.AppendTabsLineIf(".SetCreateEvent(\"createEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetSearchEvent(\"searchEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetOpenEvent(\"openEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetFocusEvent(\"focusEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetSelectEvent(\"selectEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetCloseEvent(\"closeEvent(event, ui);\")");
			sb.AppendTabsLineIf(".SetChangeEvent(\"changeEvent(event, ui);\")");

			return sb.ToString();
		}



		protected string GetSource() {
			string source = "";

			// work out what the source should be
			// ... by default this is "availableTags" which is a javascript array declared client-side 
			// ... (see Scripts/autocomplete-results.js)
			source = "availableTags";	

			if (this.useRemoteSource)
				// yeah, hard coded view, but it's only a demo :)
				source = "\"/Home/AutoCompleteResults\"";
			else if (this.useJSCallBack)
				// callback declared client-side, see Scripts/autocomplete-results.js
				source = "autoCompleteResultsCallBack";

			return source;
		}

		
	}

}
