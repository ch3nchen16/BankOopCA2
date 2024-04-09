using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //added these using statements
using System.Data;
using System.Configuration;


namespace DAL
{
    public class DAO //my DAO object can now be seen in the namespace of BankOopCA2 after
                     //adding public
    {
        SqlConnection con;

        public DAO()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings
                ["DBCon"].ConnectionString);
        }

        public SqlConnection OpenCon()
        {
            if (con.State == ConnectionState.Broken || con.State ==
                ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void CloseCon()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
    }
}
