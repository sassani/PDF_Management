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
        public PdfUtil PdfPreview { get; set; }

        private readonly string PAGE_C = "Page count: ";

        public frmMain()
        {
            InitializeComponent();
            btnExtractData.Enabled = false;
            /// TODO: remove this section tests
            filePaths = new List<string>(new string[] { "C:\\Users\\ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf" });
            previewFilePath = filePaths[0];
            lbFilesList.Items.AddRange(filePaths.ToArray());
            PdfPreview = new PdfUtil(previewFilePath);
            lbFilesList.SelectedIndex = 0;
            RenderPreview();
            /// -------------------------------
            lblError.Text = "";
            lblPageCount.Text = PAGE_C;
            fields = new List<FieldModel>();
        }

        public void AddField(FieldModel fm)
        {
            fields.Add(fm);
            RenderFields();
        }

        private void RenderFields()
        {
            if (fields.Count > 0)
            {
                btnExtractData.Enabled = true;
                lbFields.Items.Clear();
                foreach (var item in fields)
                {
                    if (item.FieldData == null)
                    {
                        item.FieldData = PdfUtil.GetDataFromPdfByArea(PdfPreview.PdfDoc, item.DataRegion);
                    }
                    lbFields.Items.Add(item);
                }
                lbFields.DisplayMember = "Name";
                lbFields.SelectedIndex = 0;
                ShowFieldsData();
            }
        }

        private void RenderPreview()
        {
            previewFilePath = lbFilesList.SelectedItem.ToString();
            lblError.Text = "";
            try
            {
                wb.Url = new Uri(PdfPreview.PreviewPath);
               
                lblPageCount.Text = PAGE_C + PdfPreview.PdfDoc.GetNumberOfPages();
                btnAddField.Enabled = true;
            }
            catch (Exception err)
            {
                lblError.Text = err.Message;
                lblPageCount.Text = PAGE_C + "0";
                btnAddField.Enabled = false;
            }

        }

        private void ShowFieldsData()
        {
            FieldModel currentField = (FieldModel)lbFields.SelectedItem;

            txtPreviewData.Text = String.Join("\n", currentField.FieldData);
        }

        #region Events
        private void btnAddField_Click(object sender, EventArgs e)
        {
            frmAddField addField = new frmAddField(this, PdfUtil.GetPteview(previewFilePath, int.Parse(txtPage.Text)));
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
            lbFilesList.SelectedIndex = 0;
            PdfPreview = new PdfUtil(filePaths[0]);
            RenderPreview();
        }

        private void lbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFieldsData();
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
