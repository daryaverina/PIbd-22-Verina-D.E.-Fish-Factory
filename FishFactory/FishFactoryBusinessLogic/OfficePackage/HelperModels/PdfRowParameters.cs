using System;
using System.Collections.Generic;
using FishFactoryBusinessLogic.OfficePackage.HelperEnums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryBusinessLogic.OfficePackage.HelperModels
{
    public class PdfRowParameters
    {
        public List<string> Texts { get; set; }
        public string Style { get; set; }
        public PdfParagraphAlignmentType ParagraphAlignment { get; set; }

    }
}
