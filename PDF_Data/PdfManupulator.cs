using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Data
{
    public class PdfManupulator
    {
        public string FilePath { get; set; }
        public List<Point> DataArea { get; set; }

        public static IEnumerable<T> GetDataFromPdfByArea<T>(string path, List<Point> rect)
        {
            List<T> result = new List<T>();
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(path));
            return result;
        }
    }
}
