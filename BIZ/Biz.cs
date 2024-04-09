using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Biz : DAO
    {
        string fn;
        SqlDataReader dr;
        public string GetUser(string un, string pw)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspLogin";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@un", un);
            cmd.Parameters.AddWithValue("@pw", pw);

            int count = Convert.ToInt16(cmd.ExecuteScalar());

            if (count > 0)
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fn = dr["Fullname"].ToString();
                }
            }
            else
            {
                fn = "Error";
            }
            CloseCon();
            return fn;
        }
        public void RegUser(string fn, string un, string pw, string email, string ad)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspRegister";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@un", un);
            cmd.Parameters.AddWithValue("@pw", pw);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@ad", ad);

            cmd.ExecuteNonQuery();
            CloseCon();
        }
    }
}

