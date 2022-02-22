
namespace PDF_Data
{
    partial class Form1
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenPdf
            // 
            this.btnOpenPdf.Location = new System.Drawing.Point(12, 12);
            this.btnOpenPdf.Name = "btnOpenPdf";
            this.btnOpenPdf.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPdf.TabIndex = 0;
            this.btnOpenPdf.Text = "button1";
            this.btnOpenPdf.UseVisualStyleBackColor = true;
            this.btnOpenPdf.Click += new System.EventHandler(this.btnOpenPdf_Click);
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(12, 237);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(960, 568);
            this.wb.TabIndex = 1;
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbReader_DocumentCompleted);
            this.wb.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wbReader_Navigating);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(12, 34);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(56, 20);
            this.txtX.TabIndex = 1;
            this.txtX.Text = "0";
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(74, 34);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(56, 20);
            this.txtY.TabIndex = 2;
            this.txtY.Text = "0";
            this.txtY.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(136, 34);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(56, 20);
            this.txtW.TabIndex = 3;
            this.txtW.Text = "200";
            this.txtW.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(198, 34);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(56, 20);
            this.txtH.TabIndex = 4;
            this.txtH.Text = "200";
            this.txtH.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtH);
            this.panel1.Controls.Add(this.txtX);
            this.panel1.Controls.Add(this.txtW);
            this.panel1.Controls.Add(this.txtY);
            this.panel1.Location = new System.Drawing.Point(93, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "W:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "H:";
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(39, 146);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(863, 637);
            this.txtPreview.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 817);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.btnOpenPdf);
            this.Name = "Form1";
            this.Text = "PDF Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPdf;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreview;
    }
}

