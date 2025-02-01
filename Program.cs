//Written by Shrijan Paudel
//01/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace The_Dominion_of_Kings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dominion_of_kings dominion declares a variable named dominion of type Dominion_of_kings
            //Dominion_of_kings is likely a class or struct defined elsewhere in your code.

            Dominion_of_kings dominion = new Dominion_of_kings();

            Console.WriteLine("Enter the number of Provinces");    // User Input
            int provinces_num = Convert.ToInt32(Console.ReadLine()); // direct convert to integer

            Console.WriteLine("Enter the number of duchies");
            int duchies_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of estates");
            int estates_num = Convert.ToInt32(Console.ReadLine());

            //assigning a value to new domainion variable

            dominion.Provinces = provinces_num;
            dominion.Duchies = duchies_num;
            dominion.Estates = estates_num;


           // CallingConvention a method
            int total = dominion.Calculate();



            if (total >= 0)
            {
                Console.WriteLine($"Total point of the kingdom is {total}");
            }
            else
            {
                Console.WriteLine("INVALID INPUTS");
            }








        }
    }
}
