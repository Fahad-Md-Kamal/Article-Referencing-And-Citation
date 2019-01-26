using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CL_ApplicationModels
{
    public class TabelConnector
    {
        public static DataTable DataTableLoader(string Command)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(DataBaseConnection.DataAccess);
            SqlCommand cmd = new SqlCommand(Command, con);
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }

                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

    }
}


