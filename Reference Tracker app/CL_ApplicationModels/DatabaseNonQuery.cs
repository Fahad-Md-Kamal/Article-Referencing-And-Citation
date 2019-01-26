using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CL_ApplicationModels
{
    public class DatabaseNonQuery
    {

        public static void InsertUpdateDelete(string Command)
        {
            SqlConnection Con = new SqlConnection(DataBaseConnection.DataAccess);
            SqlCommand cmd = new SqlCommand(Command, Con);
            try
            {
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
