using System;
using System.Data;
using System.Windows.Forms;
using CL_ApplicationModels;

namespace frmDeshboard
{
    public partial class frmReference : Form
    {
        //Class data fields.
        string id;  //Datagridview rows id;
        int userId; //Refrence savers id;

        public frmReference()
        {
            InitializeComponent();

            //loads reference table data of all users to the DataGridView.
            ShowTableData();
            cmbDocType.SelectedIndex = 0;
        }



        //Formats author's names and keeps them for database entry.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAuthorsList.Text += $"{txtLastName.Text}, {txtFirstName.Text} {txtMiddleName.Text}; ";
            MangingFormAndControls.PanelClear(panelAuthorName);
        }


        //Saves textbox's data to the database. if the user is not a Guest.
        private void SaveReference(object sender, EventArgs e)
        {
            
            if (txtTitle.Text == "" || cmbDocType.SelectedIndex == 0 || txtYear.Text == "" || txtPublisher.Text == "" || txtNameOfSource.Text == "" || txtPageNumber.Text == "")
            {
                MessageBox.Show("Title, Document type, Year, Publisher, Name of Source, Page Number fields cannot be empty.", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UserInfo.loggedIn == true)
                {
                    DatabaseNonQuery.InsertUpdateDelete($"Insert into TblReference (Title, Author, DocumentType, Year, Publisher, Abstract, NameOfSource, Issue, Volume, PageNumbers, Notes, UserID) values('{txtTitle.Text}','{txtAuthorsList.Text}','{cmbDocType.Text}','{txtYear.Text}','{txtPublisher.Text}','{txtAbstract.Text}','{txtNameOfSource.Text}','{txtIssue.Text}','{txtVolume.Text}','{txtPageNumber.Text}','{txtNotes.Text}','{UserInfo.id}')");
                    ShowTableData();
                    MangingFormAndControls.PanelClear(PanelRefrenceFields);
                }
                else
                {
                    //Shows error if it is Guest.
                    MsgBox.Show("Please Signup / Login First", "Operation Fail", "Ok", "Cancel");
                }
            }
        }





        //Clears all textbox's of the panel.
        private void ClearTextBoxes(object sender, EventArgs e)
        {
            MangingFormAndControls.PanelClear(PanelRefrenceFields);
        }



        //Updates saved refrences if the user is trying to update own recoard.
        private void UpdateReference(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || cmbDocType.SelectedIndex == 0 || txtYear.Text == "" || txtPublisher.Text == "" || txtNameOfSource.Text == "" || txtPageNumber.Text == "")///
            {
                MessageBox.Show("Title, Document type, Year, Publisher, Name of Source, Page Number fields cannot be empty.", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UserInfo.id == userId)
                {
                    DatabaseNonQuery.InsertUpdateDelete($"Update TblReference set Title ='{txtTitle.Text}', Author ='{txtAuthorsList.Text}' , DocumentType = '{cmbDocType.Text}', Year ='{txtYear.Text}', Publisher = '{txtPublisher.Text}' , Abstract = '{txtAbstract.Text}' , NameOfSource = '{txtNameOfSource.Text}' , Issue = '{txtIssue.Text}' , Volume = '{txtVolume.Text}' , PageNumbers = '{txtPageNumber.Text}' , Notes = '{txtNotes.Text}', UserID = '{UserInfo.id}' where id ='{id}'");
                    ShowTableData();
                    MangingFormAndControls.PanelClear(PanelRefrenceFields);
                }
                else
                {
                    MsgBox.Show("You cannot Edit This Reference.", "Error", "OK", "Cancel");
                }
            }
        }


        //Allows user to delete their records.
        private void DeleteReference(object sender, EventArgs e)
        {
            if (UserInfo.id == userId)
            {
                DatabaseNonQuery.InsertUpdateDelete($"Delete from TblReference where id ='{id}'");
                ShowTableData();
                MangingFormAndControls.PanelClear(PanelRefrenceFields);
            }
            else
            {
                MsgBox.Show("You cannot Delete This Reference.", "Error", "OK", "Cancel");
            }
        }






        /// <summary>
        /// Stors user datafield's data to the textboxs. By getting data table from TabelConnector class.
        /// </summary>
        /// <param name="Command"> Select query for retriving data form the data field to initialze to the datafield.</param>
        void UserInformation(string Command)
        {
            DataTable dt = TabelConnector.DataTableLoader(Command);

            try
            {
                txtTitle.Text = dt.Rows[0][1].ToString();
                txtAuthorsList.Text = dt.Rows[0][2].ToString();
                cmbDocType.Text = dt.Rows[0][3].ToString();
                txtYear.Text = dt.Rows[0][4].ToString();
                txtPublisher.Text = dt.Rows[0][5].ToString();
                txtAbstract.Text = dt.Rows[0][6].ToString();
                txtNameOfSource.Text = dt.Rows[0][7].ToString();
                txtIssue.Text = dt.Rows[0][8].ToString();
                txtVolume.Text = dt.Rows[0][9].ToString();
                txtPageNumber.Text = dt.Rows[0][10].ToString();
                txtNotes.Text = dt.Rows[0][11].ToString();
                userId = Convert.ToInt32(dt.Rows[0][12]);
            }
            catch
            {
                MessageBox.Show("Invalid Selection","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }




        //Loads data table's data to the DataGridView.
        void ShowTableData()
        {
            DGVRefrenceList.DataSource = TabelConnector.DataTableLoader("Select * from TblReference");
        }





        //Loads selected rows data to DataGridView.
        private void DGVRefrenceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = DGVRefrenceList.Rows[e.RowIndex].Cells[0].Value.ToString();    //Gets users id form the datagridview'd id column.
                UserInformation($"Select * from TblReference where id={id}");
            }
            catch
            {
            }
        }




        //Changes label text for selecting comboboxe's item.
        private void cmbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocType.SelectedIndex ==0)
            {
                lblNameOfSource.Text = "Book Name:";
            }
            else if (cmbDocType.SelectedIndex==1)
            {
                lblNameOfSource.Text = "Journal Name:";
            }
            else if (cmbDocType.SelectedIndex == 2)
            {
                lblNameOfSource.Text = "Collection Name:";
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Searches all the matching titles of the refrences of from the refrences.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DGVRefrenceList.DataSource = TabelConnector.DataTableLoader($"select * from TblReference where Title like '%{txtSearch.Text}%'");
        }
    }
}
