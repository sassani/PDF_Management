
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
            this.wb = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportList = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbFilesList = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbFields = new System.Windows.Forms.ListBox();
            this.txtPreviewData = new System.Windows.Forms.RichTextBox();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnExtractData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(0, 60);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(390, 568);
            this.wb.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnImportList
            // 
            this.btnImportList.Location = new System.Drawing.Point(10, 3);
            this.btnImportList.Margin = new System.Windows.Forms.Padding(1);
            this.btnImportList.Name = "btnImportList";
            this.btnImportList.Size = new System.Drawing.Size(75, 23);
            this.btnImportList.TabIndex = 0;
            this.btnImportList.Text = "Open PDF";
            this.btnImportList.UseVisualStyleBackColor = true;
            this.btnImportList.Click += new System.EventHandler(this.btnImportList_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(10, 3);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(75, 23);
            this.btnAddField.TabIndex = 0;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblError);
            this.splitContainer1.Panel1.Controls.Add(this.lbFilesList);
            this.splitContainer1.Panel1.Controls.Add(this.btnImportList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 628);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.TabIndex = 3;
            // 
            // lbFilesList
            // 
            this.lbFilesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilesList.FormattingEnabled = true;
            this.lbFilesList.Location = new System.Drawing.Point(3, 60);
            this.lbFilesList.Name = "lbFilesList";
            this.lbFilesList.Size = new System.Drawing.Size(363, 563);
            this.lbFilesList.TabIndex = 3;
            this.lbFilesList.SelectedIndexChanged += new System.EventHandler(this.lbFilesList_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblPageCount);
            this.splitContainer2.Panel1.Controls.Add(this.wb);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbFields);
            this.splitContainer2.Panel2.Controls.Add(this.txtPreviewData);
            this.splitContainer2.Panel2.Controls.Add(this.btnExtractData);
            this.splitContainer2.Panel2.Controls.Add(this.btnAddField);
            this.splitContainer2.Size = new System.Drawing.Size(756, 628);
            this.splitContainer2.SplitterDistance = 390;
            this.splitContainer2.TabIndex = 0;
            // 
            // lbFields
            // 
            this.lbFields.FormattingEnabled = true;
            this.lbFields.Location = new System.Drawing.Point(3, 60);
            this.lbFields.Name = "lbFields";
            this.lbFields.Size = new System.Drawing.Size(356, 134);
            this.lbFields.TabIndex = 2;
            this.lbFields.SelectedIndexChanged += new System.EventHandler(this.lbFields_SelectedIndexChanged);
            // 
            // txtPreviewData
            // 
            this.txtPreviewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreviewData.Location = new System.Drawing.Point(0, 202);
            this.txtPreviewData.Name = "txtPreviewData";
            this.txtPreviewData.Size = new System.Drawing.Size(362, 426);
            this.txtPreviewData.TabIndex = 0;
            this.txtPreviewData.Text = "";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(3, 44);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(35, 13);
            this.lblPageCount.TabIndex = 2;
            this.lblPageCount.Text = "label1";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 27);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(28, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "error";
            // 
            // btnExtractData
            // 
            this.btnExtractData.Location = new System.Drawing.Point(10, 28);
            this.btnExtractData.Margin = new System.Windows.Forms.Padding(1);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(75, 23);
            this.btnExtractData.TabIndex = 0;
            this.btnExtractData.Text = "Extract Data";
            this.btnExtractData.UseVisualStyleBackColor = true;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 630);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "PDF Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportList;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox txtPreviewData;
        private System.Windows.Forms.ListBox lbFields;
        private System.Windows.Forms.ListBox lbFilesList;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnExtractData;
    }
}

