using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;
using System.Collections.Generic;

namespace FishFactoryContracts.BusinessLogicsContracts
{
    public interface ICannedLogic
    {

        List<CannedViewModel> Read(CannedBindingModel model);
        void CreateOrUpdate(CannedBindingModel model);
    }
}
