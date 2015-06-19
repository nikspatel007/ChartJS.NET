using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts.PolarAreaChart
{
    public class PolarAreaChartOptions
    {
        /// <summary>
        ///     Show a backdrop to the scale label
        /// </summary>
        public bool? ScaleShowLabelBackDrop { get; set; }

        /// <summary>
        ///     The colour of the label backdrop
        /// </summary>
        public string ScaleBackdropColor { get; set; }

        /// <summary>
        ///     Whether the scale should begin at zero
        /// </summary>
        public string ScaleBeginAtZero { get; set; }

        /// <summary>
        ///     The backdrop padding above & below the label in pixels
        /// </summary>
        public int? ScaleBackdropPaddingY { get; set; }

        /// <summary>
        ///     The backdrop padding to the side of the label in pixels
        /// </summary>
        public int? ScaleBackdropPaddingX { get; set; }

        /// <summary>
        ///     Show line for each value in the scale
        /// </summary>
        public bool? ScaleShowLine { get; set; }

        /// <summary>
        ///     The colour of the stroke on each segement.
        /// </summary>
        public string SegmentStrokeColor { get; set; }

        /// <summary>
        ///     The width of the stroke value in pixels
        /// </summary>
        public int? SegementStrokeWidth { get; set; }

        /// <summary>
        ///     Amount of animation steps
        /// </summary>
        public int? AnimationSteps { get; set; }

        /// <summary>
        ///     Animation easing effect.
        /// </summary>
        public Enums.AnimationEasing AnimationEasing { get; set; }

        /// <summary>
        ///     Whether to animate the rotation of the chart
        /// </summary>
        public bool? AnimationRotate { get; set; }

        /// <summary>
        ///     Whether to animate scaling the chart from the centre
        /// </summary>
        public bool? AnimateScale { get; set; }

        /// <summary>
        ///     A legend template
        /// </summary>
        public string LegendTemplate { get; set; }
    }
}