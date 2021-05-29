using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Ticketing_System_1
{
    public partial class SIgnUp : Form
    {
        public SIgnUp()
        {
            InitializeComponent();
            //displayemployee();
            refreshemployee();
        
        }


      /*  public void displayemployee()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTMS1;Integrated Security=True");

            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmployeeTB", con);
            int i = 0;
            cmd = new SqlCommand("select * from EmployeeTB", con);

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
           // addemployeedgv.Rows.Clear();
            while (dr.Read())
            {
                i = i + 1;
                addemployeedgv.Rows.Add(i.ToString(), dr["employeeid"].ToString(), dr["employeename"].ToString(), dr["role"].ToString(), dr["employeeaddress"].ToString(), dr["employeephoneno"].ToString(), dr["fathersname"].ToString(), dr["mothersname"].ToString(), dr["citizenshipno"].ToString(), dr["email"].ToString());
            }
            dr.Close();
            con.Close();


        }*/


        private void signupbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

            con.Open();



            try
            {

                SqlDataAdapter adap = new SqlDataAdapter("select * from EmployeeTB where employeeid='" + employeeidtxtbox.Text + "'", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Already Exists");

                }
                else
                {

                //con.Open();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    do
                    {
                        String query = "insert into EmployeeTB values('"
                            + employeeidtxtbox.Text + "','" + employeenametxtbox.Text + "','"
                            + rolecomboBox.Text + "',  '" + employeeaddresstxtbox.Text + "','"
                            + employeephonenotxtbox.Text + "',  '"
                            + employeefatherstxtbox.Text + "',  '"
                            + employeemothersnametxtbox.Text + "',  '"
                            + cno.Text + "',  '"
                            + mailtextBox.Text + "',  '"
                            + eppassbox.Text
                            + "',  '"
                            + cppassbox.Text
                            + "')";
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    } while (eppassbox.Text == cppassbox.Text);
                   
                    
                    con.Close();
                    MessageBox.Show("Record Inserted Sucessfully");
                    //displayemployee();
                    this.Hide();
                    LOG log = new LOG();
                    log.Show();

                }

        }
            catch(Exception )
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                MessageBox.Show("                Error! \n Insert missing data field.");
                //this.Hide();
                //LOG log = new LOG();
                //log.Show();
            }
}

        void refreshemployee()
        {
            employeeidtxtbox.Text = "";
            employeenametxtbox.Text = "";
            rolecomboBox.Text = "";
            employeeaddresstxtbox.Text = "";
            employeephonenotxtbox.Text = "";
            employeefatherstxtbox.Text = "";
            employeemothersnametxtbox.Text = "";
            cno.Text = "";
            mailtextBox.Text = "";
            eppassbox.Text = "";
            cppassbox.Text = ""; 

        }

       

        private void SIgnUp_FormClosing(object sender, FormClosingEventArgs e)
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
