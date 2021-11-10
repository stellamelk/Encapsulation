using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyProperty
{
    class ReadDepartment
    {
        private string departName;
        public ReadDepartment(string value)
        {
            departName = value;
        }
        public string Departname
        {
            get
            {
                return departName;
            }
        }
    }
}
