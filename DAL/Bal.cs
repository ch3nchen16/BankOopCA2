using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BIZ
{
    public class Bal : DAO
    {
        DAO dao = new DAO();
        SqlDataReader dr;
        //void FromAcc(decimal nb)
        //{
        //    SqlCommand cmd = dao.OpenCon().CreateCommand();
        //    cmd.CommandText = "uspNewBal";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@nb", nb);

        //    cmd.ExecuteNonQuery();
        //    dao.CloseCon();
        //}
        public class ResultOfGetBalance
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Balance { get; set; }
        }

        public ResultOfGetBalance GetBal(int accNum)
        {
            string firstN = "", lastN = "", bal = "";
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetBal";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AccNum", accNum);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                firstN = dr["Firstname"].ToString();
                lastN = dr["Surname"].ToString();
                bal = dr["Balance"].ToString();
            }
            dao.CloseCon();
            return new ResultOfGetBalance()
            {
                FirstName = firstN, 
                LastName = lastN,
                Balance = bal
            };
        }
        public void GetBalTo(int AccNum, string firstN, string lastN, string bal)
        {
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspGetBal";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@AccNum", AccNum);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                firstN = dr["Firstname"].ToString();
                lastN = dr["Surname"].ToString();
                bal = dr["Balance"].ToString();
            }
            dao.CloseCon();
        }

    }
}
