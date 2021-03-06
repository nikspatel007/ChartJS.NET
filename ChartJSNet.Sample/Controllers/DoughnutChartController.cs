﻿using System.Collections.Generic;
using System.Web.Mvc;
using ChartJS.NET.Charts.Doughnut;

namespace ChartJS.NET.Sample.Controllers
{
    public class DoughnutChartController : Controller
    {
        public ActionResult Index()
        {
            var doughnutChart = new DoughnutChart();

            doughnutChart.Data = new List<DoughnutChartData>
            {
                new DoughnutChartData
                {
                    Value = 300,
                    Color = "#F7464A",
                    Highlight = "#FF5A5E",
                    Label = "Red"
                },
                new DoughnutChartData
                {
                    Value = 50,
                    Color = "#46BFBD",
                    Highlight = "#5AD3D1",
                    Label = "Green"
                },
                new DoughnutChartData
                {
                    Value = 100,
                    Color = "#FDB45C",
                    Highlight = "#FFC870",
                    Label = "Yellow"
                }
            };

            doughnutChart.ChartConfig.SegmentStrokeColor = System.Drawing.Color.Violet;
            doughnutChart.ChartConfig.SegmentShowStroke = true;
            doughnutChart.ChartConfig.SegmentStrokeWidth = 5;

            return View(doughnutChart);
        }
    }
}