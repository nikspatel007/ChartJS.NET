using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Charts
{
    public class CanvasProperties
    {
        public CanvasProperties()
        {
            Height = 400;
            Width = 400;
            CanvasId = "ChangeMe";
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public string CanvasId { get; set; }
        public string CssClass { get; set; }
    }
}
