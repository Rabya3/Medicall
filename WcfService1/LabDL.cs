using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class LabDL
    {
        public static List<Lab> LL = new List<Lab>();
        public static List<Lab> LV = new List<Lab>();
        public bool AddLab(string username, string location)
        {
            Lab u = new Lab();
            u.Location = location;
            u.name = username;
            LL.Add(u);
            return true;
        }

        public bool Labverify(string name, string location)
        {
            bool valid = false;
            foreach (Lab u in LL)
            {
                if (u.Name == name && u.Location == location)
                {
                    LV.Add(u);
                    valid = true;
                }
            }
            return valid;
        }
        public List<Lab> SearchLab(string Area)
        {
            List<Lab> LabList = new List<Lab>();
            foreach (Lab u in LV)
            {
                if (u.Location == Area)
                {
                    LabList.Add(u);
                }
            }
            return LabList;
        }
        public List<Lab> ShowLab()
        {
            return LV;
        }
        public List<Lab> SearchLabAdmin(string location)
        {
            List<Lab> LabL = new List<Lab>();
            foreach (Lab u in LabDL.LV)
            {
                if (u.Location == location)
                {
                    LabL.Add(u);
                }
            }
            return LabL;
        }
        public bool DelLab(string username, string location)
        {
            bool valid = false;
            foreach (Lab u in LabDL.LV)
            {
                if (u.Name == username && u.Location == location)
                {
                    LV.Remove(u);
                    valid = true;
                }
            }
            return valid;
        }
    }
}