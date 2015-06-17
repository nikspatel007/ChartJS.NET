using ChartJS.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Charts
{
    public abstract class BaseChart<TChartOptions> where TChartOptions : GlobalOptions
    {
        public BaseDataSet Data { get; set; }
        public List<string> Labels { get; set; }
        public abstract ChartTypes ChartType { get; }
        public CanvasProperties CanvasProperties { get; set; }
        public abstract TChartOptions ChartConfig { get; }
    }
}
