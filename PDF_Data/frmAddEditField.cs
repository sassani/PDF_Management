using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PDF_Data
{
    public partial class frmAddEditField : Form
    {
        private IDictionary<string, BLine> lines = new Dictionary<string, BLine>();
        private Point[] points = new Point[2];
        private Rectangle rectangle;
        private bool waitingForSecond = false;
        private Image image;
        private frmMain parent;
        private string[] data;
        private string currentKey;

        public frmAddEditField(frmMain parent, Image image, string currentKey = null)
        {
            InitializeComponent();
            this.image = image;
            pbPreview.Image = this.image;
            this.parent = parent;
            cbType.Items.AddRange(FieldModel.GetTypes());
            cbType.SelectedIndex = 0;
            this.currentKey = currentKey;
            if (currentKey != null)
            {
                Initialize();
            }
        }

        private void DrawRectangle()
        {
            pbPreview.Refresh();
            using (Graphics g = pbPreview.CreateGraphics())
            {
                Pen pen = new Pen(Color.Aqua);
                SolidBrush blueBrush = new SolidBrush(Color.FromArgb(50, 182, 239, 249));
                g.FillRectangle(blueBrush, rectangle);
                g.DrawRectangle(pen, rectangle);
            }
        }

        private void GenerateRectangle()
        {
            pbPreview.Refresh();
            Size s = new Size(Math.Abs(points[0].X - points[1].X), Math.Abs(points[0].Y - points[1].Y));
            Point b = new Point(0, 0);
            if (points[0].X < points[1].X)
            {//I and III
                if (points[0].Y < points[1].Y)
                {// III
                    b = points[0];
                }
                else
                {// I
                    b = new Point(points[0].X, points[1].Y);
                }
            }
            else
            {// II and IV
                if (points[0].Y < points[1].Y)
                {// IV
                    b = new Point(points[1].X, points[0].Y);
                }
                else
                {// II
                    b = points[1];
                }
            }
            rectangle = new Rectangle(b, s);
            DrawRectangle();
        }

        private void Initialize()
        {
            FieldModel field = parent.GetField(currentKey);
            rectangle = field.DataRegion;
            txtFieldName.Text = field.Name;
            DrawRectangle();
        }

        private bool CheckFieldName(string name)
        {
            if (name != "") return true;
            return false;
        }

        private bool CheckFormValidation()
        {
            bool isValid = (
                CheckFieldName(txtFieldName.Text)
                //&& (lines.Count == 4)
                );
            btnSave.Enabled = isValid;
            return isValid;
        }

        private void GetPreviewData()
        {
            if (CheckFormValidation())
            {
                try
                {
                    data = PdfUtil.GetDataFromPdfByArea(parent.PdfPreview.PdfDoc, rectangle, int.Parse(txtPageFrom.Text), int.Parse(txtPagesTo.Text));
                    txtPreview.Text = String.Join("\n", data);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        #region Events
        
        private void pbPreview_MouseClick(object sender, MouseEventArgs e)
        {
            if (!waitingForSecond)
            {
                points[0] = e.Location;
                waitingForSecond = true;
            }
            else
            {
                points[1] = e.Location;
                waitingForSecond = false;
                GetPreviewData();
            }

        }
        private void pbPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (waitingForSecond)
            {
                points[1] = e.Location;
                GenerateRectangle();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FieldModel temp = new FieldModel(
                    txtFieldName.Text,
                    rectangle,
                    (FieldModel.DataTypes)Enum.Parse(typeof(FieldModel.DataTypes), cbType.SelectedItem.ToString()),
                    data,
                    currentKey,
                    int.Parse(txtPageFrom.Text),
                    int.Parse(txtPagesTo.Text));
            if (currentKey == null)
            {
                parent.AddField(temp);
            }
            else
            {
                parent.EditField(currentKey, temp);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            GetPreviewData();
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            //DrawLines();
            DrawRectangle();
        }

        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            //DrawLines();
            DrawRectangle();
        }
        #endregion

        private void frmAddEditField_Load(object sender, EventArgs e)
        {
            if (currentKey != null) DrawRectangle();
        }
    }
}
