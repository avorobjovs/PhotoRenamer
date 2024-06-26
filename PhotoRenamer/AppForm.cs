using System;
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

        private DataTable ReadPatterns()
        {
            DataTable dataTable = new DataTable("Patterns");
            dataTable.Columns.Add("Pattern", typeof(String));
            dataTable.Columns.Add("Name", typeof(String));

            var allLines = File.ReadAllLines(Path.Combine(workPath, "patterns.csv"));
            for (int i = 1; i < allLines.Length; i++)
            {
                var currentLine = allLines[i];
                var parts = currentLine.Split(new char[] { '\t' });
                dataTable.Rows.Add(new String[] { parts[0], parts[1] });
            }

            return dataTable;
        }

        private void WritePatterns()
        {
            
        }

        private void InitPatterns()
        {
            var dataTable = ReadPatterns();
            cbPattern.DataSource = dataTable;
            cbPattern.DisplayMember = "Pattern";
            cbPattern.ValueMember = "Name";
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void cbPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedItem = (DataRowView)cbPattern.SelectedItem;
            string selectedPattern = (string)selectedItem["Pattern"];
            string selectedName = (string)selectedItem["Name"];
        }

        
    }
}
