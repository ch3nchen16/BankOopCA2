using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string AccType { get; set; }
        public int Sort {  get; set; }
        public decimal InitialBal { get; set; }
        public int Overdraft {  get; set; }


        //then create a constructor
        public Person(string fn, string sn, string em, string ph, string ad1, string ad2, string county, string city, string at, int sort, decimal ib, int ol )

        {
            Firstname = fn;
            Surname = sn;
            Email = em;
            Phone = ph;
            Address1 = ad1;
            Address2 = ad2;
            County = county;
            City = city;
            AccType = at;
            Sort = sort;
            InitialBal = ib;
            Overdraft = ol;


        }

    }
}
