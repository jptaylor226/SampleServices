using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SampleWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SampleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SampleService.svc or SampleService.svc.cs at the Solution Explorer and start debugging.
    public class SampleService : ISampleService
    {
        private readonly static List<string> _values = new List<string>();
        public void DeleteValue(int index)
        {
            if (_values.Count > index)
            {
                _values.RemoveAt(index);
            }
        }

        public string GetValue(int index)
        {
            return (_values.Count > index) ? _values[index] : null;
        }

        public IEnumerable<string> GetValues()
        {
            return _values;
        }

        public void PostValue(string value)
        {
            _values.Add(value);
        }
        public void PutValue(int index, string value)
        {
            if (_values.Count > index)
            {
                _values[index] = value;
            }
        }
    }
}