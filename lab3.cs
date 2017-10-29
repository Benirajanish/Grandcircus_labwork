using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int digit;
            string check_cont1 = "Y";
            string check_cont2 = "N";
            double square;
            double cube;

            while (check_cont1 == "Y")
            {

                Console.WriteLine("Enter an integer :");
                input = Console.ReadLine();


                bool success = int.TryParse(input, out digit);

                if (success == false)
                {
                    Console.WriteLine("It's not an integer,Please enter an integer :");
                    Console.WriteLine("Do you like to continue (Y/N) :");

                    check_cont1 = Console.ReadLine();
                }


                for (int i = 1; i <= digit; i++)
                {

                    square = Math.Pow(i, 2);
                    cube = Math.Pow(i, 3);
                    Console.WriteLine(i + "       " + square + "        " + cube);
                }
                Console.ReadLine();
            }

                Console.WriteLine("Bye!");
                check_cont2 = Console.ReadLine();
            
        }
    }
}
