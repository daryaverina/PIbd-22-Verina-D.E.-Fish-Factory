using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;


namespace FishFactoryContracts.ViewModels
{
    /// Изделие, изготавливаемое в магазине
    public class CannedViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название консервов")]
        public string CannedName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> CannedComponents { get; set; }
    }
}
