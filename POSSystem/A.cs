using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem
{
    public class A
    {
        private double unitPrice = 1.25;

        
        public double CalculateGroupPrice(int qty)
        { 
            double total = 0;
           
            double total1 = 0;
            if(qty == 3)
            {

                total = qty * unitPrice - 0.75; // with discount = 0.25*3 = 0.75 
                //Console.WriteLine(total);    
            }
            else
            {
                total1 = qty * unitPrice;
                Console.WriteLine(total1);
            }
            var grandtotal = total + total1;
            return grandtotal;
        }
       
    }
}
