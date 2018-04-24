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
        bool Dregister(string username, string password, string question, string answer, string speciality, string phone, string location, string fee, string time, string day);

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
        bool Updateinfo(string username, string phone, string speciality, string location, string time, string day, string fee);
        [OperationContract]
        bool bregister(string username, string contact, string group, string address);
        [OperationContract]
        bool Aregister(string username, string password);
        [OperationContract]
        bool AddDoctor(string username, string phone, string speciality, string location, string time, string day, string fee);
         





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
