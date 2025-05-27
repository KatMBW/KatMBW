using System;

namespace InchesToCentimetersInteractive
{
    class InchesToCentimetersInteractive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter inches you need converted to centimeters >>");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.WriteLine("{0} inches is equal to {1} centimeters", inches, centimeters);
            
        }
    }
}