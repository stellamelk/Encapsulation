using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteOnlyProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteDepartament d = new WriteDepartament();
            d.DepartName = "Security";
        }
    }
}
