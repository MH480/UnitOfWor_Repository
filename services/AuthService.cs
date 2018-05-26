using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using models.ViewModels;
using orm.Infrastructures;
using orm.OrmModels;
using services.ServicesInterfaces;

namespace services  
{
    public class AuthService : BaseService , IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AuthService(AppDbContext context,UserManager<AppUser> UserManager,SignInManager<AppUser> SignInManager) : base(context)
        {
            _userManager = UserManager;
            _signInManager = SignInManager;
        }

        public async Task<string> LogIn(string phone, string password)
        {
            var res = await _signInManager.PasswordSignInAsync(phone,password,false,false);
            if (res.Succeeded)
            return res.ToString();
            return string.Empty;
        }

        public async Task<string> LogOut()
        {
            await _signInManager.SignOutAsync();
            
            return string.Empty;
        }

        public async Task<string> SignUp(AppUserVM userVM)
        {
            var res = await _userManager.CreateAsync(new AppUser());
            if (res.Succeeded)
            {
                string errors = string.Empty;
                foreach (IdentityError item in res.Errors)
                {
                    errors = string.Concat($"{item.Code}: {item.Description} \r\n");
                }
                return errors;
            }
            return string.Empty;
        }
    }
}