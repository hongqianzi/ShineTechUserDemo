using System;
using System.Collections.Generic;
using System.Text;
using UserShineTech.Models;

namespace UserShineTech.Services
{
    public interface IUserReadSerivce
    {

        User GetUser(string userId);
        User GetUser(string name, string password);

    }

    public interface IUserWirteSerivce
    {

        void CreateUser(User user);
        void EditUser(User user);


    }

  
}
