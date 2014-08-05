
function changeEvent(event, ui) {
	addToLog("CHANGE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.item", ui.item, 28)
	);
}

function closeEvent(event, ui) {
	addToLog("CLOSE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function focusEvent(event, ui) {
	addToLog(
		"FOCUS EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui" + ui.value, 28)
	);	
}

function openEvent(event, ui) {
	addToLog("OPEN EVENT"
		+ "<br/>- event.type: " + showFirstOfString(event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.item", ui.value, 28)
	);
}

function selectEvent(event, ui) {
	addToLog("SELECT EVENT"
		+ "<br/>- event.type: " + showFirstOfString(event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.item", ui.value, 28)
	);
}
