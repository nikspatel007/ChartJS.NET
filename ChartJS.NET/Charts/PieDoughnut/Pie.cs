using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Charts.PieDoughnut
{
    public class Pie : BaseChart<PieDataSet, PieChartOptions>
    {
        private readonly PieChartOptions _chartOptions = new PieChartOptions();

        public override ChartTypes ChartType { get { return ChartTypes.Pie; } }

        public override PieChartOptions ChartConfig
        {
            get { return _chartOptions; }
        }
    }
}
