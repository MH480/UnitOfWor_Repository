using models.ViewModels;
using orm.Infrastructures;
using services.ServicesInterfaces;

namespace services  
{
    public class AuthService : BaseService , IAuthService
    {
        public AuthService(AppDbContext context) : base(context)
        {
            
        }

        public string Login(string phone, string password)
        {
            throw new System.NotImplementedException();
        }

        public string SignUp(AppUserVM userVM)
        {
            throw new System.NotImplementedException();
        }
    }
}