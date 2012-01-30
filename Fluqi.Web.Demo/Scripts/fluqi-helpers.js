
var line_num = 1;


/// <summary>
/// Simply adds a string to the logger at the right hand side of the screen
/// so we can see what's going on.
/// </summary>
function addToLog(report) {
	var logElement = $("#log");

	if (logElement.length > 0) {
		var html = logElement.html();

		html = line_num + ": " + report + "<br/>" + html;

		logElement.html(html);

		line_num++;
	}
}


/// <summary>
/// Builds up a string for reporting values from the UI, so in the dialog resize
/// event for instance we have a label of "ui.originalPosition(top,left)" with a 
/// value of [for example] 200,301.  There isn't a lot of room in the events log
/// so this builds up a string with the key & value but reduces the size of the 
/// label to allow the full value to appear in the log (which is more important)
/// </summary>
function buildKeyValue(key, value, maxLen) {
	if (key == null) key = "";
	if (value == null) value = "";

	var full = key + ": " + value;

	if (full.length < maxLen)
		// no probs we can handle that
		return full;

	// value most important so do that first
	var fullValue = showFirstOfString(value, maxLen);

	var maxLabelLen = (fullValue.length > maxLen ? 0 : maxLen - fullValue.length);

	var shortKey = showFirstOfString(key, maxLabelLen)

	shortKey = "<span title='" + key + "'>" + shortKey + "</span>";

	return shortKey + ": " + fullValue;
}


/// <summary>
/// Shortens a given string to "showN" length if the "value" is too
/// long.  So if we only want to show 10 characters "The quick brown lazy fox"
/// would become "The quick .."
/// </summary>
function showFirstOfString(value, showN) {
	if (value == null)
		return "";

	value = value.toString();
	if (value.length < showN)
		return value;

	return value.substr(0, showN) + "..";
}

function showValue(value, prompt) {
	if (prompt == null || prompt.length == 0)
		prompt = "Value is:";

	prompt += "\n\n" + value;

	alert(prompt);
}

function getValue(askFor) {
	if (askFor == null || askFor.length == 0)
		aksFor = "What value?";

	return prompt(askFor, "");
}

function clearLog() {
	var logElement = $("#log");

	logElement.val("");
}

$(document).ready(function() {
	var logH = $("#controlTab").height();

	$("#log").css("min-height", logH);

	$("#ResetLog").click(
		function() { 
			$("#log").html("");
			return false;
		} 
	);

	// activate the themeSwitcher widget
	// jQuery UI site looks a bit unreliable, so it's commented out during dev
	$('#themeswitcher').themeswitcher();

	// little bit lazy this .. just getting the log panel to line up with the example in the demo builder
	var elements = window.location.href.toString().split("/");
	if (elements != null && elements.length > 0) {
		var demo = elements[ elements.length-1 ];
		var newMargin = "";

		if (demo == "AutoComplete")
			newMargin = "3.5em";
		else if (demo == "PushButton")
			newMargin = "3.6em";
		else if (demo == "DatePicker")
			newMargin = "3.5em";
		else if (demo == "Dialog")
			newMargin = "1em";
		else if (demo == "ProgressBar")
			newMargin = "3.3em";
		else if (demo == "Slider")
			newMargin = "4em";

		$("#switchPanel").css("margin-top", newMargin);
	}


});
