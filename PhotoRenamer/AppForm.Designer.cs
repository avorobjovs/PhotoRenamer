namespace PhotoRenamer
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cbApplyToSubfolders = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPattern = new System.Windows.Forms.Label();
            this.lblCustomPattern = new System.Windows.Forms.Label();
            this.lblCustomName = new System.Windows.Forms.Label();
            this.tbCustomPattern = new System.Windows.Forms.TextBox();
            this.tbCustomName = new System.Windows.Forms.TextBox();
            this.btnCustomSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPattern = new PhotoRenamer.Components.MultiColumnComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.columnBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFolder
            // 
            this.tbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolder.Location = new System.Drawing.Point(15, 25);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(720, 20);
            this.tbFolder.TabIndex = 0;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(12, 9);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(126, 13);
            this.lblFolder.TabIndex = 1;
            this.lblFolder.Text = "Select folder with photos:";
            // 
            // btnFolder
            // 
            this.btnFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFolder.Location = new System.Drawing.Point(741, 23);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(31, 23);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // cbApplyToSubfolders
            // 
            this.cbApplyToSubfolders.AutoSize = true;
            this.cbApplyToSubfolders.Location = new System.Drawing.Point(15, 51);
            this.cbApplyToSubfolders.Name = "cbApplyToSubfolders";
            this.cbApplyToSubfolders.Size = new System.Drawing.Size(115, 17);
            this.cbApplyToSubfolders.TabIndex = 3;
            this.cbApplyToSubfolders.Text = "Apply to subfolders";
            this.cbApplyToSubfolders.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(1, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 4);
            this.panel1.TabIndex = 4;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(12, 97);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(121, 13);
            this.lblPattern.TabIndex = 6;
            this.lblPattern.Text = "Select file name pattern:";
            // 
            // lblCustomPattern
            // 
            this.lblCustomPattern.AutoSize = true;
            this.lblCustomPattern.Location = new System.Drawing.Point(12, 145);
            this.lblCustomPattern.Name = "lblCustomPattern";
            this.lblCustomPattern.Size = new System.Drawing.Size(81, 13);
            this.lblCustomPattern.TabIndex = 7;
            this.lblCustomPattern.Text = "Custom pattern:";
            // 
            // lblCustomName
            // 
            this.lblCustomName.AutoSize = true;
            this.lblCustomName.Location = new System.Drawing.Point(352, 145);
            this.lblCustomName.Name = "lblCustomName";
            this.lblCustomName.Size = new System.Drawing.Size(110, 13);
            this.lblCustomName.TabIndex = 8;
            this.lblCustomName.Text = "Custom pattern name:";
            // 
            // tbCustomPattern
            // 
            this.tbCustomPattern.Location = new System.Drawing.Point(15, 161);
            this.tbCustomPattern.Name = "tbCustomPattern";
            this.tbCustomPattern.Size = new System.Drawing.Size(327, 20);
            this.tbCustomPattern.TabIndex = 9;
            // 
            // tbCustomName
            // 
            this.tbCustomName.Location = new System.Drawing.Point(355, 161);
            this.tbCustomName.Name = "tbCustomName";
            this.tbCustomName.Size = new System.Drawing.Size(327, 20);
            this.tbCustomName.TabIndex = 10;
            // 
            // btnCustomSave
            // 
            this.btnCustomSave.Enabled = false;
            this.btnCustomSave.Location = new System.Drawing.Point(697, 159);
            this.btnCustomSave.Name = "btnCustomSave";
            this.btnCustomSave.Size = new System.Drawing.Size(75, 23);
            this.btnCustomSave.TabIndex = 11;
            this.btnCustomSave.Text = "Save";
            this.btnCustomSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(1, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 4);
            this.panel2.TabIndex = 12;
            // 
            // cbPattern
            // 
            this.cbPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPattern.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPattern.FormattingEnabled = true;
            this.cbPattern.Location = new System.Drawing.Point(15, 113);
            this.cbPattern.Name = "cbPattern";
            this.cbPattern.Size = new System.Drawing.Size(757, 21);
            this.cbPattern.TabIndex = 5;
            this.cbPattern.SelectedIndexChanged += new System.EventHandler(this.cbPattern_SelectedIndexChanged);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(607, 217);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(697, 217);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 14;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            // 
            // dataGridResult
            // 
            this.dataGridResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBefore,
            this.columnAfter});
            this.dataGridResult.Location = new System.Drawing.Point(15, 257);
            this.dataGridResult.MultiSelect = false;
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.ReadOnly = true;
            this.dataGridResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridResult.Size = new System.Drawing.Size(757, 292);
            this.dataGridResult.TabIndex = 15;
            // 
            // columnBefore
            // 
            this.columnBefore.HeaderText = "Before";
            this.columnBefore.Name = "columnBefore";
            this.columnBefore.ReadOnly = true;
            // 
            // columnAfter
            // 
            this.columnAfter.HeaderText = "After";
            this.columnAfter.Name = "columnAfter";
            this.columnAfter.ReadOnly = true;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridResult);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCustomSave);
            this.Controls.Add(this.tbCustomName);
            this.Controls.Add(this.tbCustomPattern);
            this.Controls.Add(this.lblCustomName);
            this.Controls.Add(this.lblCustomPattern);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.cbPattern);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbApplyToSubfolders);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.tbFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppForm";
            this.Text = "Photo Renamer";
            this.Load += new System.EventHandler(this.AppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox cbApplyToSubfolders;
        private System.Windows.Forms.Panel panel1;
        private PhotoRenamer.Components.MultiColumnComboBox cbPattern;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label lblCustomPattern;
        private System.Windows.Forms.Label lblCustomName;
        private System.Windows.Forms.TextBox tbCustomPattern;
        private System.Windows.Forms.TextBox tbCustomName;
        private System.Windows.Forms.Button btnCustomSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAfter;
    }
}

