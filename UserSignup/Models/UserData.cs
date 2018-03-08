using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.ViewModels;

namespace UserSignup.Models
{
    public class UserData
    {
    //Fields
        static List<User> Users = new List<User>();

    //Methods
        public static void Add(User user)
        {
            Users.Add(user);
        }

        public static List<User> GetAll()
        {
            return Users; 
        }

        public static User GetById(int id)
        {
            var thisGuy = Users.First(u => u.UserId == id);
            return thisGuy;
        }

        public static User ConvertToUser(SignInViewModel signInViewModel)
        {
            var thisGuy = Users.Single(u => u.Username == signInViewModel.Username);
            return thisGuy;
        }

        public static bool Registered(User user)
        {
            return Users.Contains(user);
        }
    }
}
