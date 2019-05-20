using System;
using System.IO;

namespace frequency_analysis
{
    internal class Program
    {
        static void English()
        {
            string text = File.ReadAllText("../../TestEN.txt");
            text = text.ToLower();
            char[,] message = new char[2, 26];

            int count = 0;
            for (int x = 'a'; x <= 'z'; x++)
            {
                message[0, count] = (char) x;
                count++;
            }

            foreach (char c in text)
            {
                count = 0;
                for (int x = 'a'; x <= 'z'; x++)
                {
                    if (c == x)
                    {
                        message[1, count]++;
                    }

                    count++;
                }
            }

            for (int x = 0; x <= 25; x++)
            {
                Console.Write(message[0, x]);
                Console.Write(" = ");
                Console.WriteLine((int) message[1, x]);
            }
        }

        static void Ukrainian()
        {
            string text = File.ReadAllText("../../TestUK.txt");
            text = text.ToLower();
            char[,] message = new char[2, 33];

            int count = 0;
            for (int x = 'а'; x <= 'я'; x++)
            {
                message[0, count] = (char) x;
                count++;
            }

            foreach (char c in text)
            {
                count = 0;
                for (int x = 'а'; x <= 'я'; x++)
                {
                    if (c == x)
                    {
                        message[1, count]++;
                    }
                    count++;
                }
            }

            for (int x = 0; x <= 31; x++)
            {
                Console.Write(message[0, x]);
                Console.Write(" = ");
                Console.WriteLine((int) message[1, x]);
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть 1 для української розмітки, або 2 для англійської розмітки");
            var selectLanguage = Convert.ToInt32(Console.ReadLine());

            if (selectLanguage == 1)
            {
                Ukrainian();
            }
            else if (selectLanguage == 2)
            {
                English();
            }

            Console.ReadKey();
        }
    }
}