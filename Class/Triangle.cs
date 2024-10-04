namespace BasicsOOP.Class
{
    public class Triangle(int aSideA, int aSideB, int aSideC, int aHeight) : IShape // Class Triangle implements the interface IShape
    {   // Private readonly fields
        private readonly int _sideA = aSideA;
        private readonly int _sideB = aSideB;
        private readonly int _sideC = aSideC;
        private readonly int _height = aHeight;

        public void ReturnArea()
        {
            Console.WriteLine($"\nArean av triangeln är: {Math.Round(GetArea(), 2)}");
        }

        public void ReturnPerimeter()
        {
            Console.WriteLine($"Omkretsen av triangeln är: {Math.Round(GetPerimeter(), 2)}");
        }

        public void ReturnVolume()
        {
            Console.WriteLine($"Volymen av prisman är: {Math.Round(GetVolume(), 2)}");
        }

        // Calculate methods and convert integer variable to double
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

        public double GetVolume()
        {
            double area = GetArea(); // Take the calculate base area
            return area * _height;    // V = base area * height
        }
    }
}