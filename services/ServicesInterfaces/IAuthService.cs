using models.ViewModels;

namespace services.ServicesInterfaces
{
    public interface IAuthService
    {
        string Login(string phone,string password);
        string SignUp(AppUserVM userVM);
    }
}