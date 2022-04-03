using System;
using System.Collections.Generic;
using FishFactoryContracts.ViewModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryBusinessLogic.OfficePackage.HelperModels
{
    public class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportCannedComponentViewModel> CannedComponents { get; set; }
    }
}
