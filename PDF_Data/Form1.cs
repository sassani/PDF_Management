using iText.Kernel.Pdf;
using System;
using System.Windows.Forms;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Parser.Filter;
using System.Text;

using IronPdf;

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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                dest = openFileDialog1.FileName;
                wb.Url = new Uri(dest);
                pdfDoc = new iText.Kernel.Pdf.PdfDocument(new PdfReader(dest));
            }
            //string dest = "https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.webbrowser.document?view=netframework-4.7.2";

            //iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(new PdfReader(dest));
            //IronPdf.PdfDocument ironPdf = IronPdf.PdfDocument.FromFile(dest);

            //string AllText = ironPdf.ExtractAllText();

            //HtmlDocument test = wbReader.Document;

            //Rectangle rect = new Rectangle(0, 0, 250, 200);
            //getDataFromRect(rect);

        }

        bool WebBrowserDocumentEventSet = false;

        private iText.Kernel.Pdf.PdfDocument pdfDoc;


        private void getDataFromRect()
        {
            //string dest = "C:\\Users\\asassani1\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf";
            //pdfDoc = new iText.Kernel.Pdf.PdfDocument(new PdfReader(dest));
            //TextRegionEventFilter regionFilter = new TextRegionEventFilter(rect);
            //StringBuilder sb = new StringBuilder();
            //for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
            //{
            //    ITextExtractionStrategy strategy = new FilteredTextEventListener(new LocationTextExtractionStrategy(), regionFilter);
            //    String str = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy) + "\n\n";
            //    sb.Append(str);
            //}

        }

        private void GetPreviewDataFromRect()
        {
            Rectangle rect = new Rectangle(
               float.Parse(txtX.Text),
                float.Parse(txtY.Text),
                float.Parse(txtW.Text),
                float.Parse(txtH.Text)
                );
            TextRegionEventFilter regionFilter = new TextRegionEventFilter(rect);
            ITextExtractionStrategy strategy = new FilteredTextEventListener(new LocationTextExtractionStrategy(), regionFilter);
            String str = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(1), strategy)+"\n";
            txtPreview.Text = str;
        }

        private void wbReader_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //WebBrowser wb = (sender as WebBrowser);
            if (wb.ReadyState == WebBrowserReadyState.Complete && WebBrowserDocumentEventSet == false)
            {
                //WebBrowserDocumentEventSet = true;
                //wb.Document.MouseDown += OnHtmlDocumentClick;
            }
            Console.WriteLine(wb.DocumentType);
            //wb.DocumentType.MouseDown += OnHtmlDocumentClick;
        }

        private void wbReader_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //(sender as WebBrowser).Document.MouseDown -= OnHtmlDocumentClick;
            //WebBrowserDocumentEventSet = false;
        }

        private void OnHtmlDocumentClick(object sender, HtmlElementEventArgs e)
        {
            Console.WriteLine(e.ClientMousePosition);
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            GetPreviewDataFromRect();
        }
    }
}
