using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Regex_n_LINQ
{
    public class File
    {
        private string[] _path_001 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Input*.txt");
        private string _path_002 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Pattern.txt";
        public List<string> ContentFiles = new List<string>();
        public void GetContentFiles()
        {
            
            for (int i = 0; i < _path_001.Length; i++)
            {
                ContentFiles.Add(_path_001[i]);
            }

            
            foreach (string file in ContentFiles)
            {
                Console.WriteLine(file + "\n");
            }
            
        }
    }
    public class Class1
    {
        public MatchCollection myRegex(string input, string pattern, string replacement = "Заменено")
        {
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            Console.WriteLine(Regex.Replace(input, pattern, replacement));
            return matches;
        }
        public void PrintMatches(MatchCollection matches)
        {
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
