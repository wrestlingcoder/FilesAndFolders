using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAndFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            Console.WriteLine("Запущенный файл: " + currentExeFilePath);

            //string folder = Path.GetDirectoryName(currentExeFilePath);
            string folder = Path.GetDirectoryName(currentExeFilePath);

            string[] files = Directory.GetFiles(folder);
            Console.WriteLine("Файлов в папке: " + files.Length.ToString());
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }


            string filePath = @"D:\prog\Example.xml";
            
            bool fileCheck = File.Exists(filePath);
            if (!fileCheck) 
            {
                Console.WriteLine("Не найден файл " + filePath);
                Console.ReadKey();
                return;
            }

            string[] text = File.ReadAllLines(filePath);
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
