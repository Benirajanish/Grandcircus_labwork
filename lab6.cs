using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author : Beniraj Rajanish
 * Date : 10/29/2017
 * Title: Convert_to_Piglatin
 * Description : This program translate the text to Pig Latin and displays it on the console.
    Convert each word to a lowercase before translating.
    If a word starts with a vowel, just add "way" onto the ending.
    If a word starts with a consonant, move all of the consonant,move all of the consonants 
    that appear before the first vowel to the end of the word,then add "ay" to the end of the word.
  
 */
namespace Lab6
{
    class Program
    {
       public static string FindPiglatin(string word)
        {
            //declaring the variables vowel_index as int datatype and piglatin as string datatype
            int vowel_index = 0;
            string piglatin = "";


            //finding position of the first vowel in a word
            for (int i = word.Length - 1; i >= 0; i--)
            {
                char letter = word.ToLower()[i];

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowel_index = i;
                }
            }
            

            //check vowel_index is equal to 0 and add way to that word
            if (vowel_index == 0)
            {
                piglatin = word + "way";
            }
            else
            {
                //moving characters before vowels to the end of the word and add ay at the end of the word
                piglatin = word.Substring(vowel_index, (word.Length - vowel_index));
                piglatin = piglatin + word.Substring(0, vowel_index) + "ay";
            }

            return piglatin;
        }




        static void Main(string[] args)
        {
            string condition = "Y";
            string piglatin_line= "";
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            while (condition == "Y" || condition == "y")
            {
                int check_integer;
                piglatin_line = "";
                //getting input as a string and stored in wordline variable
                Console.WriteLine("Enter a line to be translated : ");
                string wordline = Console.ReadLine();

                //splitting each word from sentence by checking the condition,delimiter between two words
                char[] delimiter = { ' ', ',', '.', ':', '\t' };

                string[] words = wordline.Split(delimiter);

                /*taking each word from input and checking its an integer or string.
                 If its a string,it will call method and convert each word into piglatin else integer will store as it is */ 
                foreach (string each_word in words)
                {

                    bool success = int.TryParse(each_word, out check_integer);

                    if (success == false)
                    {
                        //calling methods and getting piglatin word for each word string and stored in piglatin_line
                        piglatin_line = piglatin_line + FindPiglatin(each_word) + " ";
                    }

                    else
                    {
                        piglatin_line = piglatin_line + each_word + " ";

                    }


                }
                //translated piglatin word as output
                Console.WriteLine(piglatin_line);

                //Y or N to continue the translation again by while loop
                Console.WriteLine("Do you want to translate another line ?(y/n) : ");
                condition = Console.ReadLine();

            }
            
            
        }
    }
    
}
    

