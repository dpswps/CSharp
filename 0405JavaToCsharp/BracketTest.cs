using System;

namespace JavaToCsharp_Report
{
    class BracketTest
    {
        static void Main(string[] args)
        {
            OptExp opt = new OptExp();
            String exp = "(3*5)-6/2)";
        

            Console.WriteLine(exp);

            if (opt.testPair(exp))
                Console.WriteLine("괄호 맞음!!");

        else
                Console.WriteLine("괄호 틀림!!");
        }
    }
}
