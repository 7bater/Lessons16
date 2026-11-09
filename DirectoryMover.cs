using System;
using System.IO;

namespace Lessons16
{
    class DirectoryMover
    {
        public string SourceDir { get; set; }
        public string DestDir { get; set; }

        public DirectoryMover(string sourceDir, string destDir)
        {
            SourceDir = sourceDir;
            DestDir = destDir;
        }

        public void Move()
        {
            try
            {
                if (!Directory.Exists(SourceDir))
                {
                    Console.WriteLine($"Помилка: Вихідну папку за шляхом \"{SourceDir}\" не знайдено.");
                    return;
                }

                if (Directory.Exists(DestDir))
                {
                    Directory.Delete(DestDir, true);
                }

                Directory.Move(SourceDir, DestDir);
                Console.WriteLine($"Успіх: Папку успішно переміщено до \"{DestDir}\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час переміщення папки: {ex.Message}");
            }
        }
    }
}