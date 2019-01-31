using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student // class student
    {
        public string name;
        public string id;
        public int year_of_study;
       

        public Student(string name , string id) {//constructor 2
            this.name = name;
            this.id = id;
            year_of_study = 1;// automatically 1
        }

        public Student(string name, string id, int year_of_study)// also we have an constructor with 3 parameters if we want to enter year of study , but we will not use it
        {
            this.name = name;
            this.id = id;
            this.year_of_study = year_of_study;
        }
    }


    class Program
    {
        static void change_year(string name, Student[] a , int amount_of_student)//method1
        {
            for(int i=0; i < amount_of_student; i++)
            {
                if (a[i].name == name)
                {
                    a[i].year_of_study++;
                }
            }
        }
        //method2
        static void access_to_id(string name, Student[] a, int amount_of_student)//access to id through name (if we want to access to id  through id we will just change name to id) )
        {
            for(int i=0; i<amount_of_student; i++)
            {
                if (a[i].name == name)
                {
                    Console.WriteLine("name: " + a[i].name + " id: " + a[i].id + "year of study: " + a[i].year_of_study);
                }
            }
        }
        //method3
        static void access_to_name(string id, Student[] a, int amount_of_student)//access to name through id (if we want to access to name  through name we will just change name to id) )
        {
            for (int i = 0; i < amount_of_student; i++)
            {
                if (a[i].id == id)
                {
                    Console.WriteLine("name: " + a[i].name + " id: " + a[i].id + "year of study: " + a[i].year_of_study);
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of students : ");
            int n = int.Parse(Console.ReadLine());//n = amount of student
            Student[] a = new Student[n];

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Enter name and id through space and press enter to go next student :");
                string[] str = Console.ReadLine().Split();
                string name = str[0];
                string id = str[1];
                

                a[i] = new Student(name , id );
            }

            Console.Write("Operations :" + '\n' + "1)increment " + '\n'+ "2)write name to access id" + '\n' + "3)write id to access name" + '\n'  + "Enter the number of operation :" + '\n');

            int k = int.Parse(Console.ReadLine());

            if (k == 2)
            {
                Console.WriteLine("Enter the name :");
                string name1 = Console.ReadLine();

                access_to_id(name1, a, n);
            }else if (k == 1)
            {
                Console.WriteLine("Enter the name :");
                string name1 = Console.ReadLine();
                change_year(name1, a, n);
            }else if (k == 3)
            {
                Console.WriteLine("Enter the id :");
                string id = Console.ReadLine();
                access_to_name(id, a, n);
            }


            
        }
    }
}
