using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DisplayAll : DAO
    {
        public DataTable AllAcc()
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowCus"; //this is the stored procedure
            cmd.CommandType = /*System.Data.*/CommandType.StoredProcedure;
            //since we added the using statement it gets rid of that

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            da.SelectCommand = cmd;

            da.Fill(dt);
            return dt;

        }
    }
}

