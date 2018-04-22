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
                        "~/Assets/js/jquery-{version}.js",
                        "~/Assets/js/jquery-3.2.1.min.js",
                        "~/Assets/js/jquery-ui.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Assets/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Assets/js/bootstrap.js",
                      "~/Assets/js/respond.js"
                      ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Assets/css/bootstrap.css",
                      "~/Assets/css/site.css",
                      "~/Assets/css/jquery-ui.css",
                      "~/Assets/css/style.min.css"));
        }
    }
}
