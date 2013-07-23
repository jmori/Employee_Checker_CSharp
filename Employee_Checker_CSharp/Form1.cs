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

        public Form1()
        {
            InitializeComponent();
            OlApp = new Outlook.Application();
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
            string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathConn);

            List<string> sheets = ListSheetInExcel(gradeBookPath);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + sheets[0] + "]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            aDataGrid.DataSource = dt;

            lbl_Message.Text = "There are " + aDataGrid.RowCount + " employees";

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

            lbl_Message.Text = "There are: " + aDataGridView.RowCount + " employees with Certificates";

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //Need to redesign this, it wont work with other things
            //createTab("With Certificates");
            //showContactFolderFromOutlook();
            //AccessContacts("tester");
            //listEmployees();
            EnumerateGAL();
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
                        Console.WriteLine("1st if: " + exchUser.Name + " " + exchUser.PrimarySmtpAddress + " " + exchUser.OfficeLocation);
                    }
                    if (addrEntry.AddressEntryUserType == Outlook.OlAddressEntryUserType.olExchangeDistributionListAddressEntry)
                    {
                        Outlook.ExchangeDistributionList exchDL = addrEntry.GetExchangeDistributionList();
                        Console.WriteLine("2nd if: " + exchDL.Name + " " + exchDL.PrimarySmtpAddress + " " + exchDL.Address);
                    }
                }
            }
        }
    }
}
