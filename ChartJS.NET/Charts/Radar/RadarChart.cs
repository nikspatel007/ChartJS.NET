namespace ChartJS.NET.Charts.Radar
{
    public class RadarChart : BaseChart<RadarDataSet, RadarChartOptions>
    {
        private readonly RadarChartOptions _barChartOptions = new RadarChartOptions();

        public override ChartTypes ChartType
        {
            get { return ChartTypes.Radar; }
        }

        public override RadarChartOptions ChartConfig
        {
            get { return _barChartOptions; }
        } 
    }
}