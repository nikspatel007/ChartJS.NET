using ChartJS.NET.Models;

namespace ChartJS.NET.Charts.Bar
{
    public class BarDataSet : BaseDataSets<BarDataSet>
    {
        public string Label { get; set; }
        public string FillColor { get; set; }
        public string StrokeColor { get; set; }
        public string HighlightFillColor { get; set; }
        public string HighlightStrokeColor { get; set; }
        public double[] Data { get; set; }
    }
}