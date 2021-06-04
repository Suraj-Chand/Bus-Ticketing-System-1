﻿using System;
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
    public partial class main : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        // private object busouteTableAdapter;
        // private object bTMS1DataSet9;

        public main()
        {
            InitializeComponent();
            displaystation();
            displayemployee();
            displaybusdetails();
            displayroutecreator();
            displayticket();
            combbb();
            combb();
            comb();
            comb1();
            tic();
            emp();
            cr();
            ds();
            address();
            ss();
            sa();
            
        }

        public void tic()
        {
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select  busno from busdetails", con);

                SqlDataReader dd = ccm.ExecuteReader();

                busnocomboBox.Items.Clear();
                while (dd.Read())
                {

                    busnocomboBox.Items.Add(dd.GetValue(0).ToString());


                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                busnocomboBox.Items.Clear();

            }

        }

       


        public void sa()
        {
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select stationaddress from stations", con);

                SqlDataReader dd = ccm.ExecuteReader();

                stationaddresstxtbox.Items.Clear();
                while (dd.Read())
                {

                    stationaddresstxtbox.Items.Add(dd.GetValue(0).ToString());


                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                stationaddresstxtbox.Items.Clear();

            }

        }

        public void ss()
        {
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select sourcestation from ticketcreator", con);

                SqlDataReader dd = ccm.ExecuteReader();

                sourcestationcomboBox.Items.Clear();
                while (dd.Read())
                {

                    sourcestationcomboBox.Items.Add(dd.GetValue(0).ToString());
                  
                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                sourcestationcomboBox.Items.Clear();

            }

        }



        public void address()
        {
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select address from ticketcreator", con);

                SqlDataReader dd = ccm.ExecuteReader();

                passengeraddresstxtbox.Items.Clear();
                while (dd.Read())
                {
                   
                    passengeraddresstxtbox.Items.Add(dd.GetValue(0).ToString());
                  


                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                passengeraddresstxtbox.Items.Clear();

            }

        }

        public void ds()
        {
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select destinationstation from ticketcreator", con);

                SqlDataReader dd = ccm.ExecuteReader();

                destinationstationcombobox.Items.Clear();
                while (dd.Read())
                {

                    destinationstationcombobox.Items.Add(dd.GetValue(0).ToString());
                   
                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                destinationstationcombobox.Items.Clear();

            }

        }

        public void combb()
        {
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select Driver from busdetails", con);

                SqlDataReader dd = ccm.ExecuteReader();

                drivercomboBox.Items.Clear();
                while (dd.Read())
                {

                    drivercomboBox.Items.Add(dd.GetValue(0).ToString());


                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                drivercomboBox.Items.Clear();

            }
        }


        public void combbb()
        {
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select conductor from busdetails", con);

                SqlDataReader dd = ccm.ExecuteReader();

                conductorcomboBox.Items.Clear();
                while (dd.Read())
                {

                    conductorcomboBox.Items.Add(dd.GetValue(0).ToString());


                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                conductorcomboBox.Items.Clear();

            }
        }


        public void cr()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand ccm = new SqlCommand("select  choosestation from busoute", con);

                SqlDataReader dd = ccm.ExecuteReader();

                crcomboBox.Items.Clear();
                while (dd.Read())
                {

                    crcomboBox.Items.Add(dd.GetValue(0).ToString());


                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                crcomboBox.Items.Clear();

            }
        }





        public void comb()
        {
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select routeid from busoute", con);

                SqlDataReader dd = ccm.ExecuteReader();

                routeidtxtbox.Items.Clear();
                while (dd.Read())
                {

                    routeidtxtbox.Items.Add(dd.GetValue(0).ToString());


                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                routeidtxtbox.Items.Clear();

            }
        }

        public void comb1()
        {
            con.Close();
            try
            {
                con.Open();
                SqlCommand ccm = new SqlCommand("select choosestation from busoute", con);

                SqlDataReader dd = ccm.ExecuteReader();

                chooseroutecomboBox.Items.Clear();
                while (dd.Read())
                {

                    chooseroutecomboBox.Items.Add(dd.GetValue(0).ToString());


                }
                dd.Close();
                con.Close();
            }
            catch (IOException)
            {
                chooseroutecomboBox.Items.Clear();

            }
        }
        public void emp()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select role from EmployeeTB";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int i = int.Parse(dt.Rows.Count.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                string sd = dr["role"].ToString();




                try
                {

                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTMS1;Integrated Security=True");

                    conn.Open();
                    SqlCommand ccm = new SqlCommand("select employeename from EmployeeTB", conn);

                    SqlDataReader dd = ccm.ExecuteReader();

                    drivercomboBox.Items.Clear();
                    conductorcomboBox.Items.Clear();
                    while (dd.Read())
                    {


                        drivercomboBox.Items.Add(dd.GetValue(0).ToString());



                        conductorcomboBox.Items.Add(dd.GetValue(0).ToString());




                    }
                    dd.Close();
                    conn.Close();
                }
                catch (IOException)
                {
                    drivercomboBox.Items.Clear();
                    conductorcomboBox.Items.Clear();

                }
                con.Close();
            }


        }










        public void displaystation()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from stations", con);
            int i = 0;
            cmd = new SqlCommand("select * from stations", con);

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            addstationdgv.Rows.Clear();
            while (dr.Read())
            {
                i = i + 1;
                addstationdgv.Rows.Add(i.ToString(), dr["stationcode"].ToString(), dr["stationname"].ToString(), dr["stationaddress"].ToString(), dr["routeid"].ToString());
            }
            dr.Close();
            con.Close();


        }

        public void displayemployee()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmployeeTBother", con);
            int i = 0;
            cmd = new SqlCommand("select * from EmployeeTBother", con);

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            addemployeedgv.Rows.Clear();
            while (dr.Read())
            {
                i = i + 1;
                addemployeedgv.Rows.Add(i.ToString(), dr["employeeid"].ToString(), dr["employeename"].ToString(), dr["role"].ToString(), dr["employeeaddress"].ToString(), dr["employeephoneno"].ToString(), dr["fathersname"].ToString(), dr["mothersname"].ToString(), dr["citizenshipno"].ToString(), dr["email"].ToString());
            }
            dr.Close();
            con.Close();


        }


        public void displaybusdetails()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from busdetails", con);
            int i = 0;
            cmd = new SqlCommand("select * from busdetails", con);

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            busdetailsdgv.Rows.Clear();
            while (dr.Read())
            {
                i = i + 1;
                busdetailsdgv.Rows.Add(i.ToString(), dr["busno"].ToString(), dr["busname"].ToString(), dr["chooseroute"].ToString(), dr["bustype"].ToString(), dr["noofseats"].ToString(), dr["Model"].ToString(), dr["Driver"].ToString(), dr["conductor"].ToString());
            }
            dr.Close();
            con.Close();


        }





        public void displayroutecreator()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from busoute", con);
            int i = 0;
            cmd = new SqlCommand("select * from busoute", con);

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            brcdgv.Rows.Clear();
            while (dr.Read())
            {
                i = i + 1;
                brcdgv.Rows.Add(i.ToString(), dr["routeid"].ToString(), dr["choosestation"].ToString(), dr["distancefromsource"].ToString(), dr["arrivaltime"].ToString(), dr["departuretime"].ToString());
            }
            dr.Close();
            con.Close();


        }




        public void displayticket()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from ticketcreator", con);
            int i = 0;
            cmd = new SqlCommand("select * from ticketcreator", con);

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            searchticketdgv.Rows.Clear();
            while (dr.Read())
            {
                i = i + 1;
                searchticketdgv.Rows.Add(i.ToString(),
                    dr["ticketno"].ToString(),
                    dr["busno"].ToString(), 
                    dr["sourcestation"].ToString(),
                    dr["destinationstation"].ToString(),
                    dr["distancefromsource"].ToString(),
                    dr["chooseroute"].ToString(),
                    dr["noofpassengers"].ToString(),
                    dr["issueddate"].ToString(),
                    dr["departuredate"].ToString(),
                    dr["departuretime"].ToString(), 
                    dr["arrivaltime"].ToString(),
                    dr["totalfarecost"].ToString(),
                    dr["name"].ToString(),
                    dr["age"].ToString(), 
                    dr["gender"].ToString(), 
                    dr["address"].ToString(),
                    dr["phoneno"].ToString());
            }
            dr.Close();
            con.Close();


        }


        private void txtBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOG mw = new LOG();
            mw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bTMS1DataSet9.busoute' table. You can move, or remove it, as needed.
            // this.busouteTableAdapter.Fill(this.bTMS1DataSet9.busoute);

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        private void searchticketbtn_Click(object sender, EventArgs e)
        {

        }

        private bool IsValid()
        {
            if (passengernametxtbox.Text == string.Empty)
            {
                MessageBox.Show("passenger name cannot be empty.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }



        private void addstationbtn_Click(object sender, EventArgs e)
        {


            try
            {

                SqlDataAdapter adap = new SqlDataAdapter("select * from stations where stationcode='" + stationcodetxtbox.Text + "'", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Already Exists");

                }
                else
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into stations values('" + stationcodetxtbox.Text + "','" + stationnametxtbox.Text + "','" + stationaddresstxtbox.Text + "',  '" + routeidtxtbox.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Sucessfully");
                    displaystation();


                }

            }
            catch
            {
                MessageBox.Show("Error in Inserting data");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update stations set stationcode='" + stationcodetxtbox.Text + "',stationname='" + stationnametxtbox.Text + "',stationaddress='" + stationaddresstxtbox.Text + "', routeid='" + routeidtxtbox.Text + "' where stationcode='" + stationcodetxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Sucessfully");
            displaystation();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from stations where stationcode='" + stationcodetxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted Sucessfully");
            displaystation();
        }


        private void addstationdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (addstationdgv.Rows[e.RowIndex].Cells[1].Value == null)
                {
                    refresh();
                }
                else
                {

                    stationcodetxtbox.Text = addstationdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    stationnametxtbox.Text = addstationdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    stationaddresstxtbox.Text = addstationdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    routeidtxtbox.Text = addstationdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Enter proper record");
            }
        }


        public void refresh()
        {
            stationcodetxtbox.Text = "";
            stationnametxtbox.Text = "";
            stationaddresstxtbox.Text = "";
            routeidtxtbox.Text = "";
        }



        private void addemployeebtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

                SqlDataAdapter adap = new SqlDataAdapter("select * from EmployeeTBother where employeeid='" + employeeidtxtbox.Text + "'", con);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Already Exists");

                }
                else
                {


                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into EmployeeTBother values('" + employeeidtxtbox.Text + "','" + employeenametxtbox.Text + "','" + rolecomboBox.Text + "',  '" + employeeaddresstxtbox.Text + "','" + employeephonenotxtbox.Text + "',  '" + employeefatherstxtbox.Text + "',  '" + employeemothersnametxtbox.Text + "',  '" + cno.Text + "',  '" + mailtextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Sucessfully");
                    refreshemployee();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in Inserting data" + ex);
            }

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
           
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update EmployeeTBother set employeeid='" + employeeidtxtbox.Text + "',employeename='" + employeenametxtbox.Text + "',role='" + rolecomboBox.Text + "', employeeaddress='" + employeeaddresstxtbox.Text + "',employeephoneno='" + employeephonenotxtbox.Text + "',fathersname='" + employeefatherstxtbox.Text + "', mothersname='" + employeemothersnametxtbox.Text + "',citizenshipno='" + cno.Text + "',email='" + mailtextBox.Text + "' where employeeid='" + employeeidtxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Sucessfully");
            displayemployee();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EmployeeTBother where employeeid='" + employeeidtxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted Sucessfully");
            displayemployee();
        }





        public void refreshemployee()
        {
            employeeidtxtbox.Text = "";
            employeenametxtbox.Text = "";
            rolecomboBox.Text = "";
            employeeaddresstxtbox.Text = "";
            employeephonenotxtbox.Text = "";
            employeefatherstxtbox.Text = "";
            employeemothersnametxtbox.Text = "";
            cno.Text = "";
        }

        private void addemployeedgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (addemployeedgv.Rows[e.RowIndex].Cells[1].Value == null || addemployeedgv.CurrentRow.Index == -1)
                {
                    refreshemployee();
                }
                else
                {

                    employeeidtxtbox.Text = addemployeedgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    employeenametxtbox.Text = addemployeedgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    rolecomboBox.Text = addemployeedgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    employeeaddresstxtbox.Text = addemployeedgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                    employeephonenotxtbox.Text = addemployeedgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                    employeefatherstxtbox.Text = addemployeedgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                    employeemothersnametxtbox.Text = addemployeedgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                    cno.Text = addemployeedgv.Rows[e.RowIndex].Cells[8].Value.ToString();
                    mailtextBox.Text = addemployeedgv.Rows[e.RowIndex].Cells[9].Value.ToString();

                   
                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Enter proper record");
            }
        }



        public void refreshticket()
        {
            ticketnotxtbox.Text = "";
            busnocomboBox.Text = "";
            sourcestationcomboBox.Text = "";
            destinationstationcombobox.Text = "";
            distancefromsourcetextBox.Text = "";
            crcomboBox.Text = "";
            noptextBox.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker4.Text = "";
            dateTimePicker3.Text = "";
            totalfarecosttxtbox.Text = "";
            passengernametxtbox.Text = "";
            passengeragetxtbox.Text = "";
            passengergendercomboBox.Text = "";
            passengeraddresstxtbox.Text = "";
            passengerphonenumber.Text = "";

        }



        private void printticketbtn_Click(object sender, EventArgs e)
        {

            try
            {

                SqlDataAdapter adap = new SqlDataAdapter("select * from ticketcreator where ticketno='" + ticketnotxtbox.Text + "'", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Already Exists");

                }
                else
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into ticketcreator values" +
                        "('" + ticketnotxtbox.Text + "'," +
                        "'" + busnocomboBox.Text + "'," +
                        "'" + sourcestationcomboBox.Text + "'," +
                        "'" + destinationstationcombobox.Text + "'," +
                        "'" + distancefromsourcetextBox.Text + "'," +
                        "'" + crcomboBox.Text + "'," +
                        "'" + noptextBox.Text + "'," +
                        "'" + dateTimePicker1.Text + "'," +
                        "'" + dateTimePicker2.Text + "'," +
                        "'" + dateTimePicker4.Text + "'," +
                        "'" + dateTimePicker3.Text + "'," +
                        "'" + totalfarecosttxtbox.Text + "'," +
                        "'" + passengernametxtbox.Text + "'," +
                        "'" + passengeragetxtbox.Text + "'," +
                        "'" + passengergendercomboBox.Text + "'," +
                        "'" + passengeraddresstxtbox.Text + "'," +
                        "'" + passengerphonenumber.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Sucessfully");
                    displayticket();

                }

            }
            catch
            {
                MessageBox.Show("Error in Inserting data");
            }

        }




        private void searchticketdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (searchticketdgv.Rows[e.RowIndex].Cells[1].Value == null || searchticketdgv.CurrentRow.Index == -1)
                {
                    refreshticket();
                }
                else
                {
                    ticketnotxtbox.Text = searchticketdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    busnocomboBox.Text = searchticketdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    sourcestationcomboBox.Text = searchticketdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    destinationstationcombobox.Text = searchticketdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                    distancefromsourcetextBox.Text = searchticketdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                    crcomboBox.Text = searchticketdgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                    noptextBox.Text = searchticketdgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                    dateTimePicker1.Text = searchticketdgv.Rows[e.RowIndex].Cells[8].Value.ToString();
                    dateTimePicker2.Text = searchticketdgv.Rows[e.RowIndex].Cells[9].Value.ToString();
                    dateTimePicker4.Text = searchticketdgv.Rows[e.RowIndex].Cells[10].Value.ToString();
                    dateTimePicker3.Text = searchticketdgv.Rows[e.RowIndex].Cells[11].Value.ToString();
                    totalfarecosttxtbox.Text = searchticketdgv.Rows[e.RowIndex].Cells[12].Value.ToString();
                    passengernametxtbox.Text = searchticketdgv.Rows[e.RowIndex].Cells[13].Value.ToString();
                    passengeragetxtbox.Text = searchticketdgv.Rows[e.RowIndex].Cells[14].Value.ToString();
                    passengergendercomboBox.Text = searchticketdgv.Rows[e.RowIndex].Cells[15].Value.ToString();
                    passengeraddresstxtbox.Text = searchticketdgv.Rows[e.RowIndex].Cells[16].Value.ToString();
                    passengerphonenumber.Text = searchticketdgv.Rows[e.RowIndex].Cells[17].Value.ToString();
                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Enter proper record");
            }
        }


        public void refreshbusdetails()
        {
            busnotxtbox.Text = "";
            busnametxtbox.Text = "";
            chooseroutecomboBox.Text = "";
            bustypecomboBox.Text = "";
            noofseatstxtbox.Text = "";
            busmodeltxtbox.Text = "";
            drivercomboBox.Text = "";
            conductorcomboBox.Text = "";
        }

        private void addbd_Click(object sender, EventArgs e)
        {


            try
            {

                SqlDataAdapter adap = new SqlDataAdapter("select * from busdetails where busno='" + busnotxtbox.Text + "'", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Already Exists");

                }
                else
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into busdetails values('" + busnotxtbox.Text + "','" + busnametxtbox.Text + "','" + chooseroutecomboBox.Text + "',  '" + bustypecomboBox.Text + "','" + noofseatstxtbox.Text + "',  '" + busmodeltxtbox.Text + "',  '" + drivercomboBox.Text + "',  '" + conductorcomboBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Sucessfully");
                    displaybusdetails();


                }

            }
            catch
            {
                MessageBox.Show("Error in Inserting data");
            }
            displaybusdetails();
        }





        private void updatebd_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update busdetails set busno='" + busnotxtbox.Text + "',busname='" + busnametxtbox.Text + "', chooseroute='" + chooseroutecomboBox.Text + "', bustype='" + bustypecomboBox.Text + "', noofseats='" + noofseatstxtbox.Text + "',Model='" + busmodeltxtbox.Text + "', Driver='" + drivercomboBox.Text + "',conductor='" + conductorcomboBox.Text + "' where busno='" + busnotxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Sucessfully");
            displaybusdetails();
        }

        private void deletebd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from busdetails where busno='" + busnotxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted Sucessfully");
            displaybusdetails();
        }


        private void Busdetailsdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (busdetailsdgv.Rows[e.RowIndex].Cells[1].Value == null || busdetailsdgv.CurrentRow.Index == -1)
                {
                    refreshbusdetails();

                }
                else
                {
                    busnotxtbox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    busnametxtbox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    chooseroutecomboBox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    bustypecomboBox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                    noofseatstxtbox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                    busmodeltxtbox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                    drivercomboBox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                    conductorcomboBox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[8].Value.ToString();
                    displaybusdetails();
                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Enter proper record");
            }

        }

        public void refreshbusroutecreator()
        {
            enterrouteidtxtbox.Text = "";
            choosestationcomboBox.Text = "";
            distancefromsourcetxtbox.Text = "";
            arrivaltimetxtbox.Text = "";
            departuretimetxtbox.Text = "";

        }

        private void addroutebtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter adap = new SqlDataAdapter("select * from busoute where routeid='" + enterrouteidtxtbox.Text + "'", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Already Exists");

                }
                else
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into busoute values('" + enterrouteidtxtbox.Text + "','" + choosestationcomboBox.Text + "','" + distancefromsourcetxtbox.Text + "',  '" + arrivaltimetxtbox.Text + "','" + departuretimetxtbox.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Sucessfully");
                    displayroutecreator();


                }

            }
            catch
            {
                MessageBox.Show("Error in Inserting data");
            }

        }

        private void updateroutebtn_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update busoute set routeid='" + enterrouteidtxtbox.Text + "',choosestation='" + choosestationcomboBox.Text + "',distancefromsource='" + distancefromsourcetxtbox.Text + "', arrivaltime='" + arrivaltimetxtbox.Text + "',departuretime='" + departuretimetxtbox.Text + "' where routeid='" + enterrouteidtxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Sucessfully");
            displayroutecreator();
        }

        private void deleteroutebtn_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from busoute where routeid='" + enterrouteidtxtbox.Text + "'";
            cmd.ExecuteNonQuery(); 
            con.Close();
            MessageBox.Show("Record deleted Sucessfully");
            displayroutecreator();
        }



        private void brcdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (brcdgv.Rows[e.RowIndex].Cells[1].Value == null || brcdgv.CurrentRow.Index == -1)
                {
                    refreshbusroutecreator();
                }
                else
                {

                    enterrouteidtxtbox.Text = brcdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    choosestationcomboBox.Text = brcdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    distancefromsourcetxtbox.Text = brcdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    arrivaltimetxtbox.Text = brcdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                    departuretimetxtbox.Text = brcdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                    displayroutecreator();
                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Enter proper record");
            }
        }

        private void routeidtxtbox_Click(object sender, EventArgs e)
        {
            comb();
        }



        private void chooseroutecomboBox_Click(object sender, EventArgs e)
        {

            refreshbusdetails();
            refreshbusroutecreator();

        }



        private void tabControl1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            displaystation();
            displayemployee();
            displaybusdetails();
            displayroutecreator();
            displayticket();
            combbb();
            combb();
            comb();
            comb1();
            tic();
            emp();
            cr();
            ds();
            address();
            ss();
            sa();
            
        }

        private void enterticketnotxtbox_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand("select * from ticketcreator where ticketno like ('%" + enterticketnotxtbox.Text + "%')", con);
            SqlDataReader dr = cmd.ExecuteReader();
            searchticketdgv.Rows.Clear();
            int i = 0;
            while (dr.Read())
            {
                i = i + 1;
                searchticketdgv.Rows.Add(i.ToString(), dr["ticketno"].ToString(), dr["busno"].ToString(), dr["sourcestation"].ToString(), dr["destinationstation"].ToString(), dr["distancefromsource"].ToString(), dr["chooseroute"].ToString(), dr["totalfarecost"].ToString(), dr["issueddate"].ToString(), dr["departuredate"].ToString(), dr["departuretime"].ToString(), dr["arrivaltime"].ToString(), dr["name"].ToString(), dr["age"].ToString(), dr["gender"].ToString(), dr["address"].ToString(), dr["phoneno"].ToString());

            }
            dr.Close();
            con.Close();

        }

        private void crcomboBox_TextChanged(object sender, EventArgs e)
        {

            cr();
        }

        private void chooseroutecomboBox_TextChanged(object sender, EventArgs e)
        {
            comb1();
        }
        private void busnocomboBox_TextChanged(object sender, EventArgs e)
        {
            tic();
        }
        private void destinationstationcomboBox_TextChanged(object sender, EventArgs e)
        {
            ss();
            ds();
        }
        private void sourcestationcomboBox_TextChanged(object sender, EventArgs e)
        {
            ds();
            ss();
        }

        private void passengeraddresstxtbox_TextChanged(object sender, EventArgs e)
        {
            
            sa();
            address();
            ss();
            ds();
        }
        private void stationaddresstxtbox_TextChanged(object sender, EventArgs e)
        {
            sa();
            address();
            ss();
            ds();

        }
        private void drivercomboBox_TextChanged(object sender, EventArgs e)
        {
            
            combb();
        }
        private void conductorcomboBox_TextChanged(object sender, EventArgs e)
        {
            
            combbb();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ticketcreator set ticketno='" + ticketnotxtbox.Text + "',busno='" + busnocomboBox.Text + "', sourcestation='" + sourcestationcomboBox.Text + "', destinationstation='" + destinationstationcombobox.Text + "', chooseroute='" + chooseroutecomboBox.Text + "',distancefromsource='" + distancefromsourcetextBox.Text + "', totalfarecost='" + totalfarecosttxtbox.Text + "',issueddate='" + dateTimePicker1.Text + "',departuredate='" + dateTimePicker2.Text + "',departuretime='" + dateTimePicker4.Text + "',arrivaltime='" + dateTimePicker3.Text + "',name='" + passengernametxtbox.Text + "',age='" + passengeragetxtbox.Text + "',gender='" + passengergendercomboBox.Text + "',address='" + passengeraddresstxtbox.Text + "',phoneno='" + passengerphonenumber.Text + "' where ticketno='" + ticketnotxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Sucessfully");
            displayticket();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ticketcreator where ticketno='" + ticketnotxtbox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted Sucessfully");
            displayticket();
        }

       

       

      

        private void crcomboBox_Click(object sender, EventArgs e)
        {
            refreshbusroutecreator();
            refreshbusdetails();

        }

        private void exitbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            LOG log = new LOG();
            log.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Close();
            LOG log = new LOG();
            log.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LOG log = new LOG();
            log.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.Close();
            LOG log = new LOG();
            log.Show();
        }

        private void addemployeedgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Select(Focus.addemployeedgv.Rows());
            this.Select();
            this.Focus();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LOG log = new LOG();
            log.Show();
        }
    }
}