using System.Text;
using System.Web.Mvc;
using ChartJS.NET.Charts;
using ChartJS.NET.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ChartJS.NET.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString BuildChart<TChart, TChartOptions>(this HtmlHelper helper,
            BaseChart<TChart, TChartOptions> chartOptions)
            where TChartOptions : class
            where TChart : BaseDataSets<TChart>
        {
            var canvasTag = new TagBuilder("canvas");
            canvasTag.Attributes.Add("width", chartOptions.CanvasProperties.Width.ToString());
            canvasTag.Attributes.Add("Height", chartOptions.CanvasProperties.Height.ToString());
            canvasTag.Attributes.Add("id", chartOptions.CanvasProperties.CanvasId);

            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");

            var tagContent = new StringBuilder();
            tagContent.AppendFormat("var ctx = document.getElementById('{0}').getContext('2d');",
                chartOptions.CanvasProperties.CanvasId);
            tagContent.AppendFormat("var data = JSON.parse('{0}');", chartOptions.ChartData.ToJson());
            tagContent.AppendFormat("var options = JSON.parse('{0}');", chartOptions.ChartConfig.ToJson());
            tagContent.AppendFormat("var {0}_newChart = new Chart(ctx).{1}(data, options);",
                chartOptions.CanvasProperties.CanvasId, chartOptions.ChartType);
            tag.InnerHtml = tagContent.ToString();

            var output = new MvcHtmlString(canvasTag + "" + tag);

            return output;
        }

        public static MvcHtmlString BuildGlobalOptions(this HtmlHelper helper, GlobalOptions globalOptions)
        {
            var tag = new TagBuilder("script");
            var tagContent = new StringBuilder();

            if (globalOptions != null)
            {
                tag.Attributes.Add("type", "text/javascript");
                tagContent.Append("Chart.defaults.global = {animate: false};"); //, globalOptions.ToJson());

                tag.InnerHtml = tagContent.ToString();
            }
            return new MvcHtmlString(tag.ToString());
        }

        private static string ToJson<T>(this T obj)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };

            return JsonConvert.SerializeObject(obj, settings);
        }
    }
}