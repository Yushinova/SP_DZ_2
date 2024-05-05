using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str = args[0];
            try
            {
                string[] abc = str.Split('+', '-', '/', '*');
                int ind = str.IndexOfAny(new char[] { '+', '-', '/', '*' });
                // string[] str = args;
                double res = 0;
                if (str[ind] == '+')
                {
                    res = Convert.ToDouble(abc[0]) + Convert.ToDouble(abc[1]);
                }
                if (str[ind] == '-')
                {
                    res = Convert.ToDouble(abc[0]) - Convert.ToDouble(abc[1]);
                }
                if (str[ind]=='*')
                {
                    res = Convert.ToDouble(abc[0]) * Convert.ToDouble(abc[1]);
                }
                if (str[ind] == '/')
                {
                    if (Convert.ToDouble(abc[1]) != 0)
                    {
                        res = Convert.ToDouble(abc[0]) / Convert.ToDouble(abc[1]);
                    }
                    else Console.WriteLine("Error /0");
                }
                Console.WriteLine(res.ToString());
                Thread.Sleep(3000);
            }
           catch(Exception ex) { Console.WriteLine("Error"); }
        }
    }
}
