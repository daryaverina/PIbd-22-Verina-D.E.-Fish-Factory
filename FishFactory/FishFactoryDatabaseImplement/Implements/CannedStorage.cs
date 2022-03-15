﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryDatabaseImplement.Models;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FishFactoryDatabaseImplement.Implements
{
    public class CannedStorage : ICannedStorage
    {
        public List<CannedViewModel> GetFullList()
        {
            using var context = new FishFactoryDatabase();
            return context.Canneds.Include(rec => rec.CannedComponents).ThenInclude(rec => rec.Component).ToList().Select(CreateModel).ToList();
        }
        public List<CannedViewModel> GetFilteredList(CannedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new FishFactoryDatabase();
            return context.Canneds.Include(rec => rec.CannedComponents).ThenInclude(rec => rec.Component).Where(rec => rec.CannedName.Contains(model.CannedName)).ToList().Select(CreateModel).ToList();
        }
        public CannedViewModel GetElement(CannedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new FishFactoryDatabase();
            var canned = context.Canneds.Include(rec => rec.CannedComponents).ThenInclude(rec => rec.Component).FirstOrDefault(rec => rec.CannedName == model.CannedName || rec.Id == model.Id);
            return canned != null ? CreateModel(canned) : null;
        }
        public void Insert(CannedBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                Canned canned = new Canned()
                {
                    CannedName = model.CannedName,
                    Price = model.Price
                };
                context.Canneds.Add(canned);
                context.SaveChanges();
                CreateModel(model, canned, context);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Update(CannedBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Canneds.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Delete(CannedBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            Canned element = context.Canneds.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Canneds.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Canned CreateModel(CannedBindingModel model, Canned canned, FishFactoryDatabase context)
        {
            canned.CannedName = model.CannedName;
            canned.Price = model.Price;
            if (model.Id.HasValue)
            {
                var carComponents = context.CannedComponents.Where(rec => rec.CannedId == model.Id.Value).ToList();
                context.CannedComponents.RemoveRange(carComponents.Where(rec => !model.CannedComponents.ContainsKey(rec.ComponentId)).ToList());
                context.SaveChanges();
                foreach (var updateComponent in carComponents)
                {
                    updateComponent.Count = model.CannedComponents[updateComponent.ComponentId].Item2;
                    model.CannedComponents.Remove(updateComponent.ComponentId);
                }
                context.SaveChanges();
            }
            foreach (var pc in model.CannedComponents)
            {
                context.CannedComponents.Add(new CannedComponent
                {
                    CannedId = canned.Id,
                    ComponentId = pc.Key,
                    Count = pc.Value.Item2
                });
                context.SaveChanges();
            }
            return canned;
        }
        private static CannedViewModel CreateModel(Canned canned)
        {
            return new CannedViewModel
            {
                Id = canned.Id,
                CannedName = canned.CannedName,
                Price = canned.Price,
                CannedComponents = canned.CannedComponents.ToDictionary(recPC => recPC.ComponentId, recPC => (recPC.Component?.ComponentName, recPC.Count))
            };
        }
    }
}