using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Data
{
    public partial class frmExtractData : Form
    {
        private List<FieldModel> fields;
        private List<string> filePaths;
        private DataTable dt = new DataTable();
        public frmExtractData(List<string> filePaths, List<FieldModel> fields)
        {
            InitializeComponent();
            this.filePaths = filePaths;
            this.fields = fields;
            GetDataAsync();
        }

        private async void GetDataAsync()
        {
            dt = await PdfUtil.GetDataTableAsync(filePaths, fields);
            dgvExtractedData.DataSource = dt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Comma separated file (*.csv)|*.csv";
            openFileDialog1.AddExtension = true;
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.FileName = "Export";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        csv.WriteField(dc.ColumnName);
                    }
                    csv.NextRecord();

                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            csv.WriteField(dr[dc]);
                        }
                        csv.NextRecord();
                    }
                }
            }
        }
    }
}
