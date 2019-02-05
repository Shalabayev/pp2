using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name = "Alisher";
        public string id = "17BD110639";
        public int year = 2;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            Console.WriteLine(first.name);
            Console.WriteLine(first.id);
            Console.WriteLine(first.year);

            Console.ReadKey();
        }
    }
}

