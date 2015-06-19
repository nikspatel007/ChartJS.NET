using System.Web.Optimization;

namespace ChartJS.NET.Sample
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/common.js",
                "~/Scripts/Chart.js",
                "~/Scripts/easing.js",
                "~/Scripts/move-top.js",
                "~/Scripts/responsiveslides.min.js",
                "~/Scripts/wow.min.js"));


            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/themes/base/*.css",
                "~/Content/style.css",
                "~/Content/animate.css"));


            BundleTable.EnableOptimizations = true;
        }
    }
}