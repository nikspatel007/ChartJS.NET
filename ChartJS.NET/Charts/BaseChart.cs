using ChartJS.NET.Models;

namespace ChartJS.NET.Charts
{
    public abstract class BaseChart<TChart, TChartOptions>
        where TChart : BaseDataSets<TChart>
        where TChartOptions : class
    {
        public BaseChart()
        {
            CanvasProperties = new CanvasProperties();
            ChartData = new BaseDataSets<TChart>();
        }

        public BaseDataSets<TChart> ChartData { get; set; }
        public abstract ChartTypes ChartType { get; }
        public CanvasProperties CanvasProperties { get; set; }
        public abstract TChartOptions ChartConfig { get; }
    }
}