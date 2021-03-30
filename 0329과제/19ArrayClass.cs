using System;

namespace A058_ArrayClass
{
    class Program
    {
        private static void printArray(int[] a)
        {
            foreach (var i in a)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //(1) 배열을 선언하고 초기화
            int[] a = { 5, 25, 75, 35, 15 };
            printArray(a);

            //(2) 배열 복사의 세가지 방법
            int[] b;
            b = (int[])a.Clone();
            printArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);
            printArray(c);
            a.CopyTo(c, 3);
            printArray(c);

            //(3) 오름차순으로 정렬
            Array.Sort(a);
            printArray(a);

            //(4)내림차순으로 정렬
            Array.Reverse(a);
            printArray(a);

            //(5) 배열을 초기화
            Array.Clear(a, 0, a.Length);
            printArray(a);
        }
    }
}
