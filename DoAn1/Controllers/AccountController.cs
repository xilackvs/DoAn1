using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn1.Areas.Admin.Controllers;
using DoAn1.Areas.Admin.Models;
using DoAn1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DoAn1.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            IdentityUser user = null;
            if (ModelState.IsValid)
            {
                user = await userManager.FindByEmailAsync(model.UserName);

                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    if (await userManager.IsInRoleAsync(user, "Admin"))
                    {
                        // return RedirectToAction("Index", "Admin");
                        return RedirectToAction("Index", "Management", new { area = "Admin" });
                    }
                    if (await userManager.IsInRoleAsync(user, "Seller"))
                    {
                        // return RedirectToAction("Index", "Admin");
                        return RedirectToAction("AllOrders", "Order");
                    }
                    if (await userManager.IsInRoleAsync(user, "User"))
                    {
                        // return RedirectToAction("Index", "Admin");
                        return RedirectToAction("Index", "HomePage");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //_logger.LogInformation("User created a newaccount with password.");
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                    //await _emailSender.SendEmailConfirmationAsync(model.Email, callbackUrl);

                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    //_logger.LogInformation("User created a newaccount with password.");
                    await AddRoleUser(RoleType.User, user);
                    return await Login(new LoginViewModel
                    {
                        UserName = model.Email,
                        Password = model.Password,
                        //ReturnUrl = registerViewModel.ReturnUrl
                        
                }, returnUrl);
                }
                AddErrors(result);
            }
            // If we got this far, something failed, redisplay form
            return View(model);
        }
        private async Task AddRoleUser(RoleType type, IdentityUser user)
        {
            switch (type)
            {
                case RoleType.Admin:
                    await userManager.AddToRoleAsync(user, "Admin ");
                    break;
                case RoleType.User:
                    await userManager.AddToRoleAsync(user, "User");
                    break;
                case RoleType.Seller:
                    await userManager.AddToRoleAsync(user, "Seller");
                    break;
            }
        }
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomePageController.Index), "Home");
            }
        }
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "HomePage");
        }
    }
}