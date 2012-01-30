var playFrequency = [
	"every monday",
	"every tuesday",
	"every wednesday",
	"every thursday",
	"every friday",
	"every saturday",
	"every sunday"
];

function stepNext() {
	refreshWizard(+1);
}

function stepBack() {
	refreshWizard(-1);
}

function stepFinish() {
	refreshWizard();
	$("#confirmDlg").dialog("open");
}

function refreshWizard(movement) {
	var wasSelected = $("#wizard").tabs("option","selected");
	
	// -1 will move back, +1 will move forward
	var newSelected = (wasSelected + movement);

	if (newSelected >= 0/*Step1*/ && newSelected <= 2/*Finish*/) {
		// Enable/disable tabs accordingly
		refreshTabState(wasSelected, newSelected);
		refreshAccordion(wasSelected, newSelected);
		refreshButtons(wasSelected, newSelected);
		refreshProgress(wasSelected, newSelected);

		if (newSelected == 2)
			showSummary();
	}
}

function showSummary() {
	$("#summary").html(
		"<li><strong>Name:</strong>&nbsp;"          + $("#Name").val() + "</li>" +
		"<li><strong>Date of birth:</strong>&nbsp;" + $("#DateOfBirth").val() + "</li>" +
		"<li><strong>Age:</strong>&nbsp;"           + $("#Age").val() + "</li>" +
		"<li><strong>Play:</strong>&nbsp;"          + $("#HowOften").val() + "</li>" +
		"<li><strong>Duration:</strong>&nbsp;"      + $("#Duration").val() + "</li>"
	)
}

function refreshTabState(wasSelected, currSelected) {
	// We can't select a disabled tab, so need to:
	// 1 - Enable tab we're about to select
	// 2 - Select the correct tab
	// 3 - Disable tab that was selected
	$("#wizard").tabs("enable", currSelected)
	$("#wizard").tabs("option","selected", currSelected);
	$("#wizard").tabs("disable", wasSelected)
}

function changeAge(event, ui) {
	$("#Age").val( ui.value + " years" );
}

function refreshProgress(wasSelected, currSelected) {
	var newValue = 0;	// default to first step
	
	switch (currSelected) {
		case 0: newValue = 33; break;
		case 1: newValue = 66; break;
		case 2: newValue = 100; break;
	}

	$("#progress").progressbar("value", newValue);
}

function refreshAccordion(wasSelected, currSelected) {
	// Accordion doesn't seem to support disabling panels, so just activate the relevant step
	$("#sidebar").accordion("activate", currSelected);
}

function initView() {
	// set everything up as it would be for the first step
	refreshButtons(0, 0);
	$("#wizard").tabs("option","selected", 0);
	$("#wizard").tabs("disable", 1);
	$("#wizard").tabs("disable", 2);
	refreshProgress(0, 0);
}

function refreshButtons(wasSelected, currSelected) {
	var back = $("#back-button");
	var next = $("#next-button");
	var fin = $("#finish-button");

	if (currSelected == 0) {
		// First step
		back.hide();
		next.show();
		fin.hide();	
	} else if (currSelected == 2) {
		// Last step
		back.show();
		next.hide();
		fin.show();
	} else {
		back.show();
		next.show();
		fin.hide();
	}

}
