using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem
{
    public class B
    {
        private double unitPrice = 4.25;
        private int Quantity = 0;

        public double getunitPrice()
        {
            return unitPrice;
        }

        public void setunitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }
        public double getQuantity()
        {
            return Quantity;
        }

        public void setQuantity(int quantity)
        {
            this.Quantity = quantity;
        }


        public double CalculateIndividualPrice(int qty)
        {        
                var total = qty * unitPrice;
                Console.WriteLine(total);
                return total;
        }
    }
}
