using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingProperties
{
    class Program
    {
        public static void Main(string[] args)
        {
            Departament d = new Departament();
            d.DepartName = "Comunication";// applay to property DepartName
            Console.WriteLine($"The Department is : {d.DepartName}");
        }
    }
}
