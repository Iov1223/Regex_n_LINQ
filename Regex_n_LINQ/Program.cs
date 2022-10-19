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

            //string text, pattern001, pattern002 = "";
            //try
            //{
            //    text = args[0];
            //    pattern001 = args[1];
            //    try
            //    {
            //        pattern002 = args[2];
            //    }
            //    catch
            //    {

            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Введите текст:");
            //    text = Console.ReadLine();
            //    Console.WriteLine("Введите шаблон поиска (RegEx):");
            //    pattern001 = Console.ReadLine();
            //}
            //Class1 class1 = new Class1();
            //class1.PrintMatches(class1.myRegex(text, pattern001));
            //if (pattern002 != "")
            //{
            //    class1.PrintMatches(class1.myRegex(text, pattern002));
            //}
            File f = new File();
            f.GetContentFiles();
        }
    }
}
