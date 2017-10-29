using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num1 = 0;
            string check_cont1 = "Y";
            string check_cont2 = "N";


            while (check_cont1 == "Y")

            {
                Console.WriteLine("Enter an integer between 1 and 100 :");
                input = Console.ReadLine();


                bool success = int.TryParse(input, out num1);

                if (success == false)
                {
                    Console.WriteLine("It's not an integer,Please enter an integer :");

                }

                if (num1 % 2 == 1)

                {
                    Console.WriteLine(num1 + " and  Odd");
                }

                else if (num1 >= 2 && num1 <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }

                else if (num1 >= 26 && num1 <= 60)

                {
                    Console.WriteLine("Even");
                }
                else if (num1 > 60)
                {

                    Console.WriteLine(num1 + " and  Even");
                }

                Console.WriteLine("Do you like to continue (Y/N) : ");
                check_cont1 = Console.ReadLine();
            }
        
                Console.WriteLine("Bye!");
              check_cont2 = Console.ReadLine();
            
        }
    }
}
