using System.Collections.Generic;
using System.Web.Mvc;
using ChartJS.NET.Charts.PolarAreaChart;
using ChartJS.NET.Infrastructure;

namespace ChartJSNet.Sample.Controllers
{
    public class PolarAreaChartController : Controller
    {
        public ActionResult Index()
        {
            var polarAreChart = new PolarAreaChart();

            polarAreChart.Data = new List<PolarAreaChartData>
            {
                new PolarAreaChartData
                {
                    Value = 300,
                    Color = "#F7464A",
                    Highlight = "#FF5A5E",
                    Label = "Red"
                },
                new PolarAreaChartData
                {
                    Value = 50,
                    Color = "#46BFBD",
                    Highlight = "#5AD3D1",
                    Label = "Green"
                },
                new PolarAreaChartData
                {
                    Value = 100,
                    Color = "#FDB45C",
                    Highlight = "#FFC870",
                    Label = "Yellow"
                },
                new PolarAreaChartData
                {
                    Value = 40,
                    Color = "#949FB1",
                    Highlight = "#A8B3C5",
                    Label = "Grey"
                },
                new PolarAreaChartData
                {
                    Value = 120,
                    Color = "#4D5360",
                    Highlight = "#616774",
                    Label = "Dark Grey"
                }
            };

            polarAreChart.ChartConfig.AnimationSteps = 500;
            polarAreChart.ChartConfig.AnimationEasing = Enums.AnimationEasing.easeInBounce;

            return View(polarAreChart);
        }
    }
}