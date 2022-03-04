using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PDF_Data
{
    public partial class frmAddField : Form
    {
        private IDictionary<string, BLine> lines = new Dictionary<string, BLine>();
        private Image image;
        private frmMain parent;
        private string[] data;

        public frmAddField(frmMain parent, Image image, FieldModel currentField = null)
        {
            InitializeComponent();
            this.image = image;
            pbPreview.Image = this.image;
            this.parent = parent;
            cbType.Items.AddRange(FieldModel.GetTypes());
            cbType.SelectedIndex = 0;
            if (currentField != null) Initialize(currentField);
        }

        private void DrawLines()
        {
            pbPreview.Refresh();
            using (Graphics g = pbPreview.CreateGraphics())
            {
                foreach (BLine line in lines.Values)
                {
                    Pen pen = new Pen(line.PenColor);
                    g.DrawLine(pen, line.P1, line.P2);
                }
            }
        }

        private Rectangle GetRecatngle()
        {

            int w = Math.Abs(lines["left"].P1.X - lines["right"].P1.X);
            int h = Math.Abs(lines["top"].P1.Y - lines["bottom"].P1.Y);
            Point base1 = new Point(lines["left"].P1.X, image.Size.Height - lines["bottom"].P1.Y);// for y coordinate we need to change the direction. Base point is left_bottom instead of left_top
            Point base2 = new Point(lines["left"].P1.X, lines["top"].P1.Y);
            Rectangle rect = new Rectangle(base1, new Size(w, h));
            return rect;
        }

        private void Initialize(FieldModel field)
        {
            lines["top"] = new BLine("top", new Point(0, field.Y), new Point(image.Width, field.Y), rbTop.ForeColor);
            lines["bottom"] = new BLine("bottom", new Point(0, field.Y), new Point(image.Width, field.Y), rbTop.ForeColor);
            lines["left"] = new BLine("left", new Point(field.X, 0), new Point(field.X, image.Height), rbLeft.ForeColor);
            lines["right"] = new BLine("right", new Point(field.X, 0), new Point(field.X, image.Height), rbRight.ForeColor);
        }

        private bool CheckFieldName(string name)
        {
            if (name != "") return true;
            return false;
        }

        private void ValidateForm()
        {
            bool isValid = (
                CheckFieldName(txtFieldName.Text) &&
                (lines.Count == 4));
            btnSave.Enabled = isValid;
            if (isValid)
            {
                data = PdfUtil.GetDataFromPdfByArea(parent.PdfPreview.PdfDoc, GetRecatngle(), int.Parse(txtPageFrom.Text), int.Parse(txtPagesTo.Text));
                txtPreview.Text = String.Join("\n", data);
            }
        }

        #region Events
        private void pbPreview_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbTop.Checked)
            {
                lines["top"] = new BLine("top", new Point(0, e.Y), new Point(image.Width, e.Y), rbTop.ForeColor);
            }
            if (rbBottom.Checked)
            {
                lines["bottom"] = new BLine("bottom", new Point(0, e.Y), new Point(image.Width, e.Y), rbBottom.ForeColor);
            }
            if (rbLeft.Checked)
            {
                lines["left"] = new BLine("left", new Point(e.X, 0), new Point(e.X, image.Height), rbLeft.ForeColor);
            }
            if (rbRight.Checked)
            {
                lines["right"] = new BLine("right", new Point(e.X, 0), new Point(e.X, image.Height), rbRight.ForeColor);
            }
            DrawLines();
            ValidateForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Rectangle rect = GetRecatngle();
            parent.AddField(new FieldModel(
                txtFieldName.Text,
                rect.X, rect.Y, rect.Width, rect.Height,
                (FieldModel.DataTypes)Enum.Parse(typeof(FieldModel.DataTypes), cbType.SelectedItem.ToString()),
                data,
                int.Parse(txtPageFrom.Text),
                int.Parse(txtPagesTo.Text)));
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            DrawLines();
        }

        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            DrawLines();
        }
        #endregion
    }
}
