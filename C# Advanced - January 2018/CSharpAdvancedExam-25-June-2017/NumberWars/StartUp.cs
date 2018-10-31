namespace NumberWars
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var secondField = Console.ReadLine().Split(' ');

            Queue<string> firstPlayer = new Queue<string>(input);

            Queue<string> secondPlayer = new Queue<string>(secondField);


            int turn = 0;

            while (firstPlayer.Count > 0 || secondPlayer.Count > 0)
            {
                if (firstPlayer.Count <= 0 || secondPlayer.Count <= 0 || turn == 1000000)
                {
                    break;
                }
                else
                {
                    turn++;
                    string first = firstPlayer.Dequeue();
                    string second = secondPlayer.Dequeue();

                    if (Number(first) > Number(second))
                    {
                        firstPlayer.Enqueue(first);
                        firstPlayer.Enqueue(second);
                    }
                    else if (Number(first) < Number(second))
                    {
                        secondPlayer.Enqueue(second);
                        secondPlayer.Enqueue(first);
                    }
                    else if (Number(first) == Number(second))
                    {
                        string one = firstPlayer.Dequeue();
                        string two = firstPlayer.Dequeue();
                        string three = firstPlayer.Dequeue();

                        string four = secondPlayer.Dequeue();
                        string five = secondPlayer.Dequeue();
                        string six = secondPlayer.Dequeue();


                        int sumFirst = 0;
                        sumFirst += Char(one);
                        sumFirst += Char(two);
                        sumFirst += Char(three);

                        int secondSum = 0;
                        secondSum += Char(four);
                        secondSum += Char(five);
                        secondSum += Char(six);

                        if (sumFirst > secondSum)
                        {
                            firstPlayer.Enqueue(one);
                            firstPlayer.Enqueue(two);
                            firstPlayer.Enqueue(three);
                            firstPlayer.Enqueue(four);
                            firstPlayer.Enqueue(five);
                            firstPlayer.Enqueue(six);

                        }
                        else if (sumFirst < secondSum)
                        {
                            secondPlayer.Enqueue(six);
                            secondPlayer.Enqueue(five);
                            secondPlayer.Enqueue(four);
                            secondPlayer.Enqueue(three);
                            secondPlayer.Enqueue(two);
                            secondPlayer.Enqueue(one);

                        }
                        while (sumFirst == secondSum)
                        {
                            if (firstPlayer.Count < 3 || secondPlayer.Count < 3)
                            {
                                break;
                            }
                            else
                            {
                                string one1 = firstPlayer.Dequeue();
                                string two1 = firstPlayer.Dequeue();
                                string three1 = firstPlayer.Dequeue();

                                string four2 = secondPlayer.Dequeue();
                                string five3 = secondPlayer.Dequeue();
                                string six5 = secondPlayer.Dequeue();


                                int sumFirst1 = 0;
                                sumFirst1 += Char(one1);
                                sumFirst1 += Char(two1);
                                sumFirst1 += Char(three1);

                                int secondSum3 = 0;
                                secondSum3 += Char(four2);
                                secondSum3 += Char(five3);
                                secondSum3 += Char(six5);

                                if (sumFirst1 > secondSum3)
                                {
                                    firstPlayer.Enqueue(one1);
                                    firstPlayer.Enqueue(two1);
                                    firstPlayer.Enqueue(three1);
                                    firstPlayer.Enqueue(four2);
                                    firstPlayer.Enqueue(five3);
                                    firstPlayer.Enqueue(six5);

                                }
                                else if (sumFirst1 < secondSum3)
                                {
                                    secondPlayer.Enqueue(six5);
                                    secondPlayer.Enqueue(five3);
                                    secondPlayer.Enqueue(four2);
                                    secondPlayer.Enqueue(three1);
                                    secondPlayer.Enqueue(two1);
                                    secondPlayer.Enqueue(one1);
                                }
                            }
                        }
                    }

                }
            }

            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins after {turn} turns");
            }
            else if (secondPlayer.Count > 0)
            {
                Console.WriteLine($"Second player wind after {turn} turns");
            }
            else
            {
                Console.WriteLine($"Draw after {turn} turns");
            }
        }

        static int Number(string match)
        {
            return int.Parse(match.Substring(0, match.Length - 1));
        }

        static int Char(string match)
        {
            return match[match.Length - 1];
        }
    }
}