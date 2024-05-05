using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
       public int exitCode;
        Process process;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartChild_Click(object sender, EventArgs e)
        {
            string path = Full_Path_Child();
           
            if (path != String.Empty)
            {
                process = Process.Start(path);
               
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
            if (files.Length > 0)
            {
                return files[0];
            }
            else
            {
                return String.Empty;
            }

        }

        private void CloseChild_Click(object sender, EventArgs e)
        {
            if(process!=null)
            {
                //process.Kill();//при таком завершении программы код -1!!!!
                var ptr = MyWinApi.FindWindow(null, "Child_1");
                MyWinApi.SendMessage(ptr, MyWinApi.WM_CLOSE, IntPtr.Zero, "Закрыто");
                Thread.Sleep(100);//если не ставить задержку программа не успевает завершиться и выкидывает ошибку
                exitCode = process.ExitCode;
                ExitCode.Text = exitCode.ToString();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(process!=null)
            {
                process.WaitForExit();
                exitCode = process.ExitCode;
                ExitCode.Text = exitCode.ToString();
                Process[] pname = Process.GetProcessesByName("Child_1");//если процесс завершился обнуляем его
                if(pname.Length==0) process = null;
            }
           
        }
    }
}
