using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDF_Data
{
    public partial class frmMain : Form
    {
        private List<FieldModel> fields;
        private List<string> filePaths;
        private string previewFilePath;
        public DataManager FilePreview { get; private set; }
        private readonly string PAGE_C = "Page count: ";

        public frmMain()
        {
            InitializeComponent();
            btnExtractData.Enabled = false;
            /// TODO: remove this section tests
            filePaths = new List<string>(new string[] { "C:\\Users\\ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf" });
            previewFilePath = filePaths[0];
            lbFilesList.Items.AddRange(filePaths.ToArray());
            FilePreview = new DataManager(previewFilePath);
            /// -------------------------------
            lblError.Text = "";
            lblPageCount.Text = PAGE_C;
            fields = new List<FieldModel>();
            RenderPreview();
        }

        public void AddField(FieldModel fm)
        {
            fields.Add(fm);
            RenderFields();
        }

        private void RenderFields()
        {
            if (fields.Count > 0) btnExtractData.Enabled = true;
            //var data = PdfUtil.GetFieldsDataFromFile(filePaths, fields);
            lbFields.Items.Clear();
            foreach (var item in fields)
            {
                lbFields.Items.Add(item.Name);
            }
        }

        private void RenderPreview()
        {
            lblError.Text = "";
            try
            {
                wb.Url = new Uri(previewFilePath);
                FilePreview = new DataManager(previewFilePath);
                lblPageCount.Text = PAGE_C + FilePreview.pdfDoc.GetNumberOfPages();
                btnAddField.Enabled = true;
            }
            catch (Exception err)
            {
                lblError.Text = err.Message;
                lblPageCount.Text = PAGE_C + "0";
                btnAddField.Enabled = false;
            }

        }

        #region Events
        private void btnAddField_Click(object sender, EventArgs e)
        {
            frmAddField addField = new frmAddField(this, PdfUtil.GetPteview(previewFilePath));
            addField.ShowDialog();
        }

        private void btnImportList_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|List of files (*.txt)|*.txt";
            lbFilesList.Items.Clear();
            string[] fileNames = new string[] { "" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNames = openFileDialog1.FileNames;
                string[] temp = fileNames[0].Split('.');
                string extention = temp[temp.Length - 1];
                if (extention.ToLower() == "txt")
                {
                    fileNames = File.ReadAllLines(fileNames[0]);
                }
            }
            filePaths = fileNames.ToList();
            lbFilesList.Items.AddRange(fileNames);
        }

        private void lbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPreviewData.Text = "Under Construction!";
        }

        private void lbFilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string temp = "";
                if (lbFilesList.SelectedItem != null) temp = lbFilesList.SelectedItem.ToString();
                if (temp != "")
                {
                    previewFilePath = temp;
                    RenderPreview();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnExtractData_Click(object sender, EventArgs e)
        {
            frmExtractData extractData = new frmExtractData(filePaths, fields);
            extractData.ShowDialog();
        }

        private void btnSaveFields_Click(object sender, EventArgs e)
        {

            string json = FieldModel.GetFieldsjason(fields);
            openFileDialog1.Filter = "JavaScript Object Notation (*.json)|*.json";
            openFileDialog1.AddExtension = true;
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.FileName = "Fields";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine(json);
                }
            }
        }

        private void btnImportFields_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JavaScript Object Notation (*.json)|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string json = File.ReadAllText(fileName);
                fields = FieldModel.GetListFromJson(json);
                RenderFields();
            }
        }
        #endregion
    }
}
