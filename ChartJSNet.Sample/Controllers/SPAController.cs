using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChartJS.NET.Sample.ViewModels;
using ChartJS.NET.Charts.Line;

namespace ChartJSNet.Sample.Controllers
{
    public class SPAController : Controller
    {
        // GET: SPA
        public ActionResult Index()
        {
            chartViewModel model = new chartViewModel();

            model.LineChart = BuildLineChart();
            model.LineChartWithOptions = BuildLineChartWithOptions();

            return View(model);
        }

        private LineChart BuildLineChart()
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

            return LineChart;
        }

        private LineChart BuildLineChartWithOptions()
        {
            var lineChart = BuildLineChart();

            if (lineChart != null)
            {
                lineChart.ChartConfig.BeizerCurve = false;
                lineChart.ChartConfig.BeizerCurveTension = 25;
            }

            return lineChart;
        }
    }
}