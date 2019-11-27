using Autofac;
using Autofac.Integration.Mvc;
using AutoFacDependencyInjection.Models;
using AutoFacDependencyInjection.Services;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

namespace AutoFacDependencyInjection
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<Product>().As<IProduct>();
            builder.RegisterType<MailService>().As<IMailService>();
            
            //builder.RegisterType<Product>().As<IProduct>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
