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
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Employee_Checker_CSharp
{
    public partial class Form1 : Form
    {
        private string gradeBookPath;
        private Outlook.Application OlApp = null;
        private int employeeCount;
        private bool listParsed;

        private DataTable gradeBookTable;
        private DataTable learnersTable;

        public Form1()
        {
            InitializeComponent();
            OlApp = new Outlook.Application();
            listParsed = false;
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

            tab_Employees.SelectTab(tabPage_Gradebook);
        }

        private void displayMessage(string aMessage)
        {
            lbl_Message.Text = aMessage;
        }

        private void loadExcelFile(string filePath, DataGridView aDataGrid)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);

            List<string> sheets = ListSheetInExcel(gradeBookPath);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + sheets[0] + "]", conn);

            gradeBookTable = new DataTable();

            myDataAdapter.Fill(gradeBookTable);

            aDataGrid.DataSource = gradeBookTable;

            displayMessage("There are " + aDataGrid.RowCount + " employees");
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

        private void displayCertificateMembers(string filePath, DataGridView aDataGridView)
        {
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);

            List<string> sheets = ListSheetInExcel(gradeBookPath);
            string query = "Select [Created By], [Certificate Issued] from [" + sheets[0] + "] where [Certificate Issued]=TRUE";
            Console.WriteLine(query);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            aDataGridView.DataSource = dt;

            //lbl_Message.Text = "There are: " + aDataGridView.RowCount + " employees with Certificates";
            displayMessage("There are: " + aDataGridView.RowCount + " employees with Certificates");

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //Need to redesign this, it wont work with other things
            //createTab("With Certificates");
            //showContactFolderFromOutlook();
            //AccessContacts("tester");
            //listEmployees();
            //EnumerateGAL();
        }

        private void createTab(string nameTab)
        {
            TabPage newTab = new TabPage(nameTab);
            tab_Employees.Controls.Add(newTab);
            tab_Employees.SelectTab(newTab);

            DataGridView dataGrid_tmp = new DataGridView();
            dataGrid_tmp.Width = dataGridView_gradeBook.Width;
            dataGrid_tmp.Height = dataGridView_gradeBook.Height;
            newTab.Controls.Add(dataGrid_tmp);

            displayCertificateMembers(gradeBookPath, dataGrid_tmp);
            //newTab.Refresh();
        }

        private void showContactFolderFromOutlook()
        {
            Outlook.AddressLists addrLists;
            Outlook.Folder contactsFolder = OlApp.Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts)as Outlook.Folder;
            addrLists = OlApp.Session.AddressLists;
            foreach (Outlook.AddressList addrList in addrLists)
            {
                Outlook.Folder testFolder = addrList.GetContactsFolder() as Outlook.Folder;
                if (testFolder != null)
                {
                    // Test to determine if Folder returned
                    // by GetContactsFolder has same EntryID
                    // as default Contacts folder.
                    if (OlApp.Session.CompareEntryIDs(contactsFolder.EntryID, testFolder.EntryID))
                    {
                        Outlook.SelectNamesDialog snd = OlApp.Session.GetSelectNamesDialog();
                        snd.InitialAddressList = addrList;
                        snd.Display();
                    }
                }
            }
        }
        
        //This method only looks inside the local contacts, need to modify it to access the global list.
        private void AccessContacts(string findLastName)
        {
            Outlook.MAPIFolder folderContacts = OlApp.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
            //OlApp.ActiveExplorer().Session.GetDefaultFolder(Outlook.)
            Outlook.Items searchFolder = folderContacts.Items;
            int counter = 0;
            foreach (Outlook.ContactItem foundContact in searchFolder)
            {
                if (foundContact.LastName.Contains(findLastName))
                {
                    foundContact.Display(false);
                    counter = counter + 1;
                }
            }
            MessageBox.Show("You have " + counter + " contacts with last names that contain " + findLastName + ".");
        }

        private void listEmployees()
        {
            Outlook.AddressLists addrlists = OlApp.Application.Session.AddressLists;
            Outlook.AddressList gal = addrlists["Global Address List"];
        }

        private void EnumerateGAL()
        {
            Outlook.AddressList gal = OlApp.Application.Session.GetGlobalAddressList();
            if (gal != null)
            {
                for (int i = 1; i <= Math.Min(100, gal.AddressEntries.Count - 1); i++)
                {
                    Outlook.AddressEntry addrEntry = gal.AddressEntries[i];
                    if (addrEntry.AddressEntryUserType ==
                        Outlook.OlAddressEntryUserType.
                        olExchangeUserAddressEntry
                        || addrEntry.AddressEntryUserType ==
                        Outlook.OlAddressEntryUserType.
                        olExchangeRemoteUserAddressEntry)
                    {
                        Outlook.ExchangeUser exchUser = addrEntry.GetExchangeUser();
                        /* in case i need this later: + exchUser.PrimarySmtpAddress + " "*/
                        //if (exchUser.OfficeLocation == "CNIB Center")
                        Console.WriteLine("1st if: " + exchUser.Name + " " + exchUser.OfficeLocation);
                    }
                    if (addrEntry.AddressEntryUserType == Outlook.OlAddressEntryUserType.olExchangeDistributionListAddressEntry)
                    {
                        Outlook.ExchangeDistributionList exchDL = addrEntry.GetExchangeDistributionList();
                        //Console.WriteLine("2nd if: " + exchDL.Name + " " + exchDL.PrimarySmtpAddress + " " + exchDL.Address);
                    }
                }
            }
        }

        private void btn_Province_Click(object sender, EventArgs e)
        {
            tab_Employees.SelectTab(tabPage_Learners);
        }

        //This will be on the Learners tab
        private void btn_convertLearners_Click(object sender, EventArgs e)
        {
            if (!listParsed)
            {
                string[] employees = parseString(richTextBox_Learners.Text);

                richTextBox_Learners.Lines = employees;
            }

            //Fills up the dataGridView in this tab
            createTable(richTextBox_Learners);
            
            richTextBox_Learners.ReadOnly = true;
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
            listParsed = true;

            return employees;
        }

        //Creates table for the Learners group, and fills up the Learners DataGridView
        private void createTable(RichTextBox aRichTextBox)
        {
            learnersTable = new DataTable("Learners");

            //Create the columns in the datatable
            DataColumn c0 = new DataColumn("#");
            DataColumn c1 = new DataColumn("Name");

            //Add the created columns to the Datatable
            learnersTable.Columns.Add(c0);
            learnersTable.Columns.Add(c1);

            DataRow[] row = new DataRow[employeeCount];

            //Create rows
            for (int i = 0; i < employeeCount; i++)
            {
                row[i] = learnersTable.NewRow();
                row[i].SetField(0, i+1);
                row[i].SetField(1, aRichTextBox.Lines[i]);

                learnersTable.Rows.Add(row[i]);
            }

            dataGridView_Learners.DataSource = learnersTable;

            displayMessage("There are " + richTextBox_Learners.Lines.Length + " employees in this group");
        }

        private void resetLearnersTab()
        {
            richTextBox_Learners.ReadOnly = false;
            richTextBox_Learners.ResetText();
            listParsed = false;

            //Resetting the DataGridView
            if (dataGridView_Learners.DataSource != null)
                dataGridView_Learners.DataSource = null;
            else
                dataGridView_Learners.Rows.Clear();
        }

        private void btn_clearRichTextBox_Click(object sender, EventArgs e)
        {
            resetLearnersTab();
        }

        private void richTextBox_Learners_TextChanged(object sender, EventArgs e)
        {
            btn_Compare.Enabled = true;
        }

        private void btn_Compare_Click(object sender, EventArgs e)
        {
            tab_Employees.SelectTab(tabPage_Compare);

            compareDataTable(gradeBookTable, learnersTable);
        }

        private void compareDataTable(DataTable aGradeBookTable, DataTable aLearnersTable)
        {
            Console.WriteLine("Learners table:");

            //Compare the tables and output the names that doesn't in GradeBook
            for (int i = 0; i < aGradeBookTable.Rows.Count; i++)
            {
                if (i <= aLearnersTable.Rows.Count)
                {
                    if (String.Equals(aLearnersTable.Rows[i][1].ToString(), aGradeBookTable.Rows[i][0].ToString()))
                        Console.WriteLine(aLearnersTable.Rows[i][1]);
                }
            }
        }
    }
}
