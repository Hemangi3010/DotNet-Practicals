using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;

            do
            {
                Console.WriteLine("Enter your Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter your country:");
                country = Console.ReadLine();
            } while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));
            Console.WriteLine("Hiii ..." + name + " your country name is" + " " + country);
            Console.ReadLine();
        }
    }
}