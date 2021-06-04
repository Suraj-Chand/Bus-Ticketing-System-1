using System;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Data.SqlClient;

namespace Bus_Ticketing_System_1
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOG log = new LOG();
            log.Show();
        }

        void clear()
        {
            empuser.Text = "";
            newpass.Text = "";
            confpass.Text = "";
            
        }

        private void coppsw_Click(object sender, EventArgs e)
        { 
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
            string str;

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }


            if (empuser.Text=="" && newpass.Text=="" && confpass.Text=="")
            {
                MessageBox.Show("Enter Employee Name, New Password and Confirm New Password first.");
            }
            else
            {
                if(newpass.Text!="")
                {
                    if(confpass.Text!="")
                    {
                        if (newpass.Text == confpass.Text)
                        {

                            str = "update [EmployeeTB] set [pass] = '" + newpass.Text + "' where employeename='" + empuser.Text + "'  ";
                            con.Open();
                            cmd = new SqlCommand(str, con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Password Changed Successfully.");
                                clear();
                                con.Close();

                            }
                            else
                            {
                                MessageBox.Show("Error! No Employee Name Exists, Password not changed .");
                                clear();

                            }


                        }
                        else
                        {
                            
                            MessageBox.Show("Passwords didn't match.");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Confirm Password First.");
                    }
                }
                else
                {
                    MessageBox.Show("Enter New Password First.");
                }

                
            }


        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel == true)
            {
                this.Hide();
                LOG log = new LOG();
                log.Show();
            }
        }

        private void empuser_TextChanged(object sender, EventArgs e)
        {
            //if (empuser.Text == "" || string.IsNullOrEmpty(empuser.Text) || string.IsNullOrWhiteSpace(empuser.Text))
            //{
            //    errorProvideremployeename.Icon = Properties.Resources.close;
            //    errorProvideremployeename.SetError(empuser, "lkjhgf");
            //    //if(errorProvideremployeename.Icon.Equals(Properties.Resources.close))
            //    //{ }
            //}
            //else
            //{
            //    errorProvideremployeename.Icon = Properties.Resources.ok;
            //    errorProvideremployeename.SetError(empuser, "");
            //}
            if (empuser.Text == "" || string.IsNullOrEmpty(empuser.Text) || string.IsNullOrWhiteSpace(empuser.Text))
            {
                errorProvideremployeename.Icon = Properties.Resources.close;
            }
            else
            {
                errorProvideremployeename.Icon = Properties.Resources.ok;
            }
        }

       

        private void newpass_TextChanged(object sender, EventArgs e)
        {
            if (newpass.Text == "" || string.IsNullOrEmpty(newpass.Text) || string.IsNullOrWhiteSpace(newpass.Text))
            {
                errorProvidernewpass.Icon = Properties.Resources.close;
            }
            else
            {
                errorProvidernewpass.Icon = Properties.Resources.ok;
            }
        }

        private void confpass_TextChanged(object sender, EventArgs e)
        {
            if (confpass.Text == "" || string.IsNullOrEmpty(confpass.Text) || string.IsNullOrWhiteSpace(confpass.Text))
            {
               errorProviderconfirmnewpass.Icon = Properties.Resources.close;
            }
            else
            {
                errorProviderconfirmnewpass.Icon = Properties.Resources.ok;
            }
        }
    }
}
