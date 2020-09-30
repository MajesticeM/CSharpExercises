using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercisePart01
{
    class Program
    {
        static void Main(string[] args)
        {
            string ques01 = "Write a C# Sharp program to print Hello and your name in a separate line.";
            string ques02 = "Write a C# Sharp program to print the result of dividing two numbers.";
            string ques03 = "Write a C# Sharp program to print the result of dividing two numbers.";
            string ques04 = "Write a C# Sharp program to print the result of the specified operations.";
            Console.WriteLine("Type in solution number between 1-10");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Question01();
                    break;
                case 2:
                    Question02();
                    break;
                case 3:
                    Question03();
                    break;
                case 4:
                    Question04();
                    break;
                case 5:
                    Question05();
                    break;
                case 6:
                    Question06();
                    break;
                case 7:
                    Question07();
                    break;
                case 8:
                    Question08();
                    break;
                case 9:
                    Question09();
                    break;
                case 10:
                    Question10();
                    break;
                default:
                    Console.WriteLine("No such bro!");
                    Console.ReadLine();
                    break;
            }
        }

        public static void Question01() 
        {
            //Write a C# Sharp program to print Hello and your name in a separate line.
            string question = "What is your name?";
            Console.WriteLine(question);
            string answer = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello " + answer +" "+"nice to meet you!");
            Console.ReadLine();
        }

        public static void Question02() 
        {
            //Write a C# Sharp program to print the sum of two numbers.
            string question01 = "Enter First Number";
            Console.WriteLine(question01);
            double num01 = Convert.ToDouble(Console.ReadLine());
            string question02 = "Enter Second Number";
            Console.WriteLine(question02);
            double num02 = Convert.ToDouble(Console.ReadLine());
            double total = num01 + num02;
            string finAns = "The addition of your first and second number is : " + total;
            Console.WriteLine(finAns);
            Console.ReadLine();

        }

        public static void Question03() 
        {
            //Write a C# Sharp program to print the result of dividing two numbers.
            string question01 = "Enter First Number";
            Console.WriteLine(question01);
            double num01 = Convert.ToDouble(Console.ReadLine());
            string question02 = "Enter Second Number";
            Console.WriteLine(question02);
            double num02 = Convert.ToDouble(Console.ReadLine());
            double total = num01 / num02;
            string finAns = "The division of your first and second number is : " + total;
            Console.WriteLine(finAns);
            Console.ReadLine();
        }

        public static void Question04() 
        {
            //Write a C# Sharp program to print the result of the specified operations.
            double op01 = -1 + 4 * 6;
            string op001 = "-1 + 4 * 6";
            double op02 = (35 + 5) % 7;
            string op002 = "(35 + 5) % 7";
            double op03 = 2 + 15 / 6 * 1 / 11;
            string op003 = "2 + 15 / 6 * 1 / 11";
            double op04 = 2 + 15 / 6 * 1 - 7 % 2;
            string op004 = "2 + 15 / 6 * 1 - 7 % 2";
            Console.WriteLine("Operation 01 : "+ op001);
            Console.WriteLine("Result of first operation is : " + op01);
            Console.WriteLine("Operation 02 : "+op002);
            Console.WriteLine("Result of second operation is : " + op02);
            Console.WriteLine("Operation 03 : " + op003);
            Console.WriteLine("Result of third operation is : " + op03);
            Console.WriteLine("Operation 04 : " + op004);
            Console.WriteLine("Result of fourth operation is : " + op04);
            Console.ReadLine();
        }

        public static void Question05() 
        {
            // Write a C# Sharp program to swap two numbers.
            string question01 = "Enter First Number";
            Console.WriteLine(question01);
            double num01 = Convert.ToDouble(Console.ReadLine());
            string question02 = "Enter Second Number";
            Console.WriteLine(question02);
            double num02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Numbers before swap");
            Console.WriteLine(num01);
            Console.WriteLine(num02);
            Console.WriteLine("Numbers after swap.Voila!");
            Console.WriteLine(num02);
            Console.WriteLine(num01);
            Console.ReadLine();
        }

        public static void Question06()
        {
            //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            // Write a C# Sharp program to swap two numbers.
            string question01 = "Enter First Number";
            Console.WriteLine(question01);
            double num01 = Convert.ToDouble(Console.ReadLine());
            string question02 = "Enter Second Number";
            Console.WriteLine(question02);
            double num02 = Convert.ToDouble(Console.ReadLine());
            string question03 = "Enter Third Number";
            Console.WriteLine(question03);
            double num03 = Convert.ToDouble(Console.ReadLine());

            double op = num01 * num02 * num03;
            Console.WriteLine("The final answer of this multiplication operation is : "+op);
            Console.ReadLine();
        }

        public static void Question07() 
        {
            //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            string question01 = "Enter First Number";
            Console.WriteLine(question01);
            double num01 = Convert.ToDouble(Console.ReadLine());
            string question02 = "Enter Second Number";
            Console.WriteLine(question02);
            double num02 = Convert.ToDouble(Console.ReadLine());
            double opAdd = num01 + num02;
            double opSubtract = num01 - num02;
            double opMultiply = num01 * num02;
            double opDivide = num02 / num02;
            Console.WriteLine("The final answer of this Addition operation is : " + opAdd);
            Console.WriteLine("The final answer of this Subtraction operation is : " + opSubtract);
            Console.WriteLine("The final answer of this Multiplication operation is : " + opMultiply);
            Console.WriteLine("The final answer of this Division operation is : " + opDivide);
            Console.ReadLine();
        }

        public static void Question08() 
        {
            //Write a C# Sharp program that takes a number as input and print its multiplication table.
            Console.WriteLine("Enter your favourite number");
            double favNumber = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 12; i++)
            {
                double ops = favNumber * i;
                Console.WriteLine(favNumber +"*"+ i +" ="+ops);
            }
            Console.ReadLine();
        }

        public static void Question09() 
        {
            string question01 = "Enter First Number";
            Console.WriteLine(question01);
            double num01 = Convert.ToDouble(Console.ReadLine());
            string question02 = "Enter Second Number";
            Console.WriteLine(question02);
            double num02 = Convert.ToDouble(Console.ReadLine());
            string question03 = "Enter Third Number";
            Console.WriteLine(question03);
            double num03 = Convert.ToDouble(Console.ReadLine());
            string question04 = "Enter Fourth Number";
            Console.WriteLine(question04);
            double num04 = Convert.ToDouble(Console.ReadLine());

            double operation=num01+num02+num03+num04/3;

            Console.WriteLine("The average of your favourite numbers is : "+ operation);
            Console.ReadLine();
        }

        public static void Question10() 
        {
            //Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            string question01 = "Enter First Number";
            Console.WriteLine(question01);
            double num01 = Convert.ToDouble(Console.ReadLine());
            string question02 = "Enter Second Number";
            Console.WriteLine(question02);
            double num02 = Convert.ToDouble(Console.ReadLine());
            string question03 = "Enter Third Number";
            Console.WriteLine(question03);
            double num03 = Convert.ToDouble(Console.ReadLine());

            double op01 = (num01 + num02) * num03;
            double op02 = num01 * num02 + num02 * num03;

            Console.WriteLine("First Output of (x+y).z : " + op01);
            Console.WriteLine("Second Output of x.y + y.z" + op02);
            Console.ReadLine();
        }
    }
}
