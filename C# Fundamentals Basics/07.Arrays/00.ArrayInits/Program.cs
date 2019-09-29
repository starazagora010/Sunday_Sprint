using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            int[] copy_intArr = (int[])intArr.Clone();

            intArr[0] = 0;
            Printer(intArr);
            Printer(copy_intArr);
            Console.WriteLine();

            string[] strArr = { "1", "2", "3", "4", "5" };
            string[] copy_strArr = (string[])strArr.Clone();

            strArr[0] = "0";
            Printer(strArr);
            Printer(copy_strArr);

            // SomeShit.countOfShit++;
            Console.WriteLine("STRUCT SOME SHIT " + new SomeShit().countOfShit);
            var shit = new SomeShit();
            shit.countOfShit++;

            //ALL ARRAY INITS
            var data0 = new int[3];

            var data1 = new int[3] { 1, 2, 3 };

            var data2 = new int[] { 1, 2, 3 };

            var data3 = new[] { 1, 2, 3 };

            // var data4 = { 1, 2, 3 };

            int[] data5 = { 1, 2, 3 };

            var data6 = new int[0];
            var data7 = new int[] { };
            // var data8 = new[] { };
            // int[] data9 = new[] { };
            // var data10 = { };
            int[] data11 = { };

            // ARR INIT IN METHOD
            /*
Foo(new int[2])
Foo(new int[2] { 1, 2 })
Foo(new int[] { 1, 2 })
Foo(new[] { 1, 2 })
Foo({ 1, 2 }) is not compilable
Foo(new int[0])
Foo(new int[] { })
Foo({}) is not compilable
             */

            var arrValueTuples = new (int number, int counter)[5];

            var contacts = new[]
                               {
                                   new
                                       {
                                           Name = " Eugene Zabokritski",
                                           PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
                                       },
                                   new
                                       {
                                           Name = " Hanying Feng", PhoneNumbers = new[] { "650-555-0199" }
                                           //PhoneNumbersS = new[] { "650-555-0199" }
                                       }
                               };
        }

        static void Printer<T>(IEnumerable<T> collection)
        {
            var stringResult = string.Join<T>(" ", collection);
            Console.WriteLine(stringResult);
        }

        public struct SomeShit
        {
            public int countOfShit;

            public int CountShitsProperty { get; set; }
        }

        public static class SomeStaticShit
        {
            // public int countOfShit;
        }

        struct Distance
        {
            public void SetFeet(int feet)
            {
                Value = feet;
            }

            public void SetMiles(float miles)
            {
                Value = (int)(miles * 5280f);
            }

            public int GetFeet()
            {
                return Value;
            }

            public float GetMiles()
            {
                return Value / 5280f;
            }

            private int Value;
        }

        class Distances
        {
            public Distance Dist1 { get; set; }

            public Distance Dist2 { get; set; }
        }
    }
}