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

            Console.ReadKey();
        }
    }
}
