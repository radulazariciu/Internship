using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.Models;
using Samsung.Models.Validators;
using Samsung.Models.DataMappers;

namespace Samsung.Models.BusinessLogic
{
    public class UserBL
    {
        string messageToBeShown = "";
        private UserDM userDM;

        public UserBL()
        {
            userDM = new UserDM();
        }

        private bool confirmationEmailMatch(User user, string confirmationEmail)
        {
            return user.EmailAddress.Equals(confirmationEmail);
        }

        private bool confirmationPasswordMatch(User user, string confirmationPassword)
        {
            return user.Password.Equals(confirmationPassword);
        }

        private bool alreadyExistsUser(User user)
        {
            List<User> usersList = userDM.GetAllUsers();
            for (int index = 0; index < usersList.Count; index++)
            {
                if (usersList[index].EmailAddress.Equals(user.EmailAddress))
                {
                    return true;
                }
            }
            return false;
        }

        
        public void AddUser(string FirstName,string SecondName,string MonthBirthDay,string DayBirthDay,string YearBirthDay,string EmailAddress,string ConfirmEmailAddress,string FirstPartCellPhone,
            string SecondPartCellPhone,string ThirdPartCellPhone,string ZipCode,string Password,string ConfirmPassword)
        {
            messageToBeShown = "";
            User user = new User(FirstName, SecondName, new UserDateOfBirth(MonthBirthDay, YearBirthDay, DayBirthDay), EmailAddress, 
                                new UserCellPhone(FirstPartCellPhone, SecondPartCellPhone, ThirdPartCellPhone), ZipCode, Password);
            if (!confirmationEmailMatch(user,ConfirmEmailAddress))
            {
                messageToBeShown = "Email and confirmation eamail do not match";
                return;
            }
            if (!confirmationPasswordMatch(user,ConfirmPassword))
            {
                messageToBeShown = "Password and confirmationPassword do not match";
                return;
            }

            if (alreadyExistsUser(user))
            {
                messageToBeShown = "A user with specified email already exists";
                return;
            }

            try
            {
                userDM.Add(user);
                messageToBeShown = "User succesfuly added"; 
            }
            catch (InvalidUserException invalidUserException)
            {
                messageToBeShown = invalidUserException.Message;
            }

        }

        public string GetMessageToBeShown()
        {
            return this.messageToBeShown;
        }

        internal void verifyCredentials(string email, string password)
        {
             bool returnState = false;
      
            List<User> usersList = new List<User>();
            for (int index = 0; index < usersList.Count; index++)
            {
              if (( UserDM.usersList[index].EmailAddress == email )&&( UserDM.usersList[index].Password == password)) {
                returnState = true;
              }
            }
            if (returnState == true) {messageToBeShown = "User succesfuly logged"; }
            else { messageToBeShown = "User unsuccesfuly logged"; }
        }
        
    }
}