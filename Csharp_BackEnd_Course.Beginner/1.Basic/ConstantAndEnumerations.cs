using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class ConstantAndEnumerations
    {
        public static void Run(string[] args)
        {
            // Declaring constants
            double price = 100;
            const double ValueAddedTax = 0.175;
            const double DeliveryCharge = 4.99;

            price += (price * ValueAddedTax) + DeliveryCharge;

            // Using enumerated values
            Console.WriteLine((int)Month.Feb);
            Console.WriteLine(Month.Feb);

            // Printing all enums
            foreach (var name in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine(name);
            }
        }

        // Defining an enumerations
        enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }
    }


}
