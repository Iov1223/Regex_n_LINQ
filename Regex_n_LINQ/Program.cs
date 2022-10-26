using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Regex_n_LINQ
{
    internal class Program
    {

        static void Main(string[] args)
        {
            File file = new File();
            Replacement replacement = new Replacement(file.GetFiles());
            NewFile newFile = new NewFile();
            try
            {
                file.ShowFiles(file.GetFiles());
                file.ShowPattern();
                try
                {
                    replacement.myRegex(file.GetPattern());
                    replacement.ShowNewFiles();
                    newFile.CreateOUTPUT(replacement.myRegex(file.GetPattern()));
                }
                catch
                {
                   
                }
            }
            catch
            {
                Console.WriteLine("Файлов содержащих Input.txt или Pattern.txt в имени не найдено.");
            }
        }
    }
}
