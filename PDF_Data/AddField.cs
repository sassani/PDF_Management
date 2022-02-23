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
        public frmAddField(Image image)
        {
            InitializeComponent();
            this.image = image;
            pbPreview.Image = this.image;
        }

        private void pbPreview_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbTop.Checked)
            {
                lines["top"] = new BLine(new Point(0, e.Y), new Point(3000, e.Y), rbTop.ForeColor);
            }
            if (rbBottom.Checked)
            {
                lines["bottom"] = new BLine(new Point(0, e.Y), new Point(3000, e.Y), rbBottom.ForeColor);
            }
            if (rbLeft.Checked)
            {
                lines["left"] = new BLine(new Point(e.X, 0), new Point(e.X, 3000), rbLeft.ForeColor);
            }
            if (rbRight.Checked)
            {
                lines["right"] = new BLine(new Point(e.X, 0), new Point(e.X, 3000), rbRight.ForeColor);
            }
            DrawLines();
        }

        private void DrawLines()
        {
            pbPreview.Image = image;
            Graphics g = pbPreview.CreateGraphics();
            foreach (BLine line in lines.Values)
            {
                Pen pen = new Pen(line.PenColor);
                g.DrawLine(pen, line.P1, line.P2);
            }
            g.Dispose();
        }
    }
}
