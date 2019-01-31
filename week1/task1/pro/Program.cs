using System;  
using System.Collections.Generic;
/*using System.Linq;
using System.Text;
using System.Threading.Tasks; 
*/
namespace pro
{
    

    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine()); // enter the number as a string and converting to int  by parse function 
            List<int> list = new List<int>(); // creating list that will hold prime numbers
            string[] s = Console.ReadLine().Split(); // entering numbers as a string and by split function will be saved in string array

            

            for (int i = 0; i < s.Length; i++)// to see every number we use for
            {
                int n = int.Parse(s[i]);//converting it to int type

                int k = 0; // simple integer number that will be changed to 1 if n= NOT prime

                if (n == 1)
                {
                    k = 1;//1 is not prime

                } else if (n == 2)
                {
                    k = 0;// 2 is prime
                }else//other cases
                {
                    for (int j = 2; j < n; j++)//we will check divisbility of all numbers from 2 to n
                    {
                        if (n % j == 0) // if there is a exist such  j  it means n is not prime
                        {
                            k = 1;// and we will change k
                            break;// we will use break to stop and go next number in array
                        }
                    }
                }

                if (k == 0)//prime
                {
                    list.Add(n);

                }
                
            }

            Console.WriteLine(list.Count);// number of primes
            for (int e = 0; e < list.Count; e++)//prime numbers
            {
                Console.Write(list[e] +" ");
            }


  
        }
    }
}
