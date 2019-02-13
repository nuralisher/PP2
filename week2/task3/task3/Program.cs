using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void print(int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write("   ");
            }
        }

        static void Show(DirectoryInfo d, int n)
        {
            print(n-3);
            Console.WriteLine(d.Name);
            FileInfo[] f = d.GetFiles();
            
            foreach( FileInfo g in f)
            {
                print(n);
                Console.WriteLine(g.Name);
            }
            DirectoryInfo[] di = d.GetDirectories();
            
            foreach(DirectoryInfo dd in di)
            {
                Show(dd, n + 3);
            }
            
            
        }

        static void Main(string[] args)
        {
            DirectoryInfo s = new DirectoryInfo ("C:/Users/2017/Desktop/Files");
            
            Show(s, 3);
        }
    }
}
