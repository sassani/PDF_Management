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

namespace PDF_Data
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Image preview;
        private iText.Kernel.Pdf.PdfDocument pdfDoc;

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
                pictureBox1.Image = preview;
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
            iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(
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

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = txtPreview.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            g.DrawLine(pen,e.X,0,e.X,800 );
            g.Dispose();
            System.Drawing.Point point = new System.Drawing.Point(e.Location.X,e.Location.Y);
            Console.WriteLine(point);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dest = "C:\\Users\\asassani1\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf";
            File f = new File(dest);
            Document doc = f.Document;
            Renderer renderer = new Renderer();
            var g = renderer.Render(doc.Pages[0], new SizeF(595, 840));
            pictureBox1.Image = g;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            g.DrawLine(pen, e.X, 0, e.X, 800);
            g.Dispose();
            System.Drawing.Point point = new System.Drawing.Point(e.Location.X, e.Location.Y);
            Console.WriteLine(point);
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            frmAddField addField = new frmAddField(preview);
            addField.ShowDialog();
        }
    }
}
