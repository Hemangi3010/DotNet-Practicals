using System;

namespace Practical_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Rs to Euro\n2.Rs to frank\n3.Rs to Dollar\nEnter choice:");
            string ch=Console.ReadLine();
            int option = Convert.ToInt32(ch);
            switch (option)
            {
                case 1:convert_Rs_to_Euro();
                    break;
                case 2:
                    convert_Rs_to_Franc();
                    break;
                case 3:
                    convert_Rs_to_Dollar();
                    break;
                default:
                    Console.WriteLine("Please Enter valid choice ....");
                    break;
            }
        }
        static void convert_Rs_to_Euro() {

            Console.WriteLine("Enter Rupees to be converted : ");
            string str = Console.ReadLine();
            int rs = Convert.ToInt32(str);
            double euro = rs * 0.012;
            Console.WriteLine(rs+" INR =  "+euro+" Euro ");

        }
        static void convert_Rs_to_Franc() {

            Console.WriteLine("Enter Rupees to be converted : ");
            string str = Console.ReadLine();
            int rs = Convert.ToInt32(str);
            double franc = rs * 0.013;
            Console.WriteLine(rs + " INR =  " + franc + " FRF ");

        }
        static void convert_Rs_to_Dollar() {

            Console.WriteLine("Enter Rupees to be converted : ");
            string str = Console.ReadLine();
            int rs = Convert.ToInt32(str);
            double dollar = rs * 0.013;
            Console.WriteLine(rs + " INR =  " + dollar + " USD ");

        }

    }
}
