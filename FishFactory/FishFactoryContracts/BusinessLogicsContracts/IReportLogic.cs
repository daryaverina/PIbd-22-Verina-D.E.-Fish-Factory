using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;

namespace FishFactoryContracts.BusinessLogicsContracts
{
    public interface IReportLogic
    {
        /// Получение списка компонент с указанием, в каких изделиях используются
        List<ReportCannedComponentViewModel> GetCannedComponent();
        /// Получение списка заказов за определенный период
        List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);
        /// Сохранение компонент в файл-Word
        void SaveCannedsToWordFile(ReportBindingModel model);
        /// Сохранение компонент с указаеним продуктов в файл-Excel
        void SaveCannedComponentToExcelFile(ReportBindingModel model);
        /// Сохранение заказов в файл-Pdf
        void SaveOrdersToPdfFile(ReportBindingModel model);
    }
}
