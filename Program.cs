// Programmer:   Johannes Brannelid
// Institute:    Chas Academy
// Program:      Fullstack .NET 2024
// Course:       Programmering med C# och .NET
// Lab 5:        Grunderna OOP

using BasicsOOP.Class;

namespace BasicsOOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Instance/object of the class Circle. Pass preset values to Circle class constructor
            var circle1 = new Circle(5);
            var circle2 = new Circle(6);

            // Call void functions inside class Circle and print out calculated area, circumference and volume
            DisplayCircleMetrics(circle1, circle2);

            // Prompt user for triangle side input, read the side input from the user and display the triangle metrics
            PromptTriangleSideLengths();
            int[] sides = GetTriangleSides();

            // Prompt user for height input, read the height input from the user and display the triangle metrics
            PromptPrismHeight();
            int height = ReadInt();

            // Instance/object of the class Triangle. Pass index values from the array to Triangle class constructor
            var triangle = new Triangle(sides[0], sides[1], sides[2], height);
            DisplayTriangleMetrics(triangle);
        }

        private static int ReadInt()
        {
            while (true)
            {   // TryParse for safe conversion of user input to integer. Prompt user if input is null or not a valid integer
                string? input = Console.ReadLine();
                if (input != null && TryParse(input, out int result))
                {
                    if (result > 0)
                    {
                        return result;
                    }
                    Console.Write($"\nSidan kan inte vara negativ: ");
                }
                else
                {
                    Console.Write($"\nVänligen skriv in ett heltal: ");
                }
            }
        }

        private static bool TryParse(string input, out int result)
        {    // Custom TryPars functions. Convert value and turn back sucessfull, yes/no
            result = -1; // assign out result

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception) // Return true or false value hense why an exception specification isn't nessesary
            {
                return false;
            }
        }

        private static int[] GetTriangleSides()
        {   // Initialize an array with 3 indexes and fill it up with a for-loop. Responsible for carrying a triangle with three sides of value
            int[] sideTriangel = new int[3];

            for (int i = 0; i < sideTriangel.Length; i++)
            {
                Console.Write($"Ange längden på sida {i + 1}: ");
                sideTriangel[i] = ReadInt(); // Check if user input is valid by calling a ReadInteger functions
            }
            return sideTriangel;
        }

        private static void DisplayCircleMetrics(Circle circle1, Circle circle2)
        {
            circle1.ReturnArea();
            circle2.ReturnArea();
            Console.WriteLine();

            circle1.ReturnPerimeter();
            circle2.ReturnPerimeter();
            Console.WriteLine();

            circle1.ReturnVolume();
            circle2.ReturnVolume();
            Console.WriteLine();

            // Give user time to read. Promt user to press a key to continued. Clear the console
            PromptUserToContinue();
        }

        private static void DisplayTriangleMetrics(Triangle triangle)
        {
            triangle.ReturnArea();
            triangle.ReturnPerimeter();
            triangle.ReturnVolume();
            Console.WriteLine();

            // Give user time to read. Promt user to press a key to continued. Clear the console
            PromptUserToContinue();
        }

        private static void PromptUserToContinue()
        {
            Console.WriteLine("Tryck på en valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();
        }

        private static void PromptPrismHeight()
        {
            // Prompt input for triangle height and pass it to the class triangle functions responsible for calculating volume of a prisma
            Console.WriteLine("");
            Console.WriteLine("För att beräkna volymen i en prisma behöver vi ta reda på höjden");
            Console.Write("Ange höjden på prisman: ");
        }

        private static void PromptTriangleSideLengths()
        {
            Console.WriteLine("""
                                    För att räkna ut Area och Omkräts på en rätvinklig triangel
                                    behöver vi veta längden på triangels 3 sidor (Sida: A, B, C)
                                    """);
            Console.WriteLine("");
        }
    }
}