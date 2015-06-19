using ChartJS.NET.Charts.Doughnut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChartJS.NET.Infrastructure;

namespace ChartJSNet.Sample.Controllers
{
    public class DoughnutChartController : Controller
    {
        public ActionResult Index()
        {
            DoughnutChart doughnutChart = new DoughnutChart();

            doughnutChart.Data = new List<DoughnutChartData>(){
                     new DoughnutChartData() {
                    Value = 300,
                    Color = "#F7464A",
                    Highlight = "#FF5A5E",
                    Label = "Red"
                },
                new DoughnutChartData() {
                    Value = 50,
                    Color = "#46BFBD",
                    Highlight = "#5AD3D1",
                    Label = "Green"
                },
                new DoughnutChartData() {
                    Value = 100,
                    Color = "#FDB45C",
                    Highlight = "#FFC870",
                    Label = "Yellow"
                }
            };

            return View(doughnutChart);
        }
    }
}