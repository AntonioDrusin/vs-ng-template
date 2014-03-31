// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRouteHandler.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Web.Http.Controllers;
using AngularApp.Concerns;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace AngularApp
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For(typeof (IStore<>))
                    .ImplementedBy(typeof (Store<>)),
                Classes.FromThisAssembly()
                    .BasedOn<IHttpController>()
                    .LifestyleTransient()
                );
        }
    }
}