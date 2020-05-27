using System;

namespace program3_code
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale;
            string gender;
            Console.Write("Enter your gender:");
            gender=Console.ReadLine();
            isMale = (gender=="Male");
            Console.WriteLine("Boolean:{0}",isMale);
        }
    }
}
