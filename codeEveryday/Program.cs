using System;
using System.Collections.Generic;

namespace codeEveryday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Roman Numeral");
            string enteredNumeral = Console.ReadLine();
            var num = Converter(enteredNumeral);
            Console.WriteLine("Number: " + num);
        }

        static int Converter(string numeral)
        {
            int sum = 0;
            var list = new Dictionary<string, int>()
            {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000},
            };

            for (int i=0; i < numeral.Length; i++)
            {
                var val = list.GetValueOrDefault(numeral);
                if (i == numeral.Length - 1) sum = sum + val;
                else
                {
                    
                    var first = val;
                    var second = list.TryGetValue(i + 1, out int value);
                    if (first >= second) sum = sum + first;
                    else sum = sum = first;
                }
            }
            return sum;
        }
    }
}
