using System;
using System.Collections.Generic;
using System.Text;

namespace FishFactoryListImplement.Models
{
    /// Компонент, требуемый для изготовления изделия
    public class Component
    {
        public int Id { get; set; }
        public string ComponentName { get; set; }
    }
}
