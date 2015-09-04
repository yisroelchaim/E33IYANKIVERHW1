using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCIE237LegacyComponent;

namespace PoliceDispatcherClient
{
    class Incident 
    {
        string name;
        short code; 
        public string Name
        {
            get
            {
                return name; 
            }

        }
        public short Code
        {
            get
            {
                return code;
            }
        }
        public Incident(Class2 obj)
        {
            name = obj.Name;
            code = obj.Code;

        }

        public override string ToString()
        {
            return name + ":" + code; 
        }
    }
}
