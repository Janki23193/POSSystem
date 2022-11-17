using System;

namespace POSSystem
{
    class Program
    {        
        public static void Main(string[] args)
        { 
            A a = new A(); // object of A
            B b = new B();  // object of B
            C c = new C(); // object of C
            D d = new D();  // object of D
            string products; // for products
            int done = 1; // flag for while loop
            int qty = 0; // to track the quantity for A
            int qty1 = 0; // to track the quantity for B
            int qty2 = 0; // to track the quantity for C
            int qty3 = 0; // // to track the quantity for D

            // Display menu to see for the users
            Console.WriteLine("====Product Code   Price======");
            Console.WriteLine("[A]  $1.25 each, OR 3 for $3.00");
            Console.WriteLine("[B]  $4.25");
            Console.WriteLine("[C]  $1.00 OR $5 for a six pack");
            Console.WriteLine("[D]  $0.75");

            
            while(done==1)
            {
                Console.WriteLine("Please Enter the products from A, B, C, D"); // asking for to enter particular products
                Console.WriteLine("For exist press any lower letter and then 0"); // for exit
                products = Console.ReadLine(); // reading products from console
                switch (products)
                {
                    case "A":                       
                        Console.WriteLine("Please enter the one quantity at a time"); // to enter the quatity
                        Int32.Parse(Console.ReadLine()); // reading quantity from user
                        qty++;       // increment by 1      
                        done = 1; // set int flag to 1
                        break;
                    case "B":
                             Console.WriteLine("Please enter the one quantity at a time");
                             Int32.Parse(Console.ReadLine());
                             qty1++;
                             done = 1;
                             break;
                    case "C":
                             Console.WriteLine("Please enter the one quantity at a time");
                             Int32.Parse(Console.ReadLine());
                             qty2++;
                             done = 1;
                             break;
                    case "D":
                             Console.WriteLine("Please enter the one quantity at a time");
                             Int32.Parse(Console.ReadLine());
                             qty3++;
                             done = 1;
                             break;
                    default:
                             Console.WriteLine("please enter product between A-D");
                             Console.WriteLine("Want to exist? press 0");
                             Console.ReadLine();
                             done = 0;
                             break;
                }
            }
            double t1 = a.CalculateGroupPrice(qty); // total for A
            double t2 = b.CalculateIndividualPrice(qty1); // total for B
            double t3= c.CalculateGroupPrice(qty2); // total for C
            double t4 = d.CalculateIndividualPrice(qty3); // total for D

            double GrandTotal = t1 + t2 + t3 + t4; // Grand total for all 4 products
            Console.WriteLine("Total  $" + GrandTotal);

           
        }
        
    }
}
