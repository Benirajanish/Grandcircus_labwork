using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class DiceProgram
    {

        public static int FindRandom(int num1)
        {
            Random randNum = new Random();
            int result = 0;
            
                result = randNum.Next(1, num1);
            
            return result;
            }
        


        static void Main(string[] args)
        {
            string input;
            int num1;
            string check_cont1 = "Y";
            int rollagain = 0;

            Console.WriteLine("Welcome to the Grand Circus Casino!  Roll the dice?(Y/N) :");
            check_cont1 = Console.ReadLine();

            while (check_cont1 == "Y")
            {


                Console.WriteLine("Enter the number of sides for a pair of dice :");
                input = Console.ReadLine();


                bool success = int.TryParse(input, out num1);

                if (success == false)
                {
                    Console.WriteLine("It's not a number,Please enter a number :");
                }
                else
                {
                    int dice1 = FindRandom(num1);
                    int dice2 = dice1;
                  
                    while (dice1 == dice2)
                    {
                         dice2 = FindRandom(num1);
                        
                    }
                    
                    rollagain++;
                    Console.WriteLine("Roll " + rollagain + ":");
                    Console.WriteLine(dice1);
                    Console.WriteLine(dice2);
                }

                
                Console.WriteLine(" Roll again? Y/N ");
                check_cont1 = Console.ReadLine();
            }

        }


    }
}   




        



    
    

