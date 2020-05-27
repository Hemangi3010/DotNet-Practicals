using System;

namespace Program2_code
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3.141592653589793238f;
            float b = 3.147829856328966589f;
            bool compare;
            compare = (a>b);
            if (compare) { Console.WriteLine(" value of a is greater:{0}", a); }
            else { Console.WriteLine(" value of b is greater:{0}", b); }
            
        }
    }
}
