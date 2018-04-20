using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Lab
    {
        public string lname;
        public string llocation;

        public string Lname
        {
            get
            {
                return lname;
            }

            set
            {
                lname = value;
            }
        }

        public string Llocation
        {
            get
            {
                return llocation;
            }

            set
            {
                llocation = value;
            }
        }
    }
}