using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jDialog {

	/// <summary>
	/// Set of properties to be applied to the button(s) added to the dialog, and the responsibility for how
	/// they are scripted out to the page.
	/// </summary>
	public class ButtonOptions: Core.Options {

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Dialog object to define options for</param>
		public ButtonOptions(jDialog.Options options) 
		 : base()
		{
			this.DialogOptions = options;
			this.Buttons = new List<Button>();
		}

		/// <summary>
		/// Holds a reference to the Options class of the Dialog (so the fluent interface can
		/// be maintained and the caller can return back to the dialog to continue the configuration)
		/// </summary>
		public jDialog.Options DialogOptions { get; set; }

		/// <summary>
		/// The set of buttons to be added to the dialog.
		/// </summary>
		protected internal List<Button> Buttons { get; set; }


		/// <summary>
		/// Adds a button definition to the dialog to be rendered when the dialog is shown.
		/// </summary>
		/// <param name="label">What the user sees on the button.</param>
		/// <param name="methodSource">JavaScript to be executed when the button is clicked.</param>
		/// <returns></returns>
		public ButtonOptions AddButton(string label, string methodSource) {
			this.Buttons.Add( 
				new Button() { 
					Label = label, 
					ClickEvent = methodSource 
				} 
			);
			return this;
		}


		/// <summary>
		/// Used to flag that configuration of <see cref="ButtonOptions"/> has finished, and 
		/// returns the <see cref="Dialog"/> object so we can continue defining Dialog attributes.
		/// </summary>
		/// <returns>Returns <see cref="Dialog"/> object to return chaining to the Dialog object</returns>
		public jDialog.Options Finish() {
			return this.DialogOptions;
		}


		/// <summary>
		/// Builds up a set of options the control can use (i.e. jQuery UI control supports).  Which is
		/// then used in rendering the JavaScript required to initialise the control properties.
		/// </summary>
		/// <param name="options">Collection to add the identified options to</param>
		override protected internal void DiscoverOptions(Core.ScriptOptions options) {
			options.Add(GetButtonsScriptOption(false/*asChild*/));
		}


		/// <summary>
		/// Gets a script option defining the Button options to use for the Dialog control.
		/// </summary>
		/// <returns>Script option for the Buttons</returns>
		protected internal Core.ScriptOption GetButtonsScriptOptions() {
			return GetButtonsScriptOption(true/*asChild*/);
		}


		/// <summary>
		/// Gets a script option defining the Button options to use for the Dialog control.
		/// </summary>
		/// <param name="asChild">Flags that this option should be added a child</param>
		/// <returns>Script option for the Buttons</returns>
		protected internal Core.ScriptOption GetButtonsScriptOption(bool asChild) {
			Core.ScriptOption scriptParent = new Core.ScriptOption() {
				Key = "buttons",
				IsChild = asChild, Condition = true
			};
			Core.ScriptOptions scriptOptions = scriptParent.ChildOptions;
			 
			foreach (Button btn in this.Buttons) {
				string label = string.Format("\"{0}\"", btn.Label);

				scriptOptions.AddEventHandler(label, ""/*no params for event*/, btn.ClickEvent);
			}

			return scriptParent;
		}

	}

}
