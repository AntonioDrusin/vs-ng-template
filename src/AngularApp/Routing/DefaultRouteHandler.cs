// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRouteHandler.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Web;
using System.Web.Routing;
using System.Web.WebPages;

namespace AngularApp.Routing
{
    public class DefaultRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            // Use cases:
            //     ~/            -> ~/app/index.cshtml
            //     ~/about       -> ~/app/about.cshtml or ~/app/about/index.cshtml
            //     ~/views/about -> ~/app/about.cshtml
            //     ~/xxx         -> ~/app/404.cshtml
            string filePath = requestContext.HttpContext.Request.AppRelativeCurrentExecutionFilePath;

            if (filePath == "~/")
            {
                filePath = "~/app/index.cshtml";
            }
            else
            {
                if (!filePath.StartsWith("~/app/", StringComparison.OrdinalIgnoreCase))
                {
                    filePath = filePath.Insert(2, "app/");
                }

                if (!filePath.EndsWith(".cshtml", StringComparison.OrdinalIgnoreCase))
                {
                    filePath += ".cshtml";
                }
            }

            IHttpHandler handler = WebPageHttpHandler.CreateFromVirtualPath(filePath);
                // returns NULL if .cshtml file wasn't found

            if (handler == null)
            {
                requestContext.RouteData.DataTokens.Add("templateUrl", "/app/404/404");
                handler = WebPageHttpHandler.CreateFromVirtualPath("~/app/404/404.cshtml");
            }
            else
            {
                requestContext.RouteData.DataTokens.Add("templateUrl", filePath.Substring(1, filePath.Length - 8));
            }

            return handler;
        }
    }
}