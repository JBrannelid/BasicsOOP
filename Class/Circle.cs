namespace BasicsOOP.Class
{
    public class Circle(int aRadie) : IShape // Class Circle implements the interface IShape
    {
        private readonly int _radie = aRadie; // Private fields

        // Call calculate methods. Round the value to 2 decimal with Math.Round() for a more readable output
        public void ReturnArea()
        {
            Console.WriteLine($"Area på en cirkel med en radie: {_radie} är: {Math.Round(GetArea(), 2)}");
        }

        public void ReturnPerimeter()
        {
            Console.WriteLine($"Omkrätsen på ett cirkel med en radie: {_radie} är: {Math.Round(GetPerimeter(), 2)}");
        }

        public void ReturnVolume()
        {
            Console.WriteLine($"Volymen på ett klot med en radie: {_radie} är: {Math.Round(GetVolume(), 2)}");
        }

        // Calculate methods and convert integer variable to double
        public double GetArea()
        {
            return Math.Pow(Math.PI, 2) * _radie; ; // A = r * r * π
        }

        public double GetPerimeter()
        {
            return Math.PI * Math.Pow(_radie, 2); // P = 2 * π * r
        }

        public double GetVolume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(_radie, 3); // V = 4/3 * π * r³
        }
    }
}