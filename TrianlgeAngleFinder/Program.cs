using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TrianlgeAngleFinder
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask the user for the first angle in degrees
            WriteLine("Please enter the first angle in degrees");

            //Store the user input as angle 1
            double angle1 = double.Parse(ReadLine());

            //Ask the user for the second angle in degrees
            WriteLine("Please enter the second angle in degrees");

            //Store the users input as angle 2
            double angle2 = double.Parse(ReadLine());

            //Display the active calculation
            WriteLine("\n\n-----Calculation Acquired-----\n");

            //Display the answer provided by calling out angle finder method when passed through the two parameters
            WriteLine($"the 3rd angle of your triangle must be: {thirdAngle(angle1, angle2)}");

            //Halt the application for users convenience
            ReadLine();
        }

        static public double thirdAngle(double num1, double num2)
        {
            return 180 - (num1 + num2);
        }
    }
}
