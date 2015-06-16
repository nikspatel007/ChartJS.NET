using ChartJS.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Charts
{
    public class BaseChart
    {
        public BaseDataSet Data { get; set; }
        public ChartTypes ChartType { get; set; }
    }
}
