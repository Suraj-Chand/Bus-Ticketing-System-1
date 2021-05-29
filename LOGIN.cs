using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bus_Ticketing_System_1
{
    public partial class LOG : Form
    {
        public LOG()
        {
            InitializeComponent();
        }

        void clear()
        {
            comboBoxRole.Text = "";
            comboBoxUserName.Text = "";
            textBox1.Text = "";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from EmployeeTB where employeename='"+ comboBoxUserName.Text+"' and pass='"+ textBox1.Text+"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

          


            if (dt.Rows.Count > 0)
            {

                string cmbItemVAlue = comboBoxRole.SelectedItem.ToString();

                for (int i=0;i<dt.Rows.Count;i++)
                {
                    if (dt.Rows[i] ["role"].ToString()== cmbItemVAlue)
                    {
                        MessageBox.Show("You are LoggedIn as "+dt.Rows[i][2]);
                        {
                            this.Hide();
                            main ss = new main();
                            clear();
                            ss.Show();
                            clear();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Enter the Proper Fields.");
                        clear();
                    }
                }
            }
            
            else if (string.IsNullOrWhiteSpace(comboBoxRole.Text))
            {
                MessageBox.Show("Select Role Field.");
            }
            else if (string.IsNullOrWhiteSpace(comboBoxUserName.Text))
            {
                MessageBox.Show("User Name is Missing.");
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Password is Missing.");
            }
            else if (string.IsNullOrWhiteSpace(comboBoxRole.Text) || string.IsNullOrWhiteSpace(comboBoxUserName.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter the Missing Fields.");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.");
            }
            clear();

            con.Close();


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
            this.Hide();
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
            clear();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            signinasadmin sa = new signinasadmin();
            sa.Show();
            clear();
        }

        //private void LOG_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    con
        //}
    }
}
