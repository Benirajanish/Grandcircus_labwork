using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//comment to git
namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
           
           double length=0;
            double width = 0;
            double area=0;
            double perimeter = 0;
            string input;
            string check_cont="Y";
            bool success;

            while (check_cont == "Y")
            { 
                Console.Clear();
                Console.WriteLine("Enter value of length :");
                input = Console.ReadLine();


                success = double.TryParse(input, out length);

                if (success == false)
                {
                    Console.WriteLine("It's not an integer,Please enter an integer :");
                    Console.WriteLine("Do you like to continue (Y/N) :");

                    check_cont = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Enter value of width:");
                    input = Console.ReadLine();


                    success = double.TryParse(input, out width);

                    if (success == false)
                    {
                        Console.WriteLine("It's not an integer,Please enter an integer :");
                        

                    }
                    else
                    {
                        area = (length * width);
                        perimeter = 2 * (length + width);

                        Console.WriteLine("Area of the room : " + area);
                        Console.WriteLine("Perimeter of the room : " + perimeter);
                    }
                    Console.WriteLine("Do you like to continue (Y/N) : ");
                    check_cont = Console.ReadLine();
                } 


            } 
           

        }
    }
}
