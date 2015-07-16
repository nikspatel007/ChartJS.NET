using System.Web.Optimization;

namespace ChartJS.NET.Sample
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //"~/Scripts/jquery.cslider.js",


            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/jquery.easing.1.3.js",
                "~/Scripts/jquery.magnific-popup.js",
                "~/Scripts/jquery.snippet.min.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/common.js",
                "~/Scripts/Chart.js",
                "~/Scripts/easing.js",
                "~/Scripts/menu.js",
                "~/Scripts/modernizr.custom.28468.js",
                "~/Scripts/owl.carousel.js",
                "~/Scripts/move-top.js",
                "~/Scripts/responsiveslides.min.js",
                "~/Scripts/wow.min.js",
                "~/Scripts/jquery.cslider.js"));


            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/themes/base/*.css",
                "~/Content/style.css",
                "~/Content/animate.css",
                "~/Content/magnific-popup.css",
                "~/Content/owl.carousel.css",
                "~/Content/slider.css",
                "~/Content/jquery.snippet.min.css",
                "~/Content/font-awesome.min.css"));


            BundleTable.EnableOptimizations = true;
        }
    }
}