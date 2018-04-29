using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Doctor
    {
        private string username;
        private string dpassword;
        private string dcpassword;
        private string dquestion;
        private string danswer;
        private string location;
        private string specialization;
        private string day;
        private string time;
        private string phone;
        private string fee;

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
        [DataMember]
        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
        [DataMember]
        public string Specialization
        {
            get
            {
                return specialization;
            }

            set
            {
                specialization = value;
            }
        }
        [DataMember]
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
        [DataMember]
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
        [DataMember]
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
        [DataMember]
        public string Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        [DataMember]
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
    }
}