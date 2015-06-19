using System.Collections.Generic;
using System.Web.Mvc;
using ChartJS.NET.Charts.Pie;
using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Sample.Controllers
{
    public class PieChartController : Controller
    {
        public ActionResult Index()
        {
            List<PieChart> chartsList = new List<PieChart>();
            
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

            chartsList.Add(pieChart);

            var pieChart2 = new PieChart();

            pieChart2.Data = new List<PieChartData>
            {
                new PieChartData
                {
                    Value = 58,
                    Color = "#00274c",
                    Highlight = "#ffcb05",
                    Label = "Michigan Wins Over OSU"
                },
                new PieChartData
                {
                    Value = 46,
                    Color = "#bb0000",
                    Highlight = "#666666",
                    Label = "OSU Wins Over Michigan"
                },
                new PieChartData
                {
                    Value = 6,
                    Color = "#ffcb05",
                    Highlight = "#666666",
                    Label = "Ties"
                }
            };

            pieChart2.CanvasProperties.Height = 453;
            pieChart2.CanvasProperties.Width = 519;

            chartsList.Add(pieChart2);

            return View(chartsList);
        }
    }
}