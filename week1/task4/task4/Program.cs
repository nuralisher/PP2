﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse( Console.ReadLine());

            int j = 1;

            for(int i=0; i<n; i++)
            {

                for(int k=0; k<j; k++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
                j++;
            }

        }
    }
}
