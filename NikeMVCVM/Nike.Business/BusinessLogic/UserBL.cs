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
    }
}
