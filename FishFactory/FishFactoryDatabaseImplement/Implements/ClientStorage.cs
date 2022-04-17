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
    public class ClientStorage : IClientStorage
    {
        public List<ClientViewModel> GetFullList()
        {
            using var context = new FishFactoryDatabase();
            return context.Clients.Select(CreateModel).ToList();
        }

        public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new FishFactoryDatabase();
            return context.Clients.Where(rec => rec.Login == model.Login && rec.Password == model.Password).Select(CreateModel).ToList();
        }

        public ClientViewModel GetElement(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using var context = new FishFactoryDatabase();
            var client = context.Clients.FirstOrDefault(rec => rec.Login == model.Login || rec.Id == model.Id);
            return client != null ? CreateModel(client) : null;
        }

        public void Insert(ClientBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            context.Clients.Add(CreateModel(model, new Client()));
            context.SaveChanges();
        }

        public void Update(ClientBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            var client = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
            if (client == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, client);
            context.SaveChanges();
        }

        public void Delete(ClientBindingModel model)
        {
            using var context = new FishFactoryDatabase();
            Client client = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
            if (client != null)
            {
                context.Clients.Remove(client);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private Client CreateModel(ClientBindingModel model, Client client)
        {
            client.ClientFIO = model.ClientFIO;
            client.Login = model.Login;
            client.Password = model.Password;
            return client;
        }

        private static ClientViewModel CreateModel(Client client)
        {
            return new ClientViewModel
            {
                Id = client.Id,
                ClientFIO = client.ClientFIO,
                Login = client.Login,
                Password = client.Password
            };
        }
    }
}