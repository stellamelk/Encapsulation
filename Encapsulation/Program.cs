using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        public static int Main(string[] args)
        {
            Departament dep = new Departament();
            dep.SetDepartName("Electronics");
            Console.WriteLine("The Department is :" + dep.GetDepartName());
            return 0;
        }
        
    }
}
