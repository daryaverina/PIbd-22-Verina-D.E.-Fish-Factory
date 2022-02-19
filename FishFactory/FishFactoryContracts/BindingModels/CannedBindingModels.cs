﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FishFactoryContracts.BindingModels
{
    /// Изделие, изготавливаемое в магазине
    public class CannedBindingModel
    {
        public int? Id { get; set; }
        public string CannedName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> CannedComponents { get; set; }
    }
}