
function createEvent(event, ui) {
	addToLog(
		"CREATE EVENT"
		+ "<br/>- ui.header ..."
		+ "<br/>- ui.content ..."
	);
}

function activateEvent(event, ui) {
	addToLog(
		"ACTIVATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + (ui.oldHeader.length > 0 ? buildKeyValue("ui.oldHeader",  ui.oldHeader[0].innerText, 28) : "ui.oldHeader: n/a")
		+ "<br/>- " + (ui.newHeader.length > 0 ? buildKeyValue("ui.newHeader",  ui.newHeader[0].innerText, 28) : "ui.newHeader: n/a")
		+ "<br/>- ui.oldPanel: ..."
		+ "<br/>- ui.newPanel: ..."
	);
}

function beforeActivateEvent(event, ui) {
	if (ui.newHeader.text() == "My Panel 3") {
		addToLog("BEFORE_ACTIVATE EVENT" +
			"<br/>- My Panel 3 is set-up to illustrate a cancellation."
		);
		// new functionality in 1.9.0 which allows cancelling of the panel opening
		alert("My Panel 3 is set-up to illustrate a cancellation.");
		event.preventDefault();
		return;
	}

	addToLog(
		"BEFORE_ACTIVATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + (ui.oldHeader.length > 0 ? buildKeyValue("ui.oldHeader", ui.oldHeader[0].innerText, 28) : "ui.oldHeader: n/a")
		+ "<br/>- " +  (ui.newHeader.length > 0 ? buildKeyValue("ui.newHeader",  ui.newHeader[0].innerText, 28) : "ui.newHeader: n/a")
		+ "<br/>- ui.oldPanel: ..."
		+ "<br/>- ui.newPanel: ..."
	);

}

