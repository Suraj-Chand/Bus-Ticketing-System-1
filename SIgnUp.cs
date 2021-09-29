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
using System.Text.RegularExpressions;

namespace Bus_Ticketing_System_1
{
   
    public partial class SIgnUp : Form
    {
        string a;   
        public SIgnUp(string s)
        {
            InitializeComponent();
            refreshemployee();
            a = s;
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

        private void signupbtn_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

            con.Open();





            SqlDataAdapter adap = new SqlDataAdapter("select * from EmployeeTB where employeeid='" + employeeidtxtbox.Text + "'", con);
            DataTable dt = new DataTable();
            adap.Fill(dt);



            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (employeeidtxtbox.Text != "" &&
                employeenametxtbox.Text != "" &&
                rolecomboBox.Text != "" &&
                employeeaddresstxtbox.Text != "" &&
                employeephonenotxtbox.Text != "" &&
                employeefatherstxtbox.Text != "" &&
                employeemothersnametxtbox.Text != "" &&
                cno.Text != "" &&
                mailtextBox.Text != "" &&
                eppassbox.Text != "" &&
                cppassbox.Text != ""
                )
            {

                if (employeeidtxtbox.Text != "")
                {
                    if (employeenametxtbox.Text != "")
                    {
                        if (rolecomboBox.Text != "")
                        {
                            if (employeeaddresstxtbox.Text != "")
                            {
                                if (employeephonenotxtbox.Text.Length == 6 || employeephonenotxtbox.Text.Length == 10)
                                {
                                    if (employeefatherstxtbox.Text != "")
                                    {
                                        if (employeemothersnametxtbox.Text != "")
                                        {
                                            if (cno.Text != "")
                                            {
                                                if (mailtextBox.Text != "")
                                                {
                                                    if (eppassbox.Text != "")
                                                    {
                                                        if (cppassbox.Text != "")
                                                        {
                                                            if (eppassbox.Text == cppassbox.Text)
                                                            {
                                                                if (dt.Rows.Count > 0)
                                                                {
                                                                    MessageBox.Show("Data Already Exists");

                                                                }
                                                                else
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
                                                                   + "')";
                                                                    cmd.CommandText = query;
                                                                    cmd.ExecuteNonQuery();
                                                                    con.Close();
                                                                    MessageBox.Show("Record Inserted Sucessfully");
                                                                    //displayemployee();
                                                                    this.Hide();
                                                                    LOG log = new LOG();
                                                                    log.Show();
                                                                    refreshemployee();
                                                                }


                                                            }

                                                            else
                                                            {
                                                                MessageBox.Show("passwords didn't match.");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Enter Confirm Password First.");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Enter Password First.");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Enter Employee E-mail Address First.");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Employee Citizenship Number First.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter Employee Mother's Name First.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter Employee Father's Name First.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Check Employee Phone Number.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter Employee Address First.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Employee Role First.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Employee Name First.");
                    }

                }
                else
                {
                    MessageBox.Show("Enter Employee ID First.");
                }
            }
            else
            {
                MessageBox.Show("Enter the Missing Fields First.");
            }




        }



        private void SIgnUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LOG log = new LOG();
            log.Show();
        }



        private void mailtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string inputText = mailtextBox.Text;

            if (Regex.IsMatch(inputText, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
            {

                email.SetError(this.mailtextBox, "E-mail Address is Valid");
                email.Icon = Properties.Resources.ok;
            }
            else
            {
                email.SetError(this.mailtextBox, "E-mail Address is InValid");
                email.Icon = Properties.Resources.close;
            }
        }

        private void employeephonenotxtbox_KeyUp(object sender, KeyEventArgs e)
        {
            string inputText = employeephonenotxtbox.Text;
            if (employeephonenotxtbox.TextLength == 6 || employeephonenotxtbox.Text.Length == 10)
            {
                eph.SetError(this.employeephonenotxtbox, "Valid Local Phone No.");
                eph.Icon = Properties.Resources.ok;
            }
            else if (Regex.IsMatch(inputText, @"^(([0-9]{3})(([0-9]{10})))$"))
            {

                eph.SetError(this.employeephonenotxtbox, "Mobile No is Valid.");
                eph.Icon = Properties.Resources.ok;
            }
            else if (Regex.IsMatch(inputText, @"^(([0-9]{3})(([0-9]{6})))$"))
            {

                eph.SetError(this.employeephonenotxtbox, "Landline No is Valid.");
                eph.Icon = Properties.Resources.ok;
            }
            else
            {
                eph.SetError(this.employeephonenotxtbox, "Enter Mobile No or Land Line Phone No.");
                eph.Icon = Properties.Resources.close;

            }
        }

        private void employeephonenotxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                eph.SetError(this.employeephonenotxtbox, "Enter Numbers Only.");
            }


        }

        private void employeenametxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                ename.SetError(this.employeenametxtbox, "Enter Characters Only.");
            }
            else
            {
                ename.SetError(this.employeenametxtbox, "Ok");
            }
        }

        private void employeefatherstxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                efn.SetError(this.employeefatherstxtbox, "Enter Characters Only.");
            }
            else
            {
                efn.SetError(this.employeefatherstxtbox, "Ok");
            }
        }

        private void employeemothersnametxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                emn.SetError(this.employeemothersnametxtbox, "Enter Characters Only.");
            }
            else
            {
                emn.SetError(this.employeemothersnametxtbox, "Ok");
            }
        }



