using System;
using System.IO;

namespace Lessons16
{
    class FileReader
    {
        public string FilePath { get; set; }

        public FileReader(string filePath)
        {
            FilePath = filePath;
        }

        public void Read()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine($"Помилка: Файл за шляхом \"{FilePath}\" не знайдено.");
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine("=== ВМІСТ ФАЙЛУ ===");
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка доступу до файлу: {ex.Message}");
            }
        }
    }
}