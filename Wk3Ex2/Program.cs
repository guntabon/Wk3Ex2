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


            //This line declares secondNum as a double variable and allows it for future use
            double secondNum = 0;

            //Creates myChoice as an int variable
            int myChoice = 0;


            while (myWhile){
                //Presents the name of the program an its use
            Console.WriteLine("CALCULATOR APPLICATION");

                //Prompts the user to input the first number to be used in the application
            Console.WriteLine("What is the first number?");


                //Prompts user to enter the second number. 
            Console.WriteLine("What is the second number?");



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
                    Console.WriteLine("The result of addition is: " + userOutPut);

                        //This line breaks the program to allow it to end
                    break;

                    //The second option in line

                case 2:
                    Console.WriteLine("The result of subtraction is: " + userOutPut);

                        //This line breaks the code and allows it to end
                    break;

                    //the third option that can be selected (mulitplication)
                case 3:
                    Console.WriteLine("The result of multiplication is: " + userOutPut);

                        //Breaks code and allows it to end
                    break;

                    //The fourth option, division
                case 4:
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
            Console.ReadLine();





        }
    }
}
