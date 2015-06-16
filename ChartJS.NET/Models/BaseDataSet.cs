using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Models
{
    public class BaseDataSet
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
