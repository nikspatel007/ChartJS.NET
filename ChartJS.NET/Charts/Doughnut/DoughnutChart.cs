using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts.Doughnut
{
    public class DoughnutChart : BaseChart<List<DoughnutChartData>, DoughnutChartOptions>
    {
        private readonly DoughnutChartOptions _chartOptions = new DoughnutChartOptions();

        public override Enums.ChartTypes ChartType { get { return Enums.ChartTypes.Doughnut; } }

        public override DoughnutChartOptions ChartConfig
        {
            get { return _chartOptions; }
        }

    }
}
