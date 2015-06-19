using System.Collections.Generic;
using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts.Pie
{
    public class PieChart : BaseChart<List<PieChartData>, PieChartOptions>
    {
        private readonly PieChartOptions _chartOptions = new PieChartOptions();

        public override Enums.ChartTypes ChartType
        {
            get { return Enums.ChartTypes.Pie; }
        }

        public override PieChartOptions ChartConfig
        {
            get { return _chartOptions; }
        }
    }
}