using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using janhavi_maths;

namespace DllApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            
                char option;
                Console.WriteLine("Enter first num\n");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------\n");
                Console.WriteLine("Enter second num\n");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------\n");

                Console.WriteLine("Choose Option :\n\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n");
                option = Convert.ToChar(Console.ReadLine());

                maths m = new maths();


            
                switch (option)
                {
                    case '1':

                        int n = m.add(n1, n2);
                        Console.WriteLine("1.Addition of two numbers:" + n);
                        break;


                    case '2':

                        int n3 = m.subtract(n1, n2);
                        Console.WriteLine("2.Subtraction  of two numbers:" + n3);
                        break;

                    case '3':

                        int n4 = m.multiply(n1, n2);
                        Console.WriteLine("3.Multiplication of two numbers:" + n4);
                        break;

                    case '4':

                        int n5 = Convert.ToInt32(m.divide(n1, n2));
                        Console.WriteLine("4.Division of two numbers:" + n5);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}
