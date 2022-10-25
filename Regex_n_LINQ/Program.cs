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
            file.ShowFiles(file.GetFiles());
            file.ShowPattern();
            replacement.myRegex(file.GetPattern());
            replacement.ShowNewFiles();
            newFile.CreateOUTPUT(replacement.myRegex(file.GetPattern()));
        }
    }
}
