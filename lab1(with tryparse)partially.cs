using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
           
           double length=0;
            double width = 0;
            double area=0;

            string input;
            string check_cont="Y";
            bool success;
            while (check_cont == "Y")
            { // while loop start

                Console.WriteLine("Enter value of length :");
                input = Console.ReadLine();


                success = int.TryParse(input, out length);
                Console.WriteLine("test" + success);
                if (success==false)
                {
                    Console.WriteLine("It's not an integer,Please enter an integer :");
                    Console.WriteLine("Do you like to continue (Y/N) :");

                    check_cont = Console.ReadLine();
                    Console.Clear();
                }
                //*************************************************
                Console.WriteLine("Enter value of width:");
                input = Console.ReadLine();


                success = int.TryParse(input, out width);
                Console.WriteLine("test" + success);
                if (success == false)
                {
                    Console.WriteLine("It's not an integer,Please enter an integer :");
                    Console.WriteLine("Do you like to continue (Y/N) :");

                    check_cont = Console.ReadLine();
                    Console.Clear();
                }



            } // while loop end
           //******************************************************

        }
    }
}
