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
            //Initializes firstNum as a double
            double firstNum = 0;
            //Initializes secondNum as a double
            double secondNum = 0;
            //initializes myChoice as an int
            int myChoice = 0;
            //initializes userOutput as a double
            double userOutPut = 0;
            //Sets whileTrue to true for loop control
            bool whileTrue = true;

            //uses while loop to keep app running until user exits
            while (whileTrue) {

                //Introduces app
                Console.WriteLine("CALCULATOR APPLICATION");
                //Prompts first number
                Console.WriteLine("What is the first number?");
                //Sets firstNum to user input converted to double
                firstNum = Convert.ToDouble(Console.ReadLine());
                //Prompts second number
                Console.WriteLine("What is the second number?");
                //Sets secondNum to user input converted to double
                secondNum = Convert.ToDouble(Console.ReadLine());

                //Writes out operation select instructions
                Console.WriteLine("Select an operation: ");
                //Writes out addition
                Console.WriteLine("1 - Addition");
                //Writes out subtraction
                Console.WriteLine("2 - Subtraction");
                //Writes out muliplication
                Console.WriteLine("3 - Multiplication");
                //Writes out division
                Console.WriteLine("4 - Division");
                //writes out quit option
                Console.WriteLine("5 - Quit");
                //Allows user to select 1-5
                Console.WriteLine("Enter your choice (1 - 5): ");

                //uses myChoice as an int converted user input for switch case operator
                myChoice = Convert.ToInt32(Console.ReadLine());

                //Switch case to allow user to select options
                switch (myChoice)
                {
                    //Case 1, addition
                    case 1:
                        //COnverts sum of firstNum and secondNum to double
                        userOutPut = Convert.ToDouble(firstNum + secondNum);
                        //Writes out sum total
                        Console.WriteLine("The result of addition is: " + userOutPut);
                        //Breaks for code
                        break;
                    //Case 2, subtractioin
                    case 2:
                        //Converts user input of the difference of firsNum and secondNum to a double
                        userOutPut = Convert.ToDouble(firstNum - secondNum);
                        //Outputs the difference of firstNum and secondNum
                        Console.WriteLine("The result of subtraction is: " + userOutPut);
                        //breaks code
                        break;

                    //Case 3, muliplication
                    case 3:
                        //User output converted to double to account for the muliplicative value of firstNum and secondNum
                        userOutPut = Convert.ToDouble(firstNum * secondNum);
                        //Writes out the value of userOutput
                        Console.WriteLine("The result of multiplication is: " + userOutPut);
                        //breaks line code
                        break;
                    //Case 4, division
                    case 4:
                        //Assings userOutput the value of firstNum / secondNum and convets it to a double
                        userOutPut = Convert.ToDouble(firstNum / secondNum);
                        //Ouptuts value of userOutput
                        Console.WriteLine("The result of division is: " + userOutPut);
                        //Breaks code
                        break;
                    //Quit case
                    case 5:
                        //Thanks user for using app
                        Console.WriteLine("You have successfully quit!");
                        //sets while  loop control to false
                        whileTrue = false;
                        //breaks code
                        break;
                    //Default for any value outside of 1-5
                    default:
                        //Prints out error output
                        Console.WriteLine("Please enter a valid number between 1 and 4.");
                        //Breaks code
                        break;
                }
            }
            //Keeps console up for readability
            Console.ReadLine();





        }
    }
}