using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class PatientDL
    {
        public static List<Patient> Pat = new List<Patient>();
        public bool Pregister(string username, string password, string cpassword, string question, string answer)
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
                Patient P = new Patient();
                P.Pusername = username;
                P.Ppassword = password;
                P.Pcpassword = cpassword;
                P.Pquestion = question;
                P.Panswer = answer;
                PatientDL.Pat.Add(P);
                valid = true;
            }
            return valid;

        }
        public bool Pisvalid(string username, string password)
        {
            bool isfound = false;

            foreach (Patient u in PatientDL.Pat)
            {
                if (u.Pusername == username && u.Ppassword == password)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public bool Preset(string username, string question, string answer, string password)
        {
            bool valid = false;
            foreach (Patient u in PatientDL.Pat)
            {
                if (u.Pusername == username && u.Pquestion == question && u.Panswer == answer)
                {
                    u.Ppassword = password;
                    valid = true;
                }
            }
            return valid;

        }

    }
}