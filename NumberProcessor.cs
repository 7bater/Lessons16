using System;
using System.Collections.Generic;
using System.IO;

namespace Lessons16
{
    class NumberProcessor
    {
        public string EvenFilePath { get; set; }
        public string OddFilePath { get; set; }

        public NumberProcessor(string evenFilePath, string oddFilePath)
        {
            EvenFilePath = evenFilePath;
            OddFilePath = oddFilePath;
        }

        public void ProcessNumbers()
        {
            try
            {
                string dir = Path.GetDirectoryName(EvenFilePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                Random rand = new Random();
                List<int> evens = new List<int>();
                List<int> odds = new List<int>();

                for (int i = 0; i < 10000; i++)
                {
                    int num = rand.Next(-100000, 100001);
                    if (num % 2 == 0)
                    {
                        evens.Add(num);
                    }
                    else
                    {
                        odds.Add(num);
                    }
                }

                File.WriteAllLines(EvenFilePath, evens.ConvertAll(x => x.ToString()));
                File.WriteAllLines(OddFilePath, odds.ConvertAll(x => x.ToString()));

                FileInfo evenInfo = new FileInfo(EvenFilePath);
                FileInfo oddInfo = new FileInfo(OddFilePath);

                Console.WriteLine("статистика");
                Console.WriteLine($"Парні числа:");
                Console.WriteLine($"  Шлях: {evenInfo.FullName}");
                Console.WriteLine($"  Кількість: {evens.Count}");
                Console.WriteLine($"  Розмір файлу: {evenInfo.Length} байтів");
                Console.WriteLine();
                Console.WriteLine($"Непарні числа:");
                Console.WriteLine($"  Шлях: {oddInfo.FullName}");
                Console.WriteLine($"  Кількість: {odds.Count}");
                Console.WriteLine($"  Розмір файлу: {oddInfo.Length} байтів");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час обробки чисел: {ex.Message}");
            }
        }
    }
}