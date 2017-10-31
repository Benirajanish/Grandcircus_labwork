using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int studentNumber;
            string student_num;
            string home_food_input="";
            string more_info_input = "";

            bool stu_no_chk = false;
            bool home_food_chk = false;
            

            int dis_count = 0;

            string[] names = new string[] { "Anna", "Alex", "John", "Jack", "Bryce", "James", "Alan", "Krish", "Liza", "Tom", "Rose" };
            string[] foods = new string[] { "Pizza", "Pasta", "Chips", "Icecream", "pancake", "Friedrice", "Nuggets", "Salad", "Sandwich", "waffle", "Frenchfries" };
            string[] hometowns = new string[] { "Flint", "Troy", "Toledo", "Chicago", "Clawson", "Utica", "Columbus", "Pontiac", "Novi", "Saginaw", "Detroit" };


            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-11): ");
            while (stu_no_chk == false)
            {
                // Getting the student number
                student_num = Console.ReadLine();

                // check entered input is a integer or some string. we need pnly integer as student number

                stu_no_chk = int.TryParse(student_num, out studentNumber);
                
                // if student > 12 show the error message
                if (stu_no_chk == false || studentNumber >= 12)
                {
                    Console.WriteLine("That student does not exist. Please try again.(enter a number 1-11):");
                }
                else if (stu_no_chk == true)
                {
                   //  Console.WriteLine("Student " + studentNumber + " is " + names[studentNumber] + " ." + " What would you like to know about " + " " + names[studentNumber] + "? (enter  hometowns or favorite food) :");
                   
                    while (home_food_chk == false)
                    {
                        
                     //   if (dis_count > 0)
                     //   {
                            Console.WriteLine(" What would you like to know about " + " " + names[studentNumber] + "? (enter or hometowns or favorite food) :");
                      //  }
                      //  dis_count++;
                        home_food_input = Console.ReadLine();

                        if ( home_food_input.ToLower() == "hometowns" || home_food_input.ToLower() == "food")
                        {
                            home_food_chk = true;
                            if (home_food_input == "hometowns")
                            {
                                Console.WriteLine(names[studentNumber] + " is from " + hometowns[studentNumber] + "." + " Would you like to know more? (enter yes or no):");
                            }
                            else
                            {
                                Console.WriteLine(names[studentNumber] + " Favourite food is  " + foods[studentNumber] + "." + " Would you like to know more? (enter yes or no):");
                            }
                                 more_info_input = Console.ReadLine();
                              
                                if (more_info_input.ToLower() == "yes" || more_info_input.ToLower() == "no")
                                {
                                    if (more_info_input.ToLower() == "no")
                                    {
                                     Console.WriteLine("Thanks!");
                                    }
                                    else
                                    {
                                      home_food_chk = false;
                                    }

                                }
                                 
                          


                        }
                        else                      
                        {
                            Console.WriteLine("That data does not exist. please try again. (enter  hometowns or favorite food : )");

                        }
                    }
            
                }
            }
            
            
            

            
            
            Console.ReadLine();

         }






        
    }
    
}
