// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Web.Http;
using AngularApp.Concerns;

namespace AngularApp.Api
{
    public class ServiceController : ApiController
    {

        private readonly IStore<ServiceInformation> _store;

        public ServiceController(IStore<ServiceInformation> store)
        {
            _store = store;
        }

        // GET api/service
        public ServiceInformation Get()
        {
            return _store.Get();
        }

        public void Post(ServiceInformation data)
        {
            _store.Put(data);
        }
    }
}