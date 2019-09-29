using System;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var hex = Console.ReadLine();
            var dec = long.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(dec);
        }
    }
}
