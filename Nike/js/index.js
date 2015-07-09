$(document).ready(function() { 
	var helpButton = document.getElementById("topNavbarButtons8");
	var topDDL = document.getElementById("topDropDown");

	helpButton.addEventListener("mouseover", helpHover);
	helpButton.addEventListener("click", helpClick);
	helpButton.addEventListener("mouseout", helpMouseOut);
	topDDL.addEventListener("mouseover", topDDLover);
	topDDL.addEventListener("mouseout", topDDLoverOut);

	function helpHover() {
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
	}

	function helpClick() {
		location.href = "help.html";		
	}

	function helpMouseOut() {	
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeOut(0);
	}

	function topDDLover() {
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
	}

	function topDDLoverOut() {
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeOut(0);
	}
});
