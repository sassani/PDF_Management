using Ghostscript.NET.Rasterizer;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Filter;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PDF_Data
{
    public class PdfUtil
    {
        private static readonly int RESOLUTION = 150;

        public static Image GetPteview(string filePath)
        {
            Image preview = new Bitmap(10, 10);
            using (GhostscriptRasterizer rasterizer = new GhostscriptRasterizer())
            {
                rasterizer.Open(filePath);
                preview = rasterizer.GetPage(RESOLUTION, 1);
            }
            return preview;
        }

        public static Dictionary<string, string[]> GetFieldsDataFromFile(List<string> filePaths, List<FieldModel> fields)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            foreach (string filePath in filePaths)
            {
                PdfDocument pdfDoc = new PdfDocument(new PdfReader(filePath));
                foreach (FieldModel fm in fields)
                {
                    data[fm.Name] = GetDataFromPdfByArea(pdfDoc, fm.DataRegion, fm.FirstPage, fm.LastPage);
                }
            }
            return data;
        }

        public static Dictionary<string, string[]> GetFieldsDataFromFile(List<string> filePaths, FieldModel field)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            foreach (string filePath in filePaths)
            {
                data[field.Name] = GetDataFromPdfByArea(GetPdf(filePath), field.DataRegion, field.FirstPage, field.LastPage);
            }
            return data;
        }

        public static PdfDocument GetPdf(string filePath)
        {
            return new PdfDocument(new PdfReader(filePath));
        }

        public static string[] GetDataFromPdfByArea(PdfDocument pdfDoc, Rectangle r, int pageFrom = 1, int pageTo = -1)
        {
            iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(
                PointToPixel(r.X),
                PointToPixel(r.Y),
                PointToPixel(r.Width),
                PointToPixel(r.Height)
                );
            TextRegionEventFilter regionFilter = new TextRegionEventFilter(rect);
            StringBuilder sb = new StringBuilder();
            int lastPage = pdfDoc.GetNumberOfPages();
            if (pageTo > 0) lastPage = pageTo;
            for (int i = pageFrom; i <= lastPage; i++)
            {
                string data = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i), new FilteredTextEventListener(new LocationTextExtractionStrategy(), regionFilter));
                sb.AppendLine(data);
            }
            return sb.ToString().Remove(sb.Length - 2).Split('\n');
        }

        private static float PointToPixel(int pt)
        {
            return pt * 72 / RESOLUTION;
        }


    }
}
