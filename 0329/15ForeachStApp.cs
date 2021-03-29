using System;

namespace ForeachStApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] color = { "red", "green", "blue" };
            foreach (String s in color)
                Console.WriteLine(s);
        }
    }
}
