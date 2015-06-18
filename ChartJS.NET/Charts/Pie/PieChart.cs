using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Charts.Pie
{
    public class PieChart : BaseChart<List<PieChartData>, PieChartOptions>
    {
        private readonly PieChartOptions _chartOptions = new PieChartOptions();

        public override ChartTypes ChartType { get { return ChartTypes.Pie; } }

        public override PieChartOptions ChartConfig
        {
            get { return _chartOptions; }
        }
    }
}
