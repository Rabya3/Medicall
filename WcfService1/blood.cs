using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class blood
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

    }
}