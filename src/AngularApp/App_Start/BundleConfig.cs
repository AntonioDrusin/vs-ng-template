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
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css/app").Include("~/app/app.css"));


                    //<script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js"></script>

            bundles.Add(new ScriptBundle("~/js/app")
                .Include("~/vendor/script/jquery-{version}.js")
                .Include("~/vendor/script/angular.js")
                .Include("~/vendor/script/angular-ui-router.js")
                .IncludeDirectory("~/app/", "*.js", true)
            );

            bundles.IgnoreList.Ignore("*.spec.js");
        }
    }
}