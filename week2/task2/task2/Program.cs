using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static public bool isitprime(int n)
        {
            if (n == 1)
            {
                return false;
            }else if (n == 2)
            {
                return true;
            }
            else
            {
                for(int i=2; i<n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:/Users/2017/Desktop/Новая папка/PP2/week2/task2/input_2.txt");
            StreamWriter sw = new StreamWriter("C:/Users/2017/Desktop/Новая папка/PP2/week2/task2/output_2.txt");
            string s = sr.ReadToEnd();
            string[] ss = s.Split();
            
            for(int i=0; i<ss.Length; i++)
            {
                if ( isitprime( int.Parse(ss[i]) ) ){
                    sw.Write(ss[i] + " ");
                    
                }
            }

            sw.Close();

        }
    }
}
