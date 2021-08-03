using DjecijiKutakAPI.Entities;
using DjecijiKutakAPI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager,
                                 SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterViewModel userForRegistration)
        {
            if (userForRegistration != null && ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = userForRegistration.FirstName,
                    LastName = userForRegistration.LastName,
                    Password = userForRegistration.Password,
                    UserName = userForRegistration.UserName,
                    Email = userForRegistration.Email,
                    RegistrationDate = DateTime.Now
                };
                var result = await _userManager.CreateAsync(user, userForRegistration.Password);

                if (result.Succeeded)
                {
                    user.LastLoginDate = DateTime.Now;
                    await _userManager.AddToRoleAsync(user, "User");
                    return StatusCode(201);
                }
                else
                {
                    foreach (var x in result.Errors)
                    {
                        ModelState.AddModelError("", x.Description);
                    }
                }
        }
            return BadRequest();

        }
    }
}
