﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FishFactoryFileImplement_.Models
{
    /// Изделие, изготавливаемое в магазине
    public class Canned
    {
        public int Id { get; set; }
        public string CannedName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, int> CannedComponents { get; set; }
    }
}
