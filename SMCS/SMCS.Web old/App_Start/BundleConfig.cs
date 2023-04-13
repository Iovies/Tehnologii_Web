using System.Security.Cryptography;
using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace SMCS.Web
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

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Template integration
            // Base Site CSS Style
            bundles.Add(new StyleBundle("~/Content/style").Include(
                        "~/Content/css/style.css"));

            // Material Design Icons
            bundles.Add(new StyleBundle("~/Content/materialDesignIcons").Include(
                        "~/Content/vendors/mdi/css/materialdesignicons.min.css"));

            // ideie nu am ce-i?
            bundles.Add(new StyleBundle("~/Content/base").Include(
                        "~/Content/vendors/css/vendor.bundle.base.css"));

            // ideie nu am ce-i? 2
            bundles.Add(new Bundle("~/Content/js/base").Include(
                        "~/Content/vendors/js/vendor.bundle.base.js"));

            // Misc  (in general la momemntul dat aceasta face colapsul la sidebar gata, mai sunt unele dar nu-s imp)
            bundles.Add(new Bundle("~/Content/js/misc").Include(
                        "~/Content/js/misc.js"));
        }
    }
}