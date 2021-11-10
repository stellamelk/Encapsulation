using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteOnlyProperty
{
    class WriteDepartament
    {
        private string departname;
        public string DepartName
        {
            set
            {
                departname = value;
                Console.WriteLine($"The Department is : {departname}");
            }
        }
        
    }
}
