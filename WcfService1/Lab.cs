using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class Lab
    {
        public string name;
        public string location;
        [DataMember]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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
    }
}