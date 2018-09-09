using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoLookup
{
    public partial class BulkProcessForm : Form
    {
        public BulkProcessForm()
        {
            InitializeComponent();
        }

        private void BulkProcessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileWindow = new OpenFileDialog();

            openFileWindow.Title = "Select file";

            openFileWindow.InitialDirectory = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;

            //fdlg.FileName = 

            openFileWindow.Filter = "Excel Sheet(*.xls, *.xlsx)|*.xls;*.xlsx|All Files(*.*)|*";

            openFileWindow.FilterIndex = 1;

            openFileWindow.RestoreDirectory = true;

            if (openFileWindow.ShowDialog() == DialogResult.OK)

            {
                string filePath = openFileWindow.FileName;
                string extension = Path.GetExtension(filePath);

                using (ExcelPackage package = new ExcelPackage())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        package.Load(stream);
                    }
                    // get the first worksheet in the workbook
                    
                    var workSheet = package.Workbook.Worksheets.First();
                    DataTable dataTable = new DataTable();
                    bool hasHeader = workSheet.Cells[1, 1].Text.Equals("fqdn", StringComparison.CurrentCultureIgnoreCase);
                    //foreach (var firstRowCell in workSheet.Cells[1, 1, 1, workSheet.Dimension.End.Column])
                    //{
                    //    dataTable.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                    //}

                    dataTable.Columns.Add("fqdn");
                    dataTable.Columns.Add("ip");
                    
                    int startRow = hasHeader ? 2 : 1;

                    for (int rowNum = startRow; rowNum <= workSheet.Dimension.End.Row; rowNum++)
                    {
                        //var wsRow = workSheet.Cells[rowNum, 1, rowNum, 2];
                        //var wsRow = workSheet.Row[rowNum];
                        DataRow row = dataTable.Rows.Add();
                        
                            row[0] = workSheet.Cells[rowNum, 1].Text;
                        row[1] = workSheet.Cells[rowNum, 2].Text;
                        

                    }
                    dataGridView_Lookup.DataSource = dataTable;
                    foreach (DataGridViewRow row in this.dataGridView_Lookup.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                        //row.HeaderCell.Value = row.Index + 1;
                    }
                }
                    Application.DoEvents();

                }
        }

        private void dataGridView_Lookup_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView_Lookup.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                //row.HeaderCell.Value = row.Index + 1;
            }
        }
    }
}
