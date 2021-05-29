using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Bus_Ticketing_System_1
{
    
    class DB
    {
       private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTS1;Integrated Security=True");

        // create a function to open the connection

        public void openConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
           
        }

        // create a function to close the connection

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

        //create a function to return the connection

        public SqlConnection GetSqlConnection()
        {
            return con;
        }

    }
}
