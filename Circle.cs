using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOOP
{
    public class Circle
    {
        // Private fields
        private int _radie; // _radie is readable inside the class Circle 

        // Constructor (a-stands for argument). Place a value on a circle radie
        public Circle(int aRadie)
        {
            _radie = aRadie; // Set a value to _radie
        }

        // Call calculate methods. Usage of Microsoft static functions Math.Round. Round the value to 2 decimal
        public void ReturnArea()
        {
            Console.WriteLine($"Area på en cirkel med en radie: {_radie} är: {Math.Round(GetArea(),2)}");
        }
        public void ReturnPerimeter()
        {
            Console.WriteLine($"Omkrätsen på ett cirkel med en radie: {_radie} är: {Math.Round(GetCircumference(),2)}");
        }
        public void ReturnVolume()
        {
            Console.WriteLine($"Volymen på ett klot med en radie: {_radie} är: {Math.Round(GetVolume(),2)}");
        }

        // Calculate methods and convert integer variable to double.
        // Use Microsoft static functions for value of PI and power of x
        public double GetArea()
        {
            return (_radie * _radie) * Math.PI; // A = r * r * π
        }
        public double GetCircumference()
        {
            return 2 * Math.PI * _radie; // P = 2 * π * r
        }
        public double GetVolume()
        {
            return (4.0 / 3) * Math.PI * Math.Pow(_radie, 3); // V = 4/3 * π * r³
        }
    }
}
