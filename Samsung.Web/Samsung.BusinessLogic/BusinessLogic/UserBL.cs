using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.BusinessLogic.ViewModels;
using Samsung.DataLayer.DataMappers;
using Samsung.DataLayer.Models;
using  Samsung.DataLayer;

namespace Samsung.BusinessLogic.BusinessLogic
{
    public static class UserBL
    {
        public static Boolean CheckCredentials(LoginVM userVm)
        {
            UserMapper userMapper = new UserMapper();
            List<User> recivedList = userMapper.GetAllUsers();

            foreach (var item in recivedList)
            {
                if ((item.EmailAddress.Equals(userVm.EmailAddress)) && (item.Password.Equals(userVm.Password)))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean RegisterUser(RegisterVM registerVm)
        {
            UserMapper userMapper = new UserMapper();
            User newUser = new User(registerVm.FirstName, registerVm.LastName, registerVm.Zipcode,
                registerVm.DateOfBirth, registerVm.EmailAddress, registerVm.Password);

            Boolean succes = userMapper.CheckUserExistence(newUser);
            
            if (!succes)
            {
                getAllUsers();
                userMapper.AddUser(newUser);
                return true;
            }
            getAllUsers();
            return false;
        }


        public static void getAllUsers()
        {
            UserMapper userMapper = new UserMapper();
            Samsung_User userSamsung = new Samsung_User();
            userMapper.GetAllSamsungUsers();
        }
    }
}