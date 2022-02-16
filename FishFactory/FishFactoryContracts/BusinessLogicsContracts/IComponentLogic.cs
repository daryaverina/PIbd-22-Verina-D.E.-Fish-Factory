using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;
using System.Collections.Generic;
using System;

namespace FishFactoryContracts.BusinessLogicsContracts
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> Read(ComponentBindingModel model);
        void CreateOrUpdate(ComponentBindingModel model);
        void Delete(ComponentBindingModel model);
    }
}
