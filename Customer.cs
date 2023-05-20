using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Customer
    {
        public int cid { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }

        public Customer()
        { }

        public Customer(int cid, string fname, string mname, string lname)
        {
            this.cid = cid;
            this.fname = fname;
            this.mname = mname;
            this.lname = lname;
        }

        public string DisplayData()
        {
            return cid + ", " + fname + ", " + mname + ", " + lname + ".";
        }

    }
}
