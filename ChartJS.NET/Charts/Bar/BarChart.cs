using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts.Bar
{
    public class BarChart : BaseChart<BarDataSet, BarChartOptions>
    {
        private readonly BarChartOptions _barChartOptions = new BarChartOptions();

        public override Enums.ChartTypes ChartType
        {
            get { return Enums.ChartTypes.Bar; }
        }

        public override BarChartOptions ChartConfig
        {
            get { return _barChartOptions; }
        }
    }
}
