using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var binary = Console.ReadLine();
            var dec = Convert.ToInt64(binary, 2);
            Console.WriteLine(dec);
        }
    }
}
