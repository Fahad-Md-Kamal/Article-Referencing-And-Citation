using System;
using System.Windows.Forms;
using CL_ApplicationModels;

namespace frmDeshboard
{
    public partial class frmLogIn : Form
    {

        //Default form load event.
        public frmLogIn()
        {
            InitializeComponent();
        }


        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            

            //Checks Userid and password mathches for application running.
            if (txtUsername.Text =="")
            {
                    MessageBox.Show($"Please Enter User ID", "User Regisration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UserInfo.UserLogIn($"Select * from Users Where UserId='{txtUsername.Text}' and Password = '{txtPassword.Text}'");
                if (txtUsername.Text == UserInfo.UserId && txtPassword.Text == UserInfo.Password)
                {
                    //After checking if required filds mathches userinfo classes field is set true and show user's first name and last name in the welcome screen.
                    UserInfo.loggedIn = true;
                    DialogResult result = MsgBox.Show($"Welcome {UserInfo.FirstName} {UserInfo.LastName}", $"Logged in as {UserInfo.UserType}", "OK", "Cancel");

                    //If user press ok button than application runs. Otherwise application restarts.
                    if (result == DialogResult.Yes)
                    {
                        //Form threading starts for closing this form and starting other form.
                        MangingFormAndControls th = new MangingFormAndControls(new frmDeshBoard());
                        this.Close();
                        th.threading();
                    }
                    else
                    {
                        ////Whole application restarts.
                        Application.Restart();
                    }
                }
                else
                {
                    MsgBox.Show($"Wrong UserName / Password", "Log In faild", "Try Again", "Cancel");
                }
            }
        }



        //For entering into the application as a Guest.
        private void lblGuest_Click(object sender, EventArgs e)
        {
            MangingFormAndControls th = new MangingFormAndControls(new frmDeshBoard());
            this.Close();
            th.threading();
        }

        //For closing the application by pressing the 'X' marked label.
        private void exit_Application(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            MangingFormAndControls th = new MangingFormAndControls(new frmCreateAccount());
            this.Close();
            th.threading();
        }
    }
}
