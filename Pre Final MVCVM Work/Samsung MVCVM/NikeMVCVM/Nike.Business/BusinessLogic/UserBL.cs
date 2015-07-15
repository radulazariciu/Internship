using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike.Business.ViewModels;
using Nike.DataLayer.Mappers;
using Nike.DataLayer.Models;

namespace Nike.Business.BusinessLogic
{
    public static class UserBL
    {
               
        public static Boolean CheckCredentials(LoginVM userVm)
        {
            UserMapper userMapper = new UserMapper();
            List<User> parsedList = userMapper.GetAllUsers();

            foreach (var item in parsedList)
            {
                if ((item.emailAddress == userVm.EmailAddress) && (item.Password == userVm.Password))
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddUser(RegisterVM registerVm)
        {
            UserMapper userMapper = new UserMapper();
            User newUser = new User(registerVm.Password,registerVm.emailAddress, registerVm.DateOfBirth,registerVm.Zipcode,
                registerVm.Gender, registerVm.ScreenName, registerVm.LastName, registerVm.FirstName);

            userMapper.addUser(newUser);
        }


        public static Boolean registerUser(RegisterVM registerVm)
        {
            UserMapper userMapper = new UserMapper();
            User newUser = new User(registerVm.Password, registerVm.emailAddress, registerVm.DateOfBirth, registerVm.Zipcode,
                registerVm.Gender, registerVm.ScreenName, registerVm.LastName, registerVm.FirstName);

            Boolean succes = userMapper.checkUserExists(newUser);
            if (!succes)
            {
                userMapper.addUser(newUser);
                return true;
            }
            return false;
        }
    }
}
