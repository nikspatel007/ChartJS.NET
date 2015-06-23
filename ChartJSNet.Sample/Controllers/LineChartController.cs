using System.Collections.Generic;
using System.Web.Mvc;
using ChartJS.NET.Charts.Line;

namespace ChartJS.NET.Sample.Controllers
{
    public class LineChartController : Controller
    {
        public ActionResult Index()
        {
            //var LineChart = new LineChart();

            //LineChart.Data.Datasets = new List<LineDataSet>
            //{
            //    new LineDataSet
            //    {
            //        Label = "First Dataset",
            //        FillColor = "rgba(220, 220, 220, 0.5)",
            //        StrokeColor = "rgba(220, 220, 220, 0.8)",
            //        PointColor = "rgba(220, 220, 220, 0.75)",
            //        PointStrokeColor = "#fff",
            //        PointHighlightFill = "#fff",
            //        PointHighlightStroke = "rgba(220,220,220,1)",
            //        Data = new double[] {65, 59, 80, 81, 56, 55, 40}
            //    },
            //    new LineDataSet
            //    {
            //        Label = "Second Dataset",
            //        FillColor = "rgba(151,187,205,0.2)",
            //        StrokeColor = "rgba(151,187,205,1)",
            //        PointColor = "rgba(151,187,205,1)",
            //        PointStrokeColor = "#fff",
            //        PointHighlightFill = "#fff",
            //        PointHighlightStroke = "rgba(151,187,205,1)",
            //        Data = new double[] {28, 48, 40, 19, 86, 27, 90}
            //    }
            //};

            //LineChart.Data.Labels = new List<string>
            //{
            //    "January",
            //    "February",
            //    "March",
            //    "April",
            //    "May",
            //    "June",
            //    "July"
            //};


            var lineChart = new LineChart();

            lineChart.Data.Datasets = new List<LineDataSet>(){
                new LineDataSet(){
                    Data = new double[] { 405, 405, 405, 405, 405, 405, 405, 405 },
                    Label = "Daily Goal in Minutes",
                    FillColor = "rgba(255,255,255,1)"
                },
                new LineDataSet(){
                    Data = new double[] { 50, 100, 150, 200, 250, 300, 350, 405 },
                    Label = "Hourly Goal in Minutes",                    
                    FillColor = "rgba(151,187,205,0.2)",
                    StrokeColor = "rgba(151,187,205,1)",
                    PointColor = "rgba(151,187,205,1)",
                    PointStrokeColor = "#fff",
                    PointHighlightFill = "#fff",
                    PointHighlightStroke = "rgba(151,187,205,1)"
                },
                new LineDataSet(){
                    Data = new double[] { 35, 135, 175, 185, 270, 325, 365, 450 },
                    Label = "Actual Work in Minutes",
                    FillColor = "rgba(220,220,220,0.2)",
                    StrokeColor = "rgba(220,220,220,1)",
                    PointColor = "rgba(220,220,220,1)",
                    PointStrokeColor = "#fff",
                    PointHighlightFill = "#fff",
                    PointHighlightStroke = "rgba(220,220,220,1)"
                }
            };

            lineChart.Data.Labels = new List<string>()
            {
                "1st hour",
                "2nd hour",
                "3rd hour",
                "4th hour",
                "5th hour",
                "6th hour",
                "7th hour",
                "8th hour"
            };

            lineChart.ChartConfig.DatasetFill = false;

            lineChart.CanvasProperties.CanvasId = "line-chart-time";
            lineChart.CanvasProperties.CssClass = "chart bar-chart";
            return View(lineChart);
        }
    }
}