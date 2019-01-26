using System;
using System.Windows.Forms;

namespace frmDeshboard
{
    public partial class MsgBox : Form
    {


        public MsgBox()
        {
            InitializeComponent();
        }

        static MsgBox msb;
        static DialogResult result = DialogResult.No;
        public static DialogResult Show(string text, string caption, string btnLeft, string btnRight)
        {
            msb = new MsgBox();
            msb.lblCaption.Text = text;
            msb.btnLeft.Text = btnLeft;
            msb.btnRight.Text = btnRight;
            msb.lblMessageName.Text = caption;
            result = DialogResult.No;
            msb.ShowDialog();
            return result;

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            msb.Close();
        }

        private void CloseApplicaition_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
