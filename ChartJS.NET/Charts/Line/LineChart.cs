namespace ChartJS.NET.Charts.Line
{
    public class LineChart : BaseChart<LineDataSet, LineChartOptions>
    {
        private readonly LineChartOptions _barChartOptions = new LineChartOptions();

        public override ChartTypes ChartType
        {
            get { return ChartTypes.Line; }
        }

        public override LineChartOptions ChartConfig
        {
            get { return _barChartOptions; }
        }
    }
}