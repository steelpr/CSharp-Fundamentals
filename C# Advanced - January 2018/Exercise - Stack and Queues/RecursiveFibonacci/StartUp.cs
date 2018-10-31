namespace RecursiveFibonacci
{
    using System;

    class StartUp
    {
        static long[] nums;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            nums = (new long[number + 1]);
            nums[1] = 1;
            nums[2] = 1;

            long result = Fibonacci(number);
            Console.WriteLine(result);
        }

        private static long Fibonacci(int number)
        {
            if (0 == nums[number])
            {
                nums[number] = Fibonacci(number - 1) + Fibonacci(number - 2);
            }
            return nums[number];
        }
    }
}
