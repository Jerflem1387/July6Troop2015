namespace WebAPIAuthentication.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPIAuthentication.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIAuthentication.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPIAuthentication.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var jeremy = userManager.FindByName("jerflem1387@gmail.com");

            if (jeremy == null)
            {
                jeremy = new ApplicationUser
                {
                    UserName = "jerflem1387@gmail.com",
                    Email = "jerflem1387@gmail.com"
                };
                userManager.Create(jeremy, "123456");
            }
        }
    }
}
