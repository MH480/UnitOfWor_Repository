using System.Threading.Tasks;
using models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using services.ServicesInterfaces;

namespace WebApi.Controllers {
    public class AuthController : BaseController<object> {
        private readonly IAuthService _auth;
        public AuthController (IAuthService auth) {
            _auth = auth;
        }
        public IActionResult Index () {
            return new EmptyResult ();
        }

        [HttpGet]
        public IActionResult Login () {
            return new ContentResult { Content = "OK Get Loggin" };
        }

        [HttpPost]
        public async Task<IActionResult> Login (string phone, string password) {
            if (ModelState.IsValid) {
                var res = await _auth.LogIn (phone, password);
                return new ContentResult { Content = res };
            } else
                return new EmptyResult ();
        }

        [HttpPost]
        public async Task<IActionResult> LogUP ([FromBody] AppUserVM user) {
            var res = await _auth.SignUp (null);
            return new ContentResult { Content = res };
        }

    }
}