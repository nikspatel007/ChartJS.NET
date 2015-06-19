namespace ChartJS.NET.Models
{
    public class Scale
    {
        /// <summary>
        ///     Color of the scale line; i.e. rgba(0, 0, 0, .1)
        /// </summary>
        public string LineColor { get; set; }

        /// <summary>
        ///     Scale line width
        /// </summary>
        public int LineWidth { get; set; }

        /// <summary>
        ///     Whether to show the scale labels
        /// </summary>
        public bool ShowLabels { get; set; }

        /// <summary>
        ///     Whether the scale should use only integers instead of floats even if drawing space is there
        /// </summary>
        public bool IntegersOnly { get; set; }

        /// <summary>
        ///     Wehterh the scale should start at zero, or an order of magnitude down from the lowest value
        /// </summary>
        public bool BeginAtZero { get; set; }

        /// <summary>
        ///     Set or Get the scale font options
        /// </summary>
        public FontOptions FontOptions { get; set; }
    }
}