using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    public class product
    {
        private int id, price;
        private string name;
        private double discount, FP, FP1;
        
        public void Dataadd (int id, int price,double discount,string name)
        {
            this.id = id;
            this.name = name;
            this.price = price; 
            this.discount = discount; 
           
        }
        public void Finalprice()
        {
            FP = (double)price / 100 * discount;
            FP1 = price - FP;
        }
        public string Display()
        {
            return $"ID={id} Name={name} Price={price} Discount={discount} finalprice ={FP1}";
        }
    }
}
