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
            ContentsOfFile file = new ContentsOfFile();
            Replacement replacement = new Replacement(file.GetContentsOfInput());
            NewFile newFile = new NewFile();
            if (file.CheckExistInput() == false && file.GetPattern() == "")
            {
                Console.WriteLine("Ни файлa Pattern.txt, ни файлa/oв содержащих в имени Input*.txt не найдено");
            }
            else
            {
                if (file.CheckExistInput())
                {
                    file.ShowContentsOfInput();
                    file.ShowPattern();
                    if (file.GetPattern() != "")
                    {
                        file.GetPattern();
                        replacement.TemplateReplacement(file.GetPattern());
                        replacement.ShowContentsOfOutput();
                        newFile.CreateOUTPUT(replacement.TemplateReplacement(file.GetPattern()));
                    }
                    else
                    {
                        Console.WriteLine("Файлa Pattern.txt не найден.");
                    }

                }
                else
                {
                    Console.WriteLine("Файлa/oв содержащих в имени Input*.txt не найден/о.");
                }

            }
        }
    }
}
