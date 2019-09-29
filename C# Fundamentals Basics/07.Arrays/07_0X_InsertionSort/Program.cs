using System;

namespace _07_0X_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new int[] { 85, 12, 59, 45, 72, 51 };

            Printer(collection);

            var iInsertion = 1;
            while (iInsertion < collection.Length)
            {
                var inserted = collection[iInsertion];
                var iSelect = iInsertion;
                while (iSelect > 0)
                {
                    if (iSelect - 1 == 0 && inserted < collection[iSelect - 1]) // checkup ? TODO: FIX THIS SHhhh...
                    {
                        collection[iSelect] = collection[iSelect - 1];
                        collection[iSelect - 1] = inserted;
                    }
                    else if (inserted < collection[iSelect - 1])
                    {
                        collection[iSelect] = collection[iSelect - 1];
                    }
                    else
                    {
                        collection[iSelect] = inserted;
                        break;
                    }

                    iSelect--;
                }

                iInsertion++;
            }

            Printer(collection);
        }

        static void Printer(int[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("___________________");
        }
    }
}
