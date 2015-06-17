using ChartJS.NET.Charts;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ChartJS.NET.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString CreateChart<TChartOptions>(this HtmlHelper helper, 
            BaseChart<TChartOptions> chartOptions) where TChartOptions : GlobalOptions
        {

            string dataSets = string.Format(@"[{{{0}}}]", string.Join(",", chartOptions.Data));
            string labels = string.Join(",", chartOptions.Labels);

            string canvasMarkup = string.Format("<canvas id='{0}' width='{1}' height='{2}' class='{3}'></canvas>",
                chartOptions.CanvasProperties.CanvasId, chartOptions.CanvasProperties.Width, chartOptions.CanvasProperties.Height,
                chartOptions.CanvasProperties.CssClass);

            var chart = string.Format(@"
                {0}
                <script type='text/javascript'>
                    var ctx = document.getElementById({1}).getContext('2d');
                    var data = {{
                        labels: [{2}],
                        datasets: {3}
                    }};

                    var chartManager = new Chart(ctx).{4}(data, {5});
                </script>", canvasMarkup, chartOptions.CanvasProperties.CanvasId, labels, dataSets, chartOptions.ChartType.ToString(), 
                          chartOptions.ChartConfig.ToJson());

            MvcHtmlString output = new MvcHtmlString(chart);

            return output;
        }

        private static string ToJson<T>(this T obj)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings() 
            { 
                ContractResolver = new CamelCasePropertyNamesContractResolver(), 
                NullValueHandling = NullValueHandling.Ignore 
            };

            return JsonConvert.SerializeObject(obj, settings);
        }
    }
}
