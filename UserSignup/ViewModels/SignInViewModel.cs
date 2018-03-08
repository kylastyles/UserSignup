using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.ViewModels
{
    public class SignInViewModel
    {
    // Fields
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    // Constructor
        public SignInViewModel()
        {
            //default constructor
        }
    }
}
