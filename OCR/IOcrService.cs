using System.IO;
using System.Threading.Tasks;
using OCR.Text;

namespace OCR
{
    public interface IOcrService
    {
        Task<ScanResult> ProcessImage(Stream bitmapStream);
    }
}