using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Admin
    {
        public string aname;
        public string apassword;

        public string Aname
        {
            get
            {
                return aname;
            }

            set
            {
                aname = value;
            }
        }

        public string Apassword
        {
            get
            {
                return apassword;
            }

            set
            {
                apassword = value;
            }
        }
    }
}