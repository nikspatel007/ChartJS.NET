namespace ChartJS.NET.Models
{
    public class CustomToolTip
    {
        /// <summary>
        ///     Array of string names to attach tooltip events to; i.e. ["mousemove", "touchstart", "touchmove"]
        /// </summary>
        public string[] Events { get; set; }

        /// <summary>
        ///     Tooltip background color; i.e. "rgba(0,0,0,0.8)"
        /// </summary>
        public string FillColor { get; set; }

        /// <summary>
        ///     Font options for the tooltip
        /// </summary>
        public FontOptions FontOptions { get; set; }

        /// <summary>
        ///     Tooltip Title font options
        /// </summary>
        public FontOptions TitleOptions { get; set; }

        /// <summary>
        ///     Pixel width of padding above and below tooltip text
        /// </summary>
        public int YPadding { get; set; }

        /// <summary>
        ///     Pixel width of padding on the left and right of the tooltip text
        /// </summary>
        public int XPadding { get; set; }

        /// <summary>
        ///     Size of the caret on the tooltip
        /// </summary>
        public int CaretSize { get; set; }

        /// <summary>
        ///     Pixel radius of the tooltip border
        /// </summary>
        public int CornerRadius { get; set; }

        /// <summary>
        ///     Pixel offset from point X to the tooltip edge
        /// </summary>
        public int XOffset { get; set; }

        /// <summary>
        ///     Template string for single tooltips
        /// </summary>
        public string SingleTemplate { get; set; }

        /// <summary>
        ///     Template string for multiple tooltips
        /// </summary>
        public string MultipleTemplate { get; set; }
    }
}