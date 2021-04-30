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
    public partial class LOG : Form
    {
        public LOG()
        {
            InitializeComponent();
        }

        private void LOG_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            main ss = new main();

            ss.Show();
        }
    }
}
