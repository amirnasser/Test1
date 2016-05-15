using System.Web;
using System.Web.Optimization;

namespace ReactTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        $"~/{Links.Content.Scripts.jquery_1_10_2_min_js}"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        $"~/{Links.Content.Scripts.jquery_validate_js}"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            $"~/"~/Scripts/modernizr-*}"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      $"~/{Links.Content.Scripts.bootstrap_js}",
                      $"~/{Links.Content.Scripts.respond_js}"));

            bundles.Add(new StyleBundle("~/Content/Styles").Include(
                      $"~/{Links.Content.bootstrap_css}",
                      $"~/{Links.Content.Site_css}"));
        }
    }
}
