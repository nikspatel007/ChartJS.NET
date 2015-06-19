using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts.Pie
{
    public class PieChartOptions
    {
        /// <summary>
        /// Whether or not to show a stroke on each segment
        /// </summary>
        public bool? SegmentShowStroke { get; set; }
        
        /// <summary>
        /// Color of each segment stroke; this should be a hex color code i.e. "#fff"
        /// </summary>
        public string SegmentStrokeColor { get; set; }

        /// <summary>
        /// The width of each segment stroke in pixels
        /// </summary>
        public int? SegmentStrokeWidth { get; set; }

        /// <summary>
        /// The percentage of the chart that we cut out of the middle; for pie charts this is zero by default
        /// </summary>
        public int? PercentageInnerCutout { get; set; }

        /// <summary>
        /// The number of animation steps
        /// </summary>
        public int? AnimationSteps { get; set; }

        /// <summary>
        /// The animation easing effect
        /// </summary>
        public Enums.AnimationEasing AnimationEasing { get; set; }

        /// <summary>
        /// Whether we animate the rotation of the Pie chart
        /// </summary>
        public bool? AnimateRotate { get; set; }

        /// <summary>
        /// Whether we animate scaling the Pie chart from the center
        /// </summary>
        public bool? AnimateScale { get; set; }
    }
}
