

namespace back.Web.Controllers
{
    using back.Web.Data.Entities;
    using back.Web.Helpers;
    using back.Web.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    public class AccountController : Controller
    {
        private readonly IUserHelper userHelper;
        private readonly IConfiguration configuration;

        public AccountController(IUserHelper userHelper, IConfiguration configuration)
        {
            this.userHelper = userHelper;
            this.configuration = configuration;
        }    

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {

            }
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateToken([FromBody] LoginViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.userHelper.GetUserByEmailAsync(model.Username);
                if (user != null)
                {
                    var result = await this.userHelper.ValidatePasswordAsync(
                        user,
                        model.Password);
                    if (result.Succeeded)
                    {
                        var claims = new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Sub,user.Email),
                            new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                        };

                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["Tokens:Key"]));
                        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken( 
                            this.configuration["Tokens:Issuer"],
                            this.configuration["Tokens:Audience"],
                            claims,
                            expires: DateTime.UtcNow.AddDays(15),
                            signingCredentials: credentials
                            );

                        var results = new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo
                        };

                        return this.Created(string.Empty, results);

                    }
                }
            }
            return this.BadRequest();
        }

        public IActionResult Register()
        {
            return this.View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterNewUserViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.userHelper.GetUserByEmailAsync(model.Username);
                if (user == null)
                {
                    user = new User
                    {
                        FirstName = model.FirtsName,
                        lastName = model.LastName,
                        Email = model.Username,
                        UserName = model.Username
                    };
                    var result = await this.userHelper.AddUserAsync(user, model.Password);
                    if(result != IdentityResult.Success)
                    {
                        this.ModelState.AddModelError(string.Empty, "El usuario no fue creado");
                        return this.View(model);
                    }              
                }
            }
            return this.View(model);

        }

    }
}
