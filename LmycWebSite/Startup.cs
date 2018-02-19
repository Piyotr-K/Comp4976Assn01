using LmycDataLib;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LmycWebSite.Startup))]
namespace LmycWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createAdminandRoles();
        }

        private void createAdminandRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                // created admin role 
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                // create an admin user 
                var user = new ApplicationUser();
                user.UserName = "a";
                user.Email = "a@a.a";

                string userPWD = "P@$$w0rd";

                var chkUser = UserManager.Create(user, userPWD);

                // add default User to Role Admin
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                }
            }

            if (!roleManager.RoleExists("Member"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Member";
                roleManager.Create(role);
            }

            var user1 = new ApplicationUser();
            user1.UserName = "m";
            user1.Email = "m@m.m";

            string userPWD1 = "P@$$w0rd";

            var chkUser1 = UserManager.Create(user1, userPWD1);

            // add default User to Role Member
            if (chkUser1.Succeeded)
            {
                var result1 = UserManager.AddToRole(user1.Id, "Member");
            }
        }
    }
}
