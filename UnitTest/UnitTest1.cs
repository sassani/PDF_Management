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
            List<string> filePaths = new List<string>();

            filePaths.Add("C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf");
            //filePaths.Add("C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\24.pdf");
            //filePaths.Add("C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\25.pdf");

            fields.Add(new FieldModel("department", 125, 112, 105, 1280,FieldModel.DataTypes.ROWS));
            fields.Add(new FieldModel("province", 236, 112, 105, 1280, FieldModel.DataTypes.ROWS));
            fields.Add(new FieldModel("district", 324, 115, 220, 1280, FieldModel.DataTypes.ROWS));
            fields.Add(new FieldModel("label", 637, 1522, 79, 16,FieldModel.DataTypes.FIXED, 1, 1));

            var data = PdfUtil.GetDataTableAsync(filePaths, fields);
        }
    }
}
