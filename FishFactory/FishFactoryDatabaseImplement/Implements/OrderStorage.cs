﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.ViewModels;
using FishFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace FishFactoryDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using var context = new FishFactoryDatabase();
            return context.Orders.Include(rec => rec.Canned).Select(rec => new OrderViewModel
            {
                Id = rec.Id,
                CannedId = rec.CannedId,
                CannedName = rec.Canned.CannedName,
                Count = rec.Count,
                Sum = rec.Sum,
                Status = rec.Status.ToString(),
                DateCreate = rec.DateCreate,
                DateImplement = rec.DateImplement
            }).ToList();
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new FishFactoryDatabase();
            return context.Orders
                .Include(rec => rec.Canned)
                .Where(rec => rec.Id.Equals(model.Id)
                || rec.DateCreate >= model.DateFrom
                && rec.DateCreate <= model.DateTo)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    CannedId = rec.CannedId,
                    CannedName = rec.Canned.CannedName,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    Status = rec.Status.ToString(),
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement
                }).ToList();
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new FishFactoryDatabase();
            var order = context.Orders.Include(rec => rec.Canned).FirstOrDefault(rec => rec.Id == model.Id);
            return order != null ? CreateModel(order, context) : null;
        }
        public void Insert(OrderBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            context.Orders.Add(CreateModel(model, new Order()));
            context.SaveChanges();
        }
        public void Update(OrderBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(OrderBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Orders.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public static Order CreateModel(OrderBindingModel model,
            Order order)
        {
            order.CannedId = model.CannedId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
        private static OrderViewModel CreateModel(Order order, FishFactoryDatabase context)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                CannedId = order.CannedId,
                CannedName = order.Canned.CannedName,
                Count = order.Count,
                Sum = order.Sum,
                Status = order.Status.ToString(),
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}
