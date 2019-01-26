using System;
using System.Data;
using System.Windows.Forms;
using CL_ApplicationModels;
using System.IO;

namespace frmDeshboard
{
    public partial class frmArticles : Form
    {
       



        public frmArticles()
        {
            InitializeComponent();
            ArticleLoader();
            DGVRefList.DataSource = TabelConnector.DataTableLoader("Select * from TblReference");
            cmbRefrenceType.SelectedIndex = 0;
        }



        //Data fields;
        private int Id;
        private string title;
        private string Author;
        private string DocumentType;
        private string Year;
        private string Publisher;
        private string Abstract;
        private string NameOfDocument;
        private string Issue;
        private string Volume;
        private string PageNumbers;
        private string Notes;

        int articleId;//Get's articlelist id form the datagridview cell click event.
        string LN = Environment.NewLine; //Creates new Line to all systems.
        private string _authorLastName;//Gets authors last name rather then all name parts through AuthorLastName methode.
        int RefID;//Get's refrence id from the RefrenceList DataGridView cell click event.


        // Save Button Click Event and user confirmations..
        private void SaveDocument(object sender, EventArgs e)
        {
            if (UserInfo.loggedIn == false)
            {
                    MessageBox.Show("Please Login / Signup First", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MsgBox.Show("Do You want to save the Document ?", "Confirmation", "YES", "NO");

                if (dr == DialogResult.Yes)
                {
                    DatabaseNonQuery.InsertUpdateDelete($"Insert into TblText(Text,Refs, userid) values('{txtWordEditor.Text}','{txtRefrence.Text}','{UserInfo.id}')");
                    MessageBox.Show("File Saved to the storage.", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArticleLoader();
                }
                else
                {
                    MessageBox.Show("File not Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        //Update Button Click Event.
        private void UpdateText(object sender, EventArgs e)
        {
            DialogResult dr = MsgBox.Show("Do You want to Update the Document ?", "Confirmation", "YES", "NO");
            if (dr == DialogResult.Yes)
            {
                DatabaseNonQuery.InsertUpdateDelete($"Update TblText set Text ='{txtWordEditor.Text}',userID = '{UserInfo.id}', Refs='{txtRefrence.Text}' where id='{articleId}'");
                ArticleLoader();
            }
            else
            {
                MessageBox.Show("File not Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Delete button click event for Document delete.
        private void btnDeleteText_Click(object sender, EventArgs e)
        {
            DialogResult dr = MsgBox.Show("Do You want to Update the Document ?", "Confirmation", "YES", "NO");
            if (dr == DialogResult.Yes)
            {
                DatabaseNonQuery.InsertUpdateDelete($"Delete from TblText where id='{articleId}'");
                MangingFormAndControls.PanelClear(PanelText);
                ArticleLoader();
                MessageBox.Show("File Deleted From Storage", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Create new refrence click event for creating new refrence.
        private void btnCreateRefrence_Click(object sender, EventArgs e)
        {
            frmReference fr = new frmReference();
            fr.Show();
        }



        //Print button click event for printing document 
        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (!chkPrintWithRef.Checked)//If the user want's to print the text file only.
            {
                DialogResult result = MsgBox.Show("Do you want to print only the Article ?", "Article Printed", "YES", "NO");
                if (result == DialogResult.Yes)
                {
                    printing(txtWordEditor.Text);
                    MessageBox.Show("Document printed without Refrence Table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                printing(txtWordEditor.Text + LN + LN + LN + txtRefrence.Text);//Prints document with the references.
                MessageBox.Show("Document printed with Refrence Table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Adding Refrence to text button button click event.
        private void btnAddToText_Click(object sender, EventArgs e)
        {
            if (RefID <= 0)//Before printing user must select the refrence list.
            {
                MessageBox.Show("Please select A refrence from the reference list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbRefrenceType.SelectedIndex < 1)//User needs to select a refrence style.
                {
                    MessageBox.Show("Please select Refrence Style.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbRefrenceType.SelectedIndex == 1)
                {
                    txtWordEditor.Text += $" ({_authorLastName}; {Year}); ";
                    txtRefrence.Text += $"{HarvardRefrenceIterate()}";
                }
                else if (cmbRefrenceType.SelectedIndex == 2)
                {
                    txtWordEditor.Text += $" ({_authorLastName}; {Year}); ";
                    txtRefrence.Text += $"{APARefrence()}";
                }
                else if (cmbRefrenceType.SelectedIndex == 3)
                {
                    txtWordEditor.Text += $" ({_authorLastName}; {Year}); ";
                    txtRefrence.Text += $"{ChicagoManualStyle()}";
                }
            }
        }


        //Article DataGridView loads all the documents of the logged in user.
        void ArticleLoader()
        {
            DGVArticlesList.DataSource = TabelConnector.DataTableLoader($"Select * from TblText where userID = '{UserInfo.id}'");
        }


        //Article DataGridView Cell click event.
        private void DGVArticlesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                articleId = Convert.ToInt32(DGVArticlesList.Rows[e.RowIndex].Cells[0].Value);

                DataTable dt = TabelConnector.DataTableLoader($"Select * from tblText where id= {articleId}");//Gets a data table from the datbase and initialize data to the textbox.
                txtWordEditor.Text = dt.Rows[0][1].ToString();
                txtRefrence.Text = dt.Rows[0][3].ToString();
            }
            catch
            {
            }
            
        }

        //Refrence DataGridView cell click event.
        private void DGVRefList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RefID = Convert.ToInt32(DGVRefList.Rows[e.RowIndex].Cells[0].Value);
                FieldInitializer($"Select * from tblReference where id='{RefID}'");
            }
            catch
            {
            }
        }







        /// <summary>
        /// This method will take parameter and will print it in text file format to the location specified by the user.
        /// </summary>
        /// <param name="text"></param>
        void printing(string text)
        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "Text file (*.txt)|.txt |All files (*.*)|*.*" };
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(File.Create(save.FileName));
                sw.Write(text);
                sw.Close();
            }
        }



        /// <summary>
        /// This will initialize Database data fields to the class data fields.
        /// </summary>
        /// <param name="Command"> Database query command needs to be passed to get a datatable</param>
        void FieldInitializer(string Command)
        {
            DataTable dt = TabelConnector.DataTableLoader(Command);


            Id = Convert.ToInt32(dt.Rows[0][0]);
            title = dt.Rows[0][1].ToString();
            Author = dt.Rows[0][2].ToString();
            DocumentType = dt.Rows[0][3].ToString();
            Year = dt.Rows[0][4].ToString();
            Publisher = dt.Rows[0][5].ToString();
            Abstract = dt.Rows[0][6].ToString();
            NameOfDocument = dt.Rows[0][7].ToString();
            Issue = dt.Rows[0][8].ToString();
            Volume = dt.Rows[0][9].ToString();
            PageNumbers = dt.Rows[0][10].ToString();
            Notes = dt.Rows[0][11].ToString();

            AuthorLastName();
        }


        /// <summary>
        /// Takes authors name and provides last name first to add tag to the document file.
        /// </summary>
        void AuthorLastName()
        {
            string[] AuthorNameParts = Author.Split(',');
            _authorLastName = AuthorNameParts[0];
        }


        //Refrence styles arrenged from the data fields.

        string HarvardRefrenceIterate()// Harvard Reference style
        {
            return $"{Author}. ({Year}). {title}. {Abstract}: {Publisher}, {PageNumbers}" + LN + LN;
        }
        string APARefrence()// APA - Refrence style
        {
            return  $"{Author}. ({Year}). {title}. {Abstract}: {Publisher}, {NameOfDocument}" + LN + LN;
        }
        string ChicagoManualStyle()//Chicago Refrence style.
        {
            return $"{Author}. ({Year}). {title}. {Abstract}, {PageNumbers}, {Publisher}, {NameOfDocument}" + LN + LN;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DGVArticlesList.DataSource = TabelConnector.DataTableLoader($"select * from tbltext where text like '%{txtSearch.Text}%' and UserId='{UserInfo.id}'");
        }
    }
}