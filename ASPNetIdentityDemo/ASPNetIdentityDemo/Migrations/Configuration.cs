namespace ASPNetIdentityDemo.Migrations
{
    using ASPNetIdentityDemo.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNetIdentityDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ASPNetIdentityDemo.Models.ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<Role> roleStore = new RoleStore<Role>(context);
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);

            // seed roles
            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new Role { Name = "Admin" });

            if (!roleManager.RoleExists("General"))
                roleManager.Create(new Role { Name = "General" });

            // seed users
            ApplicationUser jeremy = userManager.FindByEmail("jerflem1387@gmail.com");

            if (jeremy == null)
            {
                jeremy = new ApplicationUser
                {
                    UserName = "jerflem1387@gmail.com",
                    Email = "jerflem1387@gmail.com"

                };

                IdentityResult result = userManager.Create(jeremy, "123456");
                if (result.Succeeded)
                {
                    jeremy = userManager.FindByEmail("jerflem1387@gmail.com");

                    userManager.AddToRole(jeremy.Id, "Admin");
                }
                else
                {
                    throw new Exception(result.Errors.FirstOrDefault());
                }
            }

            userManager.AddClaim(jeremy.Id, new Claim("CanEditProducts", "true"));

        }
    }
}
