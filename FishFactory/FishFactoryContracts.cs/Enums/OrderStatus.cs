using System;
using System.Collections.Generic;
using System.Text;

namespace FishFactoryContracts.Enums
{
    /// Статус заказа
    public enum OrderStatus
    {
        Принят = 0,
        Выполняется = 1,
        Готов = 2,
        Выдан = 3
    }
}
