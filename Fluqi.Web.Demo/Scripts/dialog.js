
function createEvent(event, ui) {
	addToLog("CREATE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function beforeClose(event, ui) {
	addToLog("BEFORE_CLOSE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function openEvent(event, ui) {
	addToLog("OPEN EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function focusEvent(event, ui) {
	addToLog("FOCUS EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function dragStartEvent(event, ui) {
// offset, position top left
	addToLog("DRAG_START EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.offset(top,left)", ui.offset.top + "," + ui.offset.left, 28)
		+ "<br/>- " + buildKeyValue("ui.position(top,left)", ui.position.top + "," + ui.position.left, 28)
	);
}

function dragEvent(event, ui) {
	addToLog("DRAG EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.offset(top,left", ui.offset.top + "," + ui.offset.left, 28)
		+ "<br/>- " + buildKeyValue("ui.position(top,left)", ui.position.top + "," + ui.position.left, 28)
	);
}

function dragStopEvent(event, ui) {
	addToLog("DRAG_STOP EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.offset(top,left)", ui.offset.top + "," + ui.offset.left, 28)
		+ "<br/>- " + buildKeyValue("ui.position(top,left)", ui.position.top + "," + ui.position.left, 28)
	);
}

function resizeStartEvent(event, ui) {
	addToLog("RESIZE_START EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.originalPosition(top,left)", ui.originalPosition.top + "," + ui.originalPosition.left, 28)
		+ "<br/>- " + buildKeyValue("ui.originalSize(h,w)", ui.originalSize.height + "," + ui.originalSize.width, 28)
		+ "<br/>- " + buildKeyValue("ui.position(top,left)", ui.position.top + "," + ui.position.left, 28)
		+ "<br/>- " + buildKeyValue("ui.size(h,w)", ui.size.height + "," + ui.size.width, 28)
	);
}

function resizeEvent(event, ui) {
	addToLog("RESIZE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.originalPosition(top,left): ", ui.originalPosition.top + "," + ui.originalPosition.left, 28)
		+ "<br/>- " + buildKeyValue("ui.originalSize(h,w)", ui.originalSize.height + "," + ui.originalSize.width, 28)
		+ "<br/>- " + buildKeyValue("ui.position(top,left)", ui.position.top + "," + ui.position.left, 28)
		+ "<br/>- " + buildKeyValue("ui.size(h,w)", ui.size.height + "," + ui.size.width, 28)
	);
}

function resizeStopEvent(event, ui) {
	addToLog("RESIZE_STOP EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
		+ "<br/>- " + buildKeyValue("ui.originalPosition(top,left)", ui.originalPosition.top + "," + ui.originalPosition.left, 28)
		+ "<br/>- " + buildKeyValue("ui.originalSize(h,w)", ui.originalSize.height + "," + ui.originalSize.width, 28)
		+ "<br/>- " + buildKeyValue("ui.position(top,left)", ui.position.top + "," + ui.position.left, 28)
		+ "<br/>- " + buildKeyValue("ui.size(h,w)", ui.size.height + "," + ui.size.width, 28)
	);

}

function closeEvent(event, ui) {
	addToLog("CLOSE EVENT"
		+ "<br/>- " + buildKeyValue("event.type", event.type, 28)
	);
}

function OKClicked(btn) {
	addToLog("OK CLICKED");
}

function CancelClicked(btn) {
	addToLog("CANCEL CLICKED");
}

