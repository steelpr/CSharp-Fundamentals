namespace StackFibonacci
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Stack<List<long>> indexOfNumber = new Stack<List<long>>();

            List<long> listNumber = new List<long>();
            listNumber.Add(0);
            Fib(number, listNumber);

            indexOfNumber.Push(listNumber);

            var result = indexOfNumber.Pop();
            var print = result[number];

            Console.WriteLine(print);

        }

       private static List<long> Fib(int num, List<long> nums)
       {
            long startNum = 0;
            long number = 1;

            for (int i = 0; i < num; i++)
            {
                long nextNum = startNum;
                startNum = number;
                number = nextNum + number;
                nums.Add(startNum);
            }
            return nums;
       }
    }
}
