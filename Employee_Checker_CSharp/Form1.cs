using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Employee_Checker_CSharp
{
    public partial class Form1 : Form
    {
        private string gradeBookPath;
        private string provincePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GradeBook_Click(object sender, EventArgs e)
        {
            OpenFileDialog openGradeBook = new OpenFileDialog();

            if (openGradeBook.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Add content to the dataGrid.
                gradeBookPath = openGradeBook.FileName;
                loadExcelFile(gradeBookPath, dataGridView_gradeBook);
            }
        }

        private void loadExcelFile(string filePath, DataGridView aDataGrid)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + gradeBookPath + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);

            List<string> sheets = ListSheetInExcel(gradeBookPath);
            
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + sheets[0] + "]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            aDataGrid.DataSource = dt;
             
        }

        /*
         * Obtaining the name of the excel sheets and placing them on a list.
         * This method was obtained from: http://stackoverflow.com/questions/1164698/using-excel-oledb-to-get-sheet-names-in-sheet-order
         */
        public List<string> ListSheetInExcel(string filePath)
        {
            OleDbConnectionStringBuilder sbConnection = new OleDbConnectionStringBuilder();
            String strExtendedProperties = String.Empty;
            sbConnection.DataSource = filePath;

            List<string> listSheet = new List<string>();

            if (Path.GetExtension(filePath).Equals(".xls"))//for 97-03 Excel file
            {
                sbConnection.Provider = "Microsoft.Jet.OLEDB.4.0";
                strExtendedProperties = "Excel 8.0;HDR=Yes;IMEX=1";//HDR=ColumnHeader,IMEX=InterMixed
            }
            else if (Path.GetExtension(filePath).Equals(".xlsx"))  //for 2007 Excel file
            {
                sbConnection.Provider = "Microsoft.ACE.OLEDB.12.0";
                strExtendedProperties = "Excel 12.0;HDR=Yes;IMEX=1";
            }
            
            sbConnection.Add("Extended Properties", strExtendedProperties);
            
            using (OleDbConnection conn = new OleDbConnection(sbConnection.ToString()))
            {
                conn.Open();
                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //List<string> listSheet = new List<string>();
                foreach (DataRow drSheet in dtSheet.Rows)
                {
                    if (drSheet["TABLE_NAME"].ToString().Contains("$"))//checks whether row contains '_xlnm#_FilterDatabase' or sheet name(i.e. sheet name always ends with $ sign)
                    {
                        listSheet.Add(drSheet["TABLE_NAME"].ToString());
                    }
                }
            }
            return listSheet;
        }

        /*
        private void test()
        {
            tab_Employees.
        }
         */ 
    }
}
