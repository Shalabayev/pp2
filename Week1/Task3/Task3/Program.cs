using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // размер масива 
            int[] arr = new int[a];
            string[] s = Console.ReadLine().Split(); // сохронил числа в виде стринга 
            for (int i = 0; i < arr.Length; i++) // форик
            {
                arr[i] = int.Parse(s[i]); // придаю стригам значение числа 
                Console.Write(arr[i] + " " + arr[i] + " ");// просто выписываю два подряд числа 

            }
            Console.ReadKey();
        }
    }
}
