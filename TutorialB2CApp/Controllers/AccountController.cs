using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;

namespace TutorialB2CApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            var redirectUrl = Url.Action(nameof(HomeController.Index), "Home");
            return Challenge(
                new AuthenticationProperties { RedirectUri = redirectUrl },
                AzureADB2CDefaults.AuthenticationScheme);
        }
    }
}