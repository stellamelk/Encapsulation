using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    public class Departament
    {
        private string departName;
        //Accessor
        public string GetDepartName()
        {
            return departName;
        }
        //Mutator
        public void SetDepartName(string a)
        {
            departName = a;
        }
    }

}
