namespace ChartJS.NET.Charts.Radar
{
    public class RadarChartOptions
    {
         /// <summary>
        ///     Default Values.
        /// </summary>
        public RadarChartOptions()
        {
            ScaleShowGridLines = true;
            ScaleGridLineColor = "rgba(0,0,0,0.05)";
            ScaleGridLineWidth = 1;
            ScaleShowHorizontalLines = true;
            ScaleShowVerticalLines = true;
            BeizerCurve = true;
            BeizerCurveTension = 0.4;
            PointDot = true;
            PointDotRadius = 4;
            PointDotStrokeWidth = 1;
            PointHitDetectionRadius = 20;
            DataSetStrokeWidth = 2;
            DatasetFill = true;
        }

        /// <summary>
        ///     Whether grid lines are shown across the chart
        /// </summary>
        public bool ScaleShowGridLines { get; set; }

        /// <summary>
        ///     Colour of the grid lines; use rgba format - "rgba(0,0,0,.1)"
        /// </summary>
        public bool AngleShowLineOut { get; set; }

        /// <summary>
        ///     Width of the grid lines
        /// </summary>
        public bool ScaleShowLabels { get; set; }

        /// <summary>
        ///     Whether to show horizontal lines (except X axis)
        /// </summary>
        public bool ScaleBeginAtZero { get; set; }

        /// <summary>
        ///     Whether to show vertical lines (except Y axis)
        /// </summary>
        public string AngleLineColor { get; set; }

        /// <summary>
        ///     Whether the line is curved between points
        /// </summary>
        public int AngleLineWidth { get; set; }

        ///// <summary>
        /////     Tension of the bezier curve between points
        ///// </summary>
        //public string PointLabelFontFamily { get; set; }

        ///// <summary>
        /////     Whether to show a dot for each point
        ///// </summary>
        //public string PointLabelFontFamily { get; set; }

        ///// <summary>
        /////     Radius of each point dot in pixels
        ///// </summary>
        //public string PointLabelFontFamily { get; set; }

        ///// <summary>
        /////     Pixel width of point dot stroke
        ///// </summary>
        //public string PointLabelFontFamily { get; set; }

        /// <summary>
        ///     amount extra to add to the radius to cater for hit detection outside the drawn point
        /// </summary>
        public int PointHitDetectionRadius { get; set; }

        /// <summary>
        ///     Whether to show a stroke for datasets
        /// </summary>
        public bool DatasetStroke { get; set; }

        /// <summary>
        ///     Pixel width of dataset stroke
        /// </summary>
        public int DataSetStrokeWidth { get; set; }

        /// <summary>
        ///     Whether to fill the dataset with a colour
        /// </summary>
        public bool DatasetFill { get; set; }

        /// <summary>
        ///     A legend template
        /// </summary>
        public string LegendTemplate { get; set; } 
    }
}