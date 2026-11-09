using System;
using System.IO;

namespace Lessons16
{
    class FileMover
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }

        public FileMover(string sourcePath, string destinationPath)
        {
            SourcePath = sourcePath;
            DestinationPath = destinationPath;
        }

        public void Move()
        {
            try
            {
                if (!File.Exists(SourcePath))
                {
                    Console.WriteLine($"Помилка: Вихідний файл за шляхом \"{SourcePath}\" не знайдено.");
                    return;
                }

                string destDir = Path.GetDirectoryName(DestinationPath);
                if (!string.IsNullOrEmpty(destDir) && !Directory.Exists(destDir))
                {
                    Directory.CreateDirectory(destDir);
                }

                if (File.Exists(DestinationPath))
                {
                    File.Delete(DestinationPath);
                }

                File.Move(SourcePath, DestinationPath);
                Console.WriteLine($"Успіх: Файл успішно переміщено до \"{DestinationPath}\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час переміщення файлу: {ex.Message}");
            }
        }
    }
}