using CleanArchitecture.Blazor.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Blazor.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            //var defaultUser = new ApplicationUser { UserName = "jason@clean-architecture", Email = "jason@clean-architecture" };

            //if (userManager.Users.All(u => u.Id != defaultUser.Id))
            //{
            //    await userManager.CreateAsync(defaultUser, "CleanArchitecture!");
            //}
            //Nothing to do
        }
    }
}