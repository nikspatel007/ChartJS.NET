using System.Collections.Generic;
using System.Web.Mvc;
using ChartJS.NET.Charts.Pie;
using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Sample.Controllers
{
    public class PieChartController : Controller
    {
        // GET: PieChart
        public ActionResult Index()
        {
            var pieChart = new PieChart();

            pieChart.Data = new List<PieChartData>
            {
                new PieChartData
                {
                    Value = 300,
                    Color = "#F7464A",
                    Highlight = "#FF5A5E",
                    Label = "Red"
                },
                new PieChartData
                {
                    Value = 50,
                    Color = "#46BFBD",
                    Highlight = "#5AD3D1",
                    Label = "Green"
                },
                new PieChartData
                {
                    Value = 100,
                    Color = "#FDB45C",
                    Highlight = "#FFC870",
                    Label = "Yellow"
                }
            };

            pieChart.ChartConfig.AnimationSteps = 500;
            pieChart.ChartConfig.AnimationEasing = Enums.AnimationEasing.easeInBounce;

            return View(pieChart);
        }
    }
}