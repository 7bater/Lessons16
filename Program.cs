//using System;
//using System.IO;
//using System.Text;
//using static System.Console;

//namespace Lessons16
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            WriteLine("переміщення файлу");

//            string source = "test.txt";
//            if (!File.Exists(source))
//            {
//                File.WriteAllText(source, "Це тестовий текстовий файл для переміщення.");
//            }

//            string destination = @"C:\Users\kozer\c#\Lessons16\file_data\moved_test.txt";

//            FileMover mover = new FileMover(source, destination);
//            mover.Move();

//            ReadKey();
//        }
//    }
//}

//exx5
//using System;
//using System.IO;
//using System.Text;
//using static System.Console;

//namespace Lessons16
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            WriteLine("копіювання папки");

//            string sourceFolder = @"C:\Users\kozer\c#\Lessons16\file_data";
//            string destFolder = @"C:\Users\kozer\c#\Lessons16\file_data_backup";

//            if (!Directory.Exists(sourceFolder))
//            {
//                Directory.CreateDirectory(sourceFolder);
//                File.WriteAllText(Path.Combine(sourceFolder, "sample.txt"), "Тестовий файл для копіювання.");
//            }

//            DirectoryCopier copier = new DirectoryCopier(sourceFolder, destFolder);
//            copier.Copy();

//            ReadKey();
//        }
//    }
//}


//exx6
//using System;
//using System.IO;
//using System.Text;
//using static System.Console;

//namespace Lessons16
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            WriteLine("переміщення папок");

//            string sourceFolder = @"C:\Users\kozer\c#\Lessons16\file_data";
//            string destFolder = @"C:\Users\kozer\c#\Lessons16\moved_file_data";

//            if (!Directory.Exists(sourceFolder))
//            {
//                Directory.CreateDirectory(sourceFolder);
//                File.WriteAllText(Path.Combine(sourceFolder, "sample.txt"), "Тестовий файл для переміщення.");
//            }

//            DirectoryMover mover = new DirectoryMover(sourceFolder, destFolder);
//            mover.Move();

//            ReadKey();
//        }
//    }
//}

//exx1
//using System;
//using System.IO;
//using System.Text;
//using static System.Console;

//namespace Lessons16
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            WriteLine("перегляд вмісту файлу");

//            string defaultPath = @"C:\Users\kozer\c#\Lessons16\file_data\sample.txt";

//            if (!File.Exists(defaultPath))
//            {
//                string dir = Path.GetDirectoryName(defaultPath);
//                if (!Directory.Exists(dir))
//                {
//                    Directory.CreateDirectory(dir);
//                }
//                File.WriteAllText(defaultPath, "Це приклад вмісту файлу.");
//            }

//            WriteLine($"Введіть шлях до файлу (або натисніть Enter для використання за замовчуванням):");
//            string path = ReadLine();
//            if (string.IsNullOrWhiteSpace(path))
//            {
//                path = defaultPath;
//            }

//            FileReader reader = new FileReader(path);
//            reader.Read();

//            ReadKey();
//        }
//    }
//}


//exx2
using System;
using System.IO;
using System.Text;
using static System.Console;

namespace Lessons16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            WriteLine("розподіл чисел");

            string evenPath = @"C:\Users\kozer\c#\Lessons16\file_data\evens.txt";
            string oddPath = @"C:\Users\kozer\c#\Lessons16\file_data\odds.txt";

            NumberProcessor processor = new NumberProcessor(evenPath, oddPath);
            processor.ProcessNumbers();

            ReadKey();
        }
    }
}