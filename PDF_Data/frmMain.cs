using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDF_Data
{
    public partial class frmMain : Form
    {
        //private List<FieldModel> fields__;
        private Dictionary<string, FieldModel> fields;
        private List<string> filePaths;
        private string previewFilePath;
        public PdfUtil PdfPreview { get; set; }

        private readonly string PAGE_C = "Page count: ";

        public frmMain()
        {
            InitializeComponent();
            btnExtractData.Enabled = false;
            lblError.Text = "";
            lblPageCount.Text = PAGE_C;
            //fields__ = new List<FieldModel>();
            fields = new Dictionary<string, FieldModel>();
        }

        public FieldModel GetField(string key)
        {
            return fields[key];
        }

        public void AddField(FieldModel fm)
        {
            fm.Id = Guid.NewGuid().ToString();
            fields.Add(fm.Id, fm);
            PrintFields();
        }

        public void EditField(string key, FieldModel fm)
        {
            fields[key] = fm;
            PrintFields();
        }

        private void RenderPreview()
        {
            previewFilePath = lbFilesList.SelectedItem.ToString();
            lblError.Text = "";
            try
            {
                wb.Url = new Uri(previewFilePath);
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

        private void PrintFields(string name = null)
        {
            if (fields.Count > 0)
            {
                btnExtractData.Enabled = true;
                lbFields.Items.Clear();
                foreach (KeyValuePair<string, FieldModel> item in fields)
                {
                    lbFields.Items.Add(item.Value);
                }
                lbFields.DisplayMember = "Name";
                lbFields.SelectedIndex = 0;
                PrintFieldsData();
            }
        }

        private void PrintFieldsData()
        {
            FieldModel selectedField = (FieldModel)lbFields.SelectedItem;
            if (selectedField.Data != null)
                txtPreviewData.Text = String.Join("\n", selectedField.Data);
        }

        private void InitializeData(List<FieldModel> _fields)
        {
            foreach (FieldModel item in _fields)
            {
                item.Data = PdfUtil.GetDataFromPdfByArea(PdfPreview.PdfDoc, item.DataRegion);
                item.Id = Guid.NewGuid().ToString();
                fields.Add(item.Id, item);
            }
        }

        #region Events
        private void btnAddEditField_Click(object sender, EventArgs e)
        {
            frmAddEditField addEditField = new frmAddEditField(this, PdfUtil.GetPteview(previewFilePath, int.Parse(txtPage.Text)));
            addEditField.ShowDialog();
            addEditField.Dispose();
        }

        private void lbFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmAddEditField addEditField = new frmAddEditField(this, PdfUtil.GetPteview(previewFilePath, int.Parse(txtPage.Text)), ((FieldModel)lbFields.SelectedItem).Id);
            if (addEditField.ShowDialog() == DialogResult.OK)
            {
                PrintFields();
            }
            addEditField.Dispose();
        }

        private void btnImportList_Click(object sender, EventArgs e)
        {
            wb.Url = null;
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

                filePaths = fileNames.ToList();
                lbFilesList.Items.AddRange(fileNames);
                PdfPreview = new PdfUtil(filePaths[0]);
                lbFilesList.SelectedIndex = 0;
                RenderPreview();
            }
        }

        private void lbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintFieldsData();
        }

        private void lbFilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("test");

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
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        private void btnExtractData_Click(object sender, EventArgs e)
        {
            frmExtractData extractData = new frmExtractData(filePaths, fields.Values.ToList());
            extractData.ShowDialog();
            extractData.Dispose();
        }

        private void btnSaveFields_Click(object sender, EventArgs e)
        {

            string json = FieldModel.GetFieldsjason(fields.Values.ToList());
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
                //fields = FieldModel.GetListFromJson(json);
                InitializeData(FieldModel.GetListFromJson(json));
                PrintFields();
            }
        }

        #endregion

        private void lbFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Console.WriteLine(lbFields.SelectedItem);

            }
        }
    }
}
