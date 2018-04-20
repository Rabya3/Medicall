using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Doctor
    {
        private string dusername;
        private string dpassword;
        private string dcpassword;
        private string dquestion;
        private string danswer;
        private string dlocation;
        private string dspecialization;
        private string day;
        private string dtime;

        public string Dusername
        {
            get
            {
                return dusername;
            }

            set
            {
                dusername = value;
            }
        }

        public string Dpassword
        {
            get
            {
                return dpassword;
            }

            set
            {
                dpassword = value;
            }
        }

        public string Dcpassword
        {
            get
            {
                return dcpassword;
            }

            set
            {
                dcpassword = value;
            }
        }

        public string Danswer
        {
            get
            {
                return danswer;
            }

            set
            {
                danswer = value;
            }
        }

        public string Dlocation
        {
            get
            {
                return dlocation;
            }

            set
            {
                dlocation = value;
            }
        }

        public string Dspecialization
        {
            get
            {
                return dspecialization;
            }

            set
            {
                dspecialization = value;
            }
        }

        public string Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public string Dtime
        {
            get
            {
                return dtime;
            }

            set
            {
                dtime = value;
            }
        }

        public string Dquestion
        {
            get
            {
                return dquestion;
            }

            set
            {
                dquestion = value;
            }
        }
    }
}