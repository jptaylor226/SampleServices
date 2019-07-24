using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SampleWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISampleService" in both code and config file together.
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        IEnumerable<string> GetValues();
        [OperationContract]
        string GetValue(int index);
        [OperationContract]
        void PostValue(string value);
        [OperationContract]
        void PutValue(int index, string value);
        [OperationContract]
        void DeleteValue(int index);
    }
}
