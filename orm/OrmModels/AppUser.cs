using Microsoft.AspNetCore.Identity;

namespace orm.OrmModels
{
    public class AppUser : IdentityUser
    {
        public bool IsActivated { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string UserImage { get; set; }
    }
}