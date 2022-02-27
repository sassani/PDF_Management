using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Data
{
    public class FileManager
    {
        public PdfDocument pdfDoc { get; private set; }

        public FileManager(string filePath)
        {
            pdfDoc = PdfUtil.GetPdf(filePath);
        }

         




    }
}
