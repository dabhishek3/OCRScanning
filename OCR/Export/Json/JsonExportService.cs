using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OCR.Text;
using Xamarin.Essentials;

namespace OCR.Export.Json
{
    public class JsonExportService : ExportServiceBase
    {
        public override Task Export(ScanResult scanResult)
        {
            var fileName = Path.Combine(_fileFolder, GetFileName(scanResult, "json"));
            File.WriteAllText(fileName, JsonConvert.SerializeObject(scanResult));
            
            return Share.RequestAsync(new ShareFileRequest
            {
                Title = "Export as json",
                File = new ShareFile(fileName)
            });                
            
        }
    }
}