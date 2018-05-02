using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class LabDL
    {
        public static List<Lab> LL = new List<Lab>();
        public List<Lab> SearchLab(string Area)
        {
            List<Lab> LabList = new List<Lab>();
            foreach (Lab u in LabDL.LL)
            {
                if (u.location == Area)
                {
                    LabList.Add(u);
                }
            }
            return LabList;
        }
        public bool AddLab(string username,string location,string day)
        {
            Lab u = new Lab();
            u.Location = location;
            u.name = username;
            return true;
        }

    }
}