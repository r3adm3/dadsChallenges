using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOrProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int usersNumber;
            string sumOrProduct;

            Console.Write("sumOrProduct\r\n-----------\r\n Enter a number:");
            usersNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" Sum or product?");
            sumOrProduct = Console.ReadLine();

            switch (sumOrProduct.ToLower()){
                case("sum"):
                    Console.WriteLine("You've Specified sum: " + (usersNumber + usersNumber));
                    break;
                case("product"):
                    Console.WriteLine("You've Specified Product: " + (usersNumber * usersNumber));
                    break;
                default:
                    Console.WriteLine("you didn't specify, so I'll sum: " + (usersNumber + usersNumber));
                    break;
             }

            //debug section
            Console.WriteLine(usersNumber.ToString() + " " + sumOrProduct);
            Console.ReadLine();

        }
    }
}
