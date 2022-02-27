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

        public static Dictionary<string, string[]> GetFieldsDataFromFile(string filePath, List<FieldModel> fields)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(filePath));
            foreach (FieldModel fm in fields)
            {
                data[fm.Name] = GetFieldDataFromPdf(pdfDoc, fm);
            }
            return data;
        }

        public static string[] GetFieldDataFromPdf(PdfDocument pdfDoc, FieldModel fm)
        {
            if (fm.Page == FieldModel.PageLocation.ALL) return GetDataFromPdfByArea(pdfDoc, fm.DataArea);
            if (fm.Page == FieldModel.PageLocation.COVER) return GetDataFromPdfByArea(pdfDoc, fm.DataArea, 1, 1);
            if (fm.Page == FieldModel.PageLocation.RANGE) return GetDataFromPdfByArea(pdfDoc, fm.DataArea, fm.FirstPage, fm.LastPage);
            return null;
        }

        private static string[] GetDataFromPdfByArea(PdfDocument pdfDoc, Rectangle r, int pageFrom = 1, int pageTo = -1)
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
