using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP
{
    public class Triangle
    {   // Fields. _ for a private variabel
        private int _sideA;
        private int _sideB;
        private int _sideC;

        public Triangle(int aSideA, int aSideB, int aSideC)
        {   // Constructor. a-stands for argument. Easy to keep the argument apart from the variabels
            _sideA = aSideA;
            _sideB = aSideB;
            _sideC = aSideC;
        }
        // 3 methods that will return Area, Perimeter and Volume
        public void ReturnArea()
        {
            Console.WriteLine($"\nArean av triangeln är: {GetArea()}");
        }
        public void ReturnPerimeter()
        {
            Console.WriteLine($"Omkretsen av triangeln är: {GetPerimeter()}\n");
        }
        public void ReturnVolume(int height)
        {
            Console.WriteLine($"\nVolymen av prismat är: {GetVolume(height)}");
        }
        // 3 calculating methods for Area, Perimeter and Volume
        public double GetArea()
        {
            // Heron's formula for area calculation
            double s = (_sideA + _sideB + _sideC) / 2.0; // Step 1 
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC)); // Step 2
        }
        public double GetPerimeter()
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