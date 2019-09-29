using System;

namespace _04.DeckPrint
{
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            //Conventional_Solution();
            MemoryWise_Solution();
        }

        public static void MemoryWise_Solution()
        {
            string lastCard = Console.ReadLine();
            string[] cardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string msg = "{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds";
            for (int i = 0; i < cardFaces.Length; i++)
            {
                Console.WriteLine(msg,cardFaces[i]);
                if (lastCard == cardFaces[i])
                {
                    break;
                }
            }
        }

        public static void Conventional_Solution()
        {
            var lastCardType = Console.ReadLine();
            string[] cardSuits = { "spades", "clubs", "hearts", "diamonds" };
            string[] cardFace = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < cardFace.Length; i++)
            {
                var msg = string.Empty;
                for (int j = 0; j < cardSuits.Length; j++)
                {
                    msg += cardFace[i] + " of " + cardSuits[j] + ", ";
                }
                Console.WriteLine(msg);
                if (cardFace[i] == lastCardType)
                {
                    break;
                }
            }
        }
    }
}
