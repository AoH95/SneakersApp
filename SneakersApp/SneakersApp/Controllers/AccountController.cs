using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SneakersApp.Models;
using SneakersApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SneakersApp.Data.Models;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SneakersApp.Controllers
{
    public class AccountController : BaseController
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, SneakersAppDbContext context) : base(context)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            /*if (DateTime.Now.AddYears(-18) <= model.BirthDate)
                ModelState.AddModelError("BirthDate", "Vous devez avoir plus de 18 ans.");*/

            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Lastname = model.Name,
                    Firstname = model.Firstname
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                else
                {
                    ModelState.AddModelError("", result.ToString());
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var resultat = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (resultat.Succeeded)
                {
                    if (!string.IsNullOrWhiteSpace(returnUrl))
                        return Redirect(returnUrl);
                    return RedirectToAction("index", "home");
                }

                if (resultat.IsLockedOut)
                {
                    ModelState.AddModelError("", "Le compte est bloqué.");
                }
                else
                {
                    ModelState.AddModelError("", "Email / mot de passe invalide");
                }

            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [HttpPost]
        public async Task<IActionResult> CreateToken([FromBody] JWTTokenViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByNameAsync(model.UserName);
                var signInResult = await signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                if (signInResult.Succeeded)
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SneakersJWTTokens.Key));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, model.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.UniqueName, model.UserName)
                    };
                    var token = new JwtSecurityToken(
                            SneakersJWTTokens.Issuer,
                            SneakersJWTTokens.Audience,
                            claims,
                            expires: DateTime.UtcNow.AddMinutes(30),
                            signingCredentials: creds
                        );

                    var result = new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    };
                    return Created("", result);
                }
                else
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }
    }
}