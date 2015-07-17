using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.Models;
<<<<<<< HEAD
using Samsung.Models.Validators;
using Samsung.Models.DataMappers;
=======
using Samsung.Controllers;
using Samsung.Controllers.DataMappers;
>>>>>>> 88e733912c7fd449e56c94f6fe867a5f49ca79fa

namespace Samsung.Models.BusinessLogic
{
    public class UserBL
    {
<<<<<<< HEAD
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
=======
         private UserDM _userDataMapper;

        public UserBL()
        {
            _userDataMapper = new UserDM();
        }

          public List<User> GetAllUsers()
        {
            return _userDataMapper.GetAllUsers();
>>>>>>> 88e733912c7fd449e56c94f6fe867a5f49ca79fa
        }
    }
}