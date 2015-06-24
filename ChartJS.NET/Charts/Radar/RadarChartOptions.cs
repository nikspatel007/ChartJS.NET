using System.Drawing;
namespace ChartJS.NET.Charts.Radar
{
    public class RadarChartOptions
    {
        /// <summary>
        ///     Whether grid lines are shown across the chart
        /// </summary>
        public bool? ScaleShowGridLines { get; set; }

        /// <summary>
        ///     Whether we show the angle lines out of the radar
        /// </summary>
        public bool? AngleShowLineOut { get; set; }

        /// <summary>
        ///     Whether to show labels on the scale
        /// </summary>
        public bool? ScaleShowLabels { get; set; }

        /// <summary>
        ///     Whether the scale should begin at zero
        /// </summary>
        public bool? ScaleBeginAtZero { get; set; }

        /// <summary>
        ///     Colour of the angle line
        /// </summary>
        public Color AngleLineColor { get; set; }

        /// <summary>
        ///     Pixel width of the angle line
        /// </summary>
        public int? AngleLineWidth { get; set; }

        /// <summary>
        ///     Point label font declaration
        /// </summary>
        public string PointLabelFontFamily { get; set; }

        /// <summary>
        ///     Point label font weight
        /// </summary>
        public string PointLabelFontStyle { get; set; }

        /// <summary>
        ///     Point label font size in pixels
        /// </summary>
        public int? PointLabelFontSize { get; set; }

        /// <summary>
        ///     Pixel width of point dot stroke
        /// </summary>
        public Color PointLabelFontColor { get; set; }

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