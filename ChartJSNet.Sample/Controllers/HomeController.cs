﻿using System.Collections.Generic;
using System.Web.Mvc;
using ChartJS.NET.Charts.Bar;

namespace ChartJSNet.Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var barChart = new BarChart();

            barChart.ChartData.Datasets = new List<BarDataSet>
            {
                new BarDataSet
                {
                    Data = new double[] {65, 59, 80, 81, 56, 55, 40},
                    Label = "First Dataset",
                    FillColor = "rgba(220, 220, 220, 0.5)",
                    StrokeColor = "rgba(220, 220, 220, 0.8)",
                    HighlightFillColor = "rgba(220, 220, 220, 0.75)",
                    HighlightStrokeColor = "rgba(220, 220, 220, 1)"
                },
                new BarDataSet
                {
                    Data = new double[] {28, 48, 40, 19, 86, 27, 90},
                    Label = "Second Dataset",
                    FillColor = "rgba(151,187,205, 0.5)",
                    StrokeColor = "rgba(151,187,205, 0.8)",
                    HighlightFillColor = "rgba(151,187,205, 0.75)",
                    HighlightStrokeColor = "rgba(151,187,205, 1)"
                }
            };

            barChart.ChartData.Labels = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July"
            };


            barChart.ChartConfig.BarDatasetSpacing = 50;
            barChart.ChartConfig.ScaleGridLineColor = "rgba(0,0,0, 1)";
            barChart.ChartConfig.ScaleGridLineWidth = 2;
            barChart.ChartConfig.ScaleShowGridLines = true;
            barChart.ChartConfig.ScaleShowHorizontalLines = true;

            return View(barChart);
        }
    }
}