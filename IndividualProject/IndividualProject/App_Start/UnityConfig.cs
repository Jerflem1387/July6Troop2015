using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using IndividualProject.Domain;
using Microsoft.AspNet.Identity;
using IndividualProject.Data.EntityFramework;
using IndividualProject.Identity;
using System;

namespace IndividualProject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager(), new InjectionConstructor("Mvc5IdentityExample"));
            container.RegisterType<IUserStore<IdentityUser, Guid>, UserStore>(new TransientLifetimeManager());
            container.RegisterType<RoleStore>(new TransientLifetimeManager());

            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}