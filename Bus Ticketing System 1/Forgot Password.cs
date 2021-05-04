using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Ticketing_System_1
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void verifybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword CP = new ChangePassword();
            CP.Show();
        }
    }
}
