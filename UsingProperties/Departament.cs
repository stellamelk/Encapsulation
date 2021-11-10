using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingProperties
{
    public class Departament
    {
        private string departName;
        public string DepartName
        {
            get
            {
                return departName;
            }
            set
            {
                departName = value;
            }
        }
    }
}
