namespace DecimalToBinary
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var dec = long.Parse(Console.ReadLine());
            
            Console.WriteLine(BinToDecV1(dec));
            Console.WriteLine(BinToDecV2(dec));

            // back to SB => bite.Replace(bite.ToString(),resultTecToBite)
        }

        static string BinToDecV1(long dec)
        {
            var binary = Convert.ToString(dec, 2);
            return binary;
        }

        static string BinToDecV2(long dec)
        {
            var bite = new StringBuilder();
            while (dec > 0)
            {
                bite.Append(dec % 2);
                dec /= 2;
            }

            var chArrToBite = bite.ToString().ToCharArray();
            Array.Reverse(chArrToBite);

            var resultDecToBite = new string(chArrToBite);
            return resultDecToBite;
        }
    }
}
