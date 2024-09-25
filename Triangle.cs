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
        // 3 methods that will return Area, circumference and Volume when called on from the Main Class
        public void ReturnArea()
        {
            Console.WriteLine($"\nArean av triangeln är: {GetArea()}");
        }
        public void ReturnPerimeter()
        {
            Console.WriteLine($"Omkretsen av triangeln är: {GetCircumference()}\n");
        }
        public void ReturnVolume(int height)
        {
            Console.WriteLine($"\nVolymen av prisman är: {GetVolume(height)}");
        }
        // Three methods for calculate Area, circumference and Volume. Convert from a integer to a double
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