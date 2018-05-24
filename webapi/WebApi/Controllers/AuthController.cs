using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AuthController : BaseController<object>
    {
        public IActionResult Index()
        {
            return new EmptyResult();
        }

        public IActionResult Login()
        {
            return new ContentResult{Content = "hi there , good to logged in"};
        }
    }
}