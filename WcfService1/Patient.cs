using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Patient
    {
        public string pusername;
        public string ppassword;
        public string pquestion;
        public string panswer;
        public string plocation;

        public string Pusername
        {
            get
            {
                return pusername;
            }

            set
            {
                pusername = value;
            }
        }

        public string Ppassword
        {
            get
            {
                return ppassword;
            }

            set
            {
                ppassword = value;
            }
        }

        public string Pquestion
        {
            get
            {
                return pquestion;
            }

            set
            {
                pquestion = value;
            }
        }

        public string Panswer
        {
            get
            {
                return panswer;
            }

            set
            {
                panswer = value;
            }
        }

        public string Plocation
        {
            get
            {
                return plocation;
            }

            set
            {
                plocation = value;
            }
        }
    }
}