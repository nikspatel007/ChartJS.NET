using ChartJS.NET.Models;

namespace ChartJS.NET.Charts.Line
{
    public class LineDataSet : BaseDataSets<LineDataSet>
    {
        public string Label { get; set; }
        public string FillColor { get; set; }
        public string StrokeColor { get; set; }
        public string PointColor { get; set; }
        public string PointStrokeColor { get; set; }
        public string PointHighlightFill { get; set; }
        public string PointHighlightStroke { get; set; }
        public double[] Data { get; set; }
    }
}