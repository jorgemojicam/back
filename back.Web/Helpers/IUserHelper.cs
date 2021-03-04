

namespace back.Web.Helpers
{
    using back.Web.Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<IdentityResult> AddUserAsync(User user,string password);


    }
}
