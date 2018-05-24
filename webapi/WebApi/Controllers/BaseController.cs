using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public abstract class BaseController<TEntity> : Controller
    {
        public BaseController()
        {
            
        }
    }
}