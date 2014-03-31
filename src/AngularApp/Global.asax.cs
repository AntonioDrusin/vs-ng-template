// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AngularApp.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace AngularApp
{
    public class Application : HttpApplication
    {
        private static IWindsorContainer _container;

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BoostrapContainer();
        }

        private static void BoostrapContainer()
        {
            _container = new WindsorContainer()
                .Install(FromAssembly.This());

            GlobalConfiguration.Configuration.Services.Replace(
                typeof (IHttpControllerActivator),
                new WindsorControllerActivator(_container));

            ControllerBuilder.Current.SetControllerFactory(
                new WindsorControllerFactory(_container.Kernel)
                );
        }
    }
}