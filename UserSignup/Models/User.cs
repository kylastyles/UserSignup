using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
    // Fields
        private int nextId = 1;

    // Properties
        public int UserId { get; set; }

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    // Constructors
        public User()
        {
            //Default constructor
            UserId = nextId;
            nextId++;
        }
    }

}
