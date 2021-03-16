using back.Web.Data.Entities;
using back.Web.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace back.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public UserHelper(
            UserManager<User> userManager, 
            SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user,string password)
        {
            return await this.userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string emanil)
        {
            return await this.userManager.FindByEmailAsync(emanil);        
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            return await this.signInManager.PasswordSignInAsync(
                model.Username,
                model.Password,
                model.RememberMe,
                false);
        }

        public async Task LogountAsync()
        {
            await this.signInManager.SignOutAsync();
        }

        public async Task<SignInResult> ValidatePasswordAsync(User user, string password)
        {
            return await this.signInManager.CheckPasswordSignInAsync(
                user,
                password,
                false);
        }
    }
}
