using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Learning.Model
{
     public   class Basket
    {
        public decimal price { get; set; } 
        public int count { get; set; } 
        public string name { get; set; }
        public  void Plus()
        {
            if (count>=10)
            {
                count = 1;
            }
            count++;
        }
        public void Minus()
        {
            if (count <=1)
            {
                count = 1;
            }
            count--;
        }
        public int totalProduct()
        {
            int totalproduct =(int) (count * price);
            if (totalproduct>2000)
            {
                return (totalproduct * 95 )/ 100;
            }
            return totalproduct;
        }
    }
}
