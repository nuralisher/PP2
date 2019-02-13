using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            string path1 = "C:/Users/2017/Desktop/experiment/forexample";
            string path = "C:/Users/2017/Desktop";
            string filename = "alisher.txt";

            string sourcefile = Path.Combine(path,filename);
            string destfile = Path.Combine(path1, filename);

            File.Create(path);
            File.Copy(sourcefile, destfile, true);
        }
    }
}
