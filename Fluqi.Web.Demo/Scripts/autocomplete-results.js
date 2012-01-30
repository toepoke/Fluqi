var availableTags = [
	"ActionScript",
	"AppleScript",
	"Asp",
	"BASIC",
	"C",
	"C++",
	"Clojure",
	"COBOL",
	"ColdFusion",
	"Erlang",
	"Fortran",
	"Groovy",
	"Haskell",
	"Java",
	"JavaScript",
	"Lisp",
	"Perl",
	"PHP",
	"Python",
	"Ruby",
	"Scala",
	"Scheme"
];

function autoCompleteResultsCallBack(req, add) {
	var data = [
		"Homer",
		"Marge",
		"Maggie",
		"Bart",
		"Lisa",
		"Mr Burns"
	];

	// filter the results
	var hits = [];

	for (var i=0; i < data.length; i++) {
		var item = data[i];
		// make the comparison
		var itemLower = item.toLowerCase();
		var termLower = req.term.toLowerCase();

		if (itemLower.indexOf(termLower) >= 0) 
			// push the original (non-lowercase) version back
			hits.push(item);
	} 

	// add the hits to the jQuery results callback
	add(hits);
}

