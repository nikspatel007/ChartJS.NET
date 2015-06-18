namespace ChartJS.NET.Charts.Bar
{
    public class BarChart : BaseChart<BarDataSet, BarChartOptions>
    {
        private readonly BarChartOptions _barChartOptions = new BarChartOptions();

        public override ChartTypes ChartType
        {
            get { return ChartTypes.Bar; }
        }

        public override BarChartOptions ChartConfig
        {
            get { return _barChartOptions; }
        }
    }
}