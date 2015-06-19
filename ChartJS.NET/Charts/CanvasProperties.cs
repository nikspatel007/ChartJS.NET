namespace ChartJS.NET.Charts
{
    public class CanvasProperties
    {
        public CanvasProperties()
        {
            Height = 400;
            Width = 600;
            CanvasId = "Canvase";
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public string CanvasId { get; set; }
        public string CssClass { get; set; }
    }
}