//using org.pdfclown.documents;
//using org.pdfclown.files;
//using org.pdfclown.tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PDF_Data
{
    public partial class frmMain : Form
    {
        private Image preview;
        private List<FieldModel> fields;
        private List<string> filePaths;
        public FileManager FilePreview { get; private set; }

        private string filePath = "C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf";

        public frmMain()
        {
            InitializeComponent();
            filePaths = new List<string>(new string[] { "C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\DengAI\\data\\DataCollection\\peru\\2020\\23.pdf" });
            FilePreview = new FileManager(filePaths[0]);
            fields = new List<FieldModel>();
        }

        public void AddField(FieldModel fm)
        {
            fields.Add(fm);
            RenderFields();
        }

        private void RenderFields()
        {
            var data = PdfUtil.GetFieldsDataFromFile(filePaths, fields);
            lbFields.Items.Clear();
            foreach (var item in fields)
            {
                lbFields.Items.Add(item.Name);
            }
        }

        #region Events
        private void btnAddField_Click(object sender, EventArgs e)
        {

            //frmAddField addField = new frmAddField(this, PdfUtil.GetPteview("C:\\Users\\Ardavan\\OneDrive - Georgia State University\\DICE\\OSM Queries.pdf"));
            frmAddField addField = new frmAddField(this, PdfUtil.GetPteview(filePaths[0]));
            addField.ShowDialog();
        }

        private void btnImportList_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|List of files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                // TODO: set filePaths according to dialog insert type

            }
        }

        private void btnOpenPdf_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                //string dest = openFileDialog1.FileName;
                //wb.Url = new Uri(dest);
                //File f = new File(dest);
                //Document doc = f.Document;
                //Renderer renderer = new Renderer();
                //preview = renderer.Render(doc.Pages[0], new SizeF(595, 840));
            }
        }
        #endregion

        private void lbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPreviewData.Text = "33";
        }
    }
}
