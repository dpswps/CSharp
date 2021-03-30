using System;

namespace A060_ArraySorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cow", "Tiger", "Rabit", "Dragon", "Snake", "Horse" };
            PrintArray("Before Sort: ", name);
            Array.Reverse(name);
            PrintArray("After Reverse ", name);
            Array.Sort(name);
            PrintArray("After Sort: ", name);
            Array.Reverse(name);
            PrintArray("After Reverse: ", name);
        }
        private static void PrintArray(String s, String[] name)
        {
            Console.WriteLine(s);
            foreach (var n in name)
                Console.Write("{0} ", n);
            Console.WriteLine();
        }
    }
}
