using System.Web;
using System.Web.Optimization;

namespace DaysProject6
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/app.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/AdminLTE.css",
                      "~/Content/main.css",
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/login").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/AdminLTE.css",
                      "~/Content/login.css",
                      "~/Content/font-awesome.min.css"));

            // Kendo
            bundles.Add(new ScriptBundle("~/bundles/kendo/js").Include(
                        "~/Scripts/Kendo/kendo.web.min.js",
                        "~/Scripts/Kendo/kendo.aspnetmvc.min.js",
                        "~/Scripts/Kendo/kendo.all.min.js"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                      "~/Kendo/kendo.common.min.css",
                      "~/Kendo/kendo.default.min.css"));

            // Angular
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-route.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Angular/app.js",
                        "~/Angular/services/factory.js",
                        "~/Angular/controllers/movieController.js"));

            bundles.IgnoreList.Clear();
        }
    }
}
