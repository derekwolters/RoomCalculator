using System;
using System.Collections.Generic;

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
            float area = 0;
            float perimeter = 0;
            float volume = 0;           
            bool keepGoing = true;
            List<string> results = new List<string> { };

            Console.WriteLine("This program will calculate the Area, Perimeter, and Volume of a room.");
            
            //keep running as long as user wishes
            while (keepGoing)
            {
                //if (results.Count > 0)
                //{                   
                //    printList(results);
                //}
                
                //get user dimensions
                width = getInputDimensions("width", results);
                length = getInputDimensions("length", results);
                height = getInputDimensions("height", results);
            
                //calculate area
                area = calcArea(width, length);
                displayResult("area", area);

                //calculate perimeter
                perimeter = calcPerimeter(width, length);
                displayResult("perimeter", perimeter);

                //calculate volume
                volume = calcVolume(width, length, height);                
                displayResult("volume", volume);

                results.Add("Width: " + width +
                            " -- Length: " + length +
                            " -- Height: " + height +
                            " -- Area: " + area +
                            " -- Perimeter:" + perimeter +
                            " -- Volume:" + volume);

                printList(results);
                //exit program               
                if (exitProgram()) break;
            }            
        }

        static float getInputDimensions(string dimType, List<string> list)
        {
            string input = "";
            float temp;

            Console.WriteLine("Enter a " + dimType + " dimension: ");

            input = Console.ReadLine();
            
            while (!float.TryParse(input, out temp))
            {
                Console.WriteLine("Not a valid input. Try again.");
                input = Console.ReadLine();
            }            

            return temp;
        }

        static void printList(List<string> list)
        {
            Console.WriteLine("Type \"print\" to display a list of " +
                                        "previous entries or press ENTER to " +
                                        "continue");
            string input = Console.ReadLine().ToLower();

            if (input.Contains("print"))
            {
                foreach (string entry in list)
                {
                    Console.WriteLine(entry);
                }                
            }
            else
            {
                return;
            }
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
                xitChoice = Console.ReadLine().ToUpper();
            }

            return xitChoice == "N" ? true : false;           
        }
    }
}
