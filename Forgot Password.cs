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

        SqlCommand cmd;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
        string str;
       

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
            //DataTable dt = new DataTable();
            // sda.Fill(dt);

            if (txtUserName.Text!="" && mail.Text!="")
            {

                if (dr.Read())
                {
                    this.Dispose(false);
                    clear();
                    ChangePassword cp = new ChangePassword();

                    cp.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect username or email.");
                }
            }
            else
            {
                MessageBox.Show("Enter Missing fields.");
            }


            //if (dt.Rows.Count > 0)
            //{



            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {

            //                this.Hide();
            //                main ss = new main();
            //                clear();
            //                ss.Show();
            //                clear();



            //    }
            //}


        }
        //    try
        //    {
        //        str = "SELECT * From EmployeeTB WHERE employeename ='"+ txtUserName .Text+ "', employeephoneno ='"+ numph.Text+ "',citizenshipno ='"+ ctznno.Text+ "'";
        //        cmd = new SqlCommand(str, cn);
        //        cn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read()) ;
        //        {
        //            if (dr["role"].ToString() == "Administrator") 
        //            {
        //                dr.Close();
        //                string v_update = "UPDATE EmployeeTB WHERE employeename ='" + txtUserName.Text + "'";
        //                SqlCommand cmd1 = new SqlCommand(v_update, cn);
        //                int i = cmd1.ExecuteNonQuery();
        //                if (i > 1)
        //                {
        //                    ChangePassword cpp = new ChangePassword();
        //                    this.Dispose(false);
        //                    cpp.Show();
        //                }
        //                else
        //                {
        //                    MessageBox.Show(message, "No Datas.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }
        //            }

        //            else
        //            {
        //                MessageBox.Show(message, "You are not an Administrator.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                clear();

        //            }



        //        }
        //        //else
        //        //{
        //        //    MessageBox.Show(message, "You are not an Administrator.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        //    dr.Close();
        //        //    cn.Close();
        //        //}
        //    }
        //    catch(Exception ex)
        //    {
        //        clear();
        //        MessageBox.Show("Error");
        //    }



        //}








        //string employeename = txtUserName.Text;
        //string employeephoneno = numph.Text;
        //string citizenshipno = ctznno.Text;

        //if (employeename != "" && employeephoneno != "" && citizenshipno != "")
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
        //    DB db = new DB();
        //    //con.Open();

        //    SqlCommand cmd = new SqlCommand("select * from EmployeeTB where employeename='" + txtUserName.Text + "' and employeephoneno='" + numph.Text + "', citizenshipno='" + ctznno + "'",con);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);

        //    this.Hide();
        //    ChangePassword cp = new ChangePassword();
        //    clear();
        //    cp.Show();
        //    clear();


        //}
        //else
        //{
        //    MessageBox.Show("fill the empty fields first.");
        //}






        //if (dt.Rows.Count > 0)
        //{

        //    string cmbItemVAlue = txtUserName.ToString();

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        if (dt.Rows[i]["role"].ToString() == cmbItemVAlue)
        //        {
        //            MessageBox.Show("You are LoggedIn as " + dt.Rows[i][2]);
        //            {
        //                this.Hide();
        //                ChangePassword cp = new ChangePassword();
        //                clear();
        //                cp.Show();
        //                clear();
        //            }

        //        }
        //        else
        //        {
        //            MessageBox.Show("Enter the Proper Fields.");
        //            clear();
        //        }
        //    }
        //}
        //else
        //{
        //    MessageBox.Show("fields empty.");
        //}






        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

        //    con.Open();


        //    SqlCommand cmd = new SqlCommand("select * from EmployeeTB where employeename='" + txtUserName.Text + "' " +
        //        ", employeephoneno='" + numph.Text + "' and citizenshipno='" + ctznno.Text + "' ", con);

        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);






        //    if (dt.Rows.Count > 0)
        //    {

        //        string cmbempVAlue = txtUserName.Text;
        //    string cmbphVAlue = numph.Text;
        //    string cmbctznVAlue = ctznno.Text;

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        if (dt.Rows[i]["employeename"].ToString() == cmbempVAlue &&
        //            dt.Rows[i]["employeephoneno"].ToString() == cmbphVAlue &&
        //            dt.Rows[i]["citizenshipno"].ToString() == cmbctznVAlue)
        //        {
        //            // MessageBox.Show("You are LoggedIn as " + dt.Rows[i][2]);
        //            MessageBox.Show("you can now change password.");

        //            this.Hide();
        //            ChangePassword CP = new ChangePassword();
        //            CP.Show();


        //        }
        //        else
        //        {
        //            MessageBox.Show("Enter the Proper Fields.");
        //        }
        //    }
        //}
        //else
        // {
        //        MessageBox.Show(" Fields Empty.");
        // }

        //this.Hide();
        //ChangePassword CP = new ChangePassword();
        //CP.Show();





        // }

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
                this.Dispose();
                LOG log = new LOG();
                log.Show();
            }
        }

        

        private void showpass_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmployeeTB where employeename='" + txtUserName.Text + "',employeephoneno='" + mail.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show(dr.GetValue(1).ToString());
            }
            else
            {
                MessageBox.Show("not match");
            }
            con.Close();
        }
    }
}
