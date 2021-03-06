﻿using ChartJS.NET.Infrastructure;

namespace ChartJS.NET.Charts
{
    public abstract class BaseChart<TChart, TChartOptions>
        where TChart : new()
        where TChartOptions : class
    {
        public BaseChart()
        {
            CanvasProperties = new CanvasProperties();
            Data = new TChart();
        }

        public TChart Data { get; set; }
        public abstract Enums.ChartTypes ChartType { get; }
        public CanvasProperties CanvasProperties { get; set; }
        public abstract TChartOptions ChartConfig { get; }
    }
}