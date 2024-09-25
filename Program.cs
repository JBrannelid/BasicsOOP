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
            // Instance/object of the class Circle. Pass preset values to the class constructor
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            // Call void functions inside class Circle and print out calculated area, circumference and volume
            circle1.ReturnArea();
            circle2.ReturnArea();
            Console.WriteLine();

            circle1.ReturnPerimeter();
            circle2.ReturnPerimeter();
            Console.WriteLine();

            circle1.ReturnVolume();
            circle2.ReturnVolume();

            // Give user time to read. Promt user to press a key to continued. Clear the console
            promtUserMessage();

            // Call local functions and save 3 integers in an array responsible for storing a triangle with 3 sides
            Console.WriteLine("För att räkna ut Area och Omkräts på en rätvinklig triangel \n" +
                              "behöver vi veta längden på triangels 3 sidor (Sida: A, B, C)\n");
            int[] sides = InputTriangle();

            // A new triangle object. The Triangle constructor class receives the arguments in the parameter (Arrey index)
            Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);

            // Print out calculated area and circumference by calling void functions from the object to local functions inside the class triangle 
            triangle.ReturnArea();
            triangle.ReturnPerimeter();

            // Give user time to read. Promt user to press a key to continued. Clear the console
            promtUserMessage();

            // Prompt input for triangle height and pass it to the class triangle functions responsible for calculating volume of a prisma
            Console.WriteLine("För att beräkna volymen i en prisma behöver vi ta reda höjden");
            Console.Write("Ange höjden på prisman: ");

            int height = ReadInt();

            triangle.ReturnVolume(height); 
        }
        static int ReadInt()
        {   // TryParse for safe convert string to an integer. Prompt user if an integer wasn't entered
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
        static int[] InputTriangle()
        {   // Initialize an array with 3 indexes and fill it up with a for-loop. Responsible for carrying a triangle with three sides of value

            int[] sideTriangel = new int[3];

            for (int i = 0; i < sideTriangel.Length; i++)
            {
                Console.Write($"Ange längden på sida {i + 1}: ");
                sideTriangel[i] = ReadInt(); // Check if user input is valid by calling a ReadInteger functions  
            }
            return sideTriangel;
        }
        static void promtUserMessage()
        {
            Console.WriteLine("Tryck på en valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
