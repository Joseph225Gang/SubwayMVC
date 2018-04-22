using System.Web;
using System.Web.Optimization;

namespace SubWayTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/jquery-{version}.js",
                        "~/assets/js/jquery-3.2.1.min.js",
                        "~/assets/js/jquery-ui.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/assets/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/js/bootstrap.js",
                      "~/assets/js/respond.js"
                      ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/assets/css/bootstrap.css",
                      "~/assets/css/site.css",
                      "~/assets/css/jquery-ui.css",
                      "~/assets/css/style.min.css"));
        }
    }
}
