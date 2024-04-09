using DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class Account : Person
    {
        AddPeople ap = new AddPeople();
        public Account(string fn, string sn, string em, string ph, string ad1, string ad2, string county, string city, string at, int sort, decimal ib, int ol)
            : base(fn, sn, em, ph, ad1, ad2, county, city, at, sort, ib, ol)
        // it takes these parameters
        {
            ap.AddAcc(fn, sn, em, ph, ad1, ad2, county, city, at, sort, ib, ol);

        }
    }
}