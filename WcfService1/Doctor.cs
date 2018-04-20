using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Doctor
    {
        public string dusername;
        public string dpassword;
        public string dquestion;
        public string danswer;
        public string dlocation;
        public string dspecialization;
        public string day;
        public string time;

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

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
    }
}