using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelimLabExam_Monteagudo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a main program with 3 choices to choose from. The following are the sub programs the user can choose.
            Console.WriteLine("-------------------");
            Console.WriteLine("  [1]: LeapYear");
            Console.WriteLine("  [2]: PHP to USD");
            Console.WriteLine("  [3]: Calculator");
            Console.WriteLine("-------------------");

            Console.WriteLine();
            
            Console.Write("What would you like to do?: ");
            int choice = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1) // 1. LeapYear: Create a program that will determine if the year entered is a Leap Year.
            {
                Console.Write("Enter a Year: ");
                int year = Int32.Parse(Console.ReadLine());

                Console.WriteLine();

                if (year % 400 == 0)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("  The year " + year + " is a Leap Year!");
                    Console.WriteLine("---------------------------------");
                }

                else if (year % 100 == 0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("  The year " + year + " is not a Leap Year.");
                    Console.WriteLine("-------------------------------------");
                }

                else if (year % 4 == 0)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("  The year " + year + " is a Leap Year!");
                    Console.WriteLine("---------------------------------");
                }

                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("  The year " + year + " is not a Leap Year.");
                    Console.WriteLine("-------------------------------------");
                }

            }

            else if (choice == 2) // 2. PHPtoUSD: Create a program that lets the user convert Philippine Peso to US Dollar.
            {
                Console.Write("Enter Your Money Balance in Philippine Peso: ");
                float peso = float.Parse(Console.ReadLine());

                Console.WriteLine();

                float usd = (float)peso * (float)0.018;


                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("  Your Money Balance in US Dollars is: " + String.Format("{0:0.00}", usd + " USD"));
                Console.WriteLine("-------------------------------------------------");

                Console.ReadLine();
            }

            else if (choice == 3) /*Calculator: Create a program using switch case that lets the user input 2 numbers,
                                    then asks which operator will be used for those two numbers.
                                    Display the result using the format: "The answer for <num1> <operator> <num2> is: "
                                  */
            {
                Console.Write("Enter First Number: ");
                float fNum = float.Parse(Console.ReadLine());
                Console.Write("Enter Second Number: ");
                float sNum = float.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("[1]: Additon");
                Console.WriteLine("[2]: Subtraction");
                Console.WriteLine("[3]: Multiplication");
                Console.WriteLine("[4]: Division");

                Console.WriteLine();

                Console.Write("Choose an Operator Above: ");
                int opt = Int32.Parse(Console.ReadLine());

                Console.WriteLine();
                
                switch (opt)
                {
                    case 1:
                    float add = (float)fNum + (float)sNum;
                    Console.WriteLine("The answer for " + fNum + " and " + sNum + " is: " + String.Format("{0:0.00}", add));
                    break;

                    case 2:
                    float sub = (float)fNum - (float)sNum;
                    Console.WriteLine("The answer for " + fNum + " and " + sNum + " is: " + String.Format("{0:0.00}", sub));
                    break;

                    case 3:
                    float mul = (float)fNum * (float)sNum;
                    Console.WriteLine("The answer for " + fNum + " and " + sNum + " is: " + String.Format("{0:0.00}", mul));
                    break;

                    case 4:
                    float div = (float)fNum / (float)sNum;
                    Console.WriteLine("The answer for " + fNum + " and " + sNum + " is: " + String.Format("{0:0.00}", div));
                    break;

                    default:
                    Console.WriteLine("Invalid Input.");
                    break;
                }
            }

            else
                {
                    Console.WriteLine("Invalid Input.");
                }

            Console.ReadKey();

        }
    }
}
