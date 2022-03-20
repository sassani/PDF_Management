
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
            this.lblError = new System.Windows.Forms.Label();
            this.lbFilesList = new System.Windows.Forms.ListBox();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.btnImportFields = new System.Windows.Forms.Button();
            this.btnSaveFields = new System.Windows.Forms.Button();
            this.lbFields = new System.Windows.Forms.ListBox();
            this.txtPreviewData = new System.Windows.Forms.RichTextBox();
            this.btnExtractData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(0, 41);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(556, 576);
            this.wb.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnImportList
            // 
            this.btnImportList.Location = new System.Drawing.Point(1, 1);
            this.btnImportList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnImportList.Name = "btnImportList";
            this.btnImportList.Size = new System.Drawing.Size(75, 23);
            this.btnImportList.TabIndex = 0;
            this.btnImportList.Text = "Open PDF";
            this.btnImportList.UseVisualStyleBackColor = true;
            this.btnImportList.Click += new System.EventHandler(this.btnImportList_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(2, 1);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(75, 23);
            this.btnAddField.TabIndex = 0;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 25);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(28, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "error";
            // 
            // lbFilesList
            // 
            this.lbFilesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilesList.FormattingEnabled = true;
            this.lbFilesList.Location = new System.Drawing.Point(0, 41);
            this.lbFilesList.Name = "lbFilesList";
            this.lbFilesList.Size = new System.Drawing.Size(417, 576);
            this.lbFilesList.TabIndex = 3;
            this.lbFilesList.SelectedIndexChanged += new System.EventHandler(this.lbFilesList_SelectedIndexChanged);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(133, 14);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(35, 13);
            this.lblPageCount.TabIndex = 2;
            this.lblPageCount.Text = "label1";
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(79, 4);
            this.txtPage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(40, 20);
            this.txtPage.TabIndex = 4;
            this.txtPage.Text = "1";
            // 
            // btnImportFields
            // 
            this.btnImportFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportFields.Location = new System.Drawing.Point(253, 26);
            this.btnImportFields.Name = "btnImportFields";
            this.btnImportFields.Size = new System.Drawing.Size(75, 23);
            this.btnImportFields.TabIndex = 3;
            this.btnImportFields.Text = "Import Fields";
            this.btnImportFields.UseVisualStyleBackColor = true;
            this.btnImportFields.Click += new System.EventHandler(this.btnImportFields_Click);
            // 
            // btnSaveFields
            // 
            this.btnSaveFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFields.Location = new System.Drawing.Point(334, 26);
            this.btnSaveFields.Name = "btnSaveFields";
            this.btnSaveFields.Size = new System.Drawing.Size(75, 23);
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
            this.lbFields.Location = new System.Drawing.Point(3, 53);
            this.lbFields.Name = "lbFields";
            this.lbFields.Size = new System.Drawing.Size(413, 160);
            this.lbFields.TabIndex = 2;
            this.lbFields.SelectedIndexChanged += new System.EventHandler(this.lbFields_SelectedIndexChanged);
            // 
            // txtPreviewData
            // 
            this.txtPreviewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreviewData.Location = new System.Drawing.Point(3, 219);
            this.txtPreviewData.Name = "txtPreviewData";
            this.txtPreviewData.Size = new System.Drawing.Size(413, 398);
            this.txtPreviewData.TabIndex = 0;
            this.txtPreviewData.Text = "";
            // 
            // btnExtractData
            // 
            this.btnExtractData.Location = new System.Drawing.Point(2, 26);
            this.btnExtractData.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(75, 23);
            this.btnExtractData.TabIndex = 0;
            this.btnExtractData.Text = "Extract Data";
            this.btnExtractData.UseVisualStyleBackColor = true;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExtractData);
            this.panel1.Controls.Add(this.txtPage);
            this.panel1.Controls.Add(this.btnSaveFields);
            this.panel1.Controls.Add(this.btnImportFields);
            this.panel1.Controls.Add(this.btnAddField);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 54);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImportList);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.lbFilesList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 617);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.wb);
            this.panel3.Controls.Add(this.lblPageCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(426, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 617);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.txtPreviewData);
            this.panel4.Controls.Add(this.lbFields);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(991, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 617);
            this.panel4.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1413, 623);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "PDF Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportList;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.RichTextBox txtPreviewData;
        private System.Windows.Forms.ListBox lbFields;
        private System.Windows.Forms.ListBox lbFilesList;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnExtractData;
        private System.Windows.Forms.Button btnImportFields;
        private System.Windows.Forms.Button btnSaveFields;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

