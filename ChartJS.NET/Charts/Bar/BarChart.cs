using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Charts.Bar
{
    public class BarChart
    {
        private readonly BarChartOptions _barChartOptions = new BarChartOptions();

        public override ChartTypes ChartType { get { return ChartTypes.Bar; } }

        public override BarChartOptions ChartOptions { get { return _barChartOptions; } }
    }
}
