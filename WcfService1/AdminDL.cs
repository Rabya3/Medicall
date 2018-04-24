using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class AdminDL
    {
        public static List<Admin> Ad = new List<Admin>();
        public bool Aregister(string username, string password)
        {
                if (username == "Admin" && password == "123") ;
                return true;
           

        }
    }
}