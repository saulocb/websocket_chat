using ChatMalta.Api.Business;
using ChatMalta.Domain.Entities;
using ChatMalta.Domain.Interfaces;
using ChatMalta.Repository.Entities;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ChatMalta.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<ISenderBusiness, SenderBusiness>();
            
            container.RegisterType<IBaseRepository<Message>, MessageRepository>();
            container.RegisterType<IBaseRepository<Sender>, SenderRepository>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}