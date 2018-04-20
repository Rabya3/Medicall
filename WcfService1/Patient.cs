using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Patient
    {
        private string pusername;
        private string ppassword;
        private string pcpassword;
        private string pquestion;
        private string panswer;
        private string plocation;

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

        public string Pcpassword
        {
            get
            {
                return pcpassword;
            }

            set
            {
                pcpassword = value;
            }
        }
    }
}