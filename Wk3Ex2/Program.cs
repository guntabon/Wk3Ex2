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
            bool myWhile = true;

            //This line declares the  variable firstNum and sets it to 0 for future use
            double firstNum = 0;

            //This line declares secondNum as a double variable and allows it for future use
            double secondNum = 0;

            //Creates myChoice as an int variable
            int myChoice = 0;

            //Creates the userOutPut double for use to be altered later
            double userOutPut = 0;

            while (myWhile){
                //Presents the name of the program an its use
                Console.WriteLine("CALCULATOR APPLICATION");

                //Prompts the user to input the first number to be used in the application
                Console.WriteLine("What is the first number?");

                //Accepts input from the user, the conversion allows the user to enter either whole numbers or decimals to be used
                firstNum = Convert.ToDouble(Console.ReadLine());

                //Prompts user to enter the second number. 
                Console.WriteLine("What is the second number?");

                //Also converts the users number into a double/decimal to allow use of non-whole numbers
                secondNum = Convert.ToDouble(Console.ReadLine());


                //Presents the options for use in the application.
                Console.WriteLine("Select an operation: ");

                //The first option is adding the two numbers together
                Console.WriteLine("1 - Addition");

                //The second allows users to subtract
                Console.WriteLine("2 - Subtraction");

                //The third allows users to multiply the two numbers
                Console.WriteLine("3 - Multiplication");

                //This prompts the user to select division
                Console.WriteLine("4 - Division");

                //This line prompts the user to select a number between 1-4
                Console.WriteLine("Enter your choice (1 - 4): ");

                //This line takes the input of the user choice and converts it into a int to be used later
                myChoice = Convert.ToInt32(Console.ReadLine());

                //I used a switch case for this. Considering there were only 4 options I decided it'd be a good way to choose the calculation
                switch (myChoice)
                {
                    //the first option, addition
                    case 1:

                        //This line takes the user's input and converts it into a decimal to allow addition of non whole numbers.
                        userOutPut = Convert.ToDouble(firstNum + secondNum);

                        //This prints out the results of the addition 
                        Console.WriteLine("The result of addition is: " + userOutPut);

                        //This line breaks the program to allow it to end
                        break;

                    //The second option in line

                    case 2:

                        //This line takes the user's input and converts it into a decimal for calculations. 
                        userOutPut = Convert.ToDouble(firstNum - secondNum);

                        //This prints out the results of the subtraction
                        Console.WriteLine("The result of subtraction is: " + userOutPut);

                        //This line breaks the code and allows it to end
                        break;

                    //the third option that can be selected (mulitplication)
                    case 3:

                        //Converts user input into decimals for multiplication using whole or non whole numbers
                        userOutPut = Convert.ToDouble(firstNum * secondNum);

                        //Prints the result of the multiplication
                        Console.WriteLine("The result of multiplication is: " + userOutPut);

                        //Breaks code and allows it to end
                        break;

                    //The fourth option, division
                    case 4:

                        //This converts the numbers and allows for the calculation. Keep in mind the firstNum is divided by secondNum. Switching the two could result in a different outcome
                        userOutPut = Convert.ToDouble(firstNum / secondNum);


                        //Prints out results of the division
                        Console.WriteLine("The result of division is: " + userOutPut);

                        //Breaks code and ends the program
                        break;

                    //In case the user does not enter the correct number range, it alerts them that the program only accepts the input of 1-4
                    default:

                        //Alerts the user they need to enter a valid number 
                        Console.WriteLine("Please enter a valid number between 1 and 4.");

                        //Breaks program and ends it
                        break;
                }
            }
            Console.ReadLine();





        }
    }
}
