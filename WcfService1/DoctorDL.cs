using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class DoctorDL
    {
        public static List<Doctor> Doc = new List<Doctor>();
        public bool Dregister(string username, string password, string cpassword, string question, string answer)
        {
            bool valid;

            if (!(password == cpassword))
            {
                valid = false;
            }
            if (!username.Any(Char.IsLetter) || !answer.Any(Char.IsLetter))
            {
                valid = false;
            }
            else
            {
                Doctor D = new Doctor();
                D.Dusername = username;
                D.Dpassword = password;
                D.Dcpassword = cpassword;
                D.Dquestion = question;
                D.Danswer = answer;
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



    }
}