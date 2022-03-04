
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
            this.lblError = new System.Windows.Forms.Label();
            this.lbFilesList = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnImportFields = new System.Windows.Forms.Button();
            this.btnSaveFields = new System.Windows.Forms.Button();
            this.lbFields = new System.Windows.Forms.ListBox();
            this.txtPreviewData = new System.Windows.Forms.RichTextBox();
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
            this.wb.Location = new System.Drawing.Point(0, 143);
            this.wb.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.wb.MinimumSize = new System.Drawing.Size(53, 48);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(938, 654);
            this.wb.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnImportList
            // 
            this.btnImportList.Location = new System.Drawing.Point(27, 7);
            this.btnImportList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportList.Name = "btnImportList";
            this.btnImportList.Size = new System.Drawing.Size(200, 55);
            this.btnImportList.TabIndex = 0;
            this.btnImportList.Text = "Open PDF";
            this.btnImportList.UseVisualStyleBackColor = true;
            this.btnImportList.Click += new System.EventHandler(this.btnImportList_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(27, 7);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(200, 55);
            this.btnAddField.TabIndex = 0;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblError);
            this.splitContainer1.Panel1.Controls.Add(this.lbFilesList);
            this.splitContainer1.Panel1.Controls.Add(this.btnImportList);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(2737, 814);
            this.splitContainer1.SplitterDistance = 892;
            this.splitContainer1.SplitterWidth = 11;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(8, 64);
            this.lblError.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(74, 32);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "error";
            // 
            // lbFilesList
            // 
            this.lbFilesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilesList.FormattingEnabled = true;
            this.lbFilesList.ItemHeight = 31;
            this.lbFilesList.Location = new System.Drawing.Point(8, 143);
            this.lbFilesList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbFilesList.Name = "lbFilesList";
            this.lbFilesList.Size = new System.Drawing.Size(872, 407);
            this.lbFilesList.TabIndex = 3;
            this.lbFilesList.SelectedIndexChanged += new System.EventHandler(this.lbFilesList_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblPageCount);
            this.splitContainer2.Panel1.Controls.Add(this.wb);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtPage);
            this.splitContainer2.Panel2.Controls.Add(this.btnImportFields);
            this.splitContainer2.Panel2.Controls.Add(this.btnSaveFields);
            this.splitContainer2.Panel2.Controls.Add(this.lbFields);
            this.splitContainer2.Panel2.Controls.Add(this.txtPreviewData);
            this.splitContainer2.Panel2.Controls.Add(this.btnExtractData);
            this.splitContainer2.Panel2.Controls.Add(this.btnAddField);
            this.splitContainer2.Size = new System.Drawing.Size(1834, 814);
            this.splitContainer2.SplitterDistance = 946;
            this.splitContainer2.SplitterWidth = 11;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(8, 105);
            this.lblPageCount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(93, 32);
            this.lblPageCount.TabIndex = 2;
            this.lblPageCount.Text = "label1";
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(233, 16);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 38);
            this.txtPage.TabIndex = 4;
            this.txtPage.Text = "1";
            // 
            // btnImportFields
            // 
            this.btnImportFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportFields.Location = new System.Drawing.Point(440, 74);
            this.btnImportFields.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnImportFields.Name = "btnImportFields";
            this.btnImportFields.Size = new System.Drawing.Size(200, 55);
            this.btnImportFields.TabIndex = 3;
            this.btnImportFields.Text = "Import Fields";
            this.btnImportFields.UseVisualStyleBackColor = true;
            this.btnImportFields.Click += new System.EventHandler(this.btnImportFields_Click);
            // 
            // btnSaveFields
            // 
            this.btnSaveFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFields.Location = new System.Drawing.Point(656, 74);
            this.btnSaveFields.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSaveFields.Name = "btnSaveFields";
            this.btnSaveFields.Size = new System.Drawing.Size(200, 55);
            this.btnSaveFields.TabIndex = 3;
            this.btnSaveFields.Text = "Save Fields";
            this.btnSaveFields.UseVisualStyleBackColor = true;
            this.btnSaveFields.Click += new System.EventHandler(this.btnSaveFields_Click);
            // 
            // lbFields
            // 
            this.lbFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFields.FormattingEnabled = true;
            this.lbFields.ItemHeight = 31;
            this.lbFields.Location = new System.Drawing.Point(8, 143);
            this.lbFields.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbFields.Name = "lbFields";
            this.lbFields.Size = new System.Drawing.Size(943, 314);
            this.lbFields.TabIndex = 2;
            this.lbFields.SelectedIndexChanged += new System.EventHandler(this.lbFields_SelectedIndexChanged);
            // 
            // txtPreviewData
            // 
            this.txtPreviewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreviewData.Location = new System.Drawing.Point(0, 484);
            this.txtPreviewData.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPreviewData.Name = "txtPreviewData";
            this.txtPreviewData.Size = new System.Drawing.Size(850, 323);
            this.txtPreviewData.TabIndex = 0;
            this.txtPreviewData.Text = "";
            // 
            // btnExtractData
            // 
            this.btnExtractData.Location = new System.Drawing.Point(27, 67);
            this.btnExtractData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(200, 55);
            this.btnExtractData.TabIndex = 0;
            this.btnExtractData.Text = "Extract Data";
            this.btnExtractData.UseVisualStyleBackColor = true;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2737, 814);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmMain";
            this.Text = "PDF Management";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnImportFields;
        private System.Windows.Forms.Button btnSaveFields;
        private System.Windows.Forms.TextBox txtPage;
    }
}

