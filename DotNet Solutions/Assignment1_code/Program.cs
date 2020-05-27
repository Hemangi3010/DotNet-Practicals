using System;


using System;
namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern();
            Console.WriteLine();
        }
        static void pattern()
        {
            int i, j;
            Console.WriteLine("1");
            for (i = 2; i < 5; i++)
            {
                Console.Write("1");
                for (j = 1; j < i; j++)
                    Console.Write("0");
                Console.Write("1");
                Console.WriteLine();
            }
        }
    }
}
