using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;
using System.Text;

namespace Fluqi.Core
{
	/// <summary>
	/// Models the Event interaction options for controls, e.g. mouseover, click, keydown, etc.
	/// </summary>
	public class BrowserEvent
	{
#pragma warning disable 1591
		/// <summary>
		/// Models the Event interaction options for controls, e.g. mouseover, click, keydown, etc.
		/// </summary>
		/// <remarks>
		/// Whilst a control may allow a given BrowserEvent to be specified, this does not mean it's
		/// an appropriate event to use.
		/// </remarks>
		public enum eBrowserEvent: byte {
			None = 1,
			Blur = 2,
			Change = 3,
			Click = 4,
			DblClick = 5,
			Focus = 6,
			FocusIn = 7,
			FocusOut = 8,
			Hover = 9,
			KeyDown = 10,
			KeyPress = 11,
			KeyUp = 12,
			MouseDown = 13,
			MouseEnter = 14,
			MouseLeave = 15,
			MouseMove = 16,
			MouseOut = 17,
			MouseOver = 18,
			MouseUp = 19,
			Resize = 20,
			Scroll = 21,
			Select = 22,

			LBound = Blur,
			UBound = Select
		}
#pragma warning restore 1591


		/// <summary>
		/// Converts the BrowserEvent option into a string.
		/// </summary>
		/// <param name="browserEvent">BrowserEvent option to convert</param>
		/// <returns>Converted string</returns>
		public static string BrowserEventToString(eBrowserEvent browserEvent) {
			switch (browserEvent) {
				case eBrowserEvent.None: return "none";
				case eBrowserEvent.Blur: return "blur";
				case eBrowserEvent.Change: return "change";
				case eBrowserEvent.Click: return "click";
				case eBrowserEvent.DblClick: return "dblclick";
				case eBrowserEvent.Focus: return "focus";
				case eBrowserEvent.FocusIn: return "focusin";
				case eBrowserEvent.FocusOut: return "focusout";
				case eBrowserEvent.Hover: return "hover";
				case eBrowserEvent.KeyDown: return "keydown";
				case eBrowserEvent.KeyPress: return "keypress";
				case eBrowserEvent.KeyUp: return "keyup";
				case eBrowserEvent.MouseDown: return "mousedown";
				case eBrowserEvent.MouseEnter: return "mouseenter";
				case eBrowserEvent.MouseLeave: return "mouseleave";
				case eBrowserEvent.MouseMove: return "mousemove";
				case eBrowserEvent.MouseOut: return "mouseout";
				case eBrowserEvent.MouseOver: return "mouseover";
				case eBrowserEvent.MouseUp: return "mouseup";
				case eBrowserEvent.Resize: return "resize";
				case eBrowserEvent.Scroll: return "scroll";
				case eBrowserEvent.Select: return "select";
			}

			throw new ArgumentException(string.Format("BrowserEvent has an invalid value ({0}).", browserEvent.ToString()));
		}


		/// <summary>
		/// Converts the BrowserEvent option into a string.
		/// </summary>
		/// <param name="browserEvent">BrowserEvent option to convert</param>
		/// <returns>Converted string</returns>
		public static string BrowserEventToString(int browserEvent) {
			return BrowserEventToString((eBrowserEvent) browserEvent);
		}


		/// <summary>
		/// Converts a string into a BrowserEvent into an enum option.
		/// </summary>
		/// <param name="browserEvent">String to convert</param>
		/// <returns>Converted option</returns>
		public static eBrowserEvent StringToBrowserEvent(string browserEvent) {
			if (string.IsNullOrEmpty(browserEvent))
				return eBrowserEvent.None;

			eBrowserEvent be = (eBrowserEvent) Enum.Parse(typeof(eBrowserEvent), browserEvent, true/*ignoreCase*/);
			return be;
		}


		/// <summary>
		/// Returns all the enumeration items as list;
		/// </summary>
		/// <returns></returns>
		public static List<string> ToList() {
			List<string> browserEvents = new List<string>( Enum.GetNames(typeof(eBrowserEvent)) );
				
			// Remove the LBound/UBound
			browserEvents.Remove("LBound");
			browserEvents.Remove("UBound");

			return browserEvents;
		}


		/// <summary>
		/// Converts a list of BrowserEvents into a (space) separated string.  Note BrowserEvents 
		/// specified as "None" are excluded.
		/// </summary>
		/// <param name="browserEvents"></param>
		/// <returns></returns>
		public static string BrowserEventsToString(List<eBrowserEvent> browserEvents) {
			List<string> strBrowserEvents = (
				from p 
					in browserEvents 
				where p != eBrowserEvent.None
				select BrowserEventToString(p)
			).ToList<string>();

			return strBrowserEvents.ToSeparated(" ");
		}

	} // BrowserEvent
	
} // ns

