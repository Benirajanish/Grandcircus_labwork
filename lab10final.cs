using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Carlist
    {
        ArrayList cars = new ArrayList();
        ArrayList model = new ArrayList();
        ArrayList year = new ArrayList();
        ArrayList price = new ArrayList();
        ArrayList miles = new ArrayList();

        public Carlist()
        {
      
            cars.Add("Cadillac");
            cars.Add("Chevrolet");
            cars.Add("GMC");
            cars.Add("BMW");
            cars.Add("Toyota");
            cars.Add("Ford");
            cars.Add("Honda");
            cars.Add("Lamborghini");

            model.Add("Escalade");
            model.Add("Prism");
            model.Add("Terrain");
            model.Add("3-Series");
            model.Add("Highlander");
            model.Add("Lincoln");
            model.Add("Accord");
            model.Add("Aventador");


            year.Add("2017");
            year.Add("2017");
            year.Add("2017");
            year.Add("2015");
            year.Add("2017");
            year.Add("2017");
            year.Add("2010");
            year.Add("2012");


            price.Add("40,000");
            price.Add("45,000");
            price.Add("50,000");
            price.Add("70,000");
            price.Add("35,000");
            price.Add("42,000");
            price.Add("38,000");
            price.Add("280,000");

            miles.Add("");
            miles.Add("");
            miles.Add("");
            miles.Add("(Used) 65,000.5 miles");
            miles.Add("");
            miles.Add("");
            miles.Add("(Used) 125,000.7 miles");
            miles.Add("(Used) 85,000.3 miles");
        }

        public string Carsmodel()
        {


            bool checkflag = true;

            while (checkflag == true)
            {

                Console.WriteLine($"{"S.No",-10} {"Cars",-15} {"Model",-15} {"Year",-15} {"Price",-15} {"Miles",-15}");
                Console.WriteLine("========================================================================================");

                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine($"{i + 1,-10} {cars[i],-15} {model[i],-15} {year[i],-15} { price[i],-15} {miles[i],-15}");

                }
                Console.WriteLine((cars.Count + 1) + "    Quit");

                Console.WriteLine("Which car would you like?  ");
                string buy = Console.ReadLine();

                bool success = int.TryParse(buy, out int list);

                if (list < cars.Count + 1)
                {

                    Console.WriteLine($" {cars[list - 1],-15} {model[list - 1],-15} {year[list - 1],-15} { price[list - 1],-15} {miles[list - 1],-15}");

                    Console.WriteLine("Would you like to buy this car? y/n ");
                    string cusbuy = Console.ReadLine();

                    if (cusbuy == "yes" || cusbuy == "y")
                    {
                        Console.WriteLine("Excellent!  Our finance department will be in touch shortly.");


                        cars.RemoveAt(list - 1);
                        model.RemoveAt(list - 1);
                        year.RemoveAt(list - 1);
                        price.RemoveAt(list - 1);
                        miles.RemoveAt(list - 1);

                    }

                }
                else
                {
                    checkflag = false;

                    Console.WriteLine("Have a great day!");

                }


            }

           

            Console.ReadLine();
            return "success";  
        }


    }

    class Program
    { 
    static void Main(string[] args)
    {
            string menu;
           
            Carlist list = new Carlist();
             menu = list.Carsmodel();

           
    }

    }
}
