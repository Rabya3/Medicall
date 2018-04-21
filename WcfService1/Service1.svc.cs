using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool Dregister(string username, string password, string cpassword, string question, string answer)
        {
            DoctorDL Dr = new DoctorDL();
            bool Dregister = Dr.Dregister(username, password, cpassword, question, answer);
            return Dregister;
        }

        public bool Drisvalid(string username, string password)
        {
            DoctorDL dr = new DoctorDL();
            bool Drisvalid = dr.Drisvalid(username, password);
            return Drisvalid;
        }

        public bool Pregister(string username, string password, string cpassword, string question, string answer)
        {
            PatientDL Pt = new PatientDL();
            bool P = Pt.Pregister(username, password, cpassword, question, answer);
            return P;
        }

        public bool Pisvalid(string username, string password)
        {
            PatientDL Pt = new PatientDL();
            bool Pisvalid = Pt.Pisvalid(username, password);
            return Pisvalid;

        }
        public bool Dreset(string username, string question, string answer, string password)
        {
            DoctorDL Dr = new DoctorDL();
            bool D = Dr.Dreset(username, question, answer, password);
            return D;
        }
        public bool Preset(string username, string question, string answer, string password)
        {
            PatientDL P = new PatientDL();
            bool Pt = P.Preset(username, question, answer, password);
            return Pt;
        }


    }
}