        private void cppassbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (cppassbox.Text != eppassbox.Text)
            {
                ecpass.Icon = Properties.Resources.close;
                ecpass.SetError(this.cppassbox, "Password Mismatch.");
            }
            else
            {
                ecpass.Icon = Properties.Resources.ok;
                ecpass.SetError(this.cppassbox, "Password Matched");
            }
        }

        private void eppassbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (eppassbox.TextLength >= 6)
            {
                epass.Icon = Properties.Resources.ok;
                epass.SetError(this.eppassbox, "Ok");
            }
            else
            {
                epass.Icon = Properties.Resources.close;
                epass.SetError(this.eppassbox, "Password must be atleast 6 Characters long");
            }
        }

        private void employeefatherstxtbox_TextChanged(object sender, EventArgs e)
        {
            if (employeefatherstxtbox.Text == "" || string.IsNullOrEmpty(employeefatherstxtbox.Text) || string.IsNullOrWhiteSpace(employeefatherstxtbox.Text))
            {
                efn.Icon = Properties.Resources.close;
                efn.SetError(this.employeefatherstxtbox, "Enter Employee Father's Name.");
            }
            else
            {
                efn.Icon = Properties.Resources.ok;
                efn.SetError(this.employeefatherstxtbox, "Ok.");
            }
        }



       

        private void employeeidtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (employeeidtxtbox.Text =="" || string.IsNullOrEmpty(employeeidtxtbox.Text) || string.IsNullOrWhiteSpace(employeeidtxtbox.Text))
            {
                empid.Icon = Properties.Resources.close;
                empid.SetError(this.employeeidtxtbox,"Enter Employee ID.");
            }
            else
            {
                empid.Icon = Properties.Resources.ok;
                empid.SetError(this.employeeidtxtbox, "Ok.");
            }
        }

        private void employeenametxtbox_TextChanged(object sender, EventArgs e)
        {
            if (employeenametxtbox.Text == "" || string.IsNullOrEmpty(employeenametxtbox.Text) || string.IsNullOrWhiteSpace(employeenametxtbox.Text))
            {
                ename.Icon = Properties.Resources.close;
                ename.SetError(this.employeenametxtbox, "Enter Employee Name.");
            }
            else
            {
                ename.Icon = Properties.Resources.ok;
                ename.SetError(this.employeenametxtbox, "Ok.");
            }
        }

        private void rolecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (rolecomboBox.Text == "" || string.IsNullOrEmpty(rolecomboBox.Text) || string.IsNullOrWhiteSpace(rolecomboBox.Text))
            {
                erole.Icon = Properties.Resources.close;
                erole.SetError(this.rolecomboBox, "Select Employee Role.");
            }
            else
            {
                erole.Icon = Properties.Resources.ok;
                erole.SetError(this.rolecomboBox, "Ok.");
            }
        }

        private void employeeaddresstxtbox_TextChanged(object sender, EventArgs e)
        {
            if (employeeaddresstxtbox.Text == "" || string.IsNullOrEmpty(employeeaddresstxtbox.Text) || string.IsNullOrWhiteSpace(employeeaddresstxtbox.Text))
            {
                eadd.Icon = Properties.Resources.close;
                eadd.SetError(this.employeeaddresstxtbox, "Enter Employee Address.");
            }
            else
            {
                eadd.Icon = Properties.Resources.ok;
                eadd.SetError(this.employeeaddresstxtbox, "Ok.");
            }
        }

        private void employeemothersnametxtbox_TextChanged(object sender, EventArgs e)
        {
            if (employeemothersnametxtbox.Text == "" || string.IsNullOrEmpty(employeemothersnametxtbox.Text) || string.IsNullOrWhiteSpace(employeemothersnametxtbox.Text))
            {
                emn.Icon = Properties.Resources.close;
                emn.SetError(this.employeemothersnametxtbox, "Enter Employee Mother's Name.");
            }
            else
            {
                emn.Icon = Properties.Resources.ok;
                emn.SetError(this.employeemothersnametxtbox, "Ok");
            }
        }

      

        private void cppassbox_TextChanged(object sender, EventArgs e)
        {
            if(cppassbox.Text=="")
            {
                epass.SetError(this.cppassbox, "Enter Confirm Password.");
                epass.Icon = Properties.Resources.close;
            }
        }

        private void cno_KeyUp(object sender, KeyEventArgs e)
        {
            string inputText = cno.Text;
           
            if (Regex.IsMatch(inputText, @"^([0-9]{2})\/([0-9]{2})\/([0-9]{2})\/([0-9]{5})$"))
            {

                ecno.SetError(this.cno, "Citizenship No is Valid.");
                ecno.Icon = Properties.Resources.ok;
            }
            else if (Regex.IsMatch(inputText, @"^([0-9]{2})\-([0-9]{2})\-([0-9]{2})\-([0-9]{5})$"))
            {

                ecno.SetError(this.cno, "Citizenship No is Valid.");
                ecno.Icon = Properties.Resources.ok;
            }           
            else
            {
                ecno.SetError(this.cno, "Citizenship No is InValid.");
                ecno.Icon = Properties.Resources.close;
            }
        }

        private void SIgnUp_Load(object sender, EventArgs e)
        {
            if (a.Equals("staff")){
               // rolecomboBox.Items.Add("Administrator");
                rolecomboBox.Items.Add("Receptionist");
                rolecomboBox.Items.Add("Employee");

                this.rolecomboBox.Text = "Administrator";
            }else if (a.Equals("Administrator"))
            {
                rolecomboBox.Items.Add("Administrator");
                rolecomboBox.Items.Add("Receptionist");
                rolecomboBox.Items.Add("Employee");

            }
            else if(a.Length==0)
            {
                rolecomboBox.Items.Add("Administrator");
                this.rolecomboBox.Text="Administrator";
                //rolecomboBox.Enabled = false;
            }
            else
            {
                rolecomboBox.Items.Add("Administrator");
                rolecomboBox.Items.Add("Receptionist");
                rolecomboBox.Items.Add("Employee");

                this.rolecomboBox.Text = "Administrator";
            }
            //int a= 0;
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from [EmployeeTB]";
            //cmd.Connection = con;
            //SqlDataReader rd = cmd.ExecuteReader();
            //while (rd.Read())
            //{
            //    if (rd[0].ToString() == "Administrator") ;
            //    {
            //        flag=true;
            //        break;
            //    }
            //}
            //if (flag = true)
            //{
                
            //    rolecomboBox.SelectedItem= "Administrator";
            //   //
            //else 
            //{
            //  //  rolecomboBox.Enabled = false;
            //    this.rolecomboBox.SelectedItem="Administrator";
            //   rolecomboBox.Enabled = false;
            //}

            //if (flag = false)
            //{
            //    rolecomboBox.Enabled = true;
            //    //this.rolecomboBox.Items.Remove(2);
            //}


        }

      
    }
    
    
}
