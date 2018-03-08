using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            // Create ViewModel for Model Binding
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            // Show Form
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if(ModelState.IsValid)
            {
                // Create new user model
                User newUser = new Models.User
                {
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password
                };

                // Add user to list of users
                UserData.Add(newUser);

                // Send to home page
                return View("Index");
            }

            // Registration failed. Send form data back to user.
            return View(addUserViewModel);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            // Show login form
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(SignInViewModel signInViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Try to locate username in userlist.
                    User tryUser = UserData.ConvertToUser(signInViewModel);
                }
                catch (System.InvalidOperationException)
                {
                    // Send unknown user to registration page.
                    return Redirect("User/Add");
                }
            }

            User user = UserData.ConvertToUser(signInViewModel);
            // TODO validate correct password entered.

            if(UserData.Registered(user))
            {
                // Successful login redirects to home page.
                return View("Index");
            }

            // Login failed. Send form data back to user.
            return View(signInViewModel);

        }
    }
}
