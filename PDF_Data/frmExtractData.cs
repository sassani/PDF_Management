using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // TODO
        }
    }
}
