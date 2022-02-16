using System;
using System.Collections.Generic;
using System.Text;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.ViewModels;
using FishFactoryContracts.Enums;

namespace FishFactoryBusinessLogic.BusinessLogics
{
    public class OrderLogic : IOrderLogic
    {
        private readonly IOrderStorage orderStorage;
        public OrderLogic(IOrderStorage orderStorage)
        {
            this.orderStorage = orderStorage;
        }
        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            if (model == null)
            {
                return orderStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<OrderViewModel> { orderStorage.GetElement(model) };
            }
            return orderStorage.GetFilteredList(model);
        }
        public void CreateOrder(CreateOrderBindingModel model)
        {
            orderStorage.Insert(new OrderBindingModel
            {
                CannedId = model.CannedId,
                Count = model.Count,
                Sum = model.Sum,
                DateCreate = DateTime.Now,
                Status = OrderStatus.Принят
            });
        }
        public void TakeOrderInWork(ChangeStatusBindingModel model)
        {
            OrderViewModel tempOrder = orderStorage.GetElement(new OrderBindingModel
            { Id = model.OrderId });
            if (tempOrder == null)
            {
                throw new Exception("Не найден заказ");
            }
            if (tempOrder.Status != OrderStatus.Принят.ToString())
            {
                throw new Exception("Статус заказа отличен от \"Принят\"");
            }
            tempOrder.Status = OrderStatus.Выполняется.ToString();
            tempOrder.DateImplement = DateTime.Now;
            orderStorage.Update(new OrderBindingModel
            {
                Id = tempOrder.Id,
                CannedId = tempOrder.CannedId,
                Count = tempOrder.Count,
                Sum = tempOrder.Sum,
                DateCreate = tempOrder.DateCreate,
                DateImplement = tempOrder.DateImplement,
                Status = OrderStatus.Выполняется
            });

        }
        public void FinishOrder(ChangeStatusBindingModel model)
        {
            var order = orderStorage.GetElement(new OrderBindingModel { Id = model.OrderId });
            if (order == null)
            {
                throw new Exception("Не найден заказ");
            }
            if (order.Status != OrderStatus.Выполняется.ToString())
            {
                throw new Exception("Заказ не в статусе \"Выполняется\"");
            }
            order.Status = OrderStatus.Готов.ToString();
            orderStorage.Update(new OrderBindingModel
            {
                Id = order.Id,
                CannedId = order.CannedId,
                Count = order.Count,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement,
                Status = OrderStatus.Готов
            });
        }
        public void DeliveryOrder(ChangeStatusBindingModel model)
        {
            // продумать логику
            var order = orderStorage.GetElement(new OrderBindingModel { Id = model.OrderId });
            if (order == null)
            {
                throw new Exception("Не найден заказ");
            }
            if (order.Status != OrderStatus.Готов.ToString())
            {
                throw new Exception("Заказ не в статусе \"Готов\"");
            }
            orderStorage.Update(new OrderBindingModel
            {
                Id = order.Id,
                CannedId = order.CannedId,
                Count = order.Count,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement,
                Status = OrderStatus.Выдан
            });
        }
    }
}
