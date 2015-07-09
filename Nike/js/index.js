$(document).ready(function() { 
	var helpButton = document.getElementById("topNavbarButtons8");
	helpButton.addEventListener("mouseover", helpHover);
	helpButton.addEventListener("click", helpClick);
	helpButton.addEventListener("mouseout", helpMouseOut);

	function helpHover() {
		 $("#topNavbar").find('.dropdown-menu').stop(false, false).delay(200).fadeIn(500);
		}
	function helpClick() {
		//location.href = "help.html";		
	}

	function helpMouseOut() {		
  		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(200).fadeOut(500);
	}

});
