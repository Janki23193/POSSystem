using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem
{
    public class D
    {
        private double unitPrice = 0.75;
        private int Quantity = 0;


        public double CalculateIndividualPrice(int qty)
        {
            var total = qty * unitPrice;
            Console.WriteLine(total);
            return total;
        }
    }
}
