
namespace PDF_Data
{
    partial class frmAddField
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
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbBottom = new System.Windows.Forms.RadioButton();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPreview = new System.Windows.Forms.RichTextBox();
            this.txtPageFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPagesTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.ForeColor = System.Drawing.Color.Blue;
            this.rbLeft.Location = new System.Drawing.Point(59, 24);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(43, 17);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Left";
            this.rbLeft.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTop);
            this.groupBox1.Controls.Add(this.rbRight);
            this.groupBox1.Controls.Add(this.rbBottom);
            this.groupBox1.Controls.Add(this.rbLeft);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boundaries";
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.ForeColor = System.Drawing.Color.Red;
            this.rbTop.Location = new System.Drawing.Point(9, 24);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(44, 17);
            this.rbTop.TabIndex = 0;
            this.rbTop.TabStop = true;
            this.rbTop.Text = "Top";
            this.rbTop.UseVisualStyleBackColor = true;
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbRight.Location = new System.Drawing.Point(108, 24);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(50, 17);
            this.rbRight.TabIndex = 0;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "Right";
            this.rbRight.UseVisualStyleBackColor = true;
            // 
            // rbBottom
            // 
            this.rbBottom.AutoSize = true;
            this.rbBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbBottom.Location = new System.Drawing.Point(164, 24);
            this.rbBottom.Name = "rbBottom";
            this.rbBottom.Size = new System.Drawing.Size(58, 17);
            this.rbBottom.TabIndex = 0;
            this.rbBottom.TabStop = true;
            this.rbBottom.Text = "Bottom";
            this.rbBottom.UseVisualStyleBackColor = true;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(87, 10);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(160, 20);
            this.txtFieldName.TabIndex = 2;
            this.txtFieldName.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Field Name:";
            // 
            // pbPreview
            // 
            this.pbPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbPreview.Location = new System.Drawing.Point(3, 3);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(100, 100);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPreview.TabIndex = 4;
            this.pbPreview.TabStop = false;
            this.pbPreview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbPreview_MouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(632, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(713, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtPreview);
            this.panel1.Controls.Add(this.pbPreview);
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 345);
            this.panel1.TabIndex = 6;
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreview.Location = new System.Drawing.Point(620, 0);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(156, 345);
            this.txtPreview.TabIndex = 5;
            this.txtPreview.Text = "";
            // 
            // txtPageFrom
            // 
            this.txtPageFrom.Location = new System.Drawing.Point(322, 10);
            this.txtPageFrom.Name = "txtPageFrom";
            this.txtPageFrom.Size = new System.Drawing.Size(39, 20);
            this.txtPageFrom.TabIndex = 2;
            this.txtPageFrom.Text = "1";
            this.txtPageFrom.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pages from:";
            // 
            // txtPagesTo
            // 
            this.txtPagesTo.Location = new System.Drawing.Point(396, 10);
            this.txtPagesTo.Name = "txtPagesTo";
            this.txtPagesTo.Size = new System.Drawing.Size(39, 20);
            this.txtPagesTo.TabIndex = 2;
            this.txtPagesTo.Text = "-1";
            this.txtPagesTo.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Field Type:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(506, 9);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(81, 21);
            this.cbType.TabIndex = 7;
            // 
            // frmAddField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPagesTo);
            this.Controls.Add(this.txtPageFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddField";
            this.Text = "AddField";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbBottom;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPageFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPagesTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtPreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
    }
}