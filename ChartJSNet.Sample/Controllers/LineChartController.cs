using System.Collections.Generic;
using System.Web.Mvc;
using ChartJS.NET.Charts.Line;

namespace ChartJS.NET.Sample.Controllers
{
    public class LineChartController : Controller
    {
        public ActionResult Index()
        {
            var LineChart = new LineChart();

            LineChart.Data.Datasets = new List<LineDataSet>
            {
                new LineDataSet
                {
                    Label = "First Dataset",
                    FillColor = "rgba(220, 220, 220, 0.5)",
                    StrokeColor = "rgba(220, 220, 220, 0.8)",
                    PointColor = "rgba(220, 220, 220, 0.75)",
                    PointStrokeColor = "#fff",
                    PointHighlightFill = "#fff",
                    PointHighlightStroke = "rgba(220,220,220,1)",
                    Data = new double[] {65, 59, 80, 81, 56, 55, 40}
                },
                new LineDataSet
                {
                    Label = "Second Dataset",
                    FillColor = "rgba(151,187,205,0.2)",
                    StrokeColor = "rgba(151,187,205,1)",
                    PointColor = "rgba(151,187,205,1)",
                    PointStrokeColor = "#fff",
                    PointHighlightFill = "#fff",
                    PointHighlightStroke = "rgba(151,187,205,1)",
                    Data = new double[] {28, 48, 40, 19, 86, 27, 90}
                }
            };

            LineChart.Data.Labels = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July"
            };


            //LineChart.ChartConfig.ScaleGridLineColor = "rgba(0,0,0, 1)";
            //LineChart.ChartConfig.ScaleGridLineWidth = 2;
            //LineChart.ChartConfig.ScaleShowGridLines = true;
            //LineChart.ChartConfig.ScaleShowHorizontalLines = true;

            return View(LineChart);
        }
    }
}