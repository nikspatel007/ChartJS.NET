using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Models
{
    public class FontOptions
    {
        /// <summary>
        /// Font family declaration; i.e. "'Arial', 'Helvetica Neue', 'Helvetica', 'San-Serif'"
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// Font size in pixels
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Font weight style; i.e. "normal", "bold", "light"
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// Font color in hex value; i.e. "#000"
        /// </summary>
        public string Color { get; set; }

    }
}
