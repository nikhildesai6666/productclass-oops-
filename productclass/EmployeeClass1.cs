using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    internal class EmployeeClass1
    {
        static void Main(string[]args)
        {
            Employee C1 =new Employee();
            C1.GetData(2, "Nikhil", 30000, 40, 20, 12);
            Console.WriteLine(C1.Print());
        }
    }
}
