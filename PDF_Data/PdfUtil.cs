using Ghostscript.NET.Rasterizer;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Filter;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Data
{
    public class PdfUtil
    {
        private static readonly int RESOLUTION = 150;
        public PdfDocument PdfDoc { get; set; }
        public string PreviewPath { get; set; }
        public int PageNumber { get; set; }


        public PdfUtil(string fileName)
        {
            PreviewPath = fileName;
            PdfDoc = GetPdf(PreviewPath);
            PageNumber = PdfDoc.GetNumberOfPages();
        }

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

        public static async Task<DataTable> GetDataTableAsync(List<string> filePaths, List<FieldModel> fields)
        {
            DataTable dt = new DataTable("extracted_data");
            foreach (var field in fields)
            {
                dt.Columns.Add(field.Name);
            }
            try
            {
                foreach (string filePath in filePaths)
                {
                    PdfDocument pdfDoc = await GetPdfAsync(filePath);
                    var data = await GetFieldsDataFromFile (filePath, fields);
                    int maxDataCount = GetMAxDataCount(data);
                    for (int i = 0; i < maxDataCount; i++)
                    {
                        DataRow newRow = dt.NewRow();
                        foreach (FieldModel field in fields)
                        {
                            String[] fieldData = data[field.Name];
                            if (fieldData.Length >= maxDataCount)
                            {
                                newRow[field.Name] = fieldData.GetValue(i);
                            }
                            else
                            {
                                newRow[field.Name] = fieldData.GetValue(fieldData.Length - 1);
                            }
                        }
                        dt.Rows.Add(newRow);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            return dt;
        }

        private static int GetMAxDataCount(Dictionary<string, string[]> data)
        {
            int max = 0;
            foreach (var item in data.Keys)
            {
                if (max < data[item].Length) max = data[item].Length;
            }
            return max;
        }

        public static Dictionary<string, string[]> GetFieldsDataFromFile(List<string> filePaths, List<FieldModel> fields)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            try
            {
                foreach (string filePath in filePaths)
                {
                    PdfDocument pdfDoc = new PdfDocument(new PdfReader(filePath));
                    foreach (FieldModel fm in fields)
                    {
                        data[fm.Name] = GetDataFromPdfByArea(pdfDoc, fm.DataRegion, fm.FirstPage, fm.LastPage);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            return data;


        }

        public static async Task<Dictionary<string, string[]>> GetFieldsDataFromFile(List<string> filePaths, FieldModel field)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            foreach (string filePath in filePaths)
            {
                data[field.Name] = GetDataFromPdfByArea(await GetPdfAsync(filePath), field.DataRegion, field.FirstPage, field.LastPage);
            }
            return data;
        }

        public static async Task<Dictionary<string, string[]>> GetFieldsDataFromFile(string filePath, List<FieldModel> fields)
        {
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            foreach (var field in fields)
            {
                data[field.Name] = GetDataFromPdfByArea(await GetPdfAsync(filePath), field.DataRegion, field.FirstPage, field.LastPage);
            }
            return data;
        }

        public static async Task<PdfDocument> GetPdfAsync(string filePath)
        {
            try
            {
                return await Task.Run(()=> new PdfDocument(new PdfReader(filePath)));
            }
            catch (Exception)
            {

                throw new Exception($"File Not Found {Environment.NewLine}({filePath})");
            }

        }

        public static PdfDocument GetPdf(string filePath)
        {
            try
            {
                return  new PdfDocument(new PdfReader(filePath));
            }
            catch (Exception)
            {

                throw new Exception($"File Not Found {Environment.NewLine}({filePath})");
            }

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
            try
            {
                int lastPage = pdfDoc.GetNumberOfPages();
                if (pageTo > 0) lastPage = pageTo;
                for (int i = pageFrom; i <= lastPage; i++)
                {
                    string data = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i), new FilteredTextEventListener(new LocationTextExtractionStrategy(), regionFilter));
                    sb.AppendLine(data);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            return sb.ToString().Remove(sb.Length - 2).Split('\n');
        }

        private static float PointToPixel(int pt)
        {
            return pt * 72 / RESOLUTION;
        }


    }
}
