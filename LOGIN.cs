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


        bool mouseDown;
        private Point offset;

        public LOG()
        {
            InitializeComponent();
        }

        void clear()
        {
            comboBoxRole.SelectedIndex=-1;
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
                          

                        }
                        
                       
                    }
                    else
                    {
                        string message = $"  User Name or Password Mis-Match ! \n Not a {comboBoxRole.Text} Name or Password .";
                        string title = "Error";
                        MessageBoxButtons btn = MessageBoxButtons.OK;
                        MessageBox.Show(message,title,btn, MessageBoxIcon.Exclamation );
                        clear();
                    }
                }
            }
            else if (string.IsNullOrWhiteSpace(comboBoxRole.Text) && string.IsNullOrWhiteSpace(comboBoxUserName.Text) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter the Missing Fields.");
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

       

        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
            
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "" || string.IsNullOrEmpty(comboBoxRole.Text) || string.IsNullOrWhiteSpace(comboBoxRole.Text))
            {
                errorProviderrole.Icon = Properties.Resources.close;
            }
            else
            {
                errorProviderrole.Icon = Properties.Resources.ok;
            }
        }

       

        private void comboBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxUserName.Text == "" || string.IsNullOrEmpty(comboBoxUserName.Text) || string.IsNullOrWhiteSpace(comboBoxUserName.Text))
            {
                errorProvidername.Icon = Properties.Resources.close;
            }
            else
            {
                errorProvidername.Icon = Properties.Resources.ok;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProviderpass.Icon = Properties.Resources.close;
                errorProviderpass.SetError(this.textBox1, "Enter Password.");
            }
            else
            {
                errorProviderpass.Icon = Properties.Resources.ok;
                errorProviderpass.SetError(this.textBox1, "ok");
            }
        }

        private void comboBoxRole_Validated(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "" || string.IsNullOrEmpty(comboBoxRole.Text) || string.IsNullOrWhiteSpace(comboBoxRole.Text))
            {
                errorProviderrole.Icon = Properties.Resources.close;
            }
            else
            {
                errorProviderrole.Icon = Properties.Resources.ok;
                
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Black;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Blue;
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_E(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        //private void LOG_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    con
        //}
    }
}
