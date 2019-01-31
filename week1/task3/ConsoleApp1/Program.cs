using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void method(int [] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine()); // we enter the size of array and we use parse function to change it to int
            string s = Console.ReadLine();
            string [] str = s.Split();

            int[] a = new int[n]; 

            for(int i=0; i<n; i++)
            {
                a[i] = int.Parse(str[i]);
            }

            method(a, n);

        }
    }
}
