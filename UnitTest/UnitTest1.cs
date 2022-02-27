using Microsoft.VisualStudio.TestTools.UnitTesting;
using PDF_Data;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPreview()
        {
            List<FieldModel> fields = new List<FieldModel>();
            List<string> filePaths = new List<string>(new string[] { "C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf" });
            fields.Add(new FieldModel("department", new System.Drawing.Rectangle(125, 112, 105, 1280)));
            fields.Add(new FieldModel("province", new System.Drawing.Rectangle(236, 112, 105, 1280)));
            fields.Add(new FieldModel("district", new System.Drawing.Rectangle(324, 115, 220, 1280)));
            fields.Add(new FieldModel("label", new System.Drawing.Rectangle(637, 1522, 79, 16), 1, 1));
            Dictionary<string, string[]> data = PdfUtil.GetFieldsDataFromFile(filePaths, fields);
        }
    }
}
