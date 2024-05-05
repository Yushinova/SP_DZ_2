using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allArgs = args[0];
            int ind = allArgs.IndexOf('*');
            string word = allArgs.Substring(ind+1);
            string path = allArgs.Substring(0, ind);
            string text = String.Empty;
            int count = 0;
            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                text = reader.ReadToEnd();
                Console.WriteLine(text);
            }
            if(text!=String.Empty)
            {
                string[]abs = text.Trim().Split(' ','.',',','\n');
                foreach (var item in abs)
                {
                    Console.WriteLine(item);
                    if (item == word) count++;
                }
            }
            Console.WriteLine(count.ToString());
            Thread.Sleep(5000);
        }
    }
}
