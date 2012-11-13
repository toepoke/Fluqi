
function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function openEvent(event, ui) {
	addToLog("OPEN EVENT"
		+ "<br/>- event.type: " + showFirstOfString(event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.value", ui.value, 28)
		+ "<br/>- ui.handle.outerHTML: .."
	);
}

function closeEvent(event, ui) {
	addToLog(
		"CLOSE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.value" + ui.value, 28)
		+ "<br/>- ui.handle.outerHTML: .."
	);
}

function getDynamicToolTip() {
	var tt =
		"<p>This tooltip is dynamic and depends on the value of the name property, which currently is " +
			"<strong>" + $("#name").val() + "</strong>" +
		".</p>";
	return tt;
}
