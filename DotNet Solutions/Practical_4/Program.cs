using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Conversion conversion = new Conversion();
            String infix = "a+b/(c-d)*E";
            String postfix;
            conversion.Infixtopostfix(ref infix, out postfix);
            Console.WriteLine("infix string : " + infix);
            Console.WriteLine("postfix string is : " + postfix);
            Console.Read();
        }
    }
}