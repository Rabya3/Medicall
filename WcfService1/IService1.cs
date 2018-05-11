using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        bool Dregister(string username, string password,string id, string question, string answer, string speciality, string phone, string location, string fee, string time, string day);

        [OperationContract]
        Doctor appoint(string d);

        [OperationContract]
        bool Drisvalid(string username, string password);

        [OperationContract]
        bool Pregister(string username, string password, string cpassword, string question, string answer);
        [OperationContract]
        bool Pisvalid(string username, string password);
        [OperationContract]
        bool Dreset(string username, string question, string answer, string password);
        [OperationContract]
        bool Preset(string username, string question, string answer, string password);
        [OperationContract]
        bool Updateinfo(string username,string id, string phone, string speciality, string location, string time, string day, string fee);
        [OperationContract]
        bool bregister(string username, string contact, string group, string address);
        [OperationContract]
        bool Aregister(string username, string password);
        [OperationContract]
        bool AddDoctor(string username,string id, string phone, string speciality, string location, string time, string day, string fee);
        [OperationContract]
        bool Docverify(string name,string id, string speciality, string fee, string location);
        [OperationContract]
        List<Doctor> SearchDoc(string speciality, string location, string fee);
        [OperationContract]
        List<Lab> SearchLab(string Area);
        [OperationContract]
        bool Labverify(string name, string location);
        [OperationContract]
        bool AddLab(string username, string location);
        [OperationContract]
        List<Doctor> ShowDoc();
        [OperationContract]
        List<Doctor> SearchDocAdmin(string speciality, string location);
        [OperationContract]
        List<Lab> SearchLabAdmin(string location);
        [OperationContract]
        List<Lab> ShowLab();
        [OperationContract]
        bool DelD(string username, string speciality);
        [OperationContract]
        bool DelLab(string username, string speciality);
        [OperationContract]
        List<blood> Showallblood();










        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
