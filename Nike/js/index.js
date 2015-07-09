$(document).ready(function() { 
	var helpButton = document.getElementById("topNavbarButtons8");
	helpButton.addEventListener("mouseover", helpHover);
	helpButton.addEventListener("click", helpClick);
	helpButton.addEventListener("mouseout", helpMouseOut);

	function helpHover() {
		
	}

	function helpClick() {
		location.href = "help.html"
	}

	function helpMouseOut() {
		
	}

});
