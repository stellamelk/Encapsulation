using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadDepartment d = new ReadDepartment("Computerscience");
            Console.WriteLine($"The department is: {d.Departname}");
        }
    }
}
