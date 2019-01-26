using System.Windows.Forms;
using System.Threading;

namespace CL_ApplicationModels
{

    public class MangingFormAndControls
    {
        private Form form; //The desired form instance.
        Thread thread; //Threading state.


        /// <summary>
        /// This constructor will receieve form instance of the form that the user want's to open while closing the runnig form.
        /// </summary>
        /// <param name="frm"> Insert form instance of the desired form</param>
        public MangingFormAndControls(Form frm)
        {
            form = frm;
        }


        /// <summary>
        /// These method will do the threading task for the page. And keeps running while one form closes.
        /// </summary>
        public void threading()
        {
            thread = new Thread(OpenForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenForm()
        {
            Application.Run(form);
        }







        /// <summary>
        /// This method will clear the textboxes of a panel. 
        /// </summary>
        /// <param name="panel"> Parameter needs to be passed of a panel to clear all the textboxes of that panel</param>
       public static void PanelClear(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }


    }
}
