using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class DoctorDL
    {
        public static List<Doctor> Doc = new List<Doctor>();
        public static List<Doctor> DocV = new List<Doctor>();
        public bool Dregister(string username, string password, string id, string question, string answer, string speciality, string phone, string location, string fee, string time, string day)
        {
            bool valid;
            if (!username.Any(Char.IsLetter) || !answer.Any(Char.IsLetter))
            {
                valid = false;
            }
            
            else
            {
                Doctor D = new Doctor();
                D.Username = username;
                D.Dpassword = password;
                D.Dquestion = question;
                D.Danswer = answer;
                D.Id = id;
                D.Specialization = speciality;
                D.Phone = phone;
                D.Location = location;
                D.Day = day;
                D.Fee = fee;
                D.Time = time;
                DoctorDL.Doc.Add(D);
                valid = true;
            }
            return valid;

        }
        public bool Drisvalid(string username, string password)
        {
            bool isfound = false;

            foreach (Doctor u in DoctorDL.Doc)
            {
                if (u.Username == username && u.Dpassword == password)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public bool Dreset(string username, string question, string answer, string password)
        {
            bool valid = false;
            foreach (Doctor u in DoctorDL.Doc)
            {
                if (u.Username == username && u.Dquestion == question && u.Danswer == answer)
                {
                    u.Dpassword = password;
                    valid = true;
                }
            }
            return valid;
        }
        public bool AddDoctor(string username,string id, string phone, string speciality, string location, string time, string day, string fee)
        {
            Doctor u = new Doctor();
            u.Username = username;
            u.Id = id;
            u.Phone = phone;
            u.Specialization = speciality;
            u.Location = location;
            u.Time = time;
            u.Day = day;
            u.Fee = fee;
            DoctorDL.DocV.Add(u);
           return true;
        }

        public bool Updateinfo(string username,string id,string phone, string speciality, string location, string time, string day, string fee)
        {
            bool valid = false;
            foreach(Doctor u in DoctorDL.Doc)
            {
                if(u.Username==username && u.Id==id)
                {
                    u.Phone = phone;
                    u.Specialization = speciality;
                    u.Location = location;
                    u.Time = time;
                    u.Day = day;
                    u.Fee = fee;
                    valid = true;
                }

            }
            return valid;
        }
        public bool Docverify(string name,string id, string speciality, string fee, string location)
        {
            bool valid = false;
            foreach (Doctor u in Doc)
            {
                if (u.Username == name && u.Id==id && u.Specialization == speciality && u.Fee == fee && u.Location == location)
                {
                    DocV.Add(u);
                    valid = true;
                }
            }
            return valid;
        }
        public List<Doctor> SearchDoc(string speciality, string location, string fee)
        {
            List<Doctor> DocList = new List<Doctor>();
            foreach (Doctor u in DoctorDL.DocV)
            {
                if (u.Specialization == speciality && u.Location == location && u.Fee == fee)
                {
                    DocList.Add(u);
                }
            }
            return DocList;
        }
        public List<Doctor> ShowDoc()
        {
            return DocV;
        }
        public List<Doctor> SearchDocAdmin(string speciality,string location)
            {
            List<Doctor> DocL = new List<Doctor>();
            foreach (Doctor u in DoctorDL.DocV)
            {
                if (u.Specialization == speciality && u.Location == location)
                {
                    DocL.Add(u);
                }
            }
            return DocL;
        }
        public bool DelD(string username, string speciality)
        {
            bool valid = false;
            foreach (Doctor u in DoctorDL.DocV)
            {
                if (u.Username == username && u.Specialization == speciality)
                {
                    DocV.Remove(u);
                    valid = true;
                }
            }
            return valid;
        }


    }
}