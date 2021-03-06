﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRouteHandler.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.MicroKernel;
using Castle.Windsor;

namespace AngularApp.Routing
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _kernel;

        public WindsorControllerFactory(IKernel kernel)
        {
            _kernel = kernel;
        }

        public override void ReleaseController(IController controller)
        {
            _kernel.ReleaseComponent(controller);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(404,
                    string.Format("The controller for path '{0}' could not be found.",
                        requestContext.HttpContext.Request.Path));
            }
            return (IController) _kernel.Resolve(controllerType);
                        
        }
    }

    public class WindsorControllerActivator : IHttpControllerActivator
    {
        private readonly IWindsorContainer _container;

        public WindsorControllerActivator(IWindsorContainer container)
        {
            _container = container;
        }

        public IHttpController Create(
            HttpRequestMessage request,
            HttpControllerDescriptor controllerDescriptor,
            Type controllerType)
        {
            var controller =
                (IHttpController)this._container.Resolve(controllerType);

            request.RegisterForDispose(
                new Release(
                    () => this._container.Release(controller)));

            return controller;
        }

        private class Release : IDisposable
        {
            private readonly Action _release;

            public Release(Action release)
            {
                _release = release;
            }

            public void Dispose()
            {

                _release();
            }
        }
    }
}