using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_ApplicationModels
{
    public class PanelFormLoader
    {
        public static void ServingForm(Form formInstance, Panel panel)
        {
            panel.Controls.Clear();
            formInstance.TopLevel = false;
            formInstance.Height = panel.Height;
            formInstance.Width = panel.Width;
            panel.Controls.Add(formInstance);
            formInstance.Show();
        }
    }
}
