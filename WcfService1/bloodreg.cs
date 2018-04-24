using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class bloodreg
    {
        public static List<blood> bl = new List<blood>();
        public bool bregister(string username, string contact, string group, string address)
        {
           
            blood B = new blood();
            B.Name = username;
            B.Contact = contact;
            B.Group = group;
            B.Address = address;
            bloodreg.bl.Add(B);
            return true;
        }

    }
}