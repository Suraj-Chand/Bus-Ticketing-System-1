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
using System.Data.Sql;

namespace Bus_Ticketing_System_1
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }
      
        void clear()
        {
            txtUserName.Text = "";
            mail.Text = "";
           
        }

        private void verifybtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT employeename,email From EmployeeTB WHERE employeename ='" + txtUserName.Text + "' and email ='" + mail.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();

            if (txtUserName.Text == "" && mail.Text == "")
            {
                MessageBox.Show("Enter Employee Name and Email Address first.");
            }
            else
            {
                if (txtUserName.Text != "")
                {
                    if (mail.Text != "")
                    {
                        if (txtUserName.Text != "" && mail.Text != "")
                        {
                            if (dr.Read())
                            {
                                this.Hide();
                                ChangePassword cp = new ChangePassword(txtUserName.Text);
                                clear();
                                errorProvideremployeename.Icon = Properties.Resources.close;
                                errorProvideremail.Icon = Properties.Resources.close;

                                cp.Show(this);
                            }
                            else
                            {
                                MessageBox.Show("Enter Correct Employee Name and Email Address.");
                                clearshow();
                                errorProvideremployeename.Icon = Properties.Resources.close;
                                errorProvideremail.Icon = Properties.Resources.close;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Enter Employee Name and Email Address first.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Email Address first.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Employee Name first.");
                }
            }
            
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOG log = new LOG();
            log.Show();

        }

        private void Forgot_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.Cancel==true)
            {
                this.Close();
                LOG log = new LOG();
                log.Show();
            }
        }

        void clearshow()
        {
            txtUserName.Text = "";
            mail.Text = "";
        }

        private void showpass_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select [pass] from EmployeeTB where employeename='" + txtUserName.Text + "'and email='" + mail.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
           
            if(txtUserName.Text == "" && mail.Text == "")
            {
                MessageBox.Show("Enter Employee Name and Email Address first.");
            }
            else
            {
                if (txtUserName.Text != "")
                {
                    if (mail.Text != "")
                    {
                        if (txtUserName.Text != "" && mail.Text != "")
                        {
                            if(dr.Read())
                            {
                               MessageBox.Show("Your Password is:- " + dr.GetValue(0).ToString());
                                clearshow();
                                errorProvideremployeename.Icon = Properties.Resources.close;
                                errorProvideremail.Icon = Properties.Resources.close;
                            }
                            else
                            {
                                MessageBox.Show("Enter Correct Employee Name and Email Address.");
                                clearshow();
                                    errorProvideremployeename.Icon = Properties.Resources.close;
                                    errorProvideremail.Icon = Properties.Resources.close;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Enter Employee Name and Email Address first.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Email Address first.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Employee Name first.");
                }
              
            }
           
            
            con.Close();
        }

       

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvideremployeename.Icon = Properties.Resources.close;
                errorProvideremployeename.SetError(this.txtUserName, "Enter Employee Name.");
            }
            else
            {
                errorProvideremployeename.Icon = Properties.Resources.ok;
                errorProvideremployeename.SetError(this.txtUserName, "Ok.");
            }
        }

       
        private void mail_TextChanged(object sender, EventArgs e)
        {
            if (mail.Text == "" || string.IsNullOrEmpty(mail.Text) || string.IsNullOrWhiteSpace(mail.Text))
            {
                errorProvideremail.Icon = Properties.Resources.close;
                errorProvideremail.SetError(this.mail, "Enter E-Mail Address.");
            }
            else
            {
                errorProvideremail.Icon = Properties.Resources.ok;
                errorProvideremail.SetError(this.mail, "Ok");
            }
        }

        private void Forgot_Password_FormClosed(object sender, FormClosedEventArgs e)
        {
                this.Hide();
                LOG log = new LOG();
                log.Show();
            
        }

       
    }
}
