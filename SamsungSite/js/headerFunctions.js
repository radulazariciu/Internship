$(document).ready(function() { 
	var loginArea = document.getElementById("loginLI");
	var loginText = document.getElementById("loginText");
	var loginIcon = document.getElementById("loginIcon");
	var basketIcon = document.getElementById("backetIcon");

	loginArea.addEventListener("mouseover", loginHover);
	loginArea.addEventListener("mouseleave", outOfHover);
	loginArea.addEventListener("click", redirectToLoginPage);
	basketIcon.addEventListener("click", redirectToBacketPage);
	
	function loginHover() {
		$(loginArea).css("background-color", "#20A2FF");
		$(loginText).css("color", "#F5F5F5");
		$(loginIcon).css("color", "#F5F5F5");
	}

	function outOfHover() {
		$(loginArea).css("background-color", "#F5F5F5");
		$(loginText).css("color", "#20A2FF");
		$(loginIcon).css("color", "#20A2FF");
	}

	function redirectToLoginPage() {
		window.location.replace("login.html");
	}

	function redirectToBacketPage() {
		window.location.replace("basket.html");
	}

});