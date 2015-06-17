using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Charts.Bar
{
    public class BarChart : BaseChart<BarChartOptions>
    {
        private readonly BarChartOptions _barChartOptions = new BarChartOptions();

        public override ChartTypes ChartType { get { return ChartTypes.Bar; } }

        public override BarChartOptions ChartConfig
        {
            get { return _barChartOptions; }
        }
    }
}
