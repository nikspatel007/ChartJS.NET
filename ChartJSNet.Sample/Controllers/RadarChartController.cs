using System.Collections.Generic;
using System.Web.Mvc;
using ChartJS.NET.Charts.Radar;

namespace ChartJSNet.Sample.Controllers
{
    public class RadarChartController : Controller
    {
        public ActionResult Index()
        {
            var radarChart = new RadarChart();
            radarChart.Data.Datasets = new List<RadarDataSet>
            {
                new RadarDataSet
                {
                    Label = "My First dataset",
                    FillColor = "rgba(220,220,220,0.2)",
                    StrokeColor = "rgba(220,220,220,1)",
                    PointColor = "rgba(220,220,220,1)",
                    PointStrokeColor = "#fff",
                    PointHighlightFill = "#fff",
                    PointHighlightStroke = "rgba(220,220,220,1)",
                    Data = new double[] {65, 59, 90, 81, 56, 55, 40}
                },
                new RadarDataSet
                {
                    Label = "My Second dataset",
                    FillColor = "rgba(151,187,205,0.2)",
                    StrokeColor = "rgba(151,187,205,1)",
                    PointColor = "rgba(151,187,205,1)",
                    PointStrokeColor = "#fff",
                    PointHighlightFill = "#fff",
                    PointHighlightStroke = "rgba(151,187,205,1)",
                    Data = new double[] {28, 48, 40, 19, 96, 27, 100}
                }
            };

            radarChart.Data.Labels = new List<string>
            {
                "Eating",
                "Drinking",
                "Sleeping",
                "Designing",
                "Coding",
                "Cycling",
                "Running"
            };

            return View(radarChart);
        }
    }
}