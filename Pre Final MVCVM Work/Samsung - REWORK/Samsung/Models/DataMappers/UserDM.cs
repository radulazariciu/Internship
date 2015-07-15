using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.Models;
using Samsung.Models.Validators;

namespace Samsung.Models.DataMappers
{
    public class UserDM
    {
        private static List<User> usersList;

        public UserDM()
        {
            usersList = new List<User>();
            usersList.Add(new User("Andrei","Toader",new UserDateOfBirth("January","1994","18"),"tdandrey94@yahoo.com",new UserCellPhone("074","261","3662"),"242","password"));
            usersList.Add(new User("Andrei","Toader",new UserDateOfBirth("January","1994","18"),"tdandrey94@gmail.com",new UserCellPhone("074","261","3662"),"242","password"));
        }

        public void Add(User User)
        {
            try
            {
                UserValidator userValidator = new UserValidator();
                userValidator.Validate(User);
                usersList.Add(User);
            }
            catch (InvalidUserException invalidUserException)
            {
                throw invalidUserException;
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> usersListToBeReturned = new List<User>();
            for (int index = 0; index < usersList.Count; index++)
            {
                usersListToBeReturned.Add(usersList[index]);
            }
            return usersListToBeReturned;
        }
    }
}