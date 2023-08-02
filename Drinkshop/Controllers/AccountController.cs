using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Drinkshop.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace Drinkshop.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;    
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInmanager)
        {
            _signInManager = signInmanager;
            _userManager = userManager;
        }
        [AllowAnonymous]

        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel user)
        {
            if(ModelState.IsValid)
            {
                var userIdentity = new IdentityUser() { Email = user.Email, UserName= user.Email };
                var result = await _userManager.CreateAsync(userIdentity, user.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(userIdentity, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
            return View(user);

        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(RegisterViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, true, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else ModelState.AddModelError("", "Invalid INformation");
            }
            return View(user);


        }
        

        public async Task<IActionResult> Logout()
        {
           await _signInManager.SignOutAsync();
           return RedirectToAction("index", "home");
        }

    }
}
