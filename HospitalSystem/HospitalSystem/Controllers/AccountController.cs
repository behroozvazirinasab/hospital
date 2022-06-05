using H.Common.Constants;
using H.DataMdel.Models;
using H.DataMdel.ViewModel.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly ILogger<AccountController> _logger;

        public AccountController(
            UserManager<UserModel> userManager,
            ILogger<AccountController> logger
            )
        {
            _userManager = userManager;
            _logger = logger;
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {   
            var errors = new List<string>();
            if (ModelState.IsValid)
            {
                var user = new UserModel{
                    UserName = model.UserName,
                    Email = model.Email,
                    CreatedDateTime = DateTime.Now
                    
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation(LogCodes.RegisterCode, $"{user.UserName} create new account");
                    var activationCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //send email
                    return Json("success");
                }

                foreach(var error in result.Errors)
                {
                    errors.Add(error.Description);
                }

            }
            return BadRequest(errors);
        }

        [HttpPost]
        public IActionResult CheckUserName(string userName)
        {
            return Json(true);
        }
    }
}
