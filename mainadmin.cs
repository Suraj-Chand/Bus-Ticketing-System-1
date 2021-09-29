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
using System.Configuration;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Bus_Ticketing_System_1
{
    public partial class mainadmin : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        // private object busouteTableAdapter;
        // private object bTMS1DataSet9;
        string role;
        public mainadmin(string s)
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
            refreshemployees();
            displayemployees();
            
            role = s;
           

        }

       
        public void tic()
        {
            displaybusdetails();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

            SqlCommand ccm = new SqlCommand("select  busno from busdetails where busstatus='Available'", con);

            SqlDataReader dd;
            try
            {
                con.Open();
                dd = ccm.ExecuteReader();
                busnocomboBox.Items.Clear();
                while (dd.Read())
                {
                    
                    string busno = dd.GetString(0);
                    busnocomboBox.Items.Add(busno);


                }
                dd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                busnocomboBox.Items.Clear();
            }


        }




        public void sa()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
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
                SqlCommand ccm = new SqlCommand("select employeename from EmployeeTBother where role='Driver'", con);

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
                SqlCommand ccm = new SqlCommand("select employeename from EmployeeTBother where role='Conductor'", con);

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

        public void displayemployees()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmployeeTB", con);
            int i = 0;
            cmd = new SqlCommand("select * from EmployeeTB", con);

            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            addemployeedgvs.Rows.Clear();
            while (dr.Read())
            {
                i = i + 1;
                addemployeedgvs.Rows.Add(i.ToString(), dr["employeeid"].ToString(), dr["employeename"].ToString(), dr["role"].ToString(), dr["employeeaddress"].ToString(), dr["employeephoneno"].ToString(), dr["fathersname"].ToString(), dr["mothersname"].ToString(), dr["citizenshipno"].ToString(), dr["email"].ToString(), dr["pass"].ToString());
            }
            dr.Close();
            con.Close();
            //    if (con.State == ConnectionState.Closed)
            //    {
            //        con.Open();
            //    }

            //    SqlCommand cmd = new SqlCommand("select * from EmployeeTB", con);
            //    int i = 0;
            //    cmd = new SqlCommand("select * from EmployeeTB", con);

            //    DataTable dt = new DataTable();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    addemployeedgvs.Rows.Clear();
            //    while (dr.Read())
            //    {
            //        i = i + 1;
            //        addemployeedgvs.Rows.Add(i.ToString(),
            //            dr["employeeid"].ToString(),
            //            dr["employeename"].ToString(),
            //            dr["role"].ToString(),
            //            dr["employeeaddress"].ToString(),
            //            dr["employeephoneno"].ToString(), 
            //            dr["fathersname"].ToString(),
            //            dr["mothersname"].ToString(),
            //            dr["citizenshipno"].ToString(),
            //            dr["email"].ToString(),
            //            dr["pass"].ToString());
            //    }
            //    dr.Close();
            //    con.Close();


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
                busdetailsdgv.Rows.Add(i.ToString(), dr["busno"].ToString(), dr["busname"].ToString(), dr["chooseroute"].ToString(), dr["bustype"].ToString(), dr["noofseats"].ToString(), dr["Model"].ToString(), dr["Driver"].ToString(), dr["conductor"].ToString(),dr["busstatus"].ToString());
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


        private bool IsValid()
        {
            if (passengernametxtbox.Text == string.Empty)
            {
                MessageBox.Show("passenger name cannot be empty.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
                else if(stationcodetxtbox.Text=="" || stationnametxtbox.Text=="" || stationaddresstxtbox.Text=="" || routeidtxtbox.Text=="")
                {
                    MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into stations values(" +
                            "'" + stationcodetxtbox.Text + "'," +
                            "'" + stationnametxtbox.Text + "'," +
                            "'" + stationaddresstxtbox.Text + "'," +
                            "  '" + routeidtxtbox.Text + "')";
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
            if (stationcodetxtbox.Text == "" || stationnametxtbox.Text == "" || stationaddresstxtbox.Text == "" || routeidtxtbox.Text != "")
            {
                MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                else if(employeeidtxtbox.Text=="" || employeenametxtbox.Text =="" || rolecomboBox.Text =="" || employeeaddresstxtbox.Text ==""
                        || employeephonenotxtbox.Text =="" || employeefatherstxtbox.Text =="" || employeemothersnametxtbox.Text =="" || cno.Text ==""
                        || mailtextBox.Text =="")
                {
                    MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into EmployeeTBother values(" +
                            "'" + employeeidtxtbox.Text + "'," +
                            "'" + employeenametxtbox.Text + "'," +
                            "'" + rolecomboBox.Text + "', " +
                            "'" + employeeaddresstxtbox.Text + "'," +
                            "'" + employeephonenotxtbox.Text + "'," +
                            "'" + employeefatherstxtbox.Text + "'," +
                            "'" + employeemothersnametxtbox.Text + "', " +
                            "'" + cno.Text + "', " +
                            "'" + mailtextBox.Text + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Inserted Sucessfully");
                        displayemployee();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in Inserting data" + ex);
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (employeeidtxtbox.Text == "" || employeenametxtbox.Text == "" || rolecomboBox.Text == "" || employeeaddresstxtbox.Text == ""
                        || employeephonenotxtbox.Text == "" || employeefatherstxtbox.Text == "" || employeemothersnametxtbox.Text == "" || cno.Text == ""
                        || mailtextBox.Text == "")
            {
                MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();

            panel1 = pnl;
            getprintarea(pnl);
            ////Code to print bill
            //DGVPrinter printer = new DGVPrinter();
            //printer.Title = "\r\n\r\nSudur Paschim Yatayat";
            //printer.SubTitle = "Sudur Paschim Province (Province 7)\r\nBus Park, Dhangadhi";
            //// printer.SubTitle = "Bus Park, Dhangadhi";
            //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //printer.PageNumbers = true;
            //printer.PageNumberInHeader = false;
            //printer.PorportionalColumns = true;
            //printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "Thank You For Travelling...";
            //printer.FooterSpacing = 15;
            //printer.PrintDataGridView(searchticketdgv);

            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprvw.ShowDialog();
        }

        public void pntdoc_printpage(object sender,PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            
            e.Graphics.DrawString("\r\nSudur Paschim Yatayat\n\r", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 10));
            e.Graphics.DrawString("\r\nSudur Paschim Province (Province 7)\r\n\tBus Park, Dhangadhi \n\r", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(265,50));

            e.Graphics.DrawString("\r\nTicket Details:-\n\r", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new Point(100, 120));

            e.Graphics.DrawString("\r\n\n\nTicket No:- "+ticketnotxtbox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 130));
            e.Graphics.DrawString("\r\n\n\nBus No:- " + busnocomboBox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 160));
            e.Graphics.DrawString("\r\n\n\nSource Station:- " + sourcestationcomboBox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 190));
            //e.Graphics.DrawImage(memorying, (pagearea.Width ) - (this.groupBox2.Width),this.groupBox2.Location.Y );
            e.Graphics.DrawString("\r\n\n\nDestination Station:- " + destinationstationcombobox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 220));
            e.Graphics.DrawString("\r\n\n\nDistance From Source:- " + distancefromsourcetextBox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 250));
            e.Graphics.DrawString("\r\n\n\nChoose Route:- " + crcomboBox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 280));
            e.Graphics.DrawString("\r\n\n\nNo of Passengers:- " + noptextBox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(500, 130));
            e.Graphics.DrawString("\r\n\n\nIssued Date:- " + dateTimePicker1.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(500, 160));
            e.Graphics.DrawString("\r\n\n\nDeparture Date:- " + dateTimePicker2.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(500, 190));
            e.Graphics.DrawString("\r\n\n\nDeparture Time:- " + dateTimePicker4.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(500, 220));
            e.Graphics.DrawString("\r\n\n\nArrival Time:- " + dateTimePicker3.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(500, 250));
            e.Graphics.DrawString("\r\n\n\nTotal Fare Cost:- " + totalfarecosttxtbox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(500, 280));

            e.Graphics.DrawString("\r\nPassenger Details:-\n\r", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new Point(100, 350));

            e.Graphics.DrawString("\r\n\n\nName:- " + passengernametxtbox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 360));
            e.Graphics.DrawString("\r\n\n\nAge:- " + passengeragetxtbox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 390));
            e.Graphics.DrawString("\r\n\n\nGender:- " + passengergendercomboBox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(100, 420));
            e.Graphics.DrawString("\r\n\n\nAddress:- " + passengeraddresstxtbox.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(500, 360));
            e.Graphics.DrawString("\r\n\n\nPhone No:- " + passengerphonenumber.Text, new Font("Times New Roman", 13, FontStyle.Bold), Brushes.Black, new Point(500, 390));

            e.Graphics.DrawString("\r\n\n\nThank You For Travelling...\n    Have a Safe Journey.", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(500, 470));

            //  e.Graphics.DrawImage(memorying,(pagearea.Width/2)-(this.panel1.Width/2),this.panel1.Location.Y);
        }

        Bitmap memorying;

        public void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(1000, 1000,pnl.Width,pnl.Height));
        }

        private void printticketbtn_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = printDocument;
            //printPreviewDialog1.ShowDialog();

           


            ////Code to print bill
            //DGVPrinter printer = new DGVPrinter();
            //printer.Title = "\r\n\r\nSudur Paschim Yatayat";
            //printer.SubTitle = "Sudur Paschim Province (Province 7)\r\nBus Park, Dhangadhi";
            //// printer.SubTitle = "Bus Park, Dhangadhi";
            //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //printer.PageNumbers = true;
            //printer.PageNumberInHeader = false;
            //printer.PorportionalColumns = true;
            //printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "Thank You For Travelling...";
            //printer.FooterSpacing = 15;
            //printer.PrintDataGridView(searchticketdgv);

            try
            {

                SqlDataAdapter adap = new SqlDataAdapter("select * from ticketcreator where ticketno='" + ticketnotxtbox.Text + "'", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Data Already Exists"); 

                }

                else if(
                    ticketnotxtbox.Text == ""||
                        busnocomboBox.Text == "" ||
                        sourcestationcomboBox.Text == "" ||
                        destinationstationcombobox.Text == "" ||
                        distancefromsourcetextBox.Text == "" ||
                        crcomboBox.Text == "" ||
                        noptextBox.Text == "" ||
                        dateTimePicker1.Text == "" ||
                        dateTimePicker2.Text == "" ||
                        dateTimePicker4.Text == "" ||
                        dateTimePicker3.Text == "" ||
                        totalfarecosttxtbox.Text == "" ||
                        passengernametxtbox.Text == "" ||
                        passengeragetxtbox.Text == "" ||
                        passengergendercomboBox.Text == "" ||
                        passengeraddresstxtbox.Text == "" ||
                        passengerphonenumber.Text == "" 
                        )
                {
                    MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);                       
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
                        MessageBox.Show("Record Inserted Sucessfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        displayticket();
                        Print(this.panel1);
                    }
                }

                
            catch
            {
                MessageBox.Show("Error in Inserting data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bscomboBox.Text = "";
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
                else if (busnotxtbox.Text == "" ||
                        busnametxtbox.Text == "" ||
                        chooseroutecomboBox.Text == "" ||
                        bustypecomboBox.Text == "" ||
                        noofseatstxtbox.Text == "" ||
                        busmodeltxtbox.Text == "" ||
                        drivercomboBox.Text == "" ||
                        conductorcomboBox.Text == ""
                        )
                {
                    MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into busdetails values('" + busnotxtbox.Text + "','" + busnametxtbox.Text + "','" + chooseroutecomboBox.Text + "',  '" + bustypecomboBox.Text + "','" + noofseatstxtbox.Text + "',  '" + busmodeltxtbox.Text + "',  '" + drivercomboBox.Text + "',  '" + conductorcomboBox.Text + "','" + bscomboBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Sucessfully");
                    displaybusdetails();
                } 

                

            }
            catch
            {
                MessageBox.Show("Error in Inserting data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // displaybusdetails();
        }





        private void updatebd_Click(object sender, EventArgs e)
        {
             if (busnotxtbox.Text == "" ||
                        busnametxtbox.Text == "" ||
                        chooseroutecomboBox.Text == "" ||
                        bustypecomboBox.Text == "" ||
                        noofseatstxtbox.Text == "" ||
                        busmodeltxtbox.Text == "" ||
                        drivercomboBox.Text == "" ||
                        conductorcomboBox.Text == ""
                        )
             {
                MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
             else
             {
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update busdetails set busno='" + busnotxtbox.Text + "',busname='" + busnametxtbox.Text + "', chooseroute='" + chooseroutecomboBox.Text + "', bustype='" + bustypecomboBox.Text + "', noofseats='" + noofseatstxtbox.Text + "',Model='" + busmodeltxtbox.Text + "', Driver='" + drivercomboBox.Text + "',conductor='" + conductorcomboBox.Text + "',busstatus='"+bscomboBox.Text+"' where busno='" + busnotxtbox.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated Sucessfully");
                displaybusdetails();
             }
           
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
                    bscomboBox.Text = busdetailsdgv.Rows[e.RowIndex].Cells[9].Value.ToString();
                    
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
                else if(enterrouteidtxtbox.Text =="" ||
                        choosestationcomboBox.Text == "" ||
                        distancefromsourcetxtbox.Text == "" ||
                        arrivaltimetxtbox.Text == "" ||
                        departuretimetxtbox.Text == "" 
                        )
                {
                    MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error in Inserting data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateroutebtn_Click(object sender, EventArgs e)
        {
            if (enterrouteidtxtbox.Text == "" ||
                        choosestationcomboBox.Text == "" ||
                        distancefromsourcetxtbox.Text == "" ||
                        arrivaltimetxtbox.Text == "" ||
                        departuretimetxtbox.Text == ""
                        )
            {
                MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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



        

        private void routeidtxtbox_Click(object sender, EventArgs e)
        {
            comb();
            comb1();
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
            refreshemployees();
            displayemployees();

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

        private void crcomboBox_TextChanged(object sender, EventArgs e)
        {
            cr();
            comb1();
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
            sa();
            ss();
            ds();
        }
        private void sourcestationcomboBox_TextChanged(object sender, EventArgs e)
        {
            sa();
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
            if (
                     ticketnotxtbox.Text == "" ||
                         busnocomboBox.Text == "" ||
                         sourcestationcomboBox.Text == "" ||
                         destinationstationcombobox.Text == "" ||
                         distancefromsourcetextBox.Text == "" ||
                         crcomboBox.Text == "" ||
                         noptextBox.Text == "" ||
                         dateTimePicker1.Text == "" ||
                         dateTimePicker2.Text == "" ||
                         dateTimePicker4.Text == "" ||
                         dateTimePicker3.Text == "" ||
                         totalfarecosttxtbox.Text == "" ||
                         passengernametxtbox.Text == "" ||
                         passengeragetxtbox.Text == "" ||
                         passengergendercomboBox.Text == "" ||
                         passengeraddresstxtbox.Text == "" ||
                         passengerphonenumber.Text == ""
                         )
            {
                MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update ticketcreator set " +
                    "ticketno='" + ticketnotxtbox.Text + "'," +
                    "busno='" + busnocomboBox.Text + "'," +
                    "sourcestation='" + sourcestationcomboBox.Text + "'," +
                    "destinationstation='" + destinationstationcombobox.Text + "'," +                    
                    "distancefromsource='" + distancefromsourcetextBox.Text + "'," +
                    "chooseroute='" + crcomboBox.Text + "'," +
                    "noofpassengers='" + noptextBox.Text + "'," +
                    "issueddate='" + dateTimePicker1.Text + "'," +
                    "departuredate='" + dateTimePicker2.Text + "'," +
                    "departuretime='" + dateTimePicker4.Text + "'," +
                    "arrivaltime='" + dateTimePicker3.Text + "'," +
                    "totalfarecost='" + totalfarecosttxtbox.Text + "'," +
                    "name='" + passengernametxtbox.Text + "'," +
                    "age='" + passengeragetxtbox.Text + "'," +
                    "gender='" + passengergendercomboBox.Text + "'," +
                    "address='" + passengeraddresstxtbox.Text + "'," +
                    "phoneno='" + passengerphonenumber.Text + "' where ticketno='" + ticketnotxtbox.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated Sucessfully");
                displayticket();
                refreshticket();
            }
           
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

       
        private void mainadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LOG log = new LOG();
            log.Show();
        }

        //private void populatebusdetails()
        //{
        //    con.Open();
        //    string query = "select * from busdetails";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        //    var ds = new DataSet();
        //    sda.Fill(ds);
        //    busdetailsdgv.DataSource = ds.Tables[0];
        //    con.Close()
        //}

        private void mainadmin_Load(object sender, EventArgs e)
        {
            
            if (role != "Administrator")
            {
                tabControl1.TabPages.Remove(tabPage5);
                
            }
            dateTimePicker1.MinDate= DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(0);
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now.AddDays(10);
            dateTimePicker4.MinDate = DateTime.Now;
            dateTimePicker4.MaxDate = DateTime.Now.AddDays(10);
            dateTimePicker3.MinDate = DateTime.Now;
            dateTimePicker3.MaxDate = DateTime.Now.AddDays(10); 
            arrivaltimetxtbox.MinDate = DateTime.Now;
            arrivaltimetxtbox.MaxDate = DateTime.Now.AddDays(10);
            departuretimetxtbox.MinDate = DateTime.Now;
            departuretimetxtbox.MaxDate = DateTime.Now.AddDays(10);
        }


        private void refreshemployees()
        {
            employeeidtxtboxs.Text = "";
            employeenametxtboxs.Text = "";
            rolecomboBoxs.Text = "";
            employeeaddresstxtboxs.Text = "";
            employeephonenotxtboxs.Text = "";
            employeefatherstxtboxs.Text = "";
            employeemothersnametxtboxs.Text = "";
            cnos.Text = "";
            mailtextBoxs.Text = "";           
            passtxtboxs.Text = "";
        }
        

        private void addemployeedgvs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (addemployeedgvs.Rows[e.RowIndex].Cells[1].Value == null || addemployeedgvs.CurrentRow.Index == -1)
                {
                    refreshemployees();
                }
                else
                {

                    employeeidtxtboxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[1].Value.ToString();
                    employeenametxtboxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[2].Value.ToString();
                    rolecomboBoxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[3].Value.ToString();
                    employeeaddresstxtboxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[4].Value.ToString();
                    employeephonenotxtboxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[5].Value.ToString();
                    employeefatherstxtboxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[6].Value.ToString();
                    employeemothersnametxtboxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[7].Value.ToString();
                    cnos.Text = addemployeedgvs.Rows[e.RowIndex].Cells[8].Value.ToString();
                    mailtextBoxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[9].Value.ToString();
                    passtxtboxs.Text = addemployeedgvs.Rows[e.RowIndex].Cells[10].Value.ToString();
                    
                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Enter proper record");
            }
        }

        private void button8s_Click(object sender, EventArgs e)
        {
            if (employeeidtxtboxs.Text == "" || employeenametxtboxs.Text == "" || rolecomboBoxs.Text == "" ||
                    employeeaddresstxtboxs.Text == "" || employeephonenotxtboxs.Text == "" || employeefatherstxtboxs.Text == "" ||
                    employeemothersnametxtboxs.Text == "" || cnos.Text == "" || mailtextBoxs.Text == "" || passtxtboxs.Text == "")
            {
                MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update EmployeeTB set employeeid='" + employeeidtxtboxs.Text + "'," +
                    "employeename='" + employeenametxtboxs.Text + "'," +
                    "role='" + rolecomboBoxs.Text + "', " +
                    "employeeaddress='" + employeeaddresstxtboxs.Text + "'," +
                    "employeephoneno='" + employeephonenotxtboxs.Text + "'," +
                    "fathersname='" + employeefatherstxtboxs.Text + "'," +
                    "mothersname='" + employeemothersnametxtboxs.Text + "'," +
                    "citizenshipno='" + cnos.Text + "'," +
                    "email='" + mailtextBoxs.Text + "'," +
                    "pass='" + passtxtboxs.Text + "' where employeeid='" + employeeidtxtboxs.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated Sucessfully");
                displayemployees();
            }
           
            //if (employeeidtxtboxs.Text != "" && employeenametxtboxs.Text != "" && rolecomboBoxs.Text != "" && employeeaddresstxtboxs.Text != ""
            //           && employeephonenotxtboxs.Text != "" && employeefatherstxtboxs.Text != "" && employeemothersnametxtboxs.Text != "" && cnos.Text != ""
            //           && mailtextBoxs.Text != "" && passtxtboxs.Text != "")
            //{
            //    con.Open();

            //    cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "update EmployeeTB set " +
            //        "employeeid='" + employeeidtxtboxs.Text + "'," +
            //        "employeename='" + employeenametxtboxs.Text + "'," +
            //        "role='" + rolecomboBoxs.Text + "'," +
            //        "employeeaddress='" + employeeaddresstxtboxs.Text + "'," +
            //        "employeephoneno='" + employeephonenotxtboxs.Text + "'," +
            //        "fathersname='" + employeefatherstxtboxs.Text + "', " +
            //        "mothersname='" + employeemothersnametxtboxs.Text + "'," +
            //        "citizenshipno='" + cnos.Text + "'," +
            //        "email='" + mailtextBoxs.Text + "'," +
            //        "pass='" + passtxtboxs.Text + "' where employeeid='" + employeeidtxtboxs.Text + "'";
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Record updated Sucessfully");
            //    displayemployees();
            //}
            //else
            //{
            //    MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        

       
        private void button9s_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EmployeeTB where employeeid='" + employeeidtxtboxs.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted Sucessfully");
           
            displayemployees();
        }

        private void addemployeebtns_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

                SqlDataAdapter adap = new SqlDataAdapter("select * from EmployeeTB where employeeid='" + employeeidtxtboxs.Text + "'", con);
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
                else if(employeeidtxtboxs.Text == "" || employeenametxtboxs.Text == "" || rolecomboBoxs.Text == "" ||
                    employeeaddresstxtboxs.Text == "" || employeephonenotxtboxs.Text == "" || employeefatherstxtboxs.Text == "" ||
                    employeemothersnametxtboxs.Text == "" || cnos.Text == "" || mailtextBoxs.Text == "" || passtxtboxs.Text == "")
                {
                    MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into EmployeeTB values('" + employeeidtxtboxs.Text + "'," +
                        "'" + employeenametxtboxs.Text + "'," +
                        "'" + rolecomboBoxs.Text + "', " +
                        "'" + employeeaddresstxtboxs.Text + "'," +
                        "'" + employeephonenotxtboxs.Text + "', " +
                        "'" + employeefatherstxtboxs.Text + "'," +
                        " '" + employeemothersnametxtboxs.Text + "',  " +
                        "'" + cnos.Text + "'," +
                        "'" + mailtextBoxs.Text + "'," +
                        "'" + passtxtboxs.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Sucessfully");
                    displayemployees();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in Inserting data" + ex);
            }
            //try
            //{
            //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

            //    SqlDataAdapter adap = new SqlDataAdapter("select * from EmployeeTB where employeeid='" + employeeidtxtboxs.Text + "'", con);
            //    if (con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }
            //    con.Open();

            //    DataTable dt = new DataTable();
            //    adap.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        MessageBox.Show("Data Already Exists");

            //    }
            //    else
            //    {
            //        if (employeeidtxtboxs.Text != "" && employeenametxtboxs.Text != "" && rolecomboBoxs.Text != "" 
            //            && employeeaddresstxtboxs.Text != "" && employeephonenotxtboxs.Text != "" && employeefatherstxtboxs.Text != "" 
            //            && employeemothersnametxtboxs.Text != "" && cnos.Text != ""
            //            && mailtextBoxs.Text != "" && passtxtboxs.Text !="")
            //        {

            //            SqlCommand cmd = con.CreateCommand();
            //            cmd.CommandType = CommandType.Text;
            //            cmd.CommandText = "insert into EmployeeTBother values" +
            //                "('" + employeeidtxtboxs.Text + "'," +
            //                "'" + employeenametxtboxs.Text + "'," +
            //                "'" + rolecomboBoxs.Text + "', " +
            //                "'" + employeeaddresstxtboxs.Text + "'," +
            //                "'" + employeephonenotxtboxs.Text + "'," +
            //                "'" + employeefatherstxtboxs.Text + "', " +
            //                "'" + employeemothersnametxtboxs.Text + "', " +
            //                "'" + cnos.Text + "',  " +
            //                "'" + mailtextBoxs.Text + "'," +
            //                "'" + passtxtboxs.Text + "')";
            //            cmd.ExecuteNonQuery();
            //            con.Close();
            //            MessageBox.Show("Record Inserted Sucessfully.");
            //            displayemployees();

            //        }
            //        else
            //        {
            //            MessageBox.Show("Enter the Empty Fields First.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error in Inserting data" + ex);
            //}

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

                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Enter proper record");
            }
        }

        private void busnocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // tic();

        }

        private void sourcestationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sa();
            address();
            ds();
            ss();
        }

        private void destinationstationcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sa(); 
            address();
            ds();
            ss();
        }

        private void crcomboBox_SelectedIndexChanged(object sender, EventArgs e)
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
            //cr();
            //comb1();
        }

        private void passengeraddresstxtbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sa();
            address();
            ss();
            ds();
        }

        private void chooseroutecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comb1();

        }

        private void drivercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            combb();
        }

        private void conductorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            combbb();
        }

        private void stationaddresstxtbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sa();
            address();
            ss();
            ds();          
        }

        private void routeidtxtbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comb();         
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

        private void employeeidtxtboxs_TextChanged(object sender, EventArgs e)
        {
            if (employeeidtxtboxs.Text == "" || string.IsNullOrEmpty(employeeidtxtboxs.Text) || string.IsNullOrWhiteSpace(employeeidtxtboxs.Text))
            {

                empids.Icon = Properties.Resources.close;
                empids.SetError(this.employeeidtxtboxs, "Enter Employee ID.");
            }
            else
            {

                empids.Icon = Properties.Resources.ok;
                empids.SetError(this.employeeidtxtboxs, "Ok.");
            }
        }

        private void employeenametxtboxs_TextChanged(object sender, EventArgs e)
        {
            if (employeenametxtboxs.Text == "" || string.IsNullOrEmpty(employeenametxtboxs.Text) || string.IsNullOrWhiteSpace(employeenametxtboxs.Text))
            {
                enames.Icon = Properties.Resources.close;
                enames.SetError(this.employeenametxtboxs, "Enter Employee Name.");
            }
            else
            {
                enames.Icon = Properties.Resources.ok;
                enames.SetError(this.employeenametxtboxs, "Ok.");
            }
        }

        private void employeenametxtboxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                enames.SetError(this.employeenametxtboxs, "Enter Characters Only.");
            }
            else
            {
                enames.SetError(this.employeenametxtboxs, "Ok");
            }
        }

        private void rolecomboBoxs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (rolecomboBoxs.Text == "" || string.IsNullOrEmpty(rolecomboBoxs.Text) || string.IsNullOrWhiteSpace(rolecomboBoxs.Text))
            {
                eroles.Icon = Properties.Resources.close;
                eroles.SetError(this.rolecomboBoxs, "Select Employee Role.");
            }
            else
            {
                eroles.Icon = Properties.Resources.ok;
                eroles.SetError(this.rolecomboBoxs, "Ok.");
            }
        }

        private void employeeaddresstxtboxs_TextChanged(object sender, EventArgs e)
        {
            sa();
            address();
            ss();
            ds();
            if (employeeaddresstxtboxs.Text == "" || string.IsNullOrEmpty(employeeaddresstxtboxs.Text) || string.IsNullOrWhiteSpace(employeeaddresstxtboxs.Text))
            {
                eadds.Icon = Properties.Resources.close;
                eadds.SetError(this.employeeaddresstxtboxs, "Enter Employee Address.");
            }
            else
            {
                eadds.Icon = Properties.Resources.ok;
                eadds.SetError(this.employeeaddresstxtboxs, "Ok.");
            }
        }

        private void employeephonenotxtboxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                ephs.SetError(this.employeephonenotxtboxs, "Enter Numbers Only.");
            }
        }

        private void employeephonenotxtboxs_KeyUp(object sender, KeyEventArgs e)
        {
            string inputText = employeephonenotxtboxs.Text;
            if (employeephonenotxtboxs.TextLength == 6 || employeephonenotxtboxs.Text.Length == 10)
            {
                ephs.SetError(this.employeephonenotxtboxs, "Valid Local Phone No.");
                ephs.Icon = Properties.Resources.ok;
            }
            else if (Regex.IsMatch(inputText, @"^(([0-9]{3})(([0-9]{10})))$"))
            {

                ephs.SetError(this.employeephonenotxtboxs, "Mobile No is Valid.");
                ephs.Icon = Properties.Resources.ok;
            }
            else if (Regex.IsMatch(inputText, @"^(([0-9]{3})(([0-9]{6})))$"))
            {

                ephs.SetError(this.employeephonenotxtboxs, "Landline No is Valid.");
                ephs.Icon = Properties.Resources.ok;
            }
            else
            {
                ephs.SetError(this.employeephonenotxtboxs, "Enter Mobile No or Land Line Phone No.");
                ephs.Icon = Properties.Resources.close;

            }
        }

        private void employeefatherstxtboxs_TextChanged(object sender, EventArgs e)
        {
            if (employeefatherstxtboxs.Text == "" || string.IsNullOrEmpty(employeefatherstxtboxs.Text) || string.IsNullOrWhiteSpace(employeefatherstxtboxs.Text))
            {
                efns.Icon = Properties.Resources.close;
                efns.SetError(this.employeefatherstxtboxs, "Enter Employee Father's Name.");
            }
            else
            {
                efns.Icon = Properties.Resources.ok;
                efns.SetError(this.employeefatherstxtboxs, "Ok.");
            }
        }

        private void employeefatherstxtboxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                efns.SetError(this.employeefatherstxtboxs, "Enter Characters Only.");
            }
            else
            {
                efns.SetError(this.employeefatherstxtboxs, "Ok");
            }
        }

        private void employeemothersnametxtboxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                emns.SetError(this.employeemothersnametxtboxs, "Enter Characters Only.");
            }
            else
            {
                emns.SetError(this.employeemothersnametxtboxs, "Ok");
            }
        }

        private void employeemothersnametxtboxs_TextChanged(object sender, EventArgs e)
        {
            if (employeemothersnametxtboxs.Text == "" || string.IsNullOrEmpty(employeemothersnametxtboxs.Text) || string.IsNullOrWhiteSpace(employeemothersnametxtboxs.Text))
            {
                emns.Icon = Properties.Resources.close;
                emns.SetError(this.employeemothersnametxtboxs, "Enter Employee Mother's Name.");
            }
            else
            {
                emns.Icon = Properties.Resources.ok;
                emns.SetError(this.employeemothersnametxtboxs, "Ok");
            }
        }

        private void cnos_KeyUp(object sender, KeyEventArgs e)
        {
            string inputText = cnos.Text;

            if (Regex.IsMatch(inputText, @"^([0-9]{2})\/([0-9]{2})\/([0-9]{2})\/([0-9]{5})$"))
            {

                ecnos.SetError(this.cnos, "Citizenship No is Valid.");
                ecnos.Icon = Properties.Resources.ok;
            }
            else if (Regex.IsMatch(inputText, @"^([0-9]{2})\-([0-9]{2})\-([0-9]{2})\-([0-9]{5})$"))
            {

                ecnos.SetError(this.cnos, "Citizenship No is Valid.");
                ecnos.Icon = Properties.Resources.ok;
            }
            else
            {
                ecnos.SetError(this.cnos, "Citizenship No is InValid.");
                ecnos.Icon = Properties.Resources.close;
            }
        }

        private void mailtextBoxs_KeyUp(object sender, KeyEventArgs e)
        {
            string inputText = mailtextBoxs.Text;

            if (Regex.IsMatch(inputText, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
            {

                emails.SetError(this.mailtextBoxs, "E-mail Address is Valid");
                emails.Icon = Properties.Resources.ok;
            }
            else
            {
                emails.SetError(this.mailtextBoxs, "E-mail Address is InValid");
                emails.Icon = Properties.Resources.close;
            }
        }

        private void passtxtboxs_KeyUp(object sender, KeyEventArgs e)
        {
            if (passtxtboxs.TextLength >= 6)
            {
                epasss.Icon = Properties.Resources.ok;
                epasss.SetError(this.passtxtboxs, "Ok");
            }
            else
            {
                epasss.Icon = Properties.Resources.close;
                epasss.SetError(this.passtxtboxs, "Password must be atleast 6 Characters long");
            }
        }

        private void employeeidtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (employeeidtxtbox.Text == "" || string.IsNullOrEmpty(employeeidtxtbox.Text) || string.IsNullOrWhiteSpace(employeeidtxtbox.Text))
            {
                empid.Icon = Properties.Resources.close;
                empid.SetError(this.employeeidtxtbox, "Enter Employee ID.");
            }
            else
            {
                empid.Icon = Properties.Resources.ok;
                empid.SetError(this.employeeidtxtbox, "Ok.");
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

        private void stationcodetxtbox_TextChanged(object sender, EventArgs e)
        {
            if (stationcodetxtbox.Text == "" || string.IsNullOrEmpty(stationcodetxtbox.Text) || string.IsNullOrWhiteSpace(stationcodetxtbox.Text))
            {
                esc.Icon = Properties.Resources.close;
                esc.SetError(this.stationcodetxtbox, "Enter Station Code.");
            }
            else
            {
                esc.Icon = Properties.Resources.ok;
                esc.SetError(this.stationcodetxtbox, "Ok.");
            }
        }

        private void stationnametxtbox_TextChanged(object sender, EventArgs e)
        {
            if (employeenametxtbox.Text == "" || string.IsNullOrEmpty(employeenametxtbox.Text) || string.IsNullOrWhiteSpace(employeenametxtbox.Text))
            {
                esn.Icon = Properties.Resources.close;
                esn.SetError(this.employeenametxtbox, "Enter Station Name.");
            }
            else
            {
                esn.Icon = Properties.Resources.ok;
                esn.SetError(this.employeenametxtbox, "Ok.");
            }
        }

        private void stationnametxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                esn.SetError(this.stationnametxtbox, "Enter Characters Only.");
            }
            else
            {
                esn.SetError(this.stationnametxtbox, "Ok");
            }
        }

       

       

        private void enterrouteidtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (enterrouteidtxtbox.Text == "" || string.IsNullOrEmpty(enterrouteidtxtbox.Text) || string.IsNullOrWhiteSpace(enterrouteidtxtbox.Text))
            {
                brcid.Icon = Properties.Resources.close;
                brcid.SetError(this.enterrouteidtxtbox, "Enter Route ID.");
            }
            else
            {
                brcid.Icon = Properties.Resources.ok;
                brcid.SetError(this.enterrouteidtxtbox, "Ok.");
            }
        }

        private void choosestationcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                brcn.SetError(this.choosestationcomboBox, "Enter Characters Only.");
            }
            else
            {
                brcn.SetError(this.choosestationcomboBox, "Ok");
            }
        }

        private void choosestationcomboBox_TextChanged(object sender, EventArgs e)
        {
            if (choosestationcomboBox.Text == "" || string.IsNullOrEmpty(choosestationcomboBox.Text) || string.IsNullOrWhiteSpace(choosestationcomboBox.Text))
            {
                brcn.Icon = Properties.Resources.close;
                brcn.SetError(this.choosestationcomboBox, "Enter Station Name.");
            }
            else
            {
                brcn.Icon = Properties.Resources.ok;
                brcn.SetError(this.choosestationcomboBox, "Ok.");
            }
        }

        private void distancefromsourcetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                brcdfs.SetError(this.distancefromsourcetxtbox, "Enter Numbers Only.");
            }
        }

        private void arrivaltimetxtbox_ValueChanged(object sender, EventArgs e)
        {
            if (arrivaltimetxtbox.Text == "" || string.IsNullOrEmpty(arrivaltimetxtbox.Text) || string.IsNullOrWhiteSpace(arrivaltimetxtbox.Text))
            {
                brcat.Icon = Properties.Resources.close;
                brcat.SetError(this.arrivaltimetxtbox, "Select Bus Arrival Time.");
            }
            else
            {
                brcat.Icon = Properties.Resources.ok;
                brcat.SetError(this.arrivaltimetxtbox, "Ok.");
            }
        }

        private void departuretimetxtbox_ValueChanged(object sender, EventArgs e)
        {
            if (departuretimetxtbox.Text == "" || string.IsNullOrEmpty(departuretimetxtbox.Text) || string.IsNullOrWhiteSpace(departuretimetxtbox.Text))
            {
                brcdt.Icon = Properties.Resources.close;
                brcdt.SetError(this.departuretimetxtbox, "Select Bus Departure Time.");
            }
            else
            {
                brcdt.Icon = Properties.Resources.ok;
                brcdt.SetError(this.departuretimetxtbox, "Ok.");
            }
        }

        private void busnotxtbox_TextChanged(object sender, EventArgs e)
        {
            if (busnotxtbox.Text == "" || string.IsNullOrEmpty(busnotxtbox.Text) || string.IsNullOrWhiteSpace(busnotxtbox.Text))
            {
                bdbno.Icon = Properties.Resources.close;
                bdbno.SetError(this.busnotxtbox, "Enter Bus No.");
            }
            else
            {
                bdbno.Icon = Properties.Resources.ok;
                bdbno.SetError(this.busnotxtbox, "Ok.");
            }
        }

        private void busnametxtbox_TextChanged(object sender, EventArgs e)
        {
            if (busnametxtbox.Text == "" || string.IsNullOrEmpty(busnametxtbox.Text) || string.IsNullOrWhiteSpace(busnametxtbox.Text))
            {
                bdbn.Icon = Properties.Resources.close;
                bdbn.SetError(this.busnametxtbox, "Enter Bus No.");
            }
            else
            {
                bdbn.Icon = Properties.Resources.ok;
                bdbn.SetError(this.busnametxtbox, "Ok.");
            }
        }

       

        private void bustypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bustypecomboBox.Text == "" || string.IsNullOrEmpty(bustypecomboBox.Text) || string.IsNullOrWhiteSpace(bustypecomboBox.Text))
            {
                bdbt.Icon = Properties.Resources.close;
                bdbt.SetError(this.bustypecomboBox, "Select a Bus Type.");
            }
            else
            {
                bdbt.Icon = Properties.Resources.ok;
                bdbt.SetError(this.bustypecomboBox, "Ok.");
            }
        }

        private void noofseatstxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                brcdfs.SetError(this.distancefromsourcetxtbox, "Enter Numbers Only.");
            }
        }

        private void noofseatstxtbox_TextChanged(object sender, EventArgs e)
        {
            if (noofseatstxtbox.Text == "" || string.IsNullOrEmpty(noofseatstxtbox.Text) || string.IsNullOrWhiteSpace(noofseatstxtbox.Text))
            {
                bdbns.Icon = Properties.Resources.close;
                bdbns.SetError(this.noofseatstxtbox, "Enter Bus No.");
            }
            else
            {
                bdbns.Icon = Properties.Resources.ok;
                bdbns.SetError(this.noofseatstxtbox, "Ok.");
            }
        }

        private void busmodeltxtbox_TextChanged(object sender, EventArgs e)
        {

            if (busmodeltxtbox.Text == "" || string.IsNullOrEmpty(busmodeltxtbox.Text) || string.IsNullOrWhiteSpace(busmodeltxtbox.Text))
            {
                bdbm.Icon = Properties.Resources.close;
                bdbm.SetError(this.busmodeltxtbox, "Enter Bus Model.");
            }
            else
            {
                bdbm.Icon = Properties.Resources.ok;
                bdbm.SetError(this.busmodeltxtbox, "Ok.");
            }
        }

        private void bscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bscomboBox.Text == "" || string.IsNullOrEmpty(bscomboBox.Text) || string.IsNullOrWhiteSpace(bscomboBox.Text))
            {
                bdbs.Icon = Properties.Resources.close;
                bdbs.SetError(this.bscomboBox, "Select Bus Status.");
            }
            else
            {
                bdbs.Icon = Properties.Resources.ok;
                bdbs.SetError(this.bscomboBox, "Ok.");
            }
        }

       
       

        private void chooseroutecomboBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (chooseroutecomboBox.Text == "" || string.IsNullOrEmpty(chooseroutecomboBox.Text) || string.IsNullOrWhiteSpace(chooseroutecomboBox.Text))
            {
                bdcr.Icon = Properties.Resources.close;
                bdcr.SetError(this.chooseroutecomboBox, "Select Route Name.");
            }
            else
            {

                bdcr.Icon = Properties.Resources.ok;
                bdcr.SetError(this.chooseroutecomboBox, "Ok.");
            }
        }

        private void drivercomboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (drivercomboBox.Text == "" || string.IsNullOrEmpty(drivercomboBox.Text) || string.IsNullOrWhiteSpace(drivercomboBox.Text))
            {
                bdd.Icon = Properties.Resources.close;
                bdd.SetError(this.drivercomboBox, "Select Driver Name.");
            }
            else
            {
                bdd.Icon = Properties.Resources.ok;
                bdd.SetError(this.drivercomboBox, "Ok.");
            }
        }

        private void conductorcomboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (conductorcomboBox.Text == "" || string.IsNullOrEmpty(conductorcomboBox.Text) || string.IsNullOrWhiteSpace(conductorcomboBox.Text))
            {
                bdc.Icon = Properties.Resources.close;
                bdc.SetError(this.conductorcomboBox, "Select Conductor Name.");
            }
            else
            {
                bdc.Icon = Properties.Resources.ok;
                bdc.SetError(this.conductorcomboBox, "Ok.");
            }
        }

        private void stationaddresstxtbox_KeyUp(object sender, KeyEventArgs e)
        {

            if (stationaddresstxtbox.Text == "" || string.IsNullOrEmpty(stationaddresstxtbox.Text) || string.IsNullOrWhiteSpace(stationaddresstxtbox.Text))
            {
                esa.Icon = Properties.Resources.close;
                esa.SetError(this.stationaddresstxtbox, "Select Station Address.");
            }
            else
            {
                esa.Icon = Properties.Resources.ok;
                esa.SetError(this.stationaddresstxtbox, "Ok.");
            }
        }

        private void routeidtxtbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (routeidtxtbox.Text == "" || string.IsNullOrEmpty(routeidtxtbox.Text) || string.IsNullOrWhiteSpace(routeidtxtbox.Text))
            {
                esid.Icon = Properties.Resources.close;
                esid.SetError(this.routeidtxtbox, "Select Route ID.");
            }
            else
            {
                esa.Icon = Properties.Resources.ok;
                esa.SetError(this.routeidtxtbox, "Ok.");
            }
        }

      

        private void busnocomboBox_Enter(object sender, EventArgs e)
        {
            tic();
        }

      





        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawString("Sudur Paschim Yatayat",new Font("Times New Roman",16,FontStyle.Bold),Brushes.Black,new Point(20,20));
        //}
    }
}
