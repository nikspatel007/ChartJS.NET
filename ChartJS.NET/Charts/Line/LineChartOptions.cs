namespace ChartJS.NET.Charts.Line
{
    public class LineChartOptions
    {
        /// <summary>
        ///     Whether grid lines are shown across the chart
        /// </summary>
        public bool? ScaleShowGridLines { get; set; }

        /// <summary>
        ///     Colour of the grid lines; use rgba format - "rgba(0,0,0,.1)"
        /// </summary>
        public string ScaleGridLineColor { get; set; }

        /// <summary>
        ///     Width of the grid lines
        /// </summary>
        public int? ScaleGridLineWidth { get; set; }

        /// <summary>
        ///     Whether to show horizontal lines (except X axis)
        /// </summary>
        public bool? ScaleShowHorizontalLines { get; set; }

        /// <summary>
        ///     Whether to show vertical lines (except Y axis)
        /// </summary>
        public bool? ScaleShowVerticalLines { get; set; }

        /// <summary>
        ///     Whether the line is curved between points
        /// </summary>
        public bool? BeizerCurve { get; set; }

        /// <summary>
        ///     Tension of the bezier curve between points
        /// </summary>
        public double? BeizerCurveTension { get; set; }

        /// <summary>
        ///     Whether to show a dot for each point
        /// </summary>
        public bool? PointDot { get; set; }

        /// <summary>
        ///     Radius of each point dot in pixels
        /// </summary>
        public int? PointDotRadius { get; set; }

        /// <summary>
        ///     Pixel width of point dot stroke
        /// </summary>
        public int? PointDotStrokeWidth { get; set; }

        /// <summary>
        ///     amount extra to add to the radius to cater for hit detection outside the drawn point
        /// </summary>
        public int? PointHitDetectionRadius { get; set; }

        /// <summary>
        ///     Whether to show a stroke for datasets
        /// </summary>
        public bool? DatasetStroke { get; set; }

        /// <summary>
        ///     Pixel width of dataset stroke
        /// </summary>
        public int? DataSetStrokeWidth { get; set; }

        /// <summary>
        ///     Whether to fill the dataset with a colour
        /// </summary>
        public bool? DatasetFill { get; set; }

        /// <summary>
        ///     A legend template
        /// </summary>
        public string LegendTemplate { get; set; }
    }
}