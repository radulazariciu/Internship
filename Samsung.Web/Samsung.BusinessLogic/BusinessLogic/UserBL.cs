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
            List<Samsung_User> recivedList = userMapper.GetAllSamsungUsers();

            foreach (var item in recivedList)
            {
                if ((item.emailAddress.Equals(userVm.EmailAddress)) && (item.password.Equals(userVm.Password)))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean RegisterUser(RegisterVM registerVm)
        {
            UserMapper userMapper = new UserMapper();
            Samsung_User newUser = new Samsung_User(registerVm.FirstName, registerVm.LastName, registerVm.Zipcode,
                registerVm.DateOfBirth, registerVm.EmailAddress, registerVm.Password);

            Boolean succes = userMapper.CheckUserExistence(newUser);
            
            if (!succes)
            {
                userMapper.AddUser(newUser);
                return true;
            }
            return false;
        }


        public static void GetAllSamsungUsers()
        {
            UserMapper userMapper = new UserMapper();
            Samsung_User userSamsung = new Samsung_User();
            userMapper.GetAllSamsungUsers();
        }
    }
}