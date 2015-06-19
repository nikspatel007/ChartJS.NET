namespace ChartJS.NET.Charts.Bar
{
    public class BarChartOptions
    {
        /// <summary>
        ///     Whether to show gridlines
        /// </summary>
        public bool ScaleShowGridLines { get; set; }

        /// <summary>
        ///     Sets the gridline color; use rgba format - "rgba(0,0,0,.1)"
        /// </summary>
        public string ScaleGridLineColor { get; set; }

        /// <summary>
        ///     Sets the gridline width in pixels
        /// </summary>
        public int ScaleGridLineWidth { get; set; }

        /// <summary>
        ///     Whether to show horizontal gridlines
        /// </summary>
        public bool ScaleShowHorizontalLines { get; set; }

        /// <summary>
        ///     Whether to show verticle gridlines
        /// </summary>
        public bool ScaleShowVerticalLines { get; set; }

        /// <summary>
        ///     If there is a stroke on each bar
        /// </summary>
        public bool BarShowStroke { get; set; }

        /// <summary>
        ///     Pixel width of the bar stroke
        /// </summary>
        public int BarStrokeWidth { get; set; }

        /// <summary>
        ///     Spacing between each of the X value sets in pixels
        /// </summary>
        public int BarValueSpacing { get; set; }

        /// <summary>
        ///     Spacing between data sets within X values in pixels
        /// </summary>
        public int BarDatasetSpacing { get; set; }
    }
}