using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    internal class productclass1
    {
        static void Main(string[]args)
        {
            product p1 = new product();
            p1.Dataadd(1, 40000, 10, "DELL");
            Console.WriteLine(p1.Display());
        }
            
    }
}
