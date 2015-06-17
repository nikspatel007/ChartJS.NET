﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS.NET.Models
{
    public class BaseDataSets<T>
    {
        public List<string> Labels { get; set; }
        public List<T> Datasets { get; set; }
    }
}