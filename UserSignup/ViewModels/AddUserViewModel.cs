using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {

        // Fields
        [Required(ErrorMessage ="Username must be between 3 and 15 characters in length.")]
        [MinLength(3)]
        [MaxLength(15)]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(dataType: DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Verify Password")] 
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Verify { get; set; }


    // Methods


    // Constructor
        public AddUserViewModel()
        {
            //default constructor
        }
    }
}
