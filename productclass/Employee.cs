using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    public class Employee
    {
        private int id ;
        private string name;
        private double BS,NPS,HRA,DA,PF,n1,n2,n3,total;

        public void GetData(int id, string name, double BS,int HRA,int DA,int PF)
        {
            this.id = id;
            this.name = name;
            this.BS = BS;
        }
        public void Calculate()
        {
            n1 = BS * HRA / 100;
            n2 = BS * DA / 100;
            n3 = BS * PF / 100;
            total = n1 + n2 + n3;
            NPS = total - n3;
        }
        public string Print()
        {
            return $"Total salary {total} Net paid salary {NPS}"; 
        }
    }
}
