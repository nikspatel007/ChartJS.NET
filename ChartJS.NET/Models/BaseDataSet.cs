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
        public string HighlightFillColor { get; set; }
        public string HighlightStrokeColor { get; set; }
        public double[] Data { get; set; }
    }
}
