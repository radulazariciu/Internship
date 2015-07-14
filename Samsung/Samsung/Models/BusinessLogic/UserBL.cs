using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.Models;
using Samsung.Controllers;
using Samsung.Controllers.DataMappers;

namespace Samsung.Controllers.BusinessLogic
{
    public class UserBL
    {
         private UserDM _userDataMapper;

        public UserBL()
        {
            _userDataMapper = new UserDM();
        }

          public List<User> GetAllUsers()
        {
            return _userDataMapper.GetAllUsers();
        }
    }
}