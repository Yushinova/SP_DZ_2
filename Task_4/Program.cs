using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        public static string Full_Path(string name)
        {
            string name_solution = "SP_DZ_2";
            string except = Process.GetCurrentProcess().MainModule.FileName;//запущенная программа
            DirectoryInfo dir = new DirectoryInfo(except);

            string solution = dir.FullName;//полный путь исполняемого файла

            int ind = solution.IndexOf(name_solution);
            int ind_2 = solution.IndexOf('\\', ind);//нужно отсечь путь до папки Решение
            solution = solution.Substring(0, ind_2);

            //получаем полный путь к дочерней программе

            string[] files = Directory.GetFiles(solution, name, SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                return files[0];
            }
            else
            {
                return String.Empty;
            }

        }

        static void Main(string[] args)
        {
            //находим путь к файлу txt
            string path = Full_Path("FindWord.txt");
            path += "*Карл";

            Process p = Process.Start(Full_Path("FindWord.exe"), path);
        }
    }
}
