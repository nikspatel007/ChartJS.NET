using System.Collections.Generic;

namespace ChartJS.NET.Models
{
    public class BaseDataSets<T>
    {
        public BaseDataSets()
        {
            Labels = new List<string>();
            Datasets = new List<T>();
        }

        public List<string> Labels { get; set; }
        public List<T> Datasets { get; set; }
    }
}