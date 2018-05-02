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

        public bool Dregister(string username, string password, string question, string answer, string speciality, string phone, string location, string fee, string time, string day)
        {
            DoctorDL Dr = new DoctorDL();
            bool Dregister = Dr.Dregister(username, password, question, answer, speciality, phone, location, fee, time, day);
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
      
        public bool Updateinfo(string username, string phone, string speciality, string location, string time, string day, string fee)
        {
            DoctorDL Dr = new DoctorDL();
            bool D = Dr.Updateinfo(username, phone, speciality, location, time, day, fee);
            return D;

        }
        public bool bregister(string username, string contact, string group, string address)
        {
            bloodreg Dr = new bloodreg();
            bool D = Dr.bregister(username, contact, group, address);
            return D;

        }
        public bool Aregister(string username, string password)
        {
            AdminDL Dr = new AdminDL();
            bool D = Dr.Aregister(username,password);
            return D;
        }
        public bool AddDoctor(string username, string phone, string speciality, string location, string time, string day, string fee)
        {
            DoctorDL Dr = new DoctorDL();
            bool D = Dr.AddDoctor(username, phone, speciality, location, time, day, fee);
            return D;
        }
        public List<Doctor> SearchDoc(string speciality, string location, string fee)
        {
            DoctorDL Dr = new DoctorDL();
           List<Doctor> D = Dr.SearchDoc(speciality, location, fee);
            return D;
        }
        public List<Lab> SearchLab(string Area)
        {
            LabDL Lb = new LabDL();
            List<Lab> D = Lb.SearchLab(Area);
            return D;
        }
        public bool AddLab(string username, string location, string day)
        {
            LabDL Dr = new LabDL();
            bool D = Dr.AddLab(username, location, day);
            return D;
        }
    }
}
