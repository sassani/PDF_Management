using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Filter;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
//using org.pdfclown.documents;
//using org.pdfclown.files;
//using org.pdfclown.tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ghostscript.NET.Rasterizer;
using PdfSharp;
using PdfSharp.Drawing;
//using PdfSharp.Pdf;
//using PdfSharp.Pdf.IO;

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

        public static string[] GetDataFromPdfByArea(string filePath, Rectangle r)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(filePath));
            iText.Kernel.Geom.Rectangle rect = new iText.Kernel.Geom.Rectangle(
                PointToPixel(r.X),
                PointToPixel(r.Y),
                PointToPixel(r.Width),
                PointToPixel(r.Height)
                );
            TextRegionEventFilter regionFilter = new TextRegionEventFilter(rect);
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
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
