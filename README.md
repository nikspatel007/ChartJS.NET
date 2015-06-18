# ChartJS.NET
Creating a .NET wrapper using MVCHtmlString to allow Razor Engine to render charts on the fly. We have used MVCHtmlString to generate HtmlString and we will use HtmlHelpers to extend the functionality of Razor Engine.

## Rendering Bar Charts
To build your Bar Chart, you will need to add code to your controller and then use the HTML Extensions in your view.  Below is the controller code:



      public ActionResult Index()
        {
            BarChart barChart = new BarChart();

            barChart.ChartData.Datasets = new List<BarDataSet>()
            {
                new BarDataSet() {
                    Data = new double[] { 65, 59, 80, 81, 56, 55, 40 },
                    Label = "First Dataset",
                    FillColor = "rgba(220, 220, 220, 0.5)",
                    StrokeColor = "rgba(220, 220, 220, 0.8)",
                    HighlightFillColor = "rgba(220, 220, 220, 0.75)",
                    HighlightStrokeColor = "rgba(220, 220, 220, 1)"
                },
                new BarDataSet() {
                    Data = new double[] { 28, 48, 40, 19, 86, 27, 90 },
                    Label = "Second Dataset",
                    FillColor = "rgba(151,187,205, 0.5)",
                    StrokeColor = "rgba(151,187,205, 0.8)",
                    HighlightFillColor = "rgba(151,187,205, 0.75)",
                    HighlightStrokeColor = "rgba(151,187,205, 1)"
                }
            };

            barChart.ChartData.Labels = new List<string>() {
                "January", "February", "March", "April", "May", "June", "July"
            };


            barChart.ChartConfig.BarDatasetSpacing = 50;
            barChart.ChartConfig.ScaleGridLineColor = "rgba(0,0,0, 1)";
            barChart.ChartConfig.ScaleGridLineWidth = 2;
            barChart.ChartConfig.ScaleShowGridLines = true;
            barChart.ChartConfig.ScaleShowHorizontalLines = true;

            return View(barChart);
        }
  
  
  and then in your view, you can use this:
  
      @model ChartJS.NET.Charts.Bar.BarChart
  
      @Html.BuildChart(Model)
  
  You should now see your bar chart rendered on the page.  There is also a samples project included so you can see how the code is being used.
