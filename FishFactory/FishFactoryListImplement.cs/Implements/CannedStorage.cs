using FishFactoryContracts.BindingModels;
using FishFactoryContracts.StoragesContracts;
using FishFactoryContracts.ViewModels;
using FishFactoryListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FishFactoryListImplement.Implements
{
    public class CannedStorage : ICannedStorage
    {
        private readonly DataListSingleton source;
        public CannedStorage()
        {
            source = DataListSingleton.GetInstance();
        }
        public List<CannedViewModel> GetFullList()
        {
            var result = new List<CannedViewModel>();
            foreach (var component in source.Canneds)
            {
                result.Add(CreateModel(component));
            }
            return result;
        }
        public List<CannedViewModel> GetFilteredList(CannedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var result = new List<CannedViewModel>();
            foreach (var canned in source.Canneds)
            {
                if (canned.CannedName.Contains(model.CannedName))
                {
                    result.Add(CreateModel(canned));
                }
            }
            return result;
        }
        public CannedViewModel GetElement(CannedBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var canned in source.Canneds)
            {
                if (canned.Id == model.Id || canned.CannedName ==
                model.CannedName)
                {
                    return CreateModel(canned);
                }
            }
            return null;
        }
        public void Insert(CannedBindingModel model)
        {
            var tempProduct = new Canned
            {
                Id = 1,
                CannedComponents = new
            Dictionary<int, int>()
            };
            foreach (var product in source.Canneds)
            {
                if (product.Id >= tempProduct.Id)
                {
                    tempProduct.Id = product.Id + 1;
                }
            }
            source.Canneds.Add(CreateModel(model, tempProduct));
        }
        public void Update(CannedBindingModel model)
        {
            Canned tempProduct = null;
            foreach (var product in source.Canneds)
            {
                if (product.Id == model.Id)
                {
                    tempProduct = product;
                }
            }
            if (tempProduct == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempProduct);
        }
        public void Delete(CannedBindingModel model)
        {
            for (int i = 0; i < source.Canneds.Count; ++i)
            {
                if (source.Canneds[i].Id == model.Id)
                {
                    source.Canneds.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private static Canned CreateModel(CannedBindingModel model, Canned
        product)
        {
            product.CannedName = model.CannedName;
            product.Price = model.Price;
            // удаляем убранные
            foreach (var key in product.CannedComponents.Keys.ToList())
            {
                if (!model.CannedComponents.ContainsKey(key))
                {
                    product.CannedComponents.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (var component in model.CannedComponents)
            {
                if (product.CannedComponents.ContainsKey(component.Key))
                {
                    product.CannedComponents[component.Key] =
                    model.CannedComponents[component.Key].Item2;
                }
                else
                {
                    product.CannedComponents.Add(component.Key,
                    model.CannedComponents[component.Key].Item2);
                }
            }
            return product;
        }
        private CannedViewModel CreateModel(Canned canned)
        {
            // требуется дополнительно получить список компонентов для изделия с названиями и их количество
            var productComponents = new Dictionary<int, (string, int)>();
            foreach (var pc in canned.CannedComponents)
            {
                string componentName = string.Empty;
                foreach (var component in source.Components)
                {
                    if (pc.Key == component.Id)
                    {
                        componentName = component.ComponentName;
                        break;
                    }
                }
                productComponents.Add(pc.Key, (componentName, pc.Value));
            }
            return new CannedViewModel
            {
                Id = canned.Id,
                CannedName = canned.CannedName,
                Price = canned.Price,
                CannedComponents = productComponents
            };
        }
    }
}
