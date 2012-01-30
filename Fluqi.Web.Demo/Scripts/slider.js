
function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function startEvent(event, ui) {
	addToLog("START EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.value", ui.value, 28)
		+ "<br/>- ui.handle.outerHTML: .."
	);
}

function slideEvent(event, ui) {
	addToLog(
		"SLIDE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.value" + ui.value, 28)
		+ "<br/>- ui.handle.outerHTML: .."
	);	
}

function changeEvent(event, ui) {
	addToLog("CHANGE EVENT"
		+ "<br/>- event.type: " + showFirstOfString(event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.value", ui.value, 28)
		+ "<br/>- ui.handle.outerHTML: .."
	);
}

function stopEvent(event, ui) {
	addToLog("STOP EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.value", ui.value, 28)
		+ "<br/>- ui.handle.outerHTML: ..."
	);
}

