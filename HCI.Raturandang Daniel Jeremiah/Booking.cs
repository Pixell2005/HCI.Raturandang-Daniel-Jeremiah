using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI.Raturandang_Daniel_Jeremiah
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNama.Text) && !string.IsNullOrEmpty(txtMobil.Text))
            {
                Confirmation confirmation = new Confirmation();
                confirmation.Show();
            }
            else
            {
                Warning warning = new Warning();
                warning.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
