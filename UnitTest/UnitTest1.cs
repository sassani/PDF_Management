using Microsoft.VisualStudio.TestTools.UnitTesting;
using PDF_Data;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPreview()
        {
            string dest = "C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf";
            List<FieldModel> fields = new List<FieldModel>();
            fields.Add(new FieldModel("department", FieldModel.FieldTypes.FIXED, new System.Drawing.Rectangle(125, 112, 105, 1280)));
            fields.Add(new FieldModel("province", FieldModel.FieldTypes.FIXED, new System.Drawing.Rectangle(236, 112, 105, 1280)));
            fields.Add(new FieldModel("district", FieldModel.FieldTypes.FIXED, new System.Drawing.Rectangle(324, 115, 220, 1280)));
            fields.Add(new FieldModel("label", FieldModel.FieldTypes.LABEL, new System.Drawing.Rectangle(637, 1522, 79, 16)));
            Dictionary<string, string[]> data = new Dictionary<string, string[]>();
            foreach (FieldModel fm in fields)
            {
                data[fm.Name] = PdfUtil.GetDataFromPdfByArea(dest, fm.DataArea);
            }
        }
    }
}
