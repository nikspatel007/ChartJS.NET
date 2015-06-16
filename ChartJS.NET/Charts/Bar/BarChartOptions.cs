using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Charts.Bar
{
    public class BarChartOptions : GlobalOptions
    {
        /// <summary>
        /// Whether to show gridlines
        /// </summary>
        public bool ShowGridLines { get; set; }

        /// <summary>
        /// Sets the gridline color
        /// </summary>
        public string GridLineColor { get; set; }

        /// <summary>
        /// Sets the gridline width in pixels
        /// </summary>
        public int GridLineWidth { get; set; }

        /// <summary>
        /// Whether to show horizontal gridlines
        /// </summary>
        public bool ShowHorizontalLines { get; set; }

        /// <summary>
        /// Whether to show verticle gridlines
        /// </summary>
        public bool ShowVerticalLines { get; set; }

        /// <summary>
        /// If there is a stroke on each bar
        /// </summary>
        public bool ShowStroke { get; set; }

        /// <summary>
        /// Pixel width of the bar stroke
        /// </summary>
        public int StrokeWidth { get; set; }

        /// <summary>
        /// Spacing between each of the X value sets in pixels
        /// </summary>
        public int ValueSpacing { get; set; }

        /// <summary>
        /// Spacing between data sets within X values in pixels
        /// </summary>
        public int DatasetSpacing { get; set; }

    }
}
