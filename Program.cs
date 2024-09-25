// Programmer:   Johannes Brannelid
// Program:      Fullstack .NET 2024
// Course:       Programmering med C# och .NET
// Lab 5:        Grunderna OOP

using System;

namespace BasicsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of the class Circle and set predefinition value
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            // Call void functions inside class Circle and print out calculated area, perimeter and volume
            circle1.ReturnArea();
            circle2.ReturnArea();
            Console.WriteLine();

            circle1.ReturnPerimeter();
            circle2.ReturnPerimeter();
            Console.WriteLine();

            circle1.ReturnVolume();
            circle2.ReturnVolume();

            // Give user time to read and promt user to press a key to continued. Clear the console
            Console.WriteLine("\nTryck på en valfri tagent för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            // Call functions and save 3 integer in an arrey
            Message();
            int[] sides = inputTriangle();

            // Create new instance of the class Triangle. Arguments (Arrey index) send to the class Triangle constructor
            Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);

            // Call void functions inside class Triangle. Print out calculated area and perimeter
            triangle.ReturnArea();
            triangle.ReturnPerimeter();

            // Give user time to read and promt user to press a key to continued. Clear the console
            Console.WriteLine("Tryck på en valfri tagent för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            // Promt input for triangle height and pass the height to calculate volum function inside triangle Class
            Console.WriteLine("Om vi ska beräkna volymen i en prisma behöver vi veta höjden på prisman");
            Console.Write("Ange höjden på prisman: ");

            int height = ReadInt();

            triangle.ReturnVolume(height); 
        }
        static int ReadInt()
        {   // TryParse for safe convert string to an integer. Promt user if an integer wasn't entered
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    return input;
                }
                else
                {
                    Console.Write($"\nVänligen skriv in ett heltal: ");
                }
            }
        }
        static int[] inputTriangle()
        {   // Initialisation an Array with 3 index and fill upp the Arrey with a foor-loop. 
            int[] sideTriangel = new int[3];

            for (int i = 0; i < sideTriangel.Length; i++)
            {
                Console.Write($"Ange längden på sida {i + 1}: ");
                sideTriangel[i] = ReadInt(); // Check if input is valid by calling a ReadInteget functions  
            }
            return sideTriangel;
        }
        static void Message()
        {
            Console.WriteLine("För att räkna ut Area och Omkräts på en rätvinkligt triangel \n" +
                              "behöver vi veta längden på dess 3 sidor\n");
        }
    }
}
