using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts.Line
{
    public class LineChart : BaseChart<LineDataSet, LineChartOptions>
    {
        private readonly LineChartOptions _barChartOptions = new LineChartOptions();

        public override Enums.ChartTypes ChartType
        {
            get { return Enums.ChartTypes.Line; }
        }

        public override LineChartOptions ChartConfig
        {
            get { return _barChartOptions; }
        }
    }
}