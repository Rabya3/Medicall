using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class DoctorDL
    {
        public static List<Doctor> Doc = new List<Doctor>();
        public bool Dregister(string username, string password, string question, string answer, string speciality, string phone, string location, string fee, string time, string day)
        {
            bool valid;
            if (!username.Any(Char.IsLetter) || !answer.Any(Char.IsLetter))
            {
                valid = false;
            }
            else
            {
                Doctor D = new Doctor();
                D.Dusername = username;
                D.Dpassword = password;
                D.Dquestion = question;
                D.Danswer = answer;
                D.Dspecialization = speciality;
                D.Dphone = phone;
                D.Dlocation = location;
                D.Day = day;
                D.Dfee = fee;
                D.Dtime = time;
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
                if (u.Dusername == username && u.Dpassword == password)
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
                if (u.Dusername == username && u.Dquestion == question && u.Danswer == answer)
                {
                    u.Dpassword = password;
                    valid = true;
                }
            }
            return valid;
        }
        public bool AddDoctor(string username, string phone, string speciality, string location, string time, string day, string fee)
        {

            Doctor u = new Doctor();
            u.Dphone = phone;
            u.Dspecialization = speciality;
            u.Dlocation = location;
            u.Dtime = time;
            u.Day = day;
            u.Dfee = fee;
           return true;

        }
        public bool Updateinfo(string username,string phone, string speciality, string location, string time, string day, string fee)
        {
            bool valid = false;
            foreach(Doctor u in DoctorDL.Doc)
            {
                if(u.Dusername==username)
                {
                    u.Dphone = phone;
                    u.Dspecialization = speciality;
                    u.Dlocation = location;
                    u.Dtime = time;
                    u.Day = day;
                    u.Dfee = fee;
                    valid = true;
                }

            }
            return valid;
            
        }
    }
}