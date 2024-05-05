using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Full_Path_Child();
            int exitCode;
            if(path!=String.Empty)
            {
                Process process = Process.Start(path);
                process.WaitForExit();
                exitCode = process.ExitCode;
                output.Text = exitCode.ToString();
            }                
        }
        private string Full_Path_Child()
        {
            string name_solution = "SP_DZ_2";
            string except = Process.GetCurrentProcess().MainModule.FileName;//запущенная программа
            DirectoryInfo dir = new DirectoryInfo(except);

            string solution = dir.FullName;//полный путь исполняемого файла

            int ind = solution.IndexOf(name_solution);
            int ind_2 = solution.IndexOf('\\', ind);//нужно отсечь путь до папки Решение
            solution = solution.Substring(0, ind_2);

            //получаем полный путь к дочерней программе

            string[] files = Directory.GetFiles(solution, "Child_1.exe", SearchOption.AllDirectories);
            if(files.Length > 0)
            {
                return files[0];
            }
            else
            {
                return String.Empty;
            }
        
        }
    }
}
