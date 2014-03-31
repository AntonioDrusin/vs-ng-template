// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics;
using System.Web.Http;

namespace AngularApp.Api
{
    public class ServiceController : ApiController
    {
        // GET api/service
        public ServiceInformation Get(string name)
        {
            return new ServiceInformation {Name = string.Format("Hello, {0}", name)};
        }

        public void Post(ServiceInformation data)
        {
            Debug.Print(data.Name);
        }
    }
}