using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Please select an option, by entering a number:\n"); 
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("That's not a valid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }

            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the{rectSide} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again. \n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number cannot be less than 0, please try again. \n");
                }
                else
                {    
                    isValid = true;
                    Console.WriteLine($"The {rectSide} of your rectangle is {number} \n");
                }
            }
            return number;

        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            bool validRectangleSelect = false;
            string RectangleSelection;
            int Selection;

            while (validRectangleSelect == false)
            {
                
                Console.WriteLine("2 = create custom rectangle \n");
                Console.WriteLine("Choose a menu Item to begin:");
                RectangleSelection = Console.ReadLine();
                Console.WriteLine();

                if ( RectangleSelection != "2")
                {
                    Console.WriteLine("Thats not a valid selection, please try again \n");
                }
                
                else if (int.Parse(RectangleSelection) == 2)
                {
                    validRectangleSelect = true;

                    int reclength;
                    int recwidth;

                    reclength = ValidateUserInput(" length");
                    recwidth = ValidateUserInput(" width");

                    Console.WriteLine($"Your custom rectangle length is {reclength} and width is {recwidth} \n");
                    Rectangle customRectangle = new Rectangle(reclength, recwidth);
                    r = customRectangle;
                }
                
             
            }


            Selection = ValidateMenuSelection();

            while (Selection != 7)
            {
                int result;

                switch (Selection)
                {
                    case 1:
                        Console.WriteLine($"Length of rectangle is: {r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("reclength");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width of a rectangle is {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("recwidth");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The perimeter of rectangle is {r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"the area of rectangle is {r.GetArea()}\n");
                        break;
                    default:
                        break;

                }

                Selection = ValidateMenuSelection();


            }
        }

    }
}
