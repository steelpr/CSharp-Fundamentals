namespace Regular
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> collection = new Queue<string>();
            List<int> all = new List<int>();

            string pattern = @"\[(\w+)<+(\d+)REGEH+(\d+)>+(\w+)+\]";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            
            foreach (Match item in matches)
            {
                string match = item.Groups[2].Value;
                int parse = int.Parse(match);
                all.Add(parse);

                string match1 = item.Groups[3].Value;
                int parse1 = int.Parse(match1);
                all.Add(parse1);
            }

            int sumD = 0;

            foreach (var item in all)
            {
                sumD += item;
                var output = sumD % (input.Length - 1);
                Console.Write(input[output]);
            }
        }
    }
}
