using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;
using System.Collections.Generic;


namespace FishFactoryContracts.StoragesContracts
{
    public interface ICannedStorage
    {
        List<CannedViewModel> GetFullList();
        List<CannedViewModel> GetFilteredList(CannedBindingModel model);
        CannedViewModel GetElement(CannedBindingModel model);
        void Insert(CannedBindingModel model);
        void Update(CannedBindingModel model);
        void Delete(CannedBindingModel model);
    }
}
