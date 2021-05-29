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
    public partial class signinasadmin : Form
    {
        public signinasadmin()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtBoxUserName.Text = "";
            textBox1.Text = "";
        }


        private void loginbtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from EmployeeTB where employeename='" + txtBoxUserName.Text + "' and pass='" + textBox1.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            


            if (dt.Rows.Count > 0)
            {

                string cmbItemVAlue = comboBoxRole.SelectedItem.ToString();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["role"].ToString() == cmbItemVAlue)
                    {
                        MessageBox.Show("You are LoggedIn as " + dt.Rows[i][2]);
                       
                            this.Hide();
                            SIgnUp su = new SIgnUp();
                            su.Show();
                            con.Close();
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Not a Administrator Username or Password.");
                        clear();
                    }

                } 
                
               
                
               

            }
            
            else if (string.IsNullOrWhiteSpace(txtBoxUserName.Text))
            {
                MessageBox.Show("User Name is Missing.");
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Password is Missing.");
            }
            else if (string.IsNullOrWhiteSpace(txtBoxUserName.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter the Missing Fields.");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.");
            }

            clear();
            if (this.IsDisposed)
            {
                this.Hide();
                SIgnUp su = new SIgnUp();
                su.Show();
            }
            con.Close();



            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOG log = new LOG();
            log.Show();
           
        }

        private void signinasadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel == true)
            {
                this.Hide();
                LOG log = new LOG();
                log.Show();
            }
        }
    }
}
