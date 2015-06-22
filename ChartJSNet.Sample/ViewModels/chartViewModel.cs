using ChartJS.NET.Charts.Bar;
using ChartJS.NET.Charts.Doughnut;
using ChartJS.NET.Charts.Line;
using ChartJS.NET.Charts.Pie;
using ChartJS.NET.Charts.PolarAreaChart;
using ChartJS.NET.Charts.Radar;

namespace ChartJS.NET.Sample.ViewModels
{
    public class chartViewModel
    {
        public chartViewModel()
        {
            LineChart = new LineChart();
            LineChartWithOptions = new LineChart();
            
            BarChart = new BarChart();
            PieChart = new PieChart();
            DoughnutChart = new DoughnutChart();
            PolarAreaChart = new PolarAreaChart();
            RadarChart = new RadarChart();
        }
        
        public LineChart LineChart { get; set; }
        public LineChart LineChartWithOptions {get; set;}

        public BarChart BarChart { get; set; }

        public PieChart PieChart { get; set; }

        public DoughnutChart DoughnutChart { get; set; }

        public PolarAreaChart PolarAreaChart { get; set; }

        public RadarChart RadarChart { get; set; }
    }
}