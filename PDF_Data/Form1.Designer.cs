
namespace PDF_Data
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenPdf = new System.Windows.Forms.Button();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenPdf
            // 
            this.btnOpenPdf.Location = new System.Drawing.Point(12, 12);
            this.btnOpenPdf.Name = "btnOpenPdf";
            this.btnOpenPdf.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPdf.TabIndex = 0;
            this.btnOpenPdf.Text = "Load PDF";
            this.btnOpenPdf.UseVisualStyleBackColor = true;
            this.btnOpenPdf.Click += new System.EventHandler(this.btnOpenPdf_Click);
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(12, 137);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(1107, 596);
            this.wb.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(362, 5);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(119, 30);
            this.btnAddField.TabIndex = 0;
            this.btnAddField.Text = "Add Feield";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 745);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.btnOpenPdf);
            this.Name = "frmMain";
            this.Text = "PDF Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPdf;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddField;
    }
}

