using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = 0.0;

            double secondNum = 0.0;

            int myChoice = 0;

            double userOutPut = 0;

            bool whileTrue = true;

            while (whileTrue) {
                Console.WriteLine("CALCULATOR APPLICATION");

                Console.WriteLine("What is the first number?");

                firstNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the second number?");

                secondNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select an operation: ");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Quit");

                Console.WriteLine("Enter your choice (1 - 4): ");

                myChoice = Convert.ToInt32(Console.ReadLine());

                switch (myChoice)
                {
                    case 1:
                        userOutPut = Convert.ToDouble(firstNum + secondNum);
                        Console.WriteLine("The result of addition is: " + userOutPut);
                        break;
                    case 2:
                        userOutPut = Convert.ToDouble(firstNum - secondNum);
                        Console.WriteLine("The result of subtraction is: " + userOutPut);
                        break;
                    case 3:
                        userOutPut = Convert.ToDouble(firstNum * secondNum);
                        Console.WriteLine("The result of multiplication is: " + userOutPut);
                        break;
                    case 4:
                        userOutPut = Convert.ToDouble(firstNum / secondNum);

                        Console.WriteLine("The result of division is: " + userOutPut);
                        break;
                    case 5:
                        Console.WriteLine("You have successfully quit!");
                        whileTrue = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 4.");
                        break;
                }
            }
            Console.ReadLine();





        }
    }
}