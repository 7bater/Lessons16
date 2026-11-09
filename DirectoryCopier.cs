using System;
using System.IO;

namespace Lessons16
{
    class DirectoryCopier
    {
        public string SourceDir { get; set; }
        public string DestDir { get; set; }

        public DirectoryCopier(string sourceDir, string destDir)
        {
            SourceDir = sourceDir;
            DestDir = destDir;
        }

        public void Copy()
        {
            try
            {
                if (!Directory.Exists(SourceDir))
                {
                    Console.WriteLine($"Помилка: Початкову папку за шляхом \"{SourceDir}\" не знайдено.");
                    return;
                }

                CopyDirectoryRecursive(SourceDir, DestDir);
                Console.WriteLine($"Успіх: Папку успішно скопійовано до \"{DestDir}\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час копіювання папки: {ex.Message}");
            }
        }

        private void CopyDirectoryRecursive(string source, string target)
        {
            Directory.CreateDirectory(target);

            foreach (string file in Directory.GetFiles(source))
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(target, fileName);
                File.Copy(file, destFile, true);
            }

            foreach (string subDir in Directory.GetDirectories(source))
            {
                string subDirName = Path.GetFileName(subDir);
                string destSubDir = Path.Combine(target, subDirName);
                CopyDirectoryRecursive(subDir, destSubDir);
            }
        }
    }
}