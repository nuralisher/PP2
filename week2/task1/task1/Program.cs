using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("C:/Users/2017/Desktop/Новая папка/PP2/week2/task1/intput1.txt");
            string s = sr.ReadToEnd();
            int k = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])    
                {
                    k = 0;
                }
            }

            if (k == 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
