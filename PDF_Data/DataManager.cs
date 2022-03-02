using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Data
{
    public class DataManager
    {
        public PdfDocument pdfDoc { get; private set; }
        private string filePath;

        public DataManager(string filePath)
        {
            this.filePath = filePath;
            pdfDoc = PdfUtil.GetPdf(filePath);
        }
    }
}
