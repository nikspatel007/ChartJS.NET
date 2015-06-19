using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts.Radar
{
    public class RadarChart : BaseChart<RadarDataSet, RadarChartOptions>
    {
        private readonly RadarChartOptions _chartOptions = new RadarChartOptions();

        public override Enums.ChartTypes ChartType
        {
            get { return Enums.ChartTypes.Radar; }
        }

        public override RadarChartOptions ChartConfig
        {
            get { return _chartOptions; }
        }
    }
}