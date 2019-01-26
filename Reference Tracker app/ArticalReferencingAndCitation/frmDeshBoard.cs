using System;
using System.Windows.Forms;
using CL_ApplicationModels;


namespace frmDeshboard
{
    public partial class frmDeshBoard : Form
    {


        //During form load event all the process are done here.
        public frmDeshBoard()
        {
            InitializeComponent();
            lblUserName.Text=  UserInfo.UserId;
            lblPageName.Text = "Desh Board";
            lblWelcomeMessage.Text = $"Welcome \"{UserInfo.FirstName} {UserInfo.LastName}\"\nTo\nReference Tracker";
        }


        //Signbutton click will load create account form to the serving panel.
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lblPageName.Text = "Sign Up";
           PanelFormLoader.ServingForm(new frmCreateAccount(), ServingPanel);
        }



        //Refrence button click will load create reference form to the serving panel.
        private void btnReferences_Click(object sender, EventArgs e)
        {
            lblPageName.Text = "References";
            PanelFormLoader.ServingForm(new frmReference(), ServingPanel);
        }



        //Articles button click will load create Articles form to the serving panel.
        private void btnArticles_Click(object sender, EventArgs e)
        {
            lblPageName.Text = "Articles";
            PanelFormLoader.ServingForm(new frmArticles(), ServingPanel);
        }


        //LogOut button click will restart the application with user's confiramtion.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult Result = MsgBox.Show("Do you want to log out ?", "Confirmation", "YES", "NO");
           
            if (Result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }


        //Exit button click will close the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult reslut= MsgBox.Show("Application is closing", "Good By", "OK", "CANCEL");
            if (reslut == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        //Log in button will ask user for log in if they are not logged in already.
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MangingFormAndControls th = new MangingFormAndControls(new frmLogIn());

            if (UserInfo.loggedIn == true)
            {
                //If user is logged in he will be logged out for further login.
                DialogResult result = MsgBox.Show("You will be logged out.", "Warning", "OK", "Cancel");

                if (result == DialogResult.Yes)
                {
                    this.Close();
                    th.threading();
                }
                
            }
            else
            {
                this.Close();
                th.threading();
            }
        }
    }
}
