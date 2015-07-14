using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.Models;

namespace Samsung.Controllers.DataMappers
{

    public class UserDM
    {
        private static List<User> _usersList;

        public UserDM()
        {
            _usersList = new List<User>();
            Init();
        }

        private void Init()
        {
            var newUser = new User();

            newUser.Id = 1;
            newUser.firstName = "User1FN";
            newUser.secondName = "User1SN";
            newUser.email = "User1Email@techromix.coms";
            newUser.password = "User1SN";
            newUser.zipCode = 12345;
            newUser.cellPhone = "0755555555";

            _usersList.Add(newUser);

            newUser = new User();

            newUser.Id = 2;
            newUser.firstName = "User2FN";
            newUser.secondName = "User2SN";
            newUser.email = "User2Email@techromix.coms";
            newUser.password = "User2SN";
            newUser.zipCode = 12345;
            newUser.cellPhone = "0755555555";

            _usersList.Add(newUser);

            newUser = new User();

            newUser.Id = 3;
            newUser.firstName = "User3FN";
            newUser.secondName = "User3SN";
            newUser.email = "User3Email@techromix.coms";
            newUser.password = "Use3SN";
            newUser.zipCode = 12345;
            newUser.cellPhone = "0755555555";

            _usersList.Add(newUser);

        }


        public void AddUser(User user)
        {
            _usersList.Add(user);
        }

        public void RemoveUser(User user)
        {
            _usersList.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            return _usersList;
        }


        
        //Check Login credentials
        public bool checkUserLogin(User u)
        {
            var user = _usersList.FirstOrDefault(usr => usr.email == u.email);
            if (user.password == u.password)
            {
                return true;
            }
            return false;
        }
    }
    
}