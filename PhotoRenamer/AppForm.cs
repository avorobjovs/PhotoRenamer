﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhotoRenamer
{
    public partial class AppForm : Form
    {
        private string workPath;
        private DataTable dataTable;
        private string selectedPattern;
        private string selectedPatternName;
        private string selectedWorkingPattern;

        public AppForm()
        {
            //string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

            //string applicationDirectory = Application.ExecutablePath;
            //string applicationDirectoryPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            workPath = AppDomain.CurrentDomain.BaseDirectory;

            InitializeComponent();
            EnableDisableCustom(false);
            EnableDisableRename(false);
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable("Patterns");
            dataTable.Columns.Add("Pattern", typeof(String));
            dataTable.Columns.Add("Name", typeof(String));

            ReadPatterns();
            InitPatterns();
        }

        private void EnableDisableCustom(bool enable)
        {
            lblCustomPattern.Enabled = enable;
            tbCustomPattern.Enabled = enable;
            lblCustomName.Enabled = enable;
            tbCustomName.Enabled = enable;
        }

        private void EnableDisableRename(bool enable)
        {
            btnTest.Enabled = enable;
            btnRename.Enabled = enable;
        }

        private void ReadPatterns()
        {
            var allLines = File.ReadAllLines(Path.Combine(workPath, "patterns.csv"));
            for (int i = 1; i < allLines.Length; i++)
            {
                var currentLine = allLines[i];
                var parts = currentLine.Split(new char[] { '\t' });
                dataTable.Rows.Add(new String[] { parts[0], parts[1] });
            }
        }

        private void WritePatterns()
        {
            var allLines = new string[dataTable.Rows.Count + 1];
            allLines[0] = "Pattern\tName";

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                allLines[i + 1] = (string)row["Pattern"] + "\t" + (string)row["Name"];
            }

            File.WriteAllLines(Path.Combine(workPath, "patterns.csv"), allLines);
        }

        private void InitPatterns()
        {
            cbPattern.DataSource = dataTable;
            cbPattern.DisplayMember = "Pattern";
            cbPattern.ValueMember = "Name";
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbFolder.Text = folderBrowserDialog.SelectedPath;
                CheckTestRenameButtons();
            }
        }

        private void tbFolder_TextChanged(object sender, EventArgs e)
        {
            CheckTestRenameButtons();
        }

        private void cbPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCustomPattern();
            CheckTestRenameButtons();
        }

        private void GetPatternSelectedValue()
        {
            DataRowView selectedItem = (DataRowView)cbPattern.SelectedItem;
            selectedPattern = (string)selectedItem["Pattern"];
            selectedPatternName = (string)selectedItem["Name"];
        }

        private void CheckCustomPattern()
        {
            GetPatternSelectedValue();

            if (!string.IsNullOrEmpty(selectedPatternName) && selectedPatternName.ToLowerInvariant() == "custom")
            {
                EnableDisableCustom(true);
            }
            else
            {
                EnableDisableCustom(false);
            }
        }

        private void tbCustomPattern_TextChanged(object sender, EventArgs e)
        {
            CheckCustomSaveButton();
            CheckTestRenameButtons();
        }

        private void tbCustomName_TextChanged(object sender, EventArgs e)
        {
            CheckCustomSaveButton();
            CheckTestRenameButtons();
        }

        private void CheckCustomSaveButton()
        {
            if (!string.IsNullOrEmpty(tbCustomPattern.Text) && !string.IsNullOrEmpty(tbCustomName.Text))
            {
                btnCustomSave.Enabled = true;
            }
            else
            {
                btnCustomSave.Enabled = false;
            }
        }

        private bool CheckCustomPatternFormat()
        {
            if (!string.IsNullOrEmpty(tbCustomPattern.Text) &&
                tbCustomPattern.Text.Contains("YYYY") &&
                tbCustomPattern.Text.Contains("MM") &&
                tbCustomPattern.Text.Contains("DD") &&
                tbCustomPattern.Text.Contains("hh") &&
                tbCustomPattern.Text.Contains("mm") &&
                tbCustomPattern.Text.Contains("ss"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Custom pattern format is not valid.", "Error");
                return false; 
            }
        }

        private bool CheckCustomPatternDuplication()
        {
            var allPatterns = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                allPatterns.Add((string)row["Pattern"]);
            }

            if (!string.IsNullOrEmpty(tbCustomPattern.Text) &&
                !allPatterns.Contains(tbCustomPattern.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Custom pattern format already exists.", "Error");
                return false;
            }
        }

        private void btnCustomSave_Click(object sender, EventArgs e)
        {
            if (CheckCustomPatternFormat() && CheckCustomPatternDuplication())
            {
                var newRow = dataTable.NewRow();
                newRow["Pattern"] = tbCustomPattern.Text;
                newRow["Name"] = tbCustomName.Text;
                dataTable.Rows.InsertAt(newRow, dataTable.Rows.Count - 1);

                WritePatterns();

                tbCustomPattern.Text = null;
                tbCustomName.Text = null;
                btnCustomSave.Enabled = false;

                cbPattern.SelectedIndex = cbPattern.Items.Count - 2;

                EnableDisableCustom(false);
            }
        }

        private void CheckTestRenameButtons()
        {
            GetPatternSelectedValue();

            selectedWorkingPattern = null;
            if (!string.IsNullOrEmpty(selectedPatternName))
            {
                if (selectedPatternName.ToLowerInvariant() != "custom")
                {
                    selectedWorkingPattern = selectedPattern;
                }
                else
                {
                    selectedWorkingPattern = tbCustomPattern.Text;
                }
            }

            if (!string.IsNullOrEmpty(tbFolder.Text) && !string.IsNullOrEmpty(selectedWorkingPattern))
            {
                EnableDisableRename(true);
            }
            else
            {
                EnableDisableRename(false);
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void btnRename_Click(object sender, EventArgs e)
        {

        }

        
    }
}
