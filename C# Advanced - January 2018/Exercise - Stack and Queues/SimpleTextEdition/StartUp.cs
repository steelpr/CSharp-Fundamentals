namespace SimpleTextEdition
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Stack<string> returnText = new Stack<string>();
            returnText.Push("");

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                                 .Split();

                string index = input[0];
                string textAppend = string.Empty;
                switch (index)
                {
                    case "1":
                        returnText.Push(text.ToString());
                        textAppend = input[1];
                        text.Append(textAppend);
                        break;
                    case "2":
                        returnText.Push(text.ToString());
                        textAppend = input[1];
                        int remove = int.Parse(textAppend);
                        text.Remove(text.Length - remove, remove);
                        break;
                    case "3":
                        textAppend = input[1];
                        int print = int.Parse(textAppend);
                        Console.WriteLine(text[print - 1]);
                        break;
                    case "4":
                        if (returnText.Count > 0)
                        {
                            text.Clear();
                            string undo = returnText.Pop();
                            text.Insert(0, undo);
                        }
                            break;
                }
            }
        }
    }
}
