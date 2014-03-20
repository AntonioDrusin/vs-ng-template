// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Web.Optimization;

namespace AngularApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css/app").Include("~/app/app.css"));

            bundles.Add(new ScriptBundle("~/js/app")
                .Include("~/vendor/scripts/jquery-{version}.js")
                .Include("~/vendor/scripts/angular.js")
                .Include("~/vendor/scripts/angular-ui-router.js")
                .IncludeDirectory("~/app/", "app.js", true)
                .IncludeDirectory("~/app/", "*-service.js", true)
                .IncludeDirectory("~/app/", "*-directive.js", true)
                .IncludeDirectory("~/app/", "*-filter.js", true)
                .IncludeDirectory("~/app/", "*-controller.js", true)
            );

            bundles.Add(new ScriptBundle("~/js/testapp")
                .Include("~/vendor/scripts/jquery-{version}.js")
                .Include("~/vendor/scripts/angular.js")
                .Include("~/vendor/scripts/angular-mocks.js")
                .Include("~/vendor/scripts/angular-ui-router.js")
                .IncludeDirectory("~/app/", "app.js", true)
                .IncludeDirectory("~/app/", "*-service.js", true)
                .IncludeDirectory("~/app/", "*-directive.js", true)
                .IncludeDirectory("~/app/", "*-filter.js", true)
                .IncludeDirectory("~/app/", "*-controller.js", true)
            );

            bundles.Add(new ScriptBundle("~/js/specs")
                .IncludeDirectory("~/app/", "*.spec.js", true)
                );


        }
    }
}