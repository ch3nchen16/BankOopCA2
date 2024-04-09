using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DAL
{
    public class AddPeople : DAO
    {
        //this is a method to add an account
        public void AddAcc(string fn, string sn, string em, string ph, string ad1, string ad2, string county, string city, string at, int sort, decimal ib, int ol)
        //need to pass in our variables ^
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddAcc"; //this is the stored procedure
            cmd.CommandType = /*System.Data.*/CommandType.StoredProcedure;
            //since we added the using statement it gets rid of that

            cmd.Parameters.AddWithValue("fn", fn);
            cmd.Parameters.AddWithValue("sn", sn);
            cmd.Parameters.AddWithValue("em", em);
            cmd.Parameters.AddWithValue("ph", ph);
            cmd.Parameters.AddWithValue("ad1", ad1);
            cmd.Parameters.AddWithValue("ad2", ad2);
            cmd.Parameters.AddWithValue("county", county);
            cmd.Parameters.AddWithValue("city", city);
            cmd.Parameters.AddWithValue("at", at);
            cmd.Parameters.AddWithValue("sort", sort);
            cmd.Parameters.AddWithValue("ib", ib);
            cmd.Parameters.AddWithValue("ol", ol);

            //no need to OpenCon(); because we already have it up there
            cmd.ExecuteNonQuery();
            CloseCon();
        }

    }
}
