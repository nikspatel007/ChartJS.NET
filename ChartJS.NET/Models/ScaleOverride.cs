using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Models
{
    public class ScaleOverride
    {
        /// <summary>
        /// The number of steps in hard coded scale
        /// </summary>
        public string Steps { get; set; }

        /// <summary>
        /// The value jump in a hard coded scale
        /// </summary>
        public string StepWidth { get; set; }

        /// <summary>
        /// The scale start value in a hard coded scale
        /// </summary>
        public string StartValue { get; set; }


    }
}
