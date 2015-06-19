using System.Collections.Generic;
using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts.PolarAreaChart
{
    public class PolarAreaChart : BaseChart<List<PolarAreaChartData>, PolarAreaChartOptions>
    {
        private readonly PolarAreaChartOptions _chartOptions = new PolarAreaChartOptions();

        public override Enums.ChartTypes ChartType
        {
            get { return Enums.ChartTypes.PolarArea; }
        }

        public override PolarAreaChartOptions ChartConfig
        {
            get { return _chartOptions; }
        }
    }
}