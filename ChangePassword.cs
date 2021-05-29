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
                    str = "update [EmployeeTB] set [pass] = '" + newpass.Text + "' where employeename='" + empuser.Text + "'  ";
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

            //try
            //{
            //    String na = empuser.Text;
            //   // String pa = oldpass.Text;
            //    String newpa = newpass.Text;
            //    String confirm = confpass.Text;
            //   // String newuse = newuser.Text;

            //    if (na != "" && newpa != "" && confirm != "")
            //    {
            //        if (newpa == confirm)
            //        {
            //            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - 1LF5S1M; Initial Catalog = BTS1; Integrated Security = True");
            //            SqlDataAdapter adap = new SqlDataAdapter("select * from EmployeeTB where employeename='" + empuser.Text.Trim() + "' and pass='" + newpass.Text.Trim() + "'", con);
            //            DataTable dtbl = new DataTable();
            //            //adap.Fill(dtbl);
            //            if (dtbl.Rows.Count == 1)
            //            {
            //                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
            //                conn.Open();
            //                SqlCommand cmdd = conn.CreateCommand();
            //                cmdd.CommandType = CommandType.Text;
            //                cmdd = new SqlCommand("update EmployeeTB set pass='" + newpass.Text + "'", conn);
            //                cmdd.ExecuteNonQuery();
            //                conn.Close();
            //                MessageBox.Show("Password changed sucessfully");
            //                //this.Hide();
            //             //   LOG log = new LOG();
            //              //  log.Show();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Invalid username or password");
            //            }
            //            con.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Password Mismatch");
            //        }
            //    }

            //    else if (na != "" &&   newpa != "" && confirm != "" )
            //    {
            //        if (newpa == confirm)
            //        {
            //            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
            //            SqlDataAdapter adap = new SqlDataAdapter("select * from EmployeeTB where employeename='" + empuser.Text.Trim() + "' and pass='" + newpass.Text.Trim() + "'", con);
            //            DataTable dtbl = new DataTable();
            //          //  adap.Fill(dtbl);
            //            if (dtbl.Rows.Count > 0)
            //            {
            //                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
            //                conn.Open();
            //                SqlCommand cmdd = conn.CreateCommand();
            //                cmdd.CommandType = CommandType.Text;
            //                cmdd = new SqlCommand("update EmployeeTB set employeename ='" + empuser.Text + "' ,pass='" + newpass.Text + "'", conn);
            //                cmdd.ExecuteNonQuery();
            //                conn.Close();
            //                MessageBox.Show("Username and Password and pincode changed sucessfully");

            //            }
            //            else
            //            {
            //                MessageBox.Show("Invalid //username or password");
            //            }
            //            con.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Password Mismatch");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Fill the empty Area");
            //    }
            //}
            //catch (InvalidOperationException)
            //{
            //    MessageBox.Show("Error");
            //}




            //this.Hide();
            //LOG log = new LOG();
            //log.Show();

            //con.Close();
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
    }
}
