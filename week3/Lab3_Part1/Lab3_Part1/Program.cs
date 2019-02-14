using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3_Part1
{
    class Farmanager
    {
        public int cursor;
        public string path;
        public DirectoryInfo directory = null;
        public int sz;

     

        public Farmanager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
        }

        public void color(FileSystemInfo fs , int i)
        {
            if (cursor == i)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (fs.GetType() == typeof(FileInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

            

        public void show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   >>> "+directory.FullName);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();

            for(int i=0; i<fs.Length; i++)
            {
                color(fs[i], i);
                Console.WriteLine((i+1)+" "+fs[i].Name);
                
            }
        }

        public void up()
        {
            cursor--;
            if (cursor < 0)
            {
                cursor = cursor + sz;
            }
        }

        public void down()
        {
            cursor++;
            if (cursor == sz)
            {
                cursor = 0;
            }
        }


        public void start()
        {
            ConsoleKeyInfo ki = Console.ReadKey();

            while (ki.Key!= ConsoleKey.Escape)
            {
                show();
                ki = Console.ReadKey();
                if (ki.Key == ConsoleKey.UpArrow)
                {
                    up();
                }
                if (ki.Key == ConsoleKey.DownArrow)
                {
                    down();
                }
                
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/2017/Desktop/experiment";
            Farmanager farman = new Farmanager(path);
            farman.start();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
