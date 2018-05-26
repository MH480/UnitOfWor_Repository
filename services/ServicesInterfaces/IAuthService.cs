using models.ViewModels;

namespace services.ServicesInterfaces
{
    public interface IAuthService
    {
        string LogIn(string phone,string password);
        string SignUp(AppUserVM userVM);

        string LogOut();
    }
}