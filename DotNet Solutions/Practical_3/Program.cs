using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit to be converted : ");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            decimalToBinary(x);
            Console.Read();
            Console.WriteLine("");
            decimalToHex(x);
            Console.Read();
            Console.WriteLine("");
            decimalToOctal(x);
            Console.Read();
            Console.WriteLine("");
            binaryToDecimal();
            Console.Read();
        }
        static void decimalToBinary(int x)
        {
            //int x = 20;
            int reminder, i = 0;
            int[] binary = new int[100];
            Console.WriteLine("Decimal To Binary Conversion of " + x + " is:");
            while (x > 0)
            {
                reminder = x % 2;
                binary[i] = reminder;
                x /= 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binary[j]);
            }
            

        }
        static void decimalToOctal(int x)
        {
            //int x = 40;
            Console.WriteLine("Decimal To Octal Conversion of " + x + " is:");
            int[] octalNum = new int[100];
            int i = 0;
            while (x != 0)
            {

                octalNum[i] = x % 8;
                x = x / 8;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(octalNum[j]);
            }
        }
        static void decimalToHex(int y)
        {
            //int x = 80;
            Console.WriteLine("Decimal To Hex Conversion of " + y + " is:");
            int reminder, i = 0;
            char[] hex = new char[100];
            while (y > 0)
            {
                reminder = y % 16;
                if (reminder > 9)
                {
                    hex[i] = (char)(reminder + 55);
                }
                else
                {
                    hex[i] = (char)(reminder + 48);
                }
                y /= 16;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(hex[j]);
            }


        }
        public static void binaryToDecimal()
        {

                /*Console.WriteLine("Enter Binary number to be converted  : ");
                string str = Console.ReadLine();
                int binaryNumber = Int32.Parse(str);*/

                int binaryNumber = 10101;
                int base1 = 1;
                int decimalValue = 0;
                Console.Write("Binary To Decimal Conversion of" + binaryNumber + "is:");
                while (binaryNumber > 0)
                {
                    int reminder = binaryNumber % 10;
                    binaryNumber = binaryNumber / 10;
                    decimalValue += reminder * base1;
                    base1 = base1 * 2;
                }
                Console.WriteLine(decimalValue);
                Console.Read();
        }
        

    }
}