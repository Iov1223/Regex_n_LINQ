using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace Regex_n_LINQ
{
    /*
     * Программу поправил. Когда сдавал она работала, но была написано сумбурно,
     * поэтому и оставил комментарий с прикреплённой работой в журнале.
     */
    public class ContentsOfFile
    {
        private  string[] _pathToInput = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Input*.txt");
        private string _pathToPattern = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Pattern.txt";
        public  List<string> ContentsOfInput = new List<string>();
        private  StreamReader read;
        private string pattern;
        public  List<string> GetContentsOfInput()
        {
            for (int i = 0; i < _pathToInput.Length; i++)
            {                
                read = new StreamReader(_pathToInput[i]);
                ContentsOfInput.Add(read.ReadToEnd());
                read.Close();
            }
            return ContentsOfInput;
        }
        public bool CheckExistInput()
        {
            if (ContentsOfInput.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ShowContentsOfInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tСодержимое файла/ов Input*.txt:\n");
            for (int i = 0; i < ContentsOfInput.Count; i++)
            {
                Console.WriteLine(ContentsOfInput[i]);
            }
            Console.WriteLine();
        }
        
        public string GetPattern()
        {
            try
            {
                read = new StreamReader(_pathToPattern);
                pattern = read.ReadToEnd();
                return pattern;
            }
            catch
            {
                return "";
            }
        }
        public void ShowPattern()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n===================================\n" +
                $"Шаблон для поиска - {GetPattern()}.\n===================================\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Replacement
    {
        private List<string> ContentsOfOutput = new List<string>();
        public Replacement(List<string> ContentsOfInput)
        {
            ContentsOfOutput = ContentsOfInput;
        }
        public List<string> TemplateReplacement(string pattern)
        {
            for (int i = 0; i < ContentsOfOutput.Count; i++)
            {
                ContentsOfOutput[i] = Regex.Replace(ContentsOfOutput[i], pattern, "специальная(ой) военная(ой) операция(ии)");
            }
            return ContentsOfOutput;
        }
        public void ShowContentsOfOutput()
        {
            Console.WriteLine("\tСодержимое файла/ов Output*.txt:\n");
            for (int i = 0; i < ContentsOfOutput.Count; i++)
            {
                Console.WriteLine(ContentsOfOutput[i] + "\n");
            }
        }
    }
    public class NewFile
    {
        private StreamWriter write;
        private string pathOutput = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public void CreateOUTPUT(List<string> ContentsOfOutput)
        {
            for (int i = 0; i < ContentsOfOutput.Count; i++)
            {
                write = new StreamWriter(pathOutput + "\\Output00" + (i + 1) + ".txt");
                write.WriteLine(ContentsOfOutput[i]);
                write.Close();
            }

        }
    }
}
