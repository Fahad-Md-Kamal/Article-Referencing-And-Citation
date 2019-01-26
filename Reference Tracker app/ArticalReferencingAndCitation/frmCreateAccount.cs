using System;
using System.Windows.Forms;
using CL_ApplicationModels;
using System.Data;

namespace frmDeshboard
{
    public partial class frmCreateAccount : Form
    {
        //Class Field.
        private string id;


        //Form Load event.
        public frmCreateAccount()
        {
            //Loads all the designe components during form load.
            InitializeComponent();

            //Sets admin panels comboBoxs dafault value initially.
            cmbUserType.Text = "USER";

            //User type log in event.
            if (UserInfo.UserType == "ADMIN")
            {
                //Loads user information textboxes during form load.
                TextBoxloader();
                //If Admin logs in User's button will hide.
                UserControlPanel.Hide();

                lblHaveAccount.Hide();

                //Admin panel shows up if admin loggs in.
                AdminPanel.Show();

                cmbUserType.Text = UserInfo.UserType;
                //Datagridview data loads from database.
                ShowTableData();
            }
            else if (UserInfo.UserType == "USER")
            {
                //loads logger information for possible further operations.
                TextBoxloader();

                lblHaveAccount.Hide();
                //User's loging hides admin control panel.
                AdminPanel.Hide();
            }
            else
            {
                MsgBox.Show($"Please Sign Up for full access", "Guest Login", "OK", "Cancel");
                AdminPanel.Hide();
            }
        }





        //Database data insert for data record.
        private void SaveData(object sender, EventArgs e)
        {

            if (txtFirstName.Text == "" || txtUserId.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("User First Name, UserID, Email, Password cannot be empty", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable userCheckDT = TabelConnector.DataTableLoader($"Select * from Users Where UserId ='{txtUserId.Text}'");
                if (userCheckDT.Rows.Count > 1) 
                {
                    MsgBox.Show($"User Already Registered", "Sign up Error", "OK", "Cancel");
                }
                else //If finds no previous record user's information is inserted to database.
                {
                    DatabaseNonQuery.InsertUpdateDelete($"Insert into Users(FirstName, LastName, UserId, Contact, Email, Address, Password, UserType) values('{txtFirstName.Text}','{txtLastName.Text}','{txtUserId.Text}','{txtContact.Text}','{txtEmail.Text}','{txtAddress.Text}','{txtPassword.Text}','{cmbUserType.Text}')");
                    ShowTableData();
                    MessageBox.Show("User Registration Complete. User Can login now", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MangingFormAndControls.PanelClear(panelUserInfo); //After operation all the text boxes are cleared.
                }
            }
        }






        //Update database data with additional admin feature.
        private void AdminUpdateData(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtUserId.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("User First Name, UserID, Email, Password cannot be empty", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            DataTable userCheckDT = TabelConnector.DataTableLoader($"Select * from Users Where UserId ='{txtUserId.Text}'");
                if (userCheckDT.Rows.Count > 1)
                {
                    MsgBox.Show($"User Already Registered", "Sign up Error", "OK", "Cancel");
                }
                else
                {
                    DatabaseNonQuery.InsertUpdateDelete($"Update Users set FirstName ='{txtFirstName.Text}',LastName='{txtLastName.Text}',UserId = '{txtUserId.Text}', Contact = '{txtContact.Text}', Email = '{txtEmail.Text}', Address = '{txtAddress.Text}', Password = '{txtPassword.Text}', UserType = '{cmbUserType.Text}' where id='{id}'");
                    ShowTableData();
                    MessageBox.Show("User Information Updated", "Update Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MangingFormAndControls.PanelClear(panelUserInfo); //After operation all the text boxes are cleared.
                }
            }
        }




        //User's update of self data.
        private void UserUpdateData(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtUserId.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("User First Name, UserID, Email, Password cannot be empty", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                //checks if the userid is already registared.
                DataTable userCheckDT = TabelConnector.DataTableLoader($"Select * from Users Where UserId ='{txtUserId.Text}'");
                if (userCheckDT.Rows.Count > 1)
                {
                    MsgBox.Show($"You are Already Registered", "Sign up Error", "OK", "Cancel");
                }
                else
                {
                    //Update operation done.
                    DatabaseNonQuery.InsertUpdateDelete($"Update Users set FirstName='{txtFirstName.Text}',LastName='{txtLastName.Text}',UserId = '{txtUserId.Text}', Contact = '{txtContact.Text}',Email = '{txtEmail.Text}',Address = '{txtAddress.Text}',Password = '{txtPassword.Text}', UserType = '{cmbUserType.Text}' where id='{UserInfo.id}'");
                    ShowTableData();
                    MessageBox.Show("Information Updated", "Update Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MangingFormAndControls.PanelClear(panelUserInfo); 
                }
            }
        }





        //Admin's record delete from database.
        private void DeleteData(object sender, EventArgs e)
        {
            DataTable userCheckDT = TabelConnector.DataTableLoader($"Select * from Users Where UserId ='{txtUserId.Text}' or email = '{txtEmail.Text}'");
            if (Convert.ToInt32(userCheckDT.Rows[0][0]) == UserInfo.id)//Admin cannot delete his/her own record.
            {
                MsgBox.Show($"You Cannot delete yourself", "Restriction", "OK", "Cancel");
            }
            else
            {
                DatabaseNonQuery.InsertUpdateDelete($"Delete from Users where id = '{id}'");
                ShowTableData();
                MessageBox.Show("User removed from the storage", "Update Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MangingFormAndControls.PanelClear(panelUserInfo); //After operation all the text boxes are cleared.
            }
        }


        //Admin search for particular user using userid
        private void SearchData(object sender, EventArgs e)
        {
            dgvUsersData.DataSource = TabelConnector.DataTableLoader($"Select * from Users where id='{txtSearch.Text}'");
        }


        //DataGridView's cell click will load row data to the Panel's controlls.
        private void DGVCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dgvUsersData.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dt = TabelConnector.DataTableLoader($"Select * from Users where id = '{id}'");
                txtFirstName.Text = dt.Rows[0][1].ToString();
                txtLastName.Text = dt.Rows[0][2].ToString();
                txtUserId.Text = dt.Rows[0][3].ToString();
                txtContact.Text = dt.Rows[0][4].ToString();
                txtEmail.Text = dt.Rows[0][5].ToString();
                txtAddress.Text = dt.Rows[0][6].ToString();
                txtPassword.Text = dt.Rows[0][7].ToString();
                cmbUserType.Text = dt.Rows[0][8].ToString();
            }
            catch
            {
            }
        }



        //Loades user datatable data to the UsersDataGridView.
        void ShowTableData()
        {
            dgvUsersData.DataSource = TabelConnector.DataTableLoader("Select * from Users");
        }


        //Loads logger's data to the datafields.
        void TextBoxloader()
        {
            txtFirstName.Text = UserInfo.FirstName;
            txtLastName.Text = UserInfo.LastName;
            txtUserId.Text = UserInfo.UserId;
            txtContact.Text = UserInfo.Contact;
            txtEmail.Text = UserInfo.Email;
            txtAddress.Text = UserInfo.Address;
            txtPassword.Text = UserInfo.Password;
            cmbUserType.Text = UserInfo.UserType;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            MangingFormAndControls th = new MangingFormAndControls(new frmLogIn());
            this.Close();
            th.threading();
        }
    }
}
