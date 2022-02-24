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
    public partial class frmAddField : Form
    {
        private IDictionary<string, BLine> lines = new Dictionary<string, BLine>();
        private Image image;
        private frmMain parent;
        public frmAddField(frmMain parent, Image image)
        {
            InitializeComponent();
            this.image = image;
            pbPreview.Image = this.image;
            this.parent = parent;
        }

        private void pbPreview_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbTop.Checked)
            {
                lines["top"] = new BLine("top", new Point(0, e.Y), new Point(3000, e.Y), rbTop.ForeColor);
            }
            if (rbBottom.Checked)
            {
                lines["bottom"] = new BLine("bottom", new Point(0, e.Y), new Point(3000, e.Y), rbBottom.ForeColor);
            }
            if (rbLeft.Checked)
            {
                lines["left"] = new BLine("left", new Point(e.X, 0), new Point(e.X, 3000), rbLeft.ForeColor);
            }
            if (rbRight.Checked)
            {
                lines["right"] = new BLine("right", new Point(e.X, 0), new Point(e.X, 3000), rbRight.ForeColor);
            }
            DrawLines();
            CheckForm();
        }

        private void DrawLines()
        {
            pbPreview.Refresh();
            Graphics g = pbPreview.CreateGraphics();
            
            foreach (BLine line in lines.Values)
            {
                Pen pen = new Pen(line.PenColor);
                g.DrawLine(pen, line.P1, line.P2);
            }
            g.Dispose();
        }

        public List<Point> GetPoints()
        {
            return new List<Point>
            {
                new Point(lines["left"].P1.X, image.Size.Height - lines["top"].P1.Y), // top-left corner
                new Point(lines["right"].P1.X, image.Size.Height - lines["bottom"].P1.Y) // bottom-right corner
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            parent.AddField(new FieldModel(txtFieldName.Text, GetPoints()));
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean CheckFieldName(string name)
        {
            if (name != "") return true;
            return false;
        }

        private void CheckForm()
        {
            btnSave.Enabled =  (
                CheckFieldName(txtFieldName.Text) && 
                (lines.Count == 4));
        }

        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            CheckForm();
        }
    }
}
