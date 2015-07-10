$(document).ready(function() { 
	var helpButton = document.getElementById("topNavbarButtons8");
	var topDDL = document.getElementById("topDropDown");
	var loginBtn = document.getElementById("loginButton");

	helpButton.addEventListener("mouseover", helpHover);
	helpButton.addEventListener("click", helpClick);
	helpButton.addEventListener("mouseout", helpMouseOut);
	loginBtn.addEventListener("mouseover", loginHover);
	topDDL.addEventListener("mouseover", topDDLover);
	topDDL.addEventListener("mouseout", topDDLoverOut);
	

	function helpHover() {	
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
	}

	function helpClick() {
		location.href = "help.html";		
	}

	setTimeout(helpMouseOut, 4000);

	function helpMouseOut() {			
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(500).fadeOut(0);		
	}

	function topDDLover() {	
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);	
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(0).fadeIn(0);			
	}

	function topDDLoverOut() {
		$("#topNavbar").find('.dropdown-menu').stop(false, false).delay(500).fadeOut(0);
	}







});







