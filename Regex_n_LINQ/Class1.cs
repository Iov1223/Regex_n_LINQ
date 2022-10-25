using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace Regex_n_LINQ
{
    public class File
    {
        private  string[] _path_001 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Input*.txt");
        private string _path_002 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Pattern.txt";
        public  List<string> ContentsOfFiles = new List<string>();
        private  StreamReader read;
        public  List<string> GetFiles()
        {
            for (int i = 0; i < _path_001.Length; i++)
            {                
                read = new StreamReader(_path_001[i]);
                ContentsOfFiles.Add(read.ReadToEnd());
                read.Close();
            }
            return ContentsOfFiles;
        }
        public void ShowFiles(List<string> ContentsOfFiles)
        {
            for (int i = 0; i < ContentsOfFiles.Count; i++)
            {
                Console.WriteLine(ContentsOfFiles[i]);
            }
            Console.WriteLine();
        }
        
        public string GetPattern()
        {
            read = new StreamReader(_path_002);
            string pattern = read.ReadToEnd();
            return pattern;
        }
        public void ShowPattern()
        {
            Console.WriteLine($"\n===================================\n" +
                $"Шаблон для поиска - {GetPattern()}.\n===================================\n");
        }
    }
    public class Replacement
    {
        private List<string> Files = new List<string>();
        public Replacement(List<string> ContentsOfFiles)
        {
            Files = ContentsOfFiles;
        }
        public List<string> myRegex(string pattern)
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            for (int i = 0; i < Files.Count; i++)
            {
                Files[i] = Regex.Replace(Files[i], pattern, "специальная(ой) военная(ой) операция(ии)");               
            }
            return Files;
        }
        public void ShowNewFiles()
        {
            Console.WriteLine(Files.Count);
            for (int i = 0; i < Files.Count; i++)
            {
                Console.WriteLine(Files[i] + "\n");
            }
        }
    }
    public class NewFile
    {
        private StreamWriter write;
        private string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public void CreateOUTPUT(List<string> newFiles)
        {

            Console.WriteLine(newFiles.Count);
            for (int i = 0; i < newFiles.Count / 2; i++)
            {
                write = new StreamWriter(_path + "\\Output" + (i + 1) + ".txt");
                write.WriteLine(newFiles[i]);
                write.Close();
            }

        }
    }
}
