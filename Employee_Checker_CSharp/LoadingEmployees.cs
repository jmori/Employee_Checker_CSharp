using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Checker_CSharp
{
    public partial class LoadingEmployees : Form
    {

        private int employeeCount;
        private DataGridView dataGridView;

        public LoadingEmployees()
        {
            InitializeComponent();
        }

        public LoadingEmployees(DataGridView aDataGridView)
        {
            employeeCount = 0;
            InitializeComponent();
        }

        private void btn_ParseEmployee_Click(object sender, EventArgs e)
        {
            string[] employees = parseString(richTxtBx_employees.Text);
            string newList = null;

            for (int i = 0; i < employees.Length; i++)
                newList += employees[i] + "\n";

            richTxtBx_employees.Text = newList;
        }

        private string[] parseString(string line)
        {
            string employeeLine = line;
            string[] lines = employeeLine.Split(';');

            //Delete their email address, if there is one attached
            string[] employees = new string[lines.Length];
            int index;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("<"))
                {
                    index = lines[i].IndexOf("<");
                    if (index != -1)
                        employees[i] = lines[i].Substring(0, index);
                }
                else
                    employees[i] = lines[i];
            }
            employeeCount = employees.Length;
            return employees;
        }

        private void createTable(string line)
        {
            string[] emp = parseString(line);

            DataTable dt = new DataTable("Learners");

            //Create the columns in the datatable
            DataColumn c0 = new DataColumn("#");
            DataColumn c1 = new DataColumn("Name");

            //Add the created columns to the Datatable
            dt.Columns.Add(c0);
            dt.Columns.Add(c1);

            DataRow[] row = new DataRow[employeeCount];

            //Create rows
            for (int i = 0; i < employeeCount; i++)
            {
                row[i] = dt.NewRow();
                row[i].SetField(0,i);
                row[i].SetField(1, emp[i]);

                dt.Rows.Add(row[i]);
            }

            dataGridView.DataSource = dt;
        }

        private void btn_LoadIntoChecker_Click(object sender, EventArgs e)
        {
            createTable(richTxtBx_employees.Text);
        }
    }
}
