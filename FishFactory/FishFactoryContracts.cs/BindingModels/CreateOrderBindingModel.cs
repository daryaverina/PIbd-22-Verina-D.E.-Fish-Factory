using System;
using System.Collections.Generic;
using System.Text;

namespace FishFactoryContracts.BindingModels
{
    /// Данные от клиента, для создания заказа
    public class CreateOrderBindingModel
    {
        public int CannedId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
