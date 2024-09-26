using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP
{
    public class Triangle
    {   // Private fields
        private int _sideA;
        private int _sideB;
        private int _sideC;

        // Constructor (a-stands for argument). Place a value on each side of a triangle
        public Triangle(int aSideA, int aSideB, int aSideC)
        {   
            _sideA = aSideA;
            _sideB = aSideB;
            _sideC = aSideC;
        }
        // Call calculate methods. Usage of Microsoft static functions Math.Round. Round the value to 2 decimal
        public void ReturnArea()
        {
            Console.WriteLine($"\nArean av triangeln är: {Math.Round(GetArea(), 2)}");
        }
        public void ReturnPerimeter()
        {
            Console.WriteLine($"Omkretsen av triangeln är: {Math.Round(GetCircumference(), 2)}\n");
        }
        public void ReturnVolume(int height)
        {
            Console.WriteLine($"\nVolymen av prisman är: {Math.Round(GetVolume(height), 2)}");
        }

        // Calculate methods and convert integer variable to double.
        // Use Microsoft static functions for Square root (Math.sqrt())
        public double GetArea()
        {
            // Heron's formula for area calculation
            double s = (_sideA + _sideB + _sideC) / 2.0; // Step 1 
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC)); // Step 2
        }
        public double GetCircumference()
        {
            return _sideA + _sideB + _sideC; // O = a + b + c
        }
        public double GetVolume(int height)
        {
            double area = GetArea(); // Take the calculate base area
            return area * height;    // V = base area * height
        }
    }
}
