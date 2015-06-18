using ChartJS.NET.Charts.Pie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartJSNet.Sample.Controllers
{
    public class PieChartController : Controller
    {
        // GET: PieChart
        public ActionResult Index()
        {
            PieChart pieChart = new PieChart();

            pieChart.Data =  new List<PieChartData>(){
                     new PieChartData() {
                    Value = 300,
                    Color = "#F7464A",
                    Highlight = "#FF5A5E",
                    Label = "Red"
                },
                new PieChartData() {
                    Value = 50,
                    Color = "#46BFBD",
                    Highlight = "#5AD3D1",
                    Label = "Green"
                },
                new PieChartData() {
                    Value = 100,
                    Color = "#FDB45C",
                    Highlight = "#FFC870",
                    Label = "Yellow"
                }
            };

            return View(pieChart);
        }
    }
}