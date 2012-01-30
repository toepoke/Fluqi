using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Fluqi.Widget.jAccordion
{
	/// <summary>
	/// Models the Panels to be added to the Accordion object
	/// </summary>
	public class Panels
	{
		/// <summary>
		/// Flags which pane is selected.
		/// </summary>
		protected internal int _CurrentPane = 0;

		/// <summary>
		/// Models the panels for the accordion
		/// </summary>
		protected List<Panel> _Panels = null;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="accordion">Accordion object the panels are related to.</param>
		public Panels(Accordion accordion)
		 : base()
		{
			this.Accordion = accordion;
			this._Panels = new List<Panel>();
		}

		/// <summary>
		/// Holds a reference to the <see cref="Accordion"/> object these events are for
		/// </summary>
		public Accordion Accordion { get; set; }

		/// <summary>
		/// Used to flag that configuration of events are completed, and 
		/// returns the <see cref="Accordion"/> object so we can continue defining Accordion attributes.
		/// </summary>
		/// <returns>Returns <see cref="Accordion"/> object to return chaining to the Accordion</returns>
		public Accordion Finish() {
			return this.Accordion;
		}

		/// <summary>
		/// Adds an accordion panel to the accordion control.
		/// </summary>
		/// <param name="title">Title to appear in the panel</param>
		/// <returns>this for chainability</returns>
		public Panels Add(string title) {
			return this.Add(title, false/*active*/);
		}


		/// <summary>
		/// Finds which Panel is defined as the active one.
		/// </summary>
		/// <returns>
		/// Returns the active panel (if one is active).
		/// Returns null if no panels are active.
		/// </returns>
		public Panel GetActivePanel() {
			foreach (Panel p in this._Panels) {
				if (p.IsActive)
					return p;
			}
			// none active
			return null;
		}


		/// <summary>
		/// Adds a accordion into the collection of tabs.  Due to the dependencies between the 
		/// accordion headings and content panes the tabs must be defined up-front
		/// </summary>
		/// <param name="title">Title of the accordion (to appear in the accordion headings)</param>
		/// <param name="active">Flags whether this accordion should be the selected accordion on page load</param>
		/// <returns>Returns Tabs object to maintain chainability</returns>
		public Panels Add(string title, bool active) {
			Panel newPanel = new Panel(this.Accordion.Writer, this.Accordion, title, active);

			this._Panels.Add(newPanel);

			return this;
		}

		/// <summary>
		/// Renders the tab content pane to the Response.
		/// </summary>
		public Panel RenderNextPane() {
			if (_CurrentPane < 0)
				throw new ArgumentException("_CurrentPane cannot be zero.", "_CurrentPane");

			if (_CurrentPane > this._Panels.Count())
				throw new Exception("All content panes have already been rendered.");

			Panel currPanel = this._Panels[_CurrentPane];

			currPanel.Render();

			_CurrentPane++;

			return currPanel;
		}


		/// <summary>
		/// Gets the underlying list of Panels on the Accordion control.
		/// </summary>
		/// <returns>List of panels on the accordion.</returns>
		/// <remarks>
		/// Note that the Panels are intentionally hidden from the caller so that the API reads more clearly.
		/// </remarks>
		public ReadOnlyCollection<Panel> ToList() {
			return this._Panels.AsReadOnly();
		}


		/// <summary>
		/// Resets the pane to be drawn (so the Accordion can be rendered multiple times if required).
		/// </summary>
		protected internal void ResetPaneIndex() {
			this._CurrentPane = 0;
		}

		/// <summary>
		/// Works out which (if any) of the content panes are marked 
		/// as the active one
		/// </summary>
		/// <returns>
		/// Returns the active accordion (if one is marked as active)
		/// Returns null otherwise
		/// </returns>
		protected internal Panel GetActivePane() {
			int activeIndex = this.GetActivePaneIndex();

			if (activeIndex >= 0) {
				return this._Panels[activeIndex];
			}

			return null;
		
		} // GetActive


		/// <summary>
		/// Works out the number of the active content pane (if one 
		/// is defined as the active one).
		/// </summary>
		/// <returns>
		/// Returns the index of the active pane (if there is one)
		/// Returns -1 if no pane is marked as active.
		/// </returns>
		protected internal int GetActivePaneIndex() {
			int activeIndex = -1;

			for (int currIndex = 0; currIndex < this._Panels.Count(); currIndex++) {
				if (this._Panels[currIndex].IsActive)
					activeIndex = currIndex;
			}

			return activeIndex;
		}

		/// <summary>
		/// Internal helper method to establish if any of the Accordion
		/// are the active one.
		/// </summary>
		/// <returns>
		/// Returns true if there is an accordion marked as active.
		/// Returns false otherwise.
		/// </returns>
		protected internal bool HasActivePane() {
			return (this.GetActivePane() != null);
		}


		/// <summary>
		/// Resets all panels to not active.
		/// </summary>
		protected internal void ResetActivePanes() {
			foreach (Panel ac in this._Panels) {
				// go directly to the underlying value rather than the property
				// ... otherwise we'll end up calling our self back and have a stackoverflow
				ac._IsActive = false;
			}
		}


		/// <summary>
		/// Work out if we have an accordion set as the active one.  If not
		/// we set the first accordion to be active.  This is necessary so we
		/// output the correct mark-up for the selected accordion (when running
		/// with the "ShowCSS" option)
		/// </summary>
		protected internal void ResolveActivePane() {
			if (!this.HasActivePane() && _Panels.Any())
				_Panels.FirstOrDefault().IsActive = true;
		}

	}

}
