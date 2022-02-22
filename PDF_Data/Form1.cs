using iText.Kernel.Pdf;
using System;
using System.Windows.Forms;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Parser.Filter;
using System.Text;

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
            string dest = "C:\\Users\\asassani1\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf";
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(dest));

            Rectangle rect = new Rectangle(100, 100, 200, 200);
            getDataFromRect(rect);

        }

        private void getDataFromRect(Rectangle rect)
        {
            string dest = "C:\\Users\\asassani1\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf";
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(dest));
            TextRegionEventFilter regionFilter = new TextRegionEventFilter(rect);
            StringBuilder sb = new StringBuilder();
            for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
            {
                ITextExtractionStrategy strategy = new FilteredTextEventListener(new LocationTextExtractionStrategy(), regionFilter);
                String str = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy) + "\n\n";
                sb.Append(str);
            }

        }
    }
}
