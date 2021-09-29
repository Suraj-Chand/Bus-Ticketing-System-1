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
    public partial class signupas : Form
    {
        bool flag = false;
        public signupas()
        {
            InitializeComponent();
        }

        private void btnSignupAsAdminClick(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from [EmployeeTB]";
            //cmd.Connection = con;
            //SqlDataReader rd = cmd.ExecuteReader();
            //while(rd.Read())
            //{
            //    if (rd[1].ToString() == "Administrator") ;
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            //if (flag == true)
            //{
            //    this.Hide();
            //    signinasadmin si = new signinasadmin();
            //    si.Show();
            //    //clear();
            //}
            //else
            //{
            //    this.Hide();
            //    SIgnUp si = new SIgnUp(false);
            //    si.Show();
            // //   clear();
            //}

            this.Hide();
            signinasadmin sa = new signinasadmin();
            sa.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIgnUp si = new SIgnUp("staff");
            si.Show();
        }

        private void signupas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LOG log = new LOG();
            log.Show();
        }
    }
}
