using iText.Kernel.Pdf;
using System;
using System.Windows.Forms;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;

namespace PDF_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenPdf_Click(object sender, EventArgs e)
        {
            string dest = "C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf";
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(dest));
            ITextExtractionStrategy extractionStrategy = new SimpleTextExtractionStrategy();
            //IPdfTextLocation textLocation = new DefaultPdfTextLocation(1, new iText.Kernel.Geom.Rectangle(20, 2), "");
            for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
            {
                IPdfTextLocation textLocation = new DefaultPdfTextLocation(i, new iText.Kernel.Geom.Rectangle(20, 2), "");
                //string sPageText = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i), extractionStrategy);
                string sPageText ="";
                Console.WriteLine(sPageText);
            }

        }
    }
}
