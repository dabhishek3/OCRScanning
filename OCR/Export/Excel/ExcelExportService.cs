using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using OCR.Text;

namespace OCR.Export.Excel
{
    [UsedImplicitly]
    public class ExcelExportService : ExportServiceBase
    {
        public override Task Export(ScanResult scanResult)
        {
            throw new NotImplementedException();
        }
    }
}