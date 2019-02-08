using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // размер массива 
            int[] arr = new int[a];// создаю массив 
            List<int> ans = new List<int>();// создаю безразмерный массив для праймов 
            string[] s = Console.ReadLine().Split();// сичтываю числа и сохраняю их как отдельные стринги в массиве 
            for (int i = 0; i < arr.Length; i++) // форик
            {
                arr[i] = int.Parse(s[i]);// сохраняю стринги в массив в виде чисел 
                int pr = 0; // создал переменную для проверки чисел на прайм
                for (int j = 2; j <= (int)Math.Sqrt(arr[i]); j++)// второй форик
                {
                    if (arr[i] % j == 0) // проверка на делимость 
                    {
                        pr = 1;
                        break;
                    }

                }
                if (pr == 0 && arr[i] != 1)// сохраняю числа в вектор 
                {
                    ans.Add(arr[i]);
                }

            }
            Console.WriteLine(ans.Count);// вывожу размер вектора
            for (int i = 0; i < ans.Count; i++)// вывожу все числа в векторе 
            {
                Console.Write(ans[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
