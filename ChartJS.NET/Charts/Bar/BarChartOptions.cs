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
