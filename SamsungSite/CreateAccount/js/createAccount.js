document.addEventListener("DOMContentLoaded", function(event) { 
  	var firstNameInput = document.getElementById("firstName");
  	var secondNameInput = document.getElementById("secondName");
  	var dayPickInput = document.getElementById("dayPick");
  	var monthPickInput = document.getElementById("monthPick");
  	var yearPickInput = document.getElementById("yearPick");
  	var emailAddressInput = document.getElementById("emailAddress");
  	var emailConfirmInput = document.getElementById("emailConfirm");
  	var cellPhoneInput = document.getElementById("cellPhone");
  	var zipFormInput = document.getElementById("zipForm");
  	var passwordFormInput = document.getElementById("passwordForm");
  	var passwordConfirmInput = document.getElementById("passwordConfirmForm");
  	var checkFormInput = document.getElementById("checkForm");
  	var submitData = document.getElementById("submitData");

  	firstNameInput.addEventListener("click", resetFields);
  	secondNameInput.addEventListener("click", resetFields);
  	dayPickInput.addEventListener("click", resetFields);
  	monthPickInput.addEventListener("click", resetFields);
  	yearPickInput.addEventListener("click", resetFields);
  	emailAddressInput.addEventListener("click", resetFields);
  	emailConfirmInput.addEventListener("click", resetFields);
  	cellPhoneInput.addEventListener("click", resetFields);
  	zipFormInput.addEventListener("click", resetFields);
  	passwordConfirmInput.addEventListener("click", resetFields);
  	passwordFormInput.addEventListener("click", resetFields);
  	checkFormInput.addEventListener("click", resetFields);

  	submitData.addEventListener("click", getInfos);

  	function getInfos() {
		var sendDatas = {
			firstName: firstNameInput.value,
			secondName: secondNameInput.value,
			dayPick: dayPickInput.value,
			monthPick: monthPickInput.value,
			yearPick: yearPickInput.value,
			emailAddress: emailAddress.value,
			cellPhone: cellPhoneInput.value,
			zipForm: zipFormInput.value,
			passwordForm: passwordConfirmInput.value,
			checkForm: checkFormInput.value
		};
		//console.log(sendDatas.firstName);
	}

	function resetFields(e) {

		//console.log(e.target.id);
		var selection= e.target.id;
		switch (selection) {
		case "firstName":
			if(firstNameInput.value=="") firstNameInput.value = "First Name";
			else firstNameInput.value = "";
		break;

		case "secondName":
			if(secondNameInput.value=="") secondNameInput.value = "Second Name";
			else secondNameInput.value = "";
		break;

		case "emailAddress":
			if(emailAddressInput.value=="") emailAddressInput.value = "Email Adress";
			else emailAddressInput.value = "";
		break;

		case "emailConfirm":
			if(emailConfirmInput.value=="") emailConfirmInput.value = "Confirm Email";
			else emailConfirmInput.value = "";
		break;

		case "cellPhone":
			if(cellPhoneInput.value=="") cellPhoneInput.value = "+407XXXXXXXX";
			else cellPhoneInput.value = "";
		break;

		case "zipForm":
			if(zipFormInput.value=="") zipFormInput.value = "Zip Code";
			else zipFormInput.value = "";
		break;

		case "passwordForm":
			if(passwordFormInput.value=="") passwordFormInput.value = "Password";
			else passwordFormInput.value = "";
		break;

		case "passwordConfirmForm":
			if(passwordConfirmInput.value=="") passwordConfirmInput.value = "Confirm Password";
			else passwordConfirmInput.value = "";
		break;
		}
	}
});


