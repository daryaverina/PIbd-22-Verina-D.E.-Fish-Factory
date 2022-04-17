﻿using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FishFactoryRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic _order;
        private readonly ICannedLogic _canned;
        public MainController(IOrderLogic order, ICannedLogic canned)
        {
            _order = order;
            _canned = canned;
        }

        [HttpGet]
        public List<CannedViewModel> GetCannedFList() => _canned.Read(null)?.ToList();

        [HttpGet]
        public CannedViewModel GetCanned(int cannedId) => _canned.Read(new CannedBindingModel { Id = cannedId })?[0];

        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new CannedBindingModel { ClientId = clientId });

        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) => _order.CreateOrder(model);
    }
}