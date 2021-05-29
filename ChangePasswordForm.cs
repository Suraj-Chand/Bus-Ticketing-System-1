using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Ticketing_System_1
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        void clear()
        {
            usn.Text = "";
            newpass.Text = "";
            confpas.Text = "";
        }

        private void confpas_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - 1LF5S1M; Initial Catalog = BTS1; Integrated Security = True");
            string str;

            try
            {
                if (newpass.Text == confpass.Text)
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                    str = "update [EmployeeTB] set [pass] = '" + newpass.Text + "' where employeename='" + usn.Text + "'  ";
                    con.Open();
                    cmd = new SqlCommand(str, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Password changed successfully.");
                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show("Password not changed successfully.");
                    }


                    //SqlDataReader dr = cmd.ExecuteReader();
                    //if(dr.Read())
                    //{
                    //    clear();
                    //    this.Hide();
                    //    LOG log = new LOG();
                    //    MessageBox.Show( "password changed successfully.");

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Incorrect datas.");
                    //}
                }
                else
                {
                    clear();
                    MessageBox.Show("passwords don't match.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LOG log = new LOG();
            log.Show();
        }
    }
}
