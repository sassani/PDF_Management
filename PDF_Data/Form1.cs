using iText.Kernel.Pdf;
using System;
using System.Windows.Forms;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Parser.Filter;
using System.Text;
using org.pdfclown.tools;
using org.pdfclown.files;

//using IronPdf;
using System.Drawing;
using org.pdfclown.documents;
using System.Collections.Generic;

namespace PDF_Data
{
    public partial class frmMain : Form
    {
        private Image preview;
        private iText.Kernel.Pdf.PdfDocument pdfDoc;
        private List<FieldModel> fields;

        public frmMain()
        {
            InitializeComponent();
            fields = new List<FieldModel>();
        }

        public void AddField(FieldModel fm)
        {
            fields.Add(fm);
        }


        public void DrawLineInt(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create coordinates of points that define line.
            int x1 = 100;
            int y1 = 100;
            int x2 = 500;
            int y2 = 100;

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
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


                File f = new File(dest);
                Document doc = f.Document;
                Renderer renderer = new Renderer();
                preview = renderer.Render(doc.Pages[0], new SizeF(595, 840));
                //pictureBox1.Image = preview;
            }
            //string dest = "https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.webbrowser.document?view=netframework-4.7.2";

            //iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(new PdfReader(dest));
            //IronPdf.PdfDocument ironPdf = IronPdf.PdfDocument.FromFile(dest);

            //string AllText = ironPdf.ExtractAllText();

            //HtmlDocument test = wbReader.Document;

            //Rectangle rect = new Rectangle(0, 0, 250, 200);
            //getDataFromRect(rect);


        }

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
            iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(3,3,3,3);
            TextRegionEventFilter regionFilter = new TextRegionEventFilter(rect);
            ITextExtractionStrategy strategy = new FilteredTextEventListener(new LocationTextExtractionStrategy(), regionFilter);
            String str = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(1), strategy)+"\n";
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            frmAddField addField = new frmAddField(this, preview);
            addField.ShowDialog();
        }
    }
}
