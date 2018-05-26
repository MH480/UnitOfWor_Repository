using System.Threading.Tasks;
using models.ViewModels;

namespace services.ServicesInterfaces
{
    public interface IAuthService
    {
        Task<string> LogIn(string phone,string password);
        Task<string> SignUp(AppUserVM userVM);

        Task<string> LogOut();
    }
}