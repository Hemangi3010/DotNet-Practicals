using System;

namespace Practical_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Fareinhit -> Celcius\n2.Celcius->Fareinhit\nEnter choice:");
            string ch = Console.ReadLine();
            int option = Convert.ToInt32(ch);
            switch (option)
            {
                case 1:
                    convert_F_to_C();
                    break;
                case 2:
                    convert_C_to_F();
                    break;
                default:
                    Console.WriteLine("Please Enter valid choice ....");
                    break;
            }
        }
        static void convert_F_to_C()
        {

            Console.WriteLine("Enter F to be converted : ");
            string str = Console.ReadLine();
            int f = Convert.ToInt32(str);
            double c = (5 * f) / 9 - 32;
            Console.WriteLine(f + " F =  " + c + " C ");

        }
        static void convert_C_to_F()
        {

            Console.WriteLine("Enter C to be converted : ");
            string str = Console.ReadLine();
            int c = Convert.ToInt32(str);
            double f = (9 * c) / 5 + 32;
            Console.WriteLine(c + " C =  " + f + " F ");
        }

    }
}
