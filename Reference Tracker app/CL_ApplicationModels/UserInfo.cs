using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_ApplicationModels
{
   public class UserInfo
    {
        //Logger's information stored for various operation.
        public static int id { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string UserId { get; set; }
        public static string Contact { get; set; }
        public static string Email { get; set; }
        public static string Address { get; set; }
        public static string Password { get; set; }
        public static string UserType { get; set; }

        //Helps for Guest login operation.
        public static bool loggedIn = false;

        /// <summary>
        /// This inilizes user information from the database.
        /// </summary>
        /// <param name="Command"></param>
        public static void UserLogIn(string Command)
        {
            DataTable dt= TabelConnector.DataTableLoader(Command);

            try
            {
                id = Convert.ToInt32(dt.Rows[0][0]);
                FirstName = dt.Rows[0][1].ToString();
                LastName = dt.Rows[0][2].ToString();
                UserId = dt.Rows[0][3].ToString();
                Contact = dt.Rows[0][4].ToString();
                Email = dt.Rows[0][5].ToString();
                Address = dt.Rows[0][6].ToString();
                Password = dt.Rows[0][7].ToString();
                UserType = dt.Rows[0][8].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    }
}
