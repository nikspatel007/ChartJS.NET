using System.Web.Mvc;
using ChartJS.NET.Charts;

namespace ChartJSNet.Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ChartJS.NET.Charts.Bar.BarChart barChart = new ChartJS.NET.Charts.Bar.BarChart();

            barChart.Data = new ChartJS.NET.Models.BaseDataSet()
            {
                Data = new double[] { 65, 59, 80, 81, 56, 55, 40 }
            };

            barChart.Labels = new System.Collections.Generic.List<string>() {
                "January", "February", "March", "April", "May", "June", "July"
            };

            return View(barChart);
        }
    }
}