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

          
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == Convert.ToChar("*"))
            {
                button1.BringToFront();
                textBox1.PasswordChar = Convert.ToChar("\0");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == Convert.ToChar("\0"))
            {
                button2.BringToFront();
                textBox1.PasswordChar = Convert.ToChar("*");
            }
        }

        private void forgotpasswordbtn_Click(object sender, EventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SIgnUp su = new SIgnUp();
            su.Show();
        }
    }
}
