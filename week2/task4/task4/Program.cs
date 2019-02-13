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
            string filename = "alisher.txt";
            string path = "C:/Users/2017/Desktop/experiment/example";
            string path1 = "C:/Users/2017/Desktop/experiment/forexample";

            string s = Path.Combine(path, filename);
            string s1 = Path.Combine(path1, filename);

            FileStream fs= File.Create(s);
            fs.Close();
            File.Copy(s, s1, true);
            File.Delete(s);
        }
    }
}
