using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercisesPart02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in solution number between 11-16");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Question11();
                    break;
                case 2:
                    Question12();
                    break;
                case 3:
                    Question13();
                    break;
                case 4:
                    Question14();
                    break;
                case 5:
                    Question15();
                    break;
                case 6:
                    Question16();
                    break;
                //case 7:
                //    Question17();
                //    break;
                //case 8:
                //    Question18();
                //    break;
                //case 9:
                //    Question19();
                //    break;
                //case 10:
                //    Question20();
                //    break;
                default:
                    Console.WriteLine("No such bro!");
                    Console.ReadLine();
                    break;
            }

           
        }

        public static void Question11() 
        {
            // Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". 
            string question = "Please enter your name";
            Console.WriteLine(question);
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("You look older than "+name);
            Console.ReadLine();
        }

        public static void Question12() 
        {
            //Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. 
            string question = "Enter your favourite number";
            Console.WriteLine(question);
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num + " "+ num + " " + num + " " + num);
            Console.WriteLine(num+""+ num+""+num + "" + num);
            Console.WriteLine("{0} {0} {0} {0}");
            Console.WriteLine("{0}{0}{0}{0}");
            Console.ReadLine();
        }

        public static void Question13() 
        {
            //Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
            string question = "Enter your favourite number";
            Console.WriteLine(question);
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num + "" + num + "" + num );
            Console.WriteLine(num + " " + num );
            Console.WriteLine(num + " " + num);
            Console.WriteLine(num + " " + num);
            Console.WriteLine(num + "" + num + "" + num);
            Console.ReadLine();
        }

        public static void Question14() 
        {
            //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            string question = "Enter amount of celsius : ";
            Console.WriteLine(question);
            double num = Convert.ToDouble(Console.ReadLine());
            double kelvin = num + 273;
            double fahrenheit = num * 18 / 10 + 32;

            Console.WriteLine("Kelvin = "+kelvin);
            Console.WriteLine("Fahrenheit = "+fahrenheit);
            Console.ReadLine();
        }

        public static void Question15() 
        {
            //Write a C# program remove specified a character from a non-empty string using index of a character.
            string question = "Enter the word you want to modify";
            Console.WriteLine(question);
            string word = Convert.ToString(Console.ReadLine());
            string secquestion = "Enter the letter you want to remove";
            Console.WriteLine(secquestion);
            int place = Convert.ToInt32(Console.ReadLine());

            word.Remove(place);
            Console.WriteLine(word);
            Console.ReadLine();
        }

        public static void Question16() 
        {
            //Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            string question = "Enter the word you want to modify";
            Console.WriteLine(question);
            string word = Convert.ToString(Console.ReadLine());
        }
    }
}
