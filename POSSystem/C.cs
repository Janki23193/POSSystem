using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem
{
    public class C
    {
        private double unitPrice = 1;
        private double groupPrice = 5.00;
        private int Quantity = 0;

        public double getunitPrice()
        {
            return unitPrice;
        }

        public void setunitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }
        public double getgroupPrice()
        {
            return groupPrice;
        }

        public void setgroupPrice(double groupPrice)
        {
            this.groupPrice = groupPrice;
        }
        public double getQuantity()
        {
            return Quantity;
        }

        public void setQuantity(int quantity)
        {
            this.Quantity = quantity;
        }


        public double CalculateGroupPrice(int qty)
        {
            double total = 0;
            double total1 = 0;
            if (qty == 6)
            {
                total = qty * unitPrice - 4.8;
                Console.WriteLine(total);
            }
            else if(qty>6)
            {
                total1 = qty * unitPrice - 1;
                Console.WriteLine(total1);
            }
            var grandtotal = total + total1;
            Console.WriteLine(grandtotal);
            return grandtotal;
        }
    }
}

