namespace Goro
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Public/scripts/libraries/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Public/scripts/libraries/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Public/scripts/libraries/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Public/scripts/libraries/bootstrap.js",
                      "~/Public/scripts/libraries/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                      "~/Public/scripts/home/clients-say-about-us.js"));

            bundles.Add(new StyleBundle("~/Public/css").Include(
                      "~/Public/styles/libraries/bootstrap.css",
                      "~/Public/styles/shared/shared.css",
                      "~/Public/styles/home/solutions.css",
                      "~/Public/styles/home/assets.css",
                      "~/Public/styles/home/clients-say-about-us.css"));
        }
    }
}
