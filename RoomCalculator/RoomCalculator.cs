using System;

///-----------------------------------------------------------------
///   Namespace:    RoomCalculator
///   Description:  Input room dimensions and calculate the area,
///                 perimeter, and volume of the room.
///   Author:       Derek Wolters                
///   Date:         3.27.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------

namespace RoomCalculator
{
    class RoomCalculator
    {
        static void Main(string[] args)
        {
            //initialize variables
            float width = 0;
            float length = 0;
            float height = 0;
            float result = 0;            
            bool keepGoing = true;

            Console.WriteLine("This program will calculate the Area, Perimeter, and Volume of a room.");
            
            //keep running as long as user wishes
            while (keepGoing)
            {
                //get user dimensions
                width = getInputDimensions("width");
                length = getInputDimensions("length");
                height = getInputDimensions("height");
            
                //calculate area
                result = calcArea(width, length);
                displayResult("area", result);

                //calculate perimeter
                result = calcPerimeter(width, length);
                displayResult("perimeter", result);

                //calculate volume
                result = calcVolume(width, length, height);
                displayResult("volume", result);
                
                //exit program               
                if (exitProgram()) break;
            }            
        }

        static float getInputDimensions(string dimType)
        {
            string input = "";
            float temp;

            Console.WriteLine("Enter a " + dimType + " dimension:");

            input = Console.ReadLine();

            while (!float.TryParse(input, out temp))
            {
                Console.WriteLine("Not a valid input. Try again.");
                input = Console.ReadLine();
            }

            return temp;
        }

        static float calcArea(float w, float l)
        {
            return w * l;
        }

        static float calcPerimeter(float w, float l)
        {
            return (w + l) * 2;
        }

        static float calcVolume(float w, float l, float h)
        {
            return w * l * h;
        }

        static void displayResult(string dimType, float dim)
        {
            Console.WriteLine("The " + dimType + " of the room is: " + dim);
        }

        static Boolean exitProgram()
        {
            string xitChoice = "";

            Console.WriteLine("Do you have another room? Enter Y or N.");

            xitChoice = Console.ReadLine().ToUpper();

            while (xitChoice != "N" && xitChoice != "Y")
            {
                Console.WriteLine("Not a vaid answer. Do you have another room? Enter Y or N.");
            }

            return xitChoice == "N" ? true : false;           
        }
    }
}
