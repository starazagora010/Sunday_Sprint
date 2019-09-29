using System;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            var dec = long.Parse(Console.ReadLine());
            var hex = dec.ToString("X");
            Console.WriteLine(hex);
        }
    }
}
